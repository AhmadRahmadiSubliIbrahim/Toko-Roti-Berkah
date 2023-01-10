Imports MySql.Data.MySqlClient

Public Class Roti
    Public Id_Roti As Integer
    Public P_IDRoti As Integer
    Public Nama_Roti As String
    Public Rasa As String
    Public Harga As String
    Public Keterangan As String
    Sub SaveDB()
        CMD = New MySqlCommand("INSERT INTO roti(id_roti, nama_roti, rasa, harga, keterangan) VALUES (""{0}"",'" & Nama_Roti & "','" & Rasa & "','" & Harga & "','" & Keterangan & "')", conn)
        CMD.ExecuteNonQuery()
    End Sub
    Sub Delet()
        CMD = New MySqlCommand("DELETE FROM roti WHERE id_roti = '" & Id_Roti & "'", conn)
        CMD.ExecuteNonQuery()
        MessageBox.Show("Roti " & FInputRoti.P_NamaRoti.Text & " Dengan Rasa " & FInputRoti.P_Rasa.Text & " Berhasil Dihapus Dari Dalam Database", "Berhasil Menghapus Roti")
    End Sub
    Sub TampilRoti()
        CMD = New MySqlCommand("SELECT * FROM roti WHERE id_roti = '" & Id_Roti & "'", conn)
        DR = CMD.ExecuteReader
    End Sub
End Class
