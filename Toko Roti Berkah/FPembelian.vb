Imports MySql.Data.MySqlClient

Public Class FPembelian
    Dim Harga As Integer
    Public UrutanID As String
    Dim TotalTagihan As Integer
    Sub ClearMe()
        BtnBeli.Enabled = False
        DataGridView1.Rows.Clear()
        TotalTagihan = 0
        P_TotalTagihan.Text = "_"
        P_NamaPembeli.Clear()
        P_JumlahBeli.Value = 1
        P_IDRoti.SelectedIndex = -1
    End Sub
    Sub IDTransaksi()
        Try

            Dim NOM As String
            Dim YEAR_NOW As String
            Dim MONTH_NOW As String
            Dim DAY_NOW As String
            YEAR_NOW = Format(Now, "yyyy")
            MONTH_NOW = Format(Now, "MM")
            DAY_NOW = Format(Now, "dd")
            CMD = New MySqlCommand("SELECT MAX(RIGHT(id_transaksi,8)) As NoMax FROM pembelian WHERE YEAR(tanggal)='" & YEAR_NOW & "' AND MONTH(tanggal)='" & MONTH_NOW & "' AND DAY(tanggal)='" & DAY_NOW & "'", conn)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                NOM = 1
                UrutanID = "T01-" & Format(Now, "ddMMyyyy-") & "0000000" & NOM
            Else
                NOM = Val(Microsoft.VisualBasic.Right(DR.Item("NOMAX").ToString, 10)) + 1
                If NOM <= 9 Then
                    UrutanID = "T01-" & Format(Now, "ddMMyyyy-") & "0000000" & NOM
                ElseIf NOM <= 99 Then
                    UrutanID = "T01-" & Format(Now, "ddMMyyyy-") & "000000" & NOM
                ElseIf NOM <= 999 Then
                    UrutanID = "T01-" & Format(Now, "ddMMyyyy-") & "00000" & NOM
                ElseIf NOM <= 9999 Then
                    UrutanID = "T01-" & Format(Now, "ddMMyyyy-") & "0000" & NOM
                ElseIf NOM <= 99999 Then
                    UrutanID = "T01-" & Format(Now, "ddMMyyyy-") & "000" & NOM
                ElseIf NOM <= 999999 Then
                    UrutanID = "T01-" & Format(Now, "ddMMyyyy-") & "00" & NOM
                ElseIf NOM <= 9999999 Then
                    UrutanID = "T01-" & Format(Now, "ddMMyyyy-") & "0" & NOM
                ElseIf NOM <= 99999999 Then
                    UrutanID = "T01-" & Format(Now, "ddMMyyyy-") & NOM
                End If

            End If
            DR.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnBeli_Click(sender As Object, e As EventArgs) Handles BtnBeli.Click
        IDTransaksi()
        If P_NamaPembeli.Text = "" Then
            MessageBox.Show("Masukan Nama Pembeli Terlebih Dahulu", "Pembelian Gagal")
        Else
            Try
                Dim simpan = New Pembeli
                simpan.Id_Transaksi = UrutanID
                simpan.nama_pembeli = P_NamaPembeli.Text
                simpan.tanggal = Format(Now, "yyyy-MM-dd HH:mm:ss")
                simpan.total = TotalTagihan
                simpan.Save()

                For i As Integer = 0 To DataGridView1.Rows.Count - 2 Step +1
                    Using CMD As New MySqlCommand("INSERT INTO detail_pembelian (id_transaksi,id_roti,jumlah_beli) VALUES('" & UrutanID & "',@id_roti, @jumlah_beli)", conn)
                        CMD.Parameters.AddWithValue("@id_roti", DataGridView1.Rows(i).Cells(0).Value)
                        CMD.Parameters.AddWithValue("@jumlah_beli", DataGridView1.Rows(i).Cells(1).Value)
                        CMD.ExecuteNonQuery()
                    End Using
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Dim TJB As Integer
            For Each R As DataGridViewRow In DataGridView1.Rows
                TJB += R.Cells(1).Value
            Next
            FHasilPembelian.ListBelanja()
            FHasilPembelian.HP_IDTransaksi.Text = UrutanID
            FHasilPembelian.HP_NamaPembeli.Text = P_NamaPembeli.Text
            FHasilPembelian.HP_Tanggal.Text = Format(Now, "dd-MM-yyyy")
            FHasilPembelian.HP_TotalJumlahBeli.Text = TJB
            FHasilPembelian.HP_TotalTagihan.Text = P_TotalTagihan.Text
            FHome.Body.Controls.Clear()
            FHasilPembelian.Location = New Point(0, 0)
            FHasilPembelian.TopLevel = False
            FHome.Body.Controls.Add(FHasilPembelian)
            FHasilPembelian.WindowState = FormWindowState.Maximized
            FHasilPembelian.Show()
            FHome.BCLabel.Text = "Home > Pembelian > Hasil Pembelian"
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles P_IDRoti.SelectedIndexChanged
        If P_IDRoti.SelectedIndex = -1 Then
            P_Harga.Text = "_"
            P_Keterangan.Text = "_"
            P_NamaRoti.Text = "_"
            P_Rasa.Text = "_"
        Else
            Dim tampilRoti = New Roti
            tampilRoti.Id_Roti = P_IDRoti.Text
            tampilRoti.TampilRoti()
            DR.Read()
            Harga = DR.Item("Harga")
            P_Keterangan.Text = DR.Item("keterangan")
            P_NamaRoti.Text = DR.Item("nama_roti")
            P_Rasa.Text = DR.Item("rasa")
            P_Harga.Text = "Rp. " & Harga
            DR.Close()
        End If
    End Sub

    Private Sub ComboBox1_Enter(sender As Object, e As EventArgs) Handles P_IDRoti.Enter
        P_IDRoti.Items.Clear()
        Resep.TampilID_Roti()
        Do While DR.Read
            P_IDRoti.Items.Add(DR.Item(0))
        Loop
        DR.Close()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        If P_IDRoti.Text = "" Then

        Else
            DataGridView1.Rows.Add(1)
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = P_IDRoti.Text
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = P_JumlahBeli.Value
            DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = P_JumlahBeli.Value * Harga
            DataGridView1.Update()
            For Each R As DataGridViewRow In DataGridView1.Rows
                TotalTagihan += R.Cells(2).Value
            Next
            P_TotalTagihan.Text = "Rp. " & TotalTagihan
            BtnBeli.Enabled = True
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        DataGridView1.Rows.Clear()
        TotalTagihan = 0
        P_TotalTagihan.Text = "_"
    End Sub
End Class