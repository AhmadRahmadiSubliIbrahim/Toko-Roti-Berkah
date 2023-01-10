Imports MySql.Data.MySqlClient
Public Class FLogin
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Koneksi()

        If Tx_Username.Text = "" Or Tx_Password.Text = "" Then
            MessageBox.Show("Username Atau Password Belum Diisi", "Gagal Login")
            If Tx_Username.Text = "" Then
                Tx_Username.Focus()
            Else
                Tx_Password.Focus()
            End If
        Else
            Try
                CMD = New MySqlCommand("SELECT * FROM petugas WHERE BINARY username = '" & Tx_Username.Text & "' AND BINARY password = '" & Tx_Password.Text & "'", conn)
                DR = CMD.ExecuteReader()
                DR.Read()
                If DR.HasRows Then
                    FHome.Profile_Nama.Text = DR.Item("nama_petugas")
                    FHome.Profile_NIK.Text = DR.Item("NIK")
                    FHome.Profile_Username.Text = DR.Item("username")
                    DR.Close()
                    CMD = New MySqlCommand("UPDATE petugas set Status = '" & "O" & "' WHERE BINARY username = '" & Tx_Username.Text & "'", conn)
                    CMD.ExecuteNonQuery()
                    FHome.Show()
                    FHome.Body.Controls.Clear()
                    FHome.Body.Controls.Add(FHome.Label11)
                    FHome.BCLabel.Text = "Home"
                    FHome.Panel6.Height = 0
                    FHome.Panel9.Height = 0
                    Me.Hide()
                Else
                    MessageBox.Show("Username Atau Password Salah", "Gagal Login")
                End If
            Catch ex As Exception

            End Try
        End If
        DR.Close()

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        End
    End Sub

    Private Sub BtnMinimized_Click(sender As Object, e As EventArgs) Handles BtnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
