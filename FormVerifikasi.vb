Imports System.Data.SqlClient

Public Class FormVerifikasi
    Public Event NPM(ByVal NPM As String)
    Public Event Nama(ByVal Nama As String)
    Public Event ALAMAT_FILE(ByVal ALAMAT_FILE As String)
    Public Event BUTTON_ENABLE(ByVal CONCAT As Boolean)
    Private STRCONN_STRING As String = My.Settings("ConnectionStringApp").ToString
  
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        If Me.Label1.Text.Contains("...") Then
            MessageBox.Show("ANDA BELUM MEMILIH SALAH SATU MAHASISWA.", "PERHATIAN")
            Return
        End If

        RaiseEvent ALAMAT_FILE(Me.Label1.Text)
        RaiseEvent NPM(Me.Label2.Text)
        RaiseEvent Nama(Me.Label3.Text)
        RaiseEvent BUTTON_ENABLE(True)
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
        Dim strQuery As String = "select * from VW_MAHASISWA ORDER BY NPM"
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
        Me.Label2.Text = Me.DataGridViewX1.CurrentRow.Cells("NPM").Value
        Me.Label3.Text = Me.DataGridViewX1.CurrentRow.Cells("NAMA_MAHASISWA").Value
    End Sub
End Class