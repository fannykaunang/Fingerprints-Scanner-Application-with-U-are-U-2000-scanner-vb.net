Imports System.Data.SqlClient

Public Class FormVerifikasiDosen
    Public Event NIP2(ByVal NIP As String)
    Public Event NAMADOSEN2(ByVal NAMADOSEN As String)
    Public Event ALAMAT_DOSEN2(ByVal ALAMAT_DOSEN As String)
    Public Event PATH_DOSEN2(ByVal PATH_DOSEN2 As String)
    Public Event BUTTON_ENABLE2(ByVal CONCAT As Boolean)
    Private STRCONN_STRING As String = My.Settings("ConnectionStringApp").ToString

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If Me.Label1.Text.Contains("...") Then
            MessageBox.Show("ANDA BELUM MEMILIH SALAH SATU DOSEN.", "PERHATIAN")
            Return
        End If

        RaiseEvent PATH_DOSEN2(Me.Label1.Text)
        RaiseEvent NIP2(Me.Label2.Text)
        RaiseEvent NAMADOSEN2(Me.Label3.Text)
        RaiseEvent ALAMAT_DOSEN2(Me.Label4.Text)
        RaiseEvent BUTTON_ENABLE2(True)
        Me.Close()
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs)
        Me.Close()
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
    Private Sub BackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork
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

    Private Sub FormVerifikasi_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BackgroundWorker.RunWorkerAsync()
    End Sub

    Private Sub DataGridViewX1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellClick
        Me.Label1.Text = Me.DataGridViewX1.CurrentRow.Cells("FINGER_IDENTITY").Value
        Me.Label2.Text = Me.DataGridViewX1.CurrentRow.Cells("NIP_NIDN").Value
        Me.Label3.Text = Me.DataGridViewX1.CurrentRow.Cells("NAMA_DOSEN").Value
        Me.Label4.Text = Me.DataGridViewX1.CurrentRow.Cells("ALAMAT").Value
    End Sub
End Class