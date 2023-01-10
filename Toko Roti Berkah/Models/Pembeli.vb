Imports MySql.Data.MySqlClient

Public Class Pembeli
    Public Id_Transaksi As String
    Public nama_pembeli As String
    Public tanggal As String
    Public total As String

    Sub Save()
        CMD = New MySqlCommand("INSERT INTO pembelian (id_transaksi,nama_pembeli,tanggal,total) VALUES ('" & Id_Transaksi & "','" & nama_pembeli & "','" & tanggal & "','" & total & "')", conn)
        CMD.ExecuteNonQuery()
    End Sub
    Public Shared Sub HasilPembelian(keyword As String)
        DA = New MySqlDataAdapter("SELECT * FROM detail_pembelian INNER JOIN roti ON detail_pembelian.id_roti=roti.id_roti  WHERE id_transaksi = '" & keyword & "'", conn)
        DS = New DataSet
    End Sub
End Class
