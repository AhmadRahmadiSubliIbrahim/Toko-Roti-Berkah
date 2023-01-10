Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class FHome
    Private Sub LblGantiPassword_Click(sender As Object, e As EventArgs) Handles LblGantiPassword.Click
        FGantiPassword.Show()
        Me.Enabled = False
    End Sub

    Private Sub LblLogout_Click(sender As Object, e As EventArgs) Handles LblLogout.Click
        FLogin.Tx_Password.Text = ""
        FLogin.Tx_Username.Text = ""
        CMD = New MySqlCommand("UPDATE petugas set Status = '" & "X" & "' WHERE BINARY username = '" & Profile_Username.Text & "'", conn)
        CMD.ExecuteNonQuery()
        Me.Hide()
        FLogin.Show()
    End Sub

    Private Sub BtnPembelian_Click(sender As Object, e As EventArgs) Handles BtnPembelian.Click
        Body.Controls.Clear()
        FPembelian.Location = New Point(0, 0)
        FPembelian.TopLevel = False
        Body.Controls.Add(FPembelian)
        FPembelian.WindowState = FormWindowState.Maximized
        FPembelian.Show()
        BCLabel.Text = "Home > Pembelian"
    End Sub

    Private Sub BtnRoti_Click(sender As Object, e As EventArgs) Handles BtnRoti.Click
        Body.Controls.Clear()
        FInputRoti.Location = New Point(0, 0)
        FInputRoti.TopLevel = False
        Body.Controls.Add(FInputRoti)
        FInputRoti.WindowState = FormWindowState.Maximized
        FInputRoti.Show()
        BCLabel.Text = "Home > Input > Input Roti"
    End Sub

    Private Sub BtnResep_Click(sender As Object, e As EventArgs) Handles BtnResep.Click
        Body.Controls.Clear()
        FInputResep.Location = New Point(0, 0)
        FInputResep.TopLevel = False
        Body.Controls.Add(FInputResep)
        FInputResep.WindowState = FormWindowState.Maximized
        FInputResep.Show()
        BCLabel.Text = "Home > Input > Input Resep"
    End Sub

    Private Sub BtnPetugas_Click(sender As Object, e As EventArgs) Handles BtnPetugas.Click
        Body.Controls.Clear()
        FInputPetugas.Location = New Point(0, 0)
        FInputPetugas.TopLevel = False
        Body.Controls.Add(FInputPetugas)
        FInputPetugas.WindowState = FormWindowState.Maximized
        FInputPetugas.Show()
        BCLabel.Text = "Home > Input > Input Petugas"
    End Sub

    Private Sub BtnGrafikPembelian_Click(sender As Object, e As EventArgs) Handles BtnGrafikPembelian.Click
        Body.Controls.Clear()
        FGrafikPembelian.Location = New Point(0, 0)
        FGrafikPembelian.TopLevel = False
        Body.Controls.Add(FGrafikPembelian)
        FGrafikPembelian.WindowState = FormWindowState.Maximized
        FGrafikPembelian.Show()
        BCLabel.Text = "Home > Laporan > Grafik Pembelian Perbulan"
    End Sub

    Private Sub BtnCetakLaporan_Click(sender As Object, e As EventArgs) Handles BtnCetakLaporan.Click
        Body.Controls.Clear()

        FCetakLaporan.Location = New Point(0, 0)
        FCetakLaporan.TopLevel = False
        Body.Controls.Add(FCetakLaporan)
        FCetakLaporan.WindowState = FormWindowState.Maximized
        FCetakLaporan.Show()
        BCLabel.Text = "Home > Laporan > Cetak Laporan "
    End Sub

    Private Sub BtnInput_Click(sender As Object, e As EventArgs) Handles BtnInput.Click
        If Panel6.Height = 0 Then
            Panel6.Height = 90
        Else
            Panel6.Height = 0
        End If
    End Sub

    Private Sub BtnLaporan_Click(sender As Object, e As EventArgs) Handles BtnLaporan.Click
        If Panel9.Height = 0 Then
            Panel9.Height = 60
        Else
            Panel9.Height = 0
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label9.Text = Format(Now, "dddd, dd MMMM yyyy")
        Label10.Text = Format(Now, "HH:mm:ss tt")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class