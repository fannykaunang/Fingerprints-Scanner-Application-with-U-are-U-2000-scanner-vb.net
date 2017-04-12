Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DevComponents.DotNetBar

Public Class FormLaporanRekapitulasiAbsensiDosen

    Private STRCONN_STRING As String = My.Settings("ConnectionStringApp").ToString
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

    Private Sub ButtonX1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If Me.TXTMATAKULIAH.Text.Contains("--PILIH--") OrElse Me.TXTJURUSAN.Text.Contains("--PILIH--") Then
            MessageBox.Show("ANDA BELUM MEMILIH DATA", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New SqlConnection(Me.STRCONN_STRING.ToString)
                Using cmd As New SqlCommand("SELECT * FROM VW_ABSENSI_DOSEN_ALL WHERE NIP_NIDN=@NIP_NIDN", conn) ' AND KODE_JURUSAN=@KODE_JURUSAN", conn)
                    cmd.CommandType = CommandType.Text
                    Using ds As New DataSet
                        cmd.Parameters.Add("@NIP_NIDN", SqlDbType.VarChar).Value = Me.TXTMATAKULIAH.Text
                        'cmd.Parameters.Add("@KODE_JURUSAN", SqlDbType.VarChar).Value = Me.TXTJURUSAN.Text
                        Using da As New SqlDataAdapter()
                            da.SelectCommand = cmd
                            'Using datatable As New DataTable()
                            da.Fill(ds, "VW_ABSENSI_DOSEN_ALL")

                            If ds.Tables(0).Rows.Count = 0 Then
                                MessageBox.Show("DATA YANG DIPILIH TIDAK TERDAPAT DALAM DATABASE", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Return
                            End If

                            Dim rptdocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                            Dim strReportPath As String = My.Application.Info.DirectoryPath & "\LAPORAN REKAP ABSENSI - DOSEN.rpt"
                            rptdocument.Load(strReportPath)

                            Me.CRV_Master.Cursor = Cursors.AppStarting
                            rptdocument.SetDataSource(ds.Tables(0))
                            Me.CRV_Master.ReportSource = (rptdocument)
                            Me.CRV_Master.Cursor = Cursors.Default

                        End Using
                    End Using
                End Using
            End Using
            'End Using
        Catch ex As Exception
            MessageBox.Show("PERHATIAN..  " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Me.TampilDataFormDialog()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.ProgressForm.BeginInvoke(New Action(Sub() ProgressForm.Close()))
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
    Private Sub FormLaporanRekapitulasiAbsensi_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.GET_DATA_COMBO(Me.TXTMATAKULIAH, "T_DOSEN", "SELECT * FROM T_DOSEN", "NIP_NIDN", "NAMA_DOSEN")
        Me.RefreshReport()
    End Sub

    Public Overloads Sub RefreshReport()
        Try
            Dim rptdocument As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim strReportPath As String = My.Application.Info.DirectoryPath & "\LAPORAN REKAP ABSENSI - DOSEN.rpt"

            modKoneksiDatabase.BukaDatabase()
            Dim SQL_Chart As String = "SELECT * FROM VW_ABSENSI_DOSEN_ALL"
            Using da As New SqlClient.SqlDataAdapter(SQL_Chart, conn)
                Using ds As New DataSet
                    da.Fill(ds, "VW_ABSENSI_DOSEN_ALL")

                    rptdocument.Load(strReportPath)
                    rptdocument.Refresh()
                    rptdocument.SetDataSource(ds.Tables(0))
                    Me.CRV_Master.ReportSource = (rptdocument)
                    Me.CRV_Master.ShowRefreshButton = True
                    Me.CRV_Master.ShowPrintButton = True

                End Using
            End Using

        Catch salah As Exception
            MessageBoxEx.Show("PERHATIAN..  " + salah.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Me.RefreshReport()
    End Sub
End Class