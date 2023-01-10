Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports MySql.Data.MySqlClient

Public Class FInputPetugas
    Sub ClearMe()
        IP_Nama.Text = ""
        IP_NIK.Text = ""
        IP_Password.Text = ""
        IP_Ulangi.Text = ""
        IP_Username.Text = ""
    End Sub
    Private Sub IP_NIK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IP_NIK.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub IP_Ulangi_Leave(sender As Object, e As EventArgs) Handles IP_Ulangi.Leave
        If IP_Ulangi.Text = IP_Password.Text Then
            ErrorProvider1.Clear()
        ElseIf IP_Ulangi.Text = "" Or IP_Password.Text = "" Then
            ErrorProvider1.Clear()
        Else
            ErrorProvider1.SetError(IP_Ulangi, "Password Tidak Cocok!")
        End If
    End Sub

    Private Sub IP_Password_TextChanged(sender As Object, e As EventArgs) Handles IP_Password.TextChanged
        If IP_Ulangi.Text = IP_Password.Text Then
            ErrorProvider1.Clear()
        ElseIf IP_Ulangi.Text = "" Or IP_Password.Text = "" Then
            ErrorProvider1.Clear()
        Else
            ErrorProvider1.SetError(IP_Ulangi, "Password Tidak Cocok!")
        End If
    End Sub

    Private Sub IP_Username_Leave(sender As Object, e As EventArgs) Handles IP_Username.Leave
        Petugas.VarUsername(IP_Username.Text)
        'CMD = New MySqlCommand("SELECT * FROM petugas WHERE BINARY username = '" & IP_Username.Text & "'", conn)
        'DR = CMD.ExecuteReader
        'DR.Read()
        If DR.HasRows Then
            ErrorProvider2.SetError(IP_Username, "Username Telah Terpakai, Silahkan Coba Yang Lain!")
        ElseIf IP_Username.Text = "" Then
            ErrorProvider2.Clear()
        Else
            BtnSimpan.Enabled = True
        End If
        DR.Close()
    End Sub
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        ErrorProvider2.Clear()
        Petugas.VarUsername(IP_Username.Text)
        'CMD = New MySqlCommand("SELECT * FROM petugas WHERE BINARY username = '" & IP_Username.Text & "'", conn)
        'DR = CMD.ExecuteReader
        'DR.Read()
        If IP_Nama.Text = "" Or IP_NIK.Text = "" Or IP_Password.Text = "" Or IP_Ulangi.Text = "" Or IP_Username.Text = "" Then
            MsgBox("Silahkan Lengkapi Data Terlebih Dahulu!", MsgBoxStyle.Exclamation, "Data Masih Ada Yang Kosong")
        ElseIf DR.HasRows Then
            ErrorProvider2.SetError(IP_Username, "Username Telah Terpakai, Silahkan Coba Yang Lain!")
        Else
            DR.Close()
            Petugas.BinaryNik(IP_NIK.Text)
            'CMD = New MySqlCommand("SELECT * FROM petugas WHERE BINARY NIK = '" & IP_NIK.Text & "'", conn)
            'DR = CMD.ExecuteReader
            'DR.Read()
            If DR.HasRows Then
                MessageBox.Show("Petugas Dengan NIK : " & IP_NIK.Text & " Telah Terdaftar!", "Gagal Menginput Petugas")
            Else
                DR.Close()
                Dim Simpan = New Petugas With {
                .Nik = IP_NIK.Text,
                .Username = IP_Username.Text,
                .Password = IP_Password.Text,
                .Nama_Petugas = IP_Nama.Text,
                .Statu = "X"
                }
                Simpan.Save()
                'CMD = New MySqlCommand("INSERT INTO petugas (NIK, username, password, nama_petugas, Status) VALUES ('" & IP_NIK.Text & "','" & IP_Username.Text & "','" & IP_Password.Text & "','" & IP_Nama.Text & "','" & "X" & "')", conn)
                'CMD.ExecuteNonQuery()
                MessageBox.Show("Data Petugas:" & vbCrLf & vbCrLf & "NIK    :   " & IP_NIK.Text & vbCrLf & "Nama    :   " & IP_Nama.Text & vbCrLf & "Username   :   " & IP_Username.Text, "Berhasil Menginput Petugas")
                ClearMe()
            End If
            DR.Close()
        End If
        DR.Close()
    End Sub

    Private Sub IP_NIK_TextChanged(sender As Object, e As EventArgs) Handles IP_NIK.TextChanged

    End Sub
End Class