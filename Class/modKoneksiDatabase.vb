'—mengaktifkan namespace untuk database SQL Server --
Imports System.Data
Imports System.Data.SqlClient
Public Module modKoneksiDatabase
    '-- deklarasi variabel objek koneksi --
    Public dtReader As SqlDataReader = Nothing
    Public conn As SqlConnection = Nothing
    Public dtAdapter As SqlDataAdapter = Nothing
    Public cmd As SqlCommand = Nothing
    Public dtTable As DataTable
    Public dtSet As DataSet

    Public Function BukaDatabase() As Boolean
        conn = New SqlClient.SqlConnection(My.Settings("ConnectionStringApp").ToString)
        conn.Open()
        If conn.State <> ConnectionState.Open Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub CloseConn()
        If Not IsNothing(conn) Then
            conn.Close()
            conn = Nothing
        End If
    End Sub

    Public Function ExecuteQuery(ByVal Query As String) As DataTable
        If Not BukaDatabase() Then
            MsgBox("Koneksi Gagal..!!", MsgBoxStyle.Critical, "Access Failed")
            Return Nothing
            Exit Function
        End If

        cmd = New SqlClient.SqlCommand(Query, conn)
        dtAdapter = New SqlClient.SqlDataAdapter
        dtAdapter.SelectCommand = cmd

        dtSet = New Data.DataSet
        dtAdapter.Fill(dtSet)

        dtTable = dtSet.Tables(0)

        Return dtTable

        dtTable = Nothing
        dtSet = Nothing
        dtAdapter = Nothing
        cmd = Nothing

        CloseConn()

    End Function

    Public Sub BacaCombo(ByVal cbRelasi As ComboBox, ByVal cmd As String)
        cbRelasi.Items.Clear()
        BukaDatabase()
        'Conn.Open()
        Dim cm As New SqlCommand(cmd, conn)
        Try
            Dim rdr As SqlDataReader = cm.ExecuteReader
            While rdr.Read
                cbRelasi.Items.Add(rdr(0).ToString)
            End While
            rdr.Close()
        Catch salah As Exception
            MessageBox.Show("PERHATIAN..  " + salah.Message, "Kesalahan")
        Finally
            conn.Close()
        End Try
    End Sub
End Module
