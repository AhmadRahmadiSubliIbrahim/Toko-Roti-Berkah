Imports MySql.Data.MySqlClient

Public Class FGantiPassword
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Hide()
        FHome.Enabled = True
        FHome.Focus()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If Tx_PasswordBaru.Text = Tx_Ulangi.Text Then
            Dim Update = New Petugas
            Update.Password = Tx_PasswordBaru.Text
            Update.Username = FHome.Profile_Username.Text
            Update.GantiPassword()
            'CMD = New MySqlCommand("UPDATE petugas SET password = '" & Tx_PasswordBaru.Text & "' WHERE BINARY username = '" & FHome.Profile_Username.Text & "'", conn)
            'CMD.ExecuteNonQuery()
            MessageBox.Show("Pembaruan Telah Disimpan Kedatabase", "Password Berhasil Diganti!")
            Me.Hide()
            FHome.Enabled = True
            FHome.Focus()
            DR.Close()
        Else
            MessageBox.Show("Password Tidak Sama", "Gagal Mengganti Password")
        End If
    End Sub
End Class