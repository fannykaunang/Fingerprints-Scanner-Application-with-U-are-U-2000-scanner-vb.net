Imports System.Data.SqlClient
Imports DevComponents.DotNetBar

' NOTE: This form is a base for the EnrollmentForm and the VerificationForm,
'	All changes in the CaptureForm will be reflected in all its derived forms.

Public Class CaptureForm
    Implements DPFP.Capture.EventHandler

    Private Capturer As DPFP.Capture.Capture
    Private STRCONN_STRING As String = My.Settings("ConnectionStringApp").ToString

    Protected Overridable Sub Init()
        Try
            Capturer = New DPFP.Capture.Capture()                   ' Create a capture operation.

            If (Not Capturer Is Nothing) Then
                Capturer.EventHandler = Me                              ' Subscribe for capturing events.
            Else
                SetPrompt("Can't initiate capture operation!")
            End If
        Catch ex As Exception
            MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub CaptureForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init()
        StartCapture()

        Me.GET_DATA_COMBO(Me.CBJURUSAN, "T_JURUSAN", "SELECT * FROM T_JURUSAN", "KODE_JURUSAN", "JURUSAN")
        Me.GET_DATA_COMBO(Me.CBFAKULTAS, "T_FAKULTAS", "SELECT * FROM T_FAKULTAS", "KODE_FAKULTAS", "FAKULTAS")
        Me.GET_DATA_COMBO(Me.cbMataKuliah, "T_MATA_KULIAH", "SELECT * FROM T_MATA_KULIAH", "KODE_MATA_KULIAH", "MATA_KULIAH")

    End Sub

    Private Sub CaptureForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        StopCapture()
    End Sub

    Sub OnComplete(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal Sample As DPFP.Sample) Implements DPFP.Capture.EventHandler.OnComplete
        MakeReport("The fingerprint sample was captured.")
        SetPrompt("Scan the same fingerprint again.")
        Process(Sample) 'ini sample
    End Sub

    Sub OnFingerGone(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerGone
        MakeReport("The finger was removed from the fingerprint reader.")
    End Sub

    Sub OnFingerTouch(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnFingerTouch
        MakeReport("The fingerprint reader was touched.")
    End Sub

    Sub OnReaderConnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderConnect
        MakeReport("The fingerprint reader was connected.")
    End Sub

    Sub OnReaderDisconnect(ByVal Capture As Object, ByVal ReaderSerialNumber As String) Implements DPFP.Capture.EventHandler.OnReaderDisconnect
        MakeReport("The fingerprint reader was disconnected...")
    End Sub

    Sub OnSampleQuality(ByVal Capture As Object, ByVal ReaderSerialNumber As String, ByVal CaptureFeedback As DPFP.Capture.CaptureFeedback) Implements DPFP.Capture.EventHandler.OnSampleQuality
        If CaptureFeedback = DPFP.Capture.CaptureFeedback.Good Then
            MakeReport("The quality of the fingerprint sample is good.")
        Else
            MakeReport("The quality of the fingerprint sample is poor.")
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

    Protected Sub MakeReport(ByVal status)
        Invoke(New FunctionCall(AddressOf _MakeReport), status)
    End Sub

    Private Sub _MakeReport(ByVal status)
        StatusText.AppendText(status + Chr(13) + Chr(10))
    End Sub

    Public Sub MakeReportJK(ByVal status)
        Invoke(New FunctionCall(AddressOf _MakeReportJK), status)
    End Sub

    Private Sub _MakeReportJK(ByVal status)
        CBJK.Text = status
    End Sub

    Protected Sub DrawPicture(ByVal bmp)
        Invoke(New FunctionCall(AddressOf _DrawPicture), bmp)
    End Sub

    Private Sub _DrawPicture(ByVal bmp)
        Picture.Image = New Bitmap(bmp, Picture.Size)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        'AddHandler Enroller.OnTemplate, AddressOf OnTemplate
        'FormMenu.SaveData()
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

    Private Sub TXTNPM_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TXTNPM.Validating, TXTNAMA.Validating
        Me.LBPath.Text = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "File" & "\" & Me.TXTNPM.Text & ".fpt")
        If My.Computer.FileSystem.FileExists(Me.LBPath.Text) Then
            MessageBox.Show("PERHATIAN..  NPM SUDAH TERSIMPAN DALAM DATABASE", "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.TXTNPM.Clear()
            Me.TXTNPM.Focus()
            Return
        End If

        If Me.TXTNPM.Text = String.Empty OrElse Me.TXTNAMA.Text = String.Empty OrElse Me.CBJK.Text = "-- PILIH --" OrElse Me.CBFAKULTAS.Text = "-- PILIH --" OrElse Me.CBJURUSAN.Text = "-- PILIH --" OrElse Me.CBSEMESTER.Text = "-- PILIH --" Then
            MessageBox.Show("PERHATIAN..  MASIH ADA DATA YANG KOSONG", "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.StopCapture()
        Else
            Me.LBPath.Text = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "File" & "\" & Me.TXTNPM.Text & ".fpt")
            Init()
            StartCapture()
        End If
        'Me.LBPath.Text = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "File" & "\" & Me.TXTNPM.Text & ".fpt")
    End Sub

    'Private Sub TXTNAMA_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TXTNAMA.Validating
    '    If Me.TXTNPM.Text = String.Empty OrElse Me.TXTNAMA.Text = String.Empty OrElse Me.CBJK.Text = "-- PILIH --" OrElse Me.CBFAKULTAS.Text = "-- PILIH --" OrElse Me.CBJURUSAN.Text = "-- PILIH --" OrElse Me.CBSEMESTER.Text = "-- PILIH --" Then
    '        StopCapture()
    '    Else
    '        Init()
    '        StartCapture()
    '    End If
    'End Sub

    Private Sub CBFAKULTAS_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CBFAKULTAS.Validating, CBJK.Validating, CBJURUSAN.Validating, CBSEMESTER.Validating
        If Me.TXTNPM.Text = String.Empty OrElse Me.TXTNAMA.Text = String.Empty OrElse Me.CBJK.Text = "-- PILIH --" OrElse Me.CBFAKULTAS.Text = "-- PILIH --" OrElse Me.CBJURUSAN.Text = "-- PILIH --" OrElse Me.CBSEMESTER.Text = "-- PILIH --" Then
            StopCapture()
        Else
            Init()
            StartCapture()
        End If
    End Sub

    Private Sub CBJK_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBJK.SelectedIndexChanged
        Me.TXTJK.Text = Me.CBJK.Text
    End Sub

    Private Sub CBFAKULTAS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBFAKULTAS.SelectedIndexChanged
        Me.TXTFAKULTAS.Text = Me.CBFAKULTAS.Text
    End Sub

    Private Sub CBJURUSAN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBJURUSAN.SelectedIndexChanged
        Me.TXTJURUSAN.Text = Me.CBJURUSAN.Text
    End Sub

    Private Sub CBSEMESTER_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSEMESTER.SelectedIndexChanged
        Me.TXTSEMESTER.Text = Me.CBSEMESTER.Text
        '507, 467
    End Sub

    Private Function GetTotalMinutes() As Integer
        Dim d1 As DateTime = DateTime.Now
        Dim d2 As DateTime = DateTime.Now.AddHours(25).AddMinutes(10)

        Dim difference As TimeSpan = (d2 - d1)
        Dim hours = Math.Floor(difference.TotalHours)
        Dim minutes = difference.Minutes

        Return d1.Minute 'difference.Minutes 'INI MSH IKUT ADDMINUTES=10
    End Function

    Private Function GetDateFromDB() As DateTime
        'Dim d1 As DateTime = DateTime.Now
        'Dim d2 As DateTime = DateTime.Now.AddHours(25).AddMinutes(10)

        'Dim difference As TimeSpan = (d2 - d1)
        'Dim hours = Math.Floor(difference.TotalHours)
        'Dim minutes = difference.Minutes

        'Return difference

        Try
            Dim SQL As String = "SELECT JAM_MASUK FROM T_MATA_KULIAH WHERE KODE_MATA_KULIAH = @KODE_MATA_KULIAH"
            Using conn As New SqlConnection(Me.STRCONN_STRING.ToString)
                Using cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(SQL, conn)
                    conn.Open()
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.Add("@KODE_MATA_KULIAH", SqlDbType.VarChar).Value = Me.cbMataKuliah.Text
                    Using r As SqlClient.SqlDataReader = cmd.ExecuteReader()
                        If r.HasRows() Then
                            If r.Read() Then
                                Return r.GetDateTime(0)
                            End If
                        End If
                        Return Nothing
                        conn.Close()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBoxEx.Show("PERHATIAN..  " + ex.Message, "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return Nothing
        End Try
    End Function

    Private Sub cbMataKuliah_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMataKuliah.SelectedIndexChanged
        Me.CariMaksimalPertemuanMK()
        'Me.CariTotalKehadiranMHS()
        Me.Label15.Text = Me.CariTotalKehadiranMHS()

        If CariTotalKehadiranMHS() >= CariMaksimalPertemuanMK() Then
            MessageBoxEx.Show("PERHATIAN..  TOTAL KEHADIRAN TIDAK BOLEH LEBIH DARI TOTAL PERTEMUAN MATA KULIAH", "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.StopCapture()
            Me.Close()
            Return
        End If

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
        Me.CariTotalKehadiranMHS()
        'MsgBox(Me.GetDateFromDB.Minute.ToString)
        If Me.GetDateFromDB.Minute >= Me.GetTotalMinutes Then
            MessageBoxEx.Show("PERHATIAN..  ANDA TERLAMBAT LEBIH DARI 15 MENIT", "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.StopCapture()
            Me.Close()
            Return
        End If
    End Sub

    Private Function CariMaksimalPertemuanMK() As Integer
        'Using CONNECTION As New SqlConnection(Me.STRCONN_STRING.ToString)
        '    CONNECTION.Open()
        '    Using dtAdapter As New SqlClient.SqlDataAdapter
        '        Using dtSet As New Data.DataSet
        '            Using CMDTampilData As SqlClient.SqlCommand = CONNECTION.CreateCommand()
        '                Dim sql As String = "SELECT TOTAL_PERTEMUAN_DALAM_1_SEMESTER FROM T_MATA_KULIAH WHERE KODE_MATA_KULIAH=@KODE_MATA_KULIAH"
        '                Dim dtTable As DataTable
        '                Try
        '                    CMDTampilData.Parameters.Add("@KODE_MATA_KULIAH", SqlDbType.VarChar).Value = Me.cbMataKuliah.Text
        '                    CMDTampilData.CommandText = sql
        '                    dtAdapter.SelectCommand = CMDTampilData
        '                    dtAdapter.Fill(dtSet)
        '                    dtTable = dtSet.Tables(0)

        '                    Return CariMaksimalPertemuanMK()
        '                Catch salah As Exception
        '                    MessageBoxEx.Show("PERHATIAN..  " + salah.Message, "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '                    Return 0
        '                End Try
        '            End Using
        '        End Using
        '    End Using
        'End Using

        modKoneksiDatabase.BukaDatabase()
        Dim rdr As SqlClient.SqlDataReader = Nothing
        Dim CMDTampilData As SqlClient.SqlCommand = conn.CreateCommand()
        Dim sql As String = "SELECT TOTAL_PERTEMUAN_DALAM_1_SEMESTER FROM T_MATA_KULIAH WHERE KODE_MATA_KULIAH=@KODE_MATA_KULIAH"
        Try
            CMDTampilData.Parameters.Add("@KODE_MATA_KULIAH", SqlDbType.VarChar).Value = Me.cbMataKuliah.Text
            CMDTampilData.CommandText = sql
            rdr = CMDTampilData.ExecuteReader()

            If (rdr.Read()) Then
                Return Double.Parse((rdr.GetValue(0)))
            Else
                Return 0
            End If
        Catch salah As Exception
            MessageBoxEx.Show("PERHATIAN..  " + salah.Message, "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function
    Private Function CariTotalKehadiranMHS() As Integer
        'Using CONNECTION As New SqlConnection(Me.STRCONN_STRING.ToString)
        '    CONNECTION.Open()
        '    Using dtAdapter As New SqlClient.SqlDataAdapter
        '        Using dtSet As New Data.DataSet
        '            Using CMDTampilData As SqlClient.SqlCommand = CONNECTION.CreateCommand()
        '                Dim sql As String = "SELECT SUM(TOTAL_KEHADIRAN) FROM T_ABSENSI_MATA_KULIAH WHERE NPM=@NPM AND KODE_MATA_KULIAH=@KODE_MATA_KULIAH"
        '                Dim dtTable As DataTable
        '                Try
        '                    CMDTampilData.Parameters.Add("@NPM", SqlDbType.VarChar).Value = Me.txtNPM2.Text
        '                    CMDTampilData.Parameters.Add("@KODE_MATA_KULIAH", SqlDbType.VarChar).Value = Me.cbMataKuliah.Text
        '                    CMDTampilData.CommandText = sql
        '                    dtAdapter.SelectCommand = CMDTampilData
        '                    dtAdapter.Fill(dtSet)
        '                    dtTable = dtSet.Tables(0)

        '                    Return CariTotalKehadiranMHS
        '                Catch salah As Exception
        '                    MessageBoxEx.Show("PERHATIAN..  " + salah.Message, "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '                    Return 0
        '                End Try
        '            End Using
        '        End Using
        '    End Using
        'End Using

        modKoneksiDatabase.BukaDatabase()
        Dim rdr As SqlClient.SqlDataReader = Nothing
        Dim CMDTampilData As SqlClient.SqlCommand = conn.CreateCommand()
        Dim sql As String = "SELECT COUNT(TOTAL_KEHADIRAN) FROM T_ABSENSI_MATA_KULIAH WHERE NPM=@NPM AND KODE_MATA_KULIAH=@KODE_MATA_KULIAH"
        Try
            CMDTampilData.Parameters.Add("@NPM", SqlDbType.VarChar).Value = Me.txtNPM2.Text
            CMDTampilData.Parameters.Add("@KODE_MATA_KULIAH", SqlDbType.VarChar).Value = Me.cbMataKuliah.Text
            CMDTampilData.CommandText = sql
            rdr = CMDTampilData.ExecuteReader()

            If (rdr.Read()) Then
                If IsDBNull(rdr.GetValue(0)) Then
                    Return 0
                End If
                Return Double.Parse((rdr.GetValue(0)))
            Else
                Return 0
            End If
        Catch salah As Exception
            MessageBoxEx.Show("PERHATIAN..  " + salah.Message, "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 0
        End Try
    End Function
End Class