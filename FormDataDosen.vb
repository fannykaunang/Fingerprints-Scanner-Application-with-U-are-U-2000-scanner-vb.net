Imports System.Data.SqlClient
Imports DevComponents.DotNetBar

Public Class FormDataDosen
    Implements DPFP.Capture.EventHandler

    Private Capturer As DPFP.Capture.Capture
    Private a As New MetroFramework.Animation.MoveAnimation
    Private jenisOperasi As operasi
    Private STRCONN_STRING As String = My.Settings("ConnectionStringApp").ToString
    Private IS_EDITING As Boolean

    Private Enum operasi
        insert = 0
        update = 1
    End Enum

#Region "SetCultureToIndonesia"
    Private Sub SetCultureToIndonesia()
        Dim ci As System.Globalization.CultureInfo
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDataDosen))

        ci = Globalization.CultureInfo.CreateSpecificCulture("id-ID")
        System.Threading.Thread.CurrentThread.CurrentCulture = ci
        'change the UI culture
        System.Threading.Thread.CurrentThread.CurrentUICulture = ci
        resources.ApplyResources(Me, "$this")
    End Sub
#End Region

    Private Function GetData(ByVal cmmd As SqlCommand) As DataTable
        Using dt As New DataTable
            Using connect As New SqlConnection(Me.STRCONN_STRING.ToString)
                Using Adapter As New SqlDataAdapter
                    cmmd.Connection = connect
                    connect.Open()
                    Adapter.SelectCommand = cmmd
                    Adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function
    Private Function VALIDATE_INPUT() As Boolean
        If Me.TXTID.Text = String.Empty _
           Or Me.TXTNAMADOSEN.Text = String.Empty _
            Then
            MessageBoxEx.Show("MASIH ADA DATA YANG KOSONG !", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub DEFAULT_TEXT(ByVal pNL As DevComponents.DotNetBar.PanelEx)
        Dim Ctrl As Control
        For Each Ctrl In pNL.Controls
            If TypeOf Ctrl Is DevComponents.DotNetBar.Controls.TextBoxX Then
                Ctrl.Text = String.Empty
            End If
        Next
    End Sub

    Private Sub CTL_PASIEN_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Init()
        Me.StartCapture()

        Me.GET_DATA_COMBO(Me.cbMataKuliah, "T_MATA_KULIAH", "SELECT * FROM T_MATA_KULIAH", "KODE_MATA_KULIAH", "MATA_KULIAH")
        Me.DEFAULT_TEXT(PanelEx2)
        Me.BackgroundWorker.RunWorkerAsync()
        Me.TXTTANGGAL.Text = Date.Parse(Today).ToString("dd-MMMM-yyyy").ToUpper
        Me.SetCultureToIndonesia()
        Me.StyleManager1.ManagerStyle = My.Settings.Style
    End Sub

    Private Sub BTKELUAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTKELUAR.Click
        Me.Dispose()
    End Sub

#Region "FINGERPRINT"

    Protected Overridable Sub Init()
        Try
            Capturer = New DPFP.Capture.Capture()

            If (Not Capturer Is Nothing) Then
                Capturer.EventHandler = Me
            Else
                SetPrompt("Can't initiate capture operation!")
            End If
        Catch ex As Exception
            MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Protected Sub DrawPicture(ByVal bmp)
        Invoke(New FunctionCall(AddressOf _DrawPicture), bmp)
    End Sub

    Private Sub _DrawPicture(ByVal bmp)
        Picture.Image = New Bitmap(bmp, Picture.Size)
    End Sub
    Protected Overridable Sub Process(ByVal Sample As DPFP.Sample)
        DrawPicture(ConvertSampleToBitmap(Sample))
    End Sub

    Protected Function ConvertSampleToBitmap(ByVal Sample As DPFP.Sample) As Bitmap
        Dim convertor As New DPFP.Capture.SampleConversion()  ' Create a sample convertor.
        Dim bitmap As Bitmap = Nothing              ' TODO: the size doesn't matter
        convertor.ConvertToPicture(Sample, bitmap)        ' TODO: return bitmap as a result
        Return bitmap
    End Function

    Protected Function ExtractFeatures(ByVal Sample As DPFP.Sample, ByVal Purpose As DPFP.Processing.DataPurpose) As DPFP.FeatureSet
        Dim extractor As New DPFP.Processing.FeatureExtraction()    ' Create a feature extractor
        Dim feedback As DPFP.Capture.CaptureFeedback = DPFP.Capture.CaptureFeedback.None
        Dim features As New DPFP.FeatureSet()
        extractor.CreateFeatureSet(Sample, Purpose, feedback, features) ' TODO: return features as a result?
        If (feedback = DPFP.Capture.CaptureFeedback.Good) Then
            Return features
        Else
            Return Nothing
        End If
    End Function

    Protected Sub StartCapture()
        If (Not Capturer Is Nothing) Then
            Try
                Capturer.StartCapture()
                SetPrompt("Scan your fingerprint, Fingerprint status is ready for scan.")
            Catch ex As Exception
                SetPrompt("Can't initiate capture!")
            End Try
        End If
    End Sub

    Protected Sub StopCapture()
        If (Not Capturer Is Nothing) Then
            Try
                Capturer.StopCapture()
                SetPrompt("Fingerprint reader is not ready for scan your finger.")
                SetStatus("Silahkan masukkan Input Data terlebih dahulu.")
            Catch ex As Exception
                SetPrompt("Can't terminate capture!")
            End Try
        End If
    End Sub
    Sub OnComplete(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        MakeReportDosen("The fingerprint sample was captured.")
        SetPrompt("Scan the same fingerprint again.")
        Process(Sample) 'ini sample
    End Sub

    Sub OnFingerGone(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerGone
        MakeReportDosen("The finger was removed from the fingerprint reader.")
    End Sub

    Sub OnFingerTouch(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerTouch
        MakeReportDosen("The fingerprint reader was touched.")
    End Sub

    Sub OnReaderConnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderConnect
        MakeReportDosen("The fingerprint reader was connected.")
    End Sub

    Sub OnReaderDisconnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderDisconnect
        MakeReportDosen("The fingerprint reader was disconnected...")
    End Sub

    Sub OnSampleQuality(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal CaptureFeedback As DPFP.Capture.CaptureFeedback) Implements DPFP.Capture.EventHandler.OnSampleQuality
        If CaptureFeedback = DPFP.Capture.CaptureFeedback.Good Then
            MakeReportDosen("The quality of the fingerprint sample is good.")
        Else
            MakeReportDosen("The quality of the fingerprint sample is poor.")
        End If
    End Sub

    Protected Sub SetStatus(ByVal status)
        Invoke(New FunctionCall(AddressOf _SetStatus), status)
    End Sub

    Private Sub _SetStatus(ByVal status)
        StatusLine.Text = status
    End Sub

    Protected Sub SetPrompt(ByVal text)
        Invoke(New FunctionCall(AddressOf _SetPrompt), text)
    End Sub

    Private Sub _SetPrompt(ByVal text)
        Prompt.Text = text
    End Sub

    Protected Sub MakeReportDosen(ByVal status)
        Try
            Invoke(New FunctionCall(AddressOf _MakeReport), status)
        Catch EX As Exception
            MessageBoxEx.Show("PERHATIAN..  " + EX.Message, "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub _MakeReport(ByVal status)
        StatusText.AppendText(status + Chr(13) + Chr(10))
    End Sub
#End Region

    Private Sub TXTID_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TXTID.Validating, TXTNAMADOSEN.Validating
        Me.LBPath.Text = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Dosen" & "\" & Me.TXTID.Text & ".fpt")
        If My.Computer.FileSystem.FileExists(Me.LBPath.Text) Then
            MessageBox.Show("PERHATIAN..  NIP/NIDN SUDAH TERSIMPAN DALAM DATABASE", "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.TXTID.Clear()
            Me.TXTID.Focus()
        End If
        'If Me.TXTID.Text = String.Empty OrElse Me.TXTNAMADOSEN.Text = String.Empty Then
        '    StopCapture()
        'Else

        'Init()
        'StartCapture()
        'End If
        'Me.LBPath.Text = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Dosen" & "\" & Me.TXTID.Text & ".fpt")
    End Sub

    Private Sub GET_DATA_COMBO(ByVal CB As MTGCComboBox, ByVal TBL As String, ByVal STR_SQL As String, ByVal SDS1 As String, ByVal SDS2 As String)
        With Me
            Try
                modKoneksiDatabase.BukaDatabase()
                Dim dtLoading As New DataTable(TBL)
                dtAdapter = New SqlDataAdapter(STR_SQL, modKoneksiDatabase.conn)
                dtLoading.Clear()
                dtAdapter.Fill(dtLoading)

                CB.SelectedIndex = -1
                CB.Items.Clear()
                CB.SourceDataString = New String(1) {SDS1, SDS2}
                CB.SourceDataTable = dtLoading
            Catch EX As Exception
                MessageBoxEx.Show("PERHATIAN..  " + EX.Message, "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End With
    End Sub
    Private Sub cbMataKuliah_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMataKuliah.SelectedIndexChanged
        Try
            Dim SQL As String = "SELECT MATA_KULIAH FROM T_MATA_KULIAH WHERE KODE_MATA_KULIAH = @KODE_MATA_KULIAH"
            Using conn As New SqlConnection(Me.STRCONN_STRING.ToString)
                Using cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(SQL, conn)
                    conn.Open()
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.Add("@KODE_MATA_KULIAH", SqlDbType.VarChar).Value = Me.cbMataKuliah.Text
                    Using r As SqlClient.SqlDataReader = cmd.ExecuteReader()
                        If r.HasRows() Then
                            If r.Read() Then
                                Me.txtMataKuliah.Text = r.GetValue(0)
                                Me.txtKodeMatKul.Text = Me.cbMataKuliah.Text
                            End If
                        Else
                            Me.txtMataKuliah.Text = String.Empty
                        End If
                        conn.Close()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBoxEx.Show("PERHATIAN..  " + ex.Message, "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class