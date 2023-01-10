Imports MySql.Data.MySqlClient

Public Class Resep
    Public Const _chars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" 'untuk random characters
    Public Const _nums As String = "0123456789" 'untuk random number
    Public Shared ReadOnly _randLock = New Object()
    Public Shared ReadOnly _rnd = New Random()

    Public Id_Resep As String
    Public Nama_Resep As String
    Public Id_Roti As Integer
    Public Keterangan As String
    Public Tgl_Update As String
    Public Shared Function RandomString(ByVal size As Integer, ByVal chars As String)
        Dim arr = New Char(size - 1) {}
        For i As Integer = 0 To size - 1
            SyncLock _randLock
                arr(i) = chars(_rnd.Next(chars.Length))
            End SyncLock
        Next
        Return New String(arr)
    End Function
    Public Shared Sub TampilID_Roti()
        CMD = New MySqlCommand("SELECT id_roti FROM roti", conn)
        DR = CMD.ExecuteReader
    End Sub
    Public Shared Function SelectIdRoti(Keyword As Integer)
        CMD = New MySqlCommand("SELECT * FROM resep WHERE id_roti = '" & Keyword & "'", conn)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub Delete()
        CMD = New MySqlCommand("DELETE FROM resep WHERE BINARY id_roti = '" & Id_Resep & "'", conn)
        CMD.ExecuteNonQuery()
    End Sub
    Sub Insert()
        CMD = New MySqlCommand("INSERT INTO resep (id_resep,nama_resep,id_roti,keterangan,tanggal_update) VALUES ('" & Id_Resep & "','" & Nama_Resep & "','" & Id_Roti & "','" & Keterangan & "','" & Tgl_Update & "')", conn)
        CMD.ExecuteNonQuery()
    End Sub
End Class
