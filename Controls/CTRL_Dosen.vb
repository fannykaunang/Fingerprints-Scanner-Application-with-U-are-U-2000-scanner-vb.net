Imports System.Data.SqlClient
Imports DevComponents.DotNetBar

Public Class CTRL_Dosen
    Private a As New MetroFramework.Animation.MoveAnimation
    Private jenisOperasi As operasi
    Private STRCONN_STRING As String = My.Settings("ConnectionStringApp").ToString
    Private IS_EDITING As Boolean
    Dim STR_NUM As String = "0123456789,"

    Private Enum operasi
        insert = 0
        update = 1
    End Enum

#Region "SetCultureToIndonesia"
    Private Sub SetCultureToIndonesia()
        Dim ci As System.Globalization.CultureInfo
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CTRL_Dosen))

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
        If Me.TXTID.Text = String.Empty Or Me.TXTNAMADOSEN.Text = String.Empty Or Me.TXTTEMPATLAHIR.Text = String.Empty Or Me.CBJK.SelectedIndex = 0 _
           Or Me.CBSTATUS.SelectedIndex = 0 Or Me.CBPENDIDIKAN.SelectedIndex = 0 _
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
            If TypeOf Ctrl Is DevComponents.DotNetBar.Controls.TextBoxX OrElse TypeOf Ctrl Is DevComponents.DotNetBar.Controls.ComboBoxEx Then
                Ctrl.Text = String.Empty
            End If
        Next
    End Sub
#Region "SQL Query Manipulation"
    Private Sub GET_INSERT_DATA()
        Try
            Dim STR_SQL As String = "INSERT INTO T_DOSEN "
            STR_SQL &= "VALUES(@NIP_NIDN, @NAMA_DOSEN, @TEMPAT_LAHIR, @TANGGAL_LAHIR, @JENIS_KELAMIN, "
            STR_SQL &= "@STATUS, @PENDIDIKAN_TERAKHIR)"
            Using CONNECTION As New SqlConnection(Me.STRCONN_STRING.ToString)
                Using COMMAND_PARAM As SqlClient.SqlCommand = New SqlClient.SqlCommand(STR_SQL, CONNECTION)

                    With COMMAND_PARAM
                        .Connection = CONNECTION
                        .CommandType = CommandType.Text
                        .CommandText = STR_SQL
                        .Parameters.Add("@NIP_NIDN", SqlDbType.VarChar).Value = Me.TXTID.Text
                        .Parameters.Add("@NAMA_DOSEN", SqlDbType.VarChar).Value = Me.TXTNAMADOSEN.Text
                        .Parameters.Add("@TEMPAT_LAHIR", SqlDbType.VarChar).Value = Me.TXTTEMPATLAHIR.Text
                        .Parameters.Add("@TANGGAL_LAHIR", SqlDbType.DateTime).Value = Me.DTLAHIR.Value
                        .Parameters.Add("@JENIS_KELAMIN", SqlDbType.VarChar).Value = Me.CBJK.Text
                        .Parameters.Add("@STATUS", SqlDbType.VarChar).Value = Me.CBSTATUS.Text
                        .Parameters.Add("@PENDIDIKAN_TERAKHIR", SqlDbType.VarChar).Value = Me.CBPENDIDIKAN.Text
                        .Connection.Open()
                        .ExecuteNonQuery()
                        .Connection.Close()
                    End With

                    MessageBoxEx.Show("DATA DOSEN DENGAN NAMA : " & Me.TXTNAMADOSEN.Text & vbNewLine & "BERHASIL DISIMPAN.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.IS_EDITING = False
                    Me.PictureBox1.Image = My.Resources.accept_icon
                    Me.LBERROR.Text = "SUCCESFULLY SAVED!"
                    Me.a.Start(DataGridViewX1, New Point(0, 0), MetroFramework.Animation.TransitionType.EaseInCubic, 10)
                    Me.BackgroundWorker.RunWorkerAsync()
                End Using
            End Using
        Catch ex As Exception
            MessageBoxEx.Show("PERHATIAN..  " + ex.Message, "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.LBERROR.Text = ex.Message
            Me.PictureBox1.Image = My.Resources.ico_alpha_Exclamation_128x128___Copy
        End Try
    End Sub
    Private Sub GET_UPDATE_DATA()
        Dim STR_SQL As String = "UPDATE T_DOSEN SET "
        STR_SQL &= "NAMA_DOSEN=@NAMA_DOSEN, TEMPAT_LAHIR=@TEMPAT_LAHIR, TANGGAL_LAHIR=@TANGGAL_LAHIR, JENIS_KELAMIN=@JENIS_KELAMIN, "
        STR_SQL &= "STATUS=@STATUS, PENDIDIKAN_TERAKHIR=@PENDIDIKAN_TERAKHIR "
        STR_SQL &= "WHERE NIP_NIDN=@NIP_NIDN"
        Using CONNECTION As New SqlConnection(Me.STRCONN_STRING.ToString)
            Using COMMAND_PARAM As SqlClient.SqlCommand = CONNECTION.CreateCommand
                Try
                    With COMMAND_PARAM
                        .Connection = CONNECTION
                        .CommandType = CommandType.Text
                        .CommandText = STR_SQL
                        .Parameters.Add("@NIP_NIDN", SqlDbType.VarChar).Value = Me.TXTID.Text
                        .Parameters.Add("@NAMA_DOSEN", SqlDbType.VarChar).Value = Me.TXTNAMADOSEN.Text
                        .Parameters.Add("@TEMPAT_LAHIR", SqlDbType.VarChar).Value = Me.TXTTEMPATLAHIR.Text
                        .Parameters.Add("@TANGGAL_LAHIR", SqlDbType.DateTime).Value = Me.DTLAHIR.Value
                        .Parameters.Add("@JENIS_KELAMIN", SqlDbType.VarChar).Value = Me.CBJK.Text
                        .Parameters.Add("@STATUS", SqlDbType.VarChar).Value = Me.CBSTATUS.Text
                        .Parameters.Add("@PENDIDIKAN_TERAKHIR", SqlDbType.VarChar).Value = Me.CBPENDIDIKAN.Text
                        .Connection.Open()
                        .ExecuteNonQuery()
                        .Connection.Close()
                    End With

                    MessageBoxEx.Show("DATA DOSEN DENGAN NAMA : " & Me.TXTNAMADOSEN.Text & vbNewLine & "BERHASIL DIUBAH.", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.PictureBox1.Image = My.Resources.accept_icon
                    Me.LBERROR.Text = "SUCCESFULLY UPDATED!"
                    Me.IS_EDITING = False

                    Me.a.Start(DataGridViewX1, New Point(0, 0), MetroFramework.Animation.TransitionType.EaseInCubic, 10)
                    Me.BackgroundWorker.RunWorkerAsync()
                Catch ex As Exception
                    MessageBoxEx.Show("PERHATIAN..  " + ex.Message, "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Me.LBERROR.Text = ex.Message
                    Me.PictureBox1.Image = My.Resources.ico_alpha_Exclamation_128x128___Copy
                End Try
            End Using
        End Using
    End Sub
    Private Sub GET_DELETE_RECORD(ByVal Kode_D_W As String)
        Dim query As String = "DELETE FROM T_DOSEN WHERE NIP_NIDN = @NIP_NIDN"
        Using conn As New SqlConnection(Me.STRCONN_STRING.ToString)
            Using cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(query, conn)
                Try
                    With cmd
                        .Connection = conn
                        .CommandText = query
                        .Connection.Open()
                        .Parameters.Add("@NIP_NIDN", SqlDbType.VarChar).Value = Kode_D_W
                        .ExecuteNonQuery()
                        .Connection.Close()
                    End With

                    ToastNotification.Show(Me, RowsToDelete.Count & " DATA BERHASIL DIHAPUS", _
                     IIf(True, My.Resources.accept_icon1, Nothing), 3 * 1000, glow, eToastPosition.MiddleCenter)

                    Me.PictureBox1.Image = My.Resources.accept_icon
                    Me.LBERROR.Text = "SUCCESFULLY DELETED!"

                    Me.IS_EDITING = False

                Catch ex As Exception
                    MessageBoxEx.Show("PERHATIAN..  " + ex.Message, "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Me.LBERROR.Text = ex.Message
                    Me.PictureBox1.Image = My.Resources.ico_alpha_Exclamation_128x128___Copy
                End Try
            End Using
        End Using
    End Sub

    Private RowsToDelete As New List(Of DataGridViewRow)
    Private Sub BTHAPUS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTHAPUS.Click
        Me.RowsToDelete.Clear()
        Try
            For Each row As DataGridViewRow In Me.DataGridViewX1.Rows
                If row.Cells(0).Value = True Then
                    RowsToDelete.Add(row)
                    Me.GET_DELETE_RECORD(row.Cells(1).Value)
                End If
            Next

            For Each rowtodelete In RowsToDelete
                DataGridViewX1.Rows.Remove(rowtodelete)
            Next

        Catch ex As Exception
            MessageBoxEx.Show("PERHATIAN..  " + ex.Message, "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
#End Region

    Private Sub CTL_PASIEN_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load  
        Me.DEFAULT_TEXT(PanelEx2)
        Me.BackgroundWorker.RunWorkerAsync()
        Me.TXTTANGGAL.Text = Date.Parse(Today).ToString("dd-MMMM-yyyy").ToUpper
        Me.SetCultureToIndonesia()
        Me.StyleManager1.ManagerStyle = My.Settings.Style
    End Sub

    Private Sub BTBATAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTBATAL.Click
        a.Start(DataGridViewX1, New Point(0, 0), MetroFramework.Animation.TransitionType.EaseInCubic, 10)
    End Sub

    Private Sub BTTAMBAH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTTAMBAH.Click
        Me.DEFAULT_TEXT(PanelEx2)
        'Me.NOMOR_OTOMATIS()
        Dim p As New Point(Me.PanelEx1.Width, 0)
        a.Start(DataGridViewX1, p, MetroFramework.Animation.TransitionType.EaseInCubic, 15)
        Me.jenisOperasi = operasi.insert
    End Sub

    Private Sub BTKELUAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTKELUAR.Click
        Me.Dispose()
    End Sub

    Private Sub BTSIMPAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTSIMPAN.Click
        If VALIDATE_INPUT() Then
            If Me.jenisOperasi = operasi.insert Then
                Me.GET_INSERT_DATA()
            ElseIf Me.jenisOperasi = operasi.update Then
                Me.GET_UPDATE_DATA()
            End If
        End If
    End Sub

    Private Sub BTUBAH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTUBAH.Click
        If Me.DataGridViewX1.CurrentRow.Cells("NIP_NIDN").Selected = False AndAlso Me.DataGridViewX1.CurrentRow.Cells("NAMA_DOSEN").Selected = False Then
            MessageBoxEx.Show("PERHATIAN..  ANDA BELUM MEMILIH SALAH SATU DATA YANG AKAN DIUBAH", "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Me.jenisOperasi = operasi.update
        Try
            Dim SQL As String = "SELECT * FROM T_DOSEN WHERE NIP_NIDN = @NIP_NIDN"
            Using conn As New SqlConnection(Me.STRCONN_STRING.ToString)
                Using cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(SQL, conn)
                    conn.Open()
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.Add("@NIP_NIDN", SqlDbType.VarChar).Value = Me.DataGridViewX1.CurrentRow.Cells("NIP_NIDN").Value
                    Using r As SqlClient.SqlDataReader = cmd.ExecuteReader()
                        If r.HasRows() Then
                            If r.Read() Then
                                Dim p As New Point(Me.PanelEx1.Width, 0)
                                a.Start(DataGridViewX1, p, MetroFramework.Animation.TransitionType.EaseInCubic, 15)
                                Me.TXTID.Text = r("NIP_NIDN").ToString
                                Me.TXTNAMADOSEN.Text = r("NAMA_DOSEN").ToString
                                Me.TXTTEMPATLAHIR.Text = r("TEMPAT_LAHIR").ToString
                                Me.DTLAHIR.Value = r("TANGGAL_LAHIR").ToString
                                Me.CBJK.Text = r("JENIS_KELAMIN").ToString
                                Me.CBSTATUS.Text = r("STATUS").ToString
                                Me.CBPENDIDIKAN.Text = r("PENDIDIKAN_TERAKHIR").ToString

                                Me.jenisOperasi = operasi.update
                            End If
                        Else
                            Me.TXTID.Text = r("NIP_NIDN").ToString
                            Me.TXTNAMADOSEN.Text = String.Empty
                            Me.TXTTEMPATLAHIR.Text = String.Empty
                            Me.DTLAHIR.Value = Today
                            Me.CBJK.Text = "-- PILIH --"
                            Me.CBSTATUS.Text = "-- PILIH --"
                            Me.CBPENDIDIKAN.Text = "-- PILIH --"
                            Me.jenisOperasi = operasi.update
                        End If
                        conn.Close()
                    End Using
                End Using
            End Using
        Catch ex As Exception
            'MessageBoxEx.Show("PERHATIAN..  " + ex.Message, "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

#Region "ASYNCHRONOUS"
    Delegate Sub AsiggnDTCallback(ByVal dt As DataTable)
    Private Sub AsignaDT(ByVal dt As DataTable)
        If Me.DataGridViewX1.InvokeRequired Then
            Dim d As New AsiggnDTCallback(AddressOf AsignaDT)
            Me.Invoke(d, New Object() {dt})
        Else
            Me.DataGridViewX1.DataSource = dt
            Me.DataGridViewX1.Refresh()
        End If
    End Sub

    Private Sub BackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork
        Me.TampilDataFormDialog()
        Dim strQuery As String = "select * from T_DOSEN ORDER BY NIP_NIDN"
        Try
            Using conn As New SqlConnection(Me.STRCONN_STRING.ToString)
                Using da As New SqlClient.SqlDataAdapter(strQuery, conn)
                    Using dt As New Data.DataTable
                        dt.Clear()
                        da.Fill(dt)
                        Me.AsignaDT(dt)

                        For i As Integer = 0 To 1000
                            BackgroundWorker.ReportProgress(i / 10)
                        Next

                    End Using
                End Using
            End Using
        Catch ex As Exception
            Exit Try
        End Try
    End Sub

    Private Sub BackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted
        Me.ProgressForm.BeginInvoke(New Action(Sub() ProgressForm.Close()))
    End Sub

    Private ProgressForm As New Form_Wait
    Private th As New Threading.Thread(AddressOf ShowFormWait)

    Private Sub TampilDataFormDialog()
        If Me.th Is Nothing OrElse Not Me.th.IsAlive Then
            Me.th = New Threading.Thread(New Threading.ThreadStart(AddressOf Me.ShowFormWait))
            Me.th.SetApartmentState(Threading.ApartmentState.STA)
            Me.th.Start()
        End If
    End Sub
    Private Sub ShowFormWait()
        If Me.InvokeRequired Then
            Me.ProgressForm.ShowDialog()
        End If
    End Sub
#End Region

    Private Sub BackgroundWorkerSearch_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerSearch.DoWork
        Me.TampilDataFormDialog()
        Dim strQuery As String = "select * from VW_TERAPI_OBAT_GIZI_JNSOBAT WHERE NIP_NIDN LIKE @p1 Or KODE_JURUSAN LIKE @p2 Or NAMA_OBAT LIKE @p3 Or NAMA_GIZI LIKE @p4"
        strQuery &= " ORDER BY NIP_NIDN"

        Try
            Using conn As New SqlConnection(Me.STRCONN_STRING.ToString)
                Using da As New SqlClient.SqlDataAdapter(strQuery, conn)
                    Using dt As New Data.DataTable
                        da.SelectCommand.Parameters.AddWithValue("@p1", "%" & Me.TXTSEARCH.Text & "%")
                        da.SelectCommand.Parameters.AddWithValue("@p2", "%" & Me.TXTSEARCH.Text & "%")
                        da.SelectCommand.Parameters.AddWithValue("@p3", "%" & Me.TXTSEARCH.Text & "%")
                        da.SelectCommand.Parameters.AddWithValue("@p4", "%" & Me.TXTSEARCH.Text & "%")

                        dt.Clear()
                        da.Fill(dt)
                        Me.AsignaDT(dt)

                        For i As Integer = 0 To 1000
                            BackgroundWorker.ReportProgress(i / 10)
                        Next

                    End Using
                End Using
            End Using
        Catch ex As Exception
            Exit Try
        End Try
    End Sub

    Private Sub TXTSEARCH_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXTSEARCH.TextChanged
        Do While Me.BackgroundWorkerSearch.IsBusy
            Application.DoEvents()
        Loop
        Me.BackgroundWorkerSearch.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorkerSearch_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted
        Me.ProgressForm.BeginInvoke(New Action(Sub() ProgressForm.Close()))
        If Me.BackgroundWorkerSearch.IsBusy Then Me.BackgroundWorkerSearch.Dispose()
    End Sub

    Private Sub BackgroundWorkerSearch_RunWorkerCompleted1(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerSearch.RunWorkerCompleted
        Me.ProgressForm.BeginInvoke(New Action(Sub() ProgressForm.Close()))
        If Me.BackgroundWorkerSearch.IsBusy Then Me.BackgroundWorkerSearch.Dispose()
    End Sub
End Class
