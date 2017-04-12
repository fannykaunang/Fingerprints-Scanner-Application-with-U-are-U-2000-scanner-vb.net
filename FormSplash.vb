Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Public Class FormSplash
    Private STRCONN_STRING As String = My.Settings("ConnectionStringApp").ToString
    Private SYNCHRONIZE As Boolean

    Delegate Sub EditTextCallback(ByVal Obj As Object, ByVal bool As Boolean, ByVal txt As String)
    Delegate Sub EnabledButtonCallback(ByVal btn As DevComponents.DotNetBar.ButtonX, ByVal bool As Boolean, ByVal txt As String)
    Delegate Sub ValueProgressBarCallback(ByVal pgb As DevComponents.DotNetBar.Controls.ProgressBarX, ByVal value As Integer)
    Delegate Sub ItemCallback(ByVal bool As Boolean, ByVal txt As String)
    Delegate Sub AsiggnDTCallback(ByVal dt As DataTable)

    Private Sub EditText(ByVal Obj As Object, ByVal [Concat] As Boolean, ByVal [Text] As String)
        If Obj.InvokeRequired Then
            Dim d As New EditTextCallback(AddressOf EditText)
            Me.Invoke(d, New Object() {Obj, [Concat], [Text]})
        Else
            Select Case [Concat]

                Case True
                    Obj.Text += [Text]

                Case False
                    Obj.Text = [Text]

            End Select

        End If
    End Sub

    Private Sub EnabledButton(ByVal [button] As ButtonX, ByVal [concat] As Boolean, ByVal [Text] As String)
        If [button].InvokeRequired Then
            Dim d As New EnabledButtonCallback(AddressOf EnabledButton)
            Me.Invoke(d, New Object() {[button], [concat], [Text]})
        Else
            [button].Enabled = [concat]
            [button].Text = [Text]
        End If
    End Sub

    Private Sub ValueProgressBar(ByVal [Progress] As DevComponents.DotNetBar.Controls.ProgressBarX, ByVal [Value] As Integer)
        If [Progress].InvokeRequired Then
            Dim d As New ValueProgressBarCallback(AddressOf ValueProgressBar)
            Me.Invoke(d, New Object() {[Progress], [Value]})
        Else

            [Progress].Value = [Value]

        End If
    End Sub

    Private Sub Item(ByVal [concat] As Boolean, ByVal [Text] As String)

    End Sub

    Private Sub FORM_SPLASH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.SYNCHRONIZE = False
        Me.BackgroundWorker.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker.ProgressChanged
        Me.ValueProgressBar(Me.PB, e.ProgressPercentage)
        Me.EditText(Me.PB, False, e.ProgressPercentage & "%")

        If e.ProgressPercentage = 10 Then
            Me.LabelItem2.Text = "CONNECTING TO DATABASE..."
        ElseIf e.ProgressPercentage = 30 Then
            Me.LabelItem2.Text = "ANALYZE TABLES, VIEW AND STORED PROCEDURE..."
        ElseIf e.ProgressPercentage = 80 Then
            Me.LabelItem2.Text = "PREPARING APPLICATION REFERENCES AND USER INTERACES...    "
        ElseIf e.ProgressPercentage = 100 Then
            Me.PB.Visible = False
            Me.lbValPercent.Visible = False
            Me.PB.TextVisible = False
        End If
    End Sub

    Private Sub BackgroundWorker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted
        Me.EditText(Me.LabelItem2, True, "OPERATION COMPLETED SUCCESSFULL.. WELCOME.")
        Dim FRM As New FormMain
        FRM.Show()
        'Me.Visible = False
        'Me.Close()

        Me.ChangeUI()
        Me.Visible = True
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop

    End Sub

    Private Sub BackgroundWorker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork
        Me.ExecuteQuery()
    End Sub

    Private Sub ExecuteQuery()
        Me.EditText(Me.LabelItem2, False, "EXECUTING...")
        'Me.EnabledButton(Me.ButtonX1, True, "BATAL")
        Me.ValueProgressBar(Me.PB, 0)

        Dim qry As String
        qry = " sp_tables @table_type = " & Chr(34) & Chr(39) & "TABLE" & Chr(39) & "," & Chr(39) '& "VIEW" & Chr(39) & Chr(34)
        'qry += " WAITFOR DELAY '0:0:10'; "
        Dim da As New Data.SqlClient.SqlDataAdapter(qry, Me.STRCONN_STRING.ToString)
        Dim dtTablas As New Data.DataTable("T_MAHASISWA")

        Try
            da.Fill(dtTablas)

            Dim irow As Data.DataRow = Nothing
            Dim i As Integer = 0
            For Each irow In dtTablas.Rows
                If BackgroundWorker.CancellationPending Then
                    Exit Sub
                Else
                    BackgroundWorker.ReportProgress(i / (dtTablas.Rows.Count / 100))
                    Me.FillTable(irow.Item(2).ToString())
                End If
                i = i + 1
            Next
            BackgroundWorker.ReportProgress(dtTablas.Rows.Count / (dtTablas.Rows.Count / 100))
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Private Sub FillTable(ByVal tbl As String)

        Dim qry As String
        qry = " sp_columns " & tbl

        Dim da As New Data.SqlClient.SqlDataAdapter(qry, Me.STRCONN_STRING.ToString)
        Dim dtColumnas As New Data.DataTable("kolom")

        Try
            'Lleno el datatable dtColumnas con las columnas de la Tabla
            da.Fill(dtColumnas)

            Dim irow As Data.DataRow = Nothing

            For Each irow In dtColumnas.Rows

                Try
                    'qry = " SELECT * FROM " & Tabla & " WHERE " & irow.Item(3) & " LIKE '%" & txtBusqueda.Text & "%' "

                    Dim dr As SqlDataReader
                    Dim cmd As New SqlCommand(qry)
                    Dim conn As New SqlConnection(Me.STRCONN_STRING.ToString)
                    cmd.Connection = conn
                    cmd.Connection.Open()
                    dr = cmd.ExecuteReader()

                    If dr.HasRows = True Then
                        'EditaTexto(txtResultado, True, irow.Item(0).ToString() & "." & irow.Item(1).ToString() & "." & irow.Item(2).ToString() & "." & irow.Item(3).ToString() & vbCrLf)
                        Item(False, irow.Item(0).ToString() & "." & irow.Item(1).ToString() & "." & irow.Item(2).ToString() & "." & irow.Item(3).ToString())
                    End If

                    cmd.Connection.Close()

                    cmd = Nothing
                    dr = Nothing

                Catch ex As Exception
                    Exit Try
                End Try

            Next

        Catch ex As Exception
            Exit Sub
        End Try

    End Sub
    Private Sub ChangeUI()
        'Me.LabelX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
        ' Or System.Windows.Forms.AnchorStyles.Left) _
        ' Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)

        Me.LabelX1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.White
        'Me.LabelX1.Location = New System.Drawing.Point(12, 18)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(325, 24)
        Me.LabelX1.TabIndex = 259
        Me.LabelX1.Text = "SISTEM ABSENSI MATA KULIAH MENGGUNAKAN SIDIK JARI"

        Me.PictureBox1.Size = New System.Drawing.Size(22, 23)
        Me.LabelX2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.TXTUSER.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPASSWORD.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        'Me.TextBoxX1.Size = New System.Drawing.Size(212, 22)
        'Me.TextBoxX2.Size = New System.Drawing.Size(212, 22)

        'Me.ButtonX1.Size = New System.Drawing.Size(66, 51)
        'Me.PanelEx1.Size = New System.Drawing.Size(375, 80)

        Me.ClientSize = New System.Drawing.Size(390, 120)
        Me.MetroStatusBar1.Visible = False
        Me.PanelEx1.Visible = True
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If Me.BackgroundWorker.IsBusy Then
            Dim logout As String = MessageBoxEx.Show("PERHATIAN.. SINKRONISASI SEDANG BERJALAN. APAKAH ANDA YAKIN AKAN TETAP KELUAR ?", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If logout = vbYes Then
                Me.BackgroundWorker.CancelAsync()
                Me.Close()
            End If
        Else
            Me.Close()
            'Application.Exit()
        End If

    End Sub

    Private WithEvents BS As New BuildString
    Private r As FormMain
    Private VerifikasiUser As String
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Private Shared Function FindWindow(ByVal lpClassName As String, ByVal lpWindowName As String) As IntPtr
    End Function
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim hwnd As Integer = FindWindow(vbNullString, "APLIKASI ABSENSI MATA KULIAH MENGGUNAKAN SIDIK JARI")
        'If hwnd <> 0 Then
        '    BS.PostEnabled(hwnd, &H400, 0, False)
        'End If

        Me.VerifikasiUser = Login()
        If (VerifikasiUser = "ADMINISTRATOR") Then
            If hwnd <> 0 Then
                BS.PostString(hwnd, &H400, 0, "ADMINISTRATOR")
            End If
        ElseIf (VerifikasiUser = "DOSEN") Then
            If hwnd <> 0 Then
                BS.PostString(hwnd, &H400, 0, "DOSEN")
            End If
        Else
            ToastNotification.Show(Me, "Kombinasi Username dan SANDI anda salah. Silahkan ulangi", IIf(True, My.Resources.ico_alpha_Failed_72x721, Nothing), 3 * 1000, glow, pos)
            Me.TXTPASSWORD.Focus()
            System.Windows.Forms.SendKeys.Send("{Home}+{End}")
        End If

        'If TXTUSER.Text = Nothing Then
        '    ToastNotification.Show(Me, "Nama User masih kosong", IIf(True, My.Resources.ico_alpha_Failed_72x721, Nothing), 3 * 1000, glow, pos)
        'ElseIf TXTUSER.Text = Nothing Then
        '    ToastNotification.Show(Me, "SANDI belum diisi", IIf(True, My.Resources.ico_alpha_Failed_72x721, Nothing), 3 * 1000, glow, pos)
        '    TXTUSER.Focus()
        'Else
        '    Try
        '        Dim Str As String = "SELECT * FROM T_User WHERE NAMA_USER='" & TXTUSER.Text & "' and [SANDI]='" & TXTPASSWORD.Text & "'"
        '        modKoneksiDatabase.BukaDatabase()
        '        cmd = New SqlCommand(Str)
        '        cmd.Connection = conn
        '        dtReader = cmd.ExecuteReader

        '        If dtReader.HasRows Then
        '            MessageBoxEx.Show(Me, "Login sukses. Selamat datang : " & TXTUSER.Text, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '            Me.Visible = False
        '            FormMain.lbUser.Text = "Users : " & Me.TXTUSER.Text
        '            FormMain.Show()
        '        Else
        '            If Not dtReader.Read Then
        '                ToastNotification.Show(Me, "Kombinasi Username dan SANDI anda salah. Silahkan ulangi", IIf(True, My.Resources.ico_alpha_Failed_72x721, Nothing), 3 * 1000, glow, pos)
        '            End If
        '        End If
        '        cmd.Dispose()
        '        dtReader.Close()
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        Me.Close()
        '        FormMain.Close()
        '    End Try
        'End If
    End Sub

    Private Function Login() As String
        modKoneksiDatabase.BukaDatabase()
        Dim rdr As SqlClient.SqlDataReader = Nothing
        Dim CMDTampilData As SqlClient.SqlCommand = conn.CreateCommand()
        Dim sql As String = "SELECT LEVEL_USER FROM T_USER WHERE NAMA_USER=@NAMA_USER AND SANDI=@SANDI"
        Try
            CMDTampilData.Parameters.Add("@NAMA_USER", SqlDbType.VarChar).Value = Me.TXTUSER.Text
            CMDTampilData.Parameters.Add("@SANDI", SqlDbType.VarChar).Value = Me.TXTPASSWORD.Text
            CMDTampilData.CommandText = sql
            rdr = CMDTampilData.ExecuteReader()

            If (rdr.Read()) Then
                Return rdr.GetValue(0).ToString
            Else
                Return String.Empty
            End If
        Catch salah As Exception
            MessageBox.Show("PERHATIAN..  " + salah.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return String.Empty
        Finally
            modKoneksiDatabase.CloseConn()
        End Try
    End Function
End Class