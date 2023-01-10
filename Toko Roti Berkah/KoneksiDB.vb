Imports MySql.Data.MySqlClient
Module KoneksiDB
    Public conn As MySqlConnection
    Public CMD As MySqlCommand
    Public DR As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public DT As DataTable
    Public DRow As DataRow
    Public Str As String
    Sub Koneksi()
        Try
            Str = "Server=localhost;user id=root;password=;database=db_bakery;Convert Zero Datetime=True;old guids=true"
            conn = New MySqlConnection(Str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
