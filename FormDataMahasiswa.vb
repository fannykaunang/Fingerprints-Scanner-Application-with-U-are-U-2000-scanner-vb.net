Imports DevComponents.DotNetBar
Imports System.Data.SqlClient

Public Class FormDataMahasiswa

    Private RowsToDelete As New List(Of DataGridViewRow)
    Private STRCONN_STRING As String = My.Settings("ConnectionStringApp").ToString

    Private Sub GET_DELETE_RECORD(ByVal NPM As String, ByVal aFileName As String)
        Dim query As String = "DELETE FROM T_MAHASISWA WHERE NPM = @NPM"
        Using conn As New SqlConnection(Me.STRCONN_STRING.ToString)
            Using cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(query, conn)
                Try
                    With cmd
                        .Connection = conn
                        .CommandText = query
                        .Connection.Open()
                        .Parameters.Add("@NPM", SqlDbType.VarChar).Value = NPM
                        .ExecuteNonQuery()
                        .Connection.Close()
                        If IO.File.Exists(aFileName) Then
                            IO.File.Delete(aFileName)
                        End If
                    End With

                    ToastNotification.Show(Me, RowsToDelete.Count & " DATA BERHASIL DIHAPUS", _
                     IIf(True, My.Resources.accept_icon1, Nothing), 3 * 1000, glow, eToastPosition.MiddleCenter)

                Catch ex As Exception
                    MessageBoxEx.Show("PERHATIAN..  " + ex.Message, "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End Using
        End Using
    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.RowsToDelete.Clear()
        Try
            For Each row As DataGridViewRow In Me.DataGridViewX1.Rows
                If row.Cells(0).Value = True Then
                    RowsToDelete.Add(row)
                    Me.GET_DELETE_RECORD(row.Cells(1).Value, row.Cells(7).Value)
                End If
            Next

            For Each rowtodelete In RowsToDelete
                DataGridViewX1.Rows.Remove(rowtodelete)
            Next

        Catch ex As Exception
            MessageBoxEx.Show("PERHATIAN..  " + ex.Message, "KESALAHAN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub FormDataMahasiswa_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Me.TampilDataFormDialog()
        Dim strQuery As String = "select * from VW_MAHASISWA ORDER BY NPM"
        Try
            Using conn As New SqlConnection(Me.STRCONN_STRING.ToString)
                Using da As New SqlClient.SqlDataAdapter(strQuery, conn)
                    Using dt As New Data.DataTable
                        dt.Clear()
                        da.Fill(dt)
                        Me.AsignaDT(dt)

                        For i As Integer = 0 To 1000
                            BackgroundWorker1.ReportProgress(i / 10)
                        Next

                    End Using
                End Using
            End Using
        Catch ex As Exception
            Exit Try
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
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

    Private Sub DataGridViewX1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellClick
        Me.Label1.Text = Me.DataGridViewX1.CurrentRow.Cells("FINGER_IDENTITY").Value
    End Sub

    Private Sub BackgroundWorkerSearch_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorkerSearch.DoWork
        Me.TampilDataFormDialog()
        Dim strQuery As String = "select * from VW_MAHASISWA WHERE NPM LIKE @p1 Or NAMA_MAHASISWA LIKE @p2 Or FAKULTAS LIKE @p3 Or JURUSAN LIKE @p4"
        strQuery &= " ORDER BY NPM"

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
                            BackgroundWorkerSearch.ReportProgress(i / 10)
                        Next

                    End Using
                End Using
            End Using
        Catch ex As Exception
            Exit Try
        End Try
    End Sub

    Private Sub TXTSEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXTSEARCH.TextChanged
        Do While Me.BackgroundWorkerSearch.IsBusy
            Application.DoEvents()
        Loop
        Me.BackgroundWorkerSearch.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorkerSearch_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorkerSearch.RunWorkerCompleted
        Me.ProgressForm.BeginInvoke(New Action(Sub() ProgressForm.Close()))
        If Me.BackgroundWorkerSearch.IsBusy Then Me.BackgroundWorkerSearch.Dispose()
    End Sub
End Class