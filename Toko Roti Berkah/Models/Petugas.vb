Imports MySql.Data.MySqlClient

Public Class Petugas
    Public Nik As Integer
    Public Username As String
    Public Password As String
    Public Nama_Petugas As String
    Public Statu As String

    Sub Save()
        CMD = New MySqlCommand("INSERT INTO petugas (NIK, username, password, nama_petugas, Status) VALUES ('" & Nik & "','" & Username & "','" & Password & "','" & Nama_Petugas & "','" & "X" & "')", conn)
        CMD.ExecuteNonQuery()
    End Sub

    Public Shared Function BinaryNik(Keyword As Integer)
        CMD = New MySqlCommand("SELECT * FROM petugas WHERE BINARY NIK = '" & Keyword & "'", conn)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Shared Function VarUsername(Keyword As String)
        CMD = New MySqlCommand("SELECT * FROM petugas WHERE BINARY username = '" & Keyword & "'", conn)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub GantiPassword()
        CMD = New MySqlCommand("UPDATE petugas SET password = '" & Password & "' WHERE BINARY username = '" & Username & "'", conn)
        CMD.ExecuteNonQuery()
    End Sub
End Class
