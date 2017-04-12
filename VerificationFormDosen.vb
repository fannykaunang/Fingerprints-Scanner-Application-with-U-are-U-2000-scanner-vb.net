Imports System.Data.SqlClient

Public Class VerificationFormDosen
    Inherits FormDataDosen

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
                MakeReportDosen("The fingerprint was VERIFIED.")
                Me.SaveDataDosen()
            Else
                MakeReportDosen("The fingerprint was NOT VERIFIED.")
            End If
        End If
    End Sub

    Protected Sub UpdateStatus(ByVal FAR As Integer)
        SetStatus(String.Format("False Accept Rate (FAR) = {0}", FAR))
    End Sub

    Private STRCONN_STRING As String = My.Settings("ConnectionStringApp").ToString
    Public Overridable Overloads Sub SaveDataDosen()
        Using connect As New SqlConnection(Me.STRCONN_STRING.ToString)
            Dim cmd As New SqlCommand("INSERT INTO T_ABSENSI_DOSEN VALUES(@KODE_ABSENSI_DOSEN, @KODE_MATA_KULIAH, @NIP_NIDN, @JAM_ABSEN, @TOTAL_KEHADIRAN)", connect)
            cmd.Parameters.Add("KODE_ABSENSI_DOSEN", SqlDbType.VarChar).Value = Me.LBNOMOROTO.Text
            cmd.Parameters.Add("KODE_MATA_KULIAH", SqlDbType.VarChar).Value = Me.txtKodeMatKul.Text
            cmd.Parameters.Add("NIP_NIDN", SqlDbType.VarChar).Value = Me.LBNIP.Text
            cmd.Parameters.Add("JAM_ABSEN", SqlDbType.DateTime).Value = Now
            cmd.Parameters.Add("TOTAL_KEHADIRAN", SqlDbType.Int).Value = Me.TXTCount.Text

            connect.Open()
            cmd.ExecuteNonQuery()

            MessageBox.Show("DATA BERHASIL DISIMPAN", "Save", MessageBoxButtons.OK)
            'MsgBox("The application has been updated and will now restart.", MsgBoxStyle.Information)
        End Using
    End Sub
    Public Overridable Overloads Sub NOMOR_OTOMATIS_DOSEN()
        Using connect As New SqlConnection(Me.STRCONN_STRING.ToString)
            Dim str As String = "SELECT (ABS(CHECKSUM(NEWID())) % 100001) + ((ABS(CHECKSUM(NEWID())) % 100001) * 0.00001) [KODE_ABSENSI_DOSEN]"
            Using cmd As New SqlCommand(str, connect)

                With cmd
                    .CommandType = CommandType.Text
                    .CommandText = str
                    .Connection = connect
                    .Connection.Open()
                End With
                'PAS VERIFIKASI DOSEN GAK MAU INITIATE
                'Button VERIFY DOSEN BERMASALAH
                Using dr As SqlDataReader = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        Me.LBNOMOROTO.Text = "DSN-" & dr.GetValue(0)
                    End If
                End Using
            End Using
        End Using
    End Sub
    Private Function Count_Kehadiran_Dosen() As DataTable
        Using CONNECTION As New SqlConnection(Me.STRCONN_STRING.ToString)
            CONNECTION.Open()
            Using dtAdapter As New SqlClient.SqlDataAdapter
                Using dtSet As New Data.DataSet
                    Using CMDTampilData As SqlClient.SqlCommand = CONNECTION.CreateCommand()
                        Dim sql As String = "SELECT * FROM T_ABSENSI_MATA_KULIAH WHERE NPM=@NPM"
                        Dim dtTable As DataTable
                        Try
                            CMDTampilData.Parameters.Add("@NPM", SqlDbType.VarChar).Value = Me.LBNIP.Text
                            CMDTampilData.CommandText = sql
                            dtAdapter.SelectCommand = CMDTampilData
                            dtAdapter.Fill(dtSet)
                            dtTable = dtSet.Tables(0)

                            Return dtTable
                        Catch salah As Exception
                            MessageBox.Show("PERHATIAN..  " + salah.Message, "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return Nothing
                        End Try
                    End Using
                End Using
            End Using
        End Using
    End Function
End Class