Imports System.Data.SqlClient

Public Class VerificationForm
    Inherits CaptureForm

    Private Template As DPFP.Template
    Private Verificator As DPFP.Verification.Verification

    Public Sub Verify(ByVal template As DPFP.Template)
        Me.Template = template
        ShowDialog()
    End Sub

    Protected Overrides Sub Init()
        MyBase.Init()
        MyBase.Text = "Fingerprint Verifications.."
        Verificator = New DPFP.Verification.Verification()
        UpdateStatus(0)
    End Sub

    Protected Overrides Sub Process(ByVal Sample As DPFP.Sample)
        MyBase.Process(Sample)
        Dim features As DPFP.FeatureSet = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification)

        If Not features Is Nothing Then
            Dim result As DPFP.Verification.Verification.Result = New DPFP.Verification.Verification.Result()
            Verificator.Verify(features, Template, result)
            UpdateStatus(result.FARAchieved)
            If result.Verified Then
                MakeReport("The fingerprint was VERIFIED.")
                Me.SaveData()
            Else
                MakeReport("The fingerprint was NOT VERIFIED.")
            End If
        End If
    End Sub

    Protected Sub UpdateStatus(ByVal FAR As Integer)
        SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR))
    End Sub

    Private STRCONN_STRING As String = My.Settings("ConnectionStringApp").ToString
    Public Overridable Overloads Sub SaveData()
        Using connect As New SqlConnection(Me.STRCONN_STRING.ToString)
            Dim cmd As New SqlCommand("INSERT INTO T_ABSENSI_MATA_KULIAH VALUES(@KODE_ABSENSI_MK, @KODE_MATA_KULIAH, @NPM, @JAM_ABSEN, @TOTAL_KEHADIRAN)", connect)
            cmd.Parameters.Add("KODE_ABSENSI_MK", SqlDbType.VarChar).Value = Me.txtID.Text
            cmd.Parameters.Add("KODE_MATA_KULIAH", SqlDbType.VarChar).Value = Me.txtKodeMatKul.Text
            cmd.Parameters.Add("NPM", SqlDbType.VarChar).Value = Me.txtNPM2.Text
            cmd.Parameters.Add("JAM_ABSEN", SqlDbType.DateTime).Value = Now
            cmd.Parameters.Add("TOTAL_KEHADIRAN", SqlDbType.Int).Value = Me.Label15.Text

            connect.Open()
            cmd.ExecuteNonQuery()

            MessageBox.Show("DATA BERHASIL DISIMPAN", "Save", MessageBoxButtons.OK)
            'MsgBox("The application has been updated and will now restart.", MsgBoxStyle.Information)
        End Using
    End Sub
    Public Overridable Overloads Sub NOMOR_OTOMATIS()
        Using connect As New SqlConnection(Me.STRCONN_STRING.ToString)
            Dim str As String = "SELECT (ABS(CHECKSUM(NEWID())) % 100001) + ((ABS(CHECKSUM(NEWID())) % 100001) * 0.00001) [KODE_ABSENSI_MK]"
            Using cmd As New SqlCommand(str, connect)

                With cmd
                    .CommandType = CommandType.Text
                    .CommandText = str
                    .Connection = connect
                    .Connection.Open()
                End With

                Using dr As SqlDataReader = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        Me.txtID.Text = "MHS-" & dr.GetValue(0)
                    End If
                End Using
            End Using
        End Using
    End Sub
    'Private Function Count_Kehadiran() As DataTable
    '    Using CONNECTION As New SqlConnection(Me.STRCONN_STRING.ToString)
    '        CONNECTION.Open()
    '        Using dtAdapter As New SqlClient.SqlDataAdapter
    '            Using dtSet As New Data.DataSet
    '                Using CMDTampilData As SqlClient.SqlCommand = CONNECTION.CreateCommand()
    '                    Dim sql As String = "SELECT * FROM T_ABSENSI_MATA_KULIAH WHERE NPM=@NPM"
    '                    Dim dtTable As DataTable
    '                    Try
    '                        CMDTampilData.Parameters.Add("@NPM", SqlDbType.VarChar).Value = Me.TXTNPM.Text
    '                        CMDTampilData.CommandText = sql
    '                        dtAdapter.SelectCommand = CMDTampilData
    '                        dtAdapter.Fill(dtSet)
    '                        dtTable = dtSet.Tables(0)

    '                        Return dtTable
    '                    Catch salah As Exception
    '                        MessageBox.Show("PERHATIAN..  " + salah.Message, "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                        Return Nothing
    '                    End Try
    '                End Using
    '            End Using
    '        End Using
    '    End Using
    'End Function

    Private Sub InitializeComponent()
        Dim MtgcComboBoxItem1 As MTGCComboBoxItem = CType(New System.Windows.Forms.ListViewItem("FAK-76577.55455"), MTGCComboBoxItem)
        Dim MtgcComboBoxItem2 As MTGCComboBoxItem = CType(New System.Windows.Forms.ListViewItem("FAK-76577.65454"), MTGCComboBoxItem)
        Dim MtgcComboBoxItem3 As MTGCComboBoxItem = CType(New System.Windows.Forms.ListViewItem("JUR-44444.55555"), MTGCComboBoxItem)
        Dim MtgcComboBoxItem4 As MTGCComboBoxItem = CType(New System.Windows.Forms.ListViewItem("JUR-65455.54344"), MTGCComboBoxItem)
        Dim MtgcComboBoxItem5 As MTGCComboBoxItem = CType(New System.Windows.Forms.ListViewItem("JUR-65455.88875"), MTGCComboBoxItem)
        Dim MtgcComboBoxItem6 As MTGCComboBoxItem = CType(New System.Windows.Forms.ListViewItem("MK-001"), MTGCComboBoxItem)
        Me.SuspendLayout()
        '
        'CBFAKULTAS
        '
        Me.CBFAKULTAS.Items.AddRange(New Object() {MtgcComboBoxItem1, MtgcComboBoxItem2})
        Me.CBFAKULTAS.Size = New System.Drawing.Size(365, 23)
        '
        'CBJURUSAN
        '
        Me.CBJURUSAN.Items.AddRange(New Object() {MtgcComboBoxItem3, MtgcComboBoxItem4, MtgcComboBoxItem5})
        Me.CBJURUSAN.Size = New System.Drawing.Size(365, 23)
        '
        'cbMataKuliah
        '
        Me.cbMataKuliah.Items.AddRange(New Object() {MtgcComboBoxItem6})
        Me.cbMataKuliah.Size = New System.Drawing.Size(365, 23)
        '
        'VerificationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(487, 354)
        Me.Name = "VerificationForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


End Class
