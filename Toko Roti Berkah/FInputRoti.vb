Imports CrystalDecisions.[Shared].Json
Imports MySql.Data.MySqlClient

Public Class FInputRoti
    Sub ClearMe()
        IRT_Harga.Value = 0
        IRT_Keterangan.Clear()
        IRT_Nama.Clear()
        IRT_Rasa.Clear()
        P_IDRoti.Text = ""
        P_Rasa.Text = ""
        P_NamaRoti.Text = ""
        P_Harga.Text = ""
        P_Keterangan.Text = ""
    End Sub
    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If IRT_Nama.Text = "" Or IRT_Rasa.Text = "" Then
            MessageBox.Show("Data Tidak Boleh Kosong", "Gagal Menginput Roti")
            If IRT_Nama.Text = "" Then
                ErrorProvider1.SetError(IRT_Nama, "Masukan Nama Roti Terlebih Dahulu!")
            End If
            If IRT_Rasa.Text = "" Then
                ErrorProvider2.SetError(IRT_Rasa, "Masukan Rasa Roti Terbelih Dahulu!")
            End If
        Else
            Dim simpan = New Roti
            simpan.Nama_Roti = IRT_Nama.Text
            simpan.Rasa = IRT_Rasa.Text
            simpan.Harga = IRT_Harga.Value
            simpan.Keterangan = IRT_Keterangan.Text
            simpan.SaveDB()
            MessageBox.Show("Roti " & IRT_Nama.Text & " Dengan Rasa " & IRT_Rasa.Text & " Berhasil Disimpan Ke Dalam Database", "Berhasil Menginput Roti")
            ClearMe()
        End If
        DR.Close()
    End Sub

    Private Sub IRT_Nama_TextChanged(sender As Object, e As EventArgs) Handles IRT_Nama.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub IRT_Rasa_TextChanged(sender As Object, e As EventArgs) Handles IRT_Rasa.TextChanged
        ErrorProvider2.Clear()
    End Sub

    Private Sub P_IDRoti_SelectedIndexChanged(sender As Object, e As EventArgs) Handles P_IDRoti.SelectedIndexChanged
        If P_IDRoti.SelectedIndex = -1 Then
            P_Harga.Text = "_"
            P_Keterangan.Text = "_"
            P_NamaRoti.Text = "_"
            P_Rasa.Text = "_"
        Else

            Dim harga As Integer
            Dim tampilRoti = New Roti
            tampilRoti.Id_Roti = P_IDRoti.Text
            tampilRoti.TampilRoti()
            DR.Read()
            harga = DR.Item("Harga")
            P_Keterangan.Text = DR.Item("keterangan")
            P_NamaRoti.Text = DR.Item("nama_roti")
            P_Rasa.Text = DR.Item("rasa")
            P_Harga.Text = "Rp. " & harga
            DR.Close()
        End If
    End Sub

    Private Sub P_IDRoti_Enter(sender As Object, e As EventArgs) Handles P_IDRoti.Enter
        P_IDRoti.Items.Clear()
        Resep.TampilID_Roti()
        Do While DR.Read
            P_IDRoti.Items.Add(DR.Item(0))
        Loop
        DR.Close()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim delete = New Roti
        delete.Id_Roti = P_IDRoti.Text
        delete.Delet()
        ClearMe()
    End Sub
End Class