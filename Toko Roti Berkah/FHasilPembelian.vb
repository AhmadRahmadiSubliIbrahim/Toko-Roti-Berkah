Imports MySql.Data.MySqlClient

Public Class FHasilPembelian
    Sub ListBelanja()
        Try
            If ListView1.Columns.Count <= 0 Then
                ListView1.Columns.Add("ID Roti", 50, HorizontalAlignment.Center)
                ListView1.Columns.Add("Nama Roti", 100, HorizontalAlignment.Left)
                ListView1.Columns.Add("Rasa", 100, HorizontalAlignment.Left)
                ListView1.Columns.Add("Harga Satuan(Rp.)", 120, HorizontalAlignment.Left)
                ListView1.Columns.Add("Jumlah Beli", 75, HorizontalAlignment.Left)
                ListView1.Columns.Add("Total Harga(Rp.)", 120, HorizontalAlignment.Left)
            End If
            Pembeli.HasilPembelian(FPembelian.UrutanID)
            'DA = New MySqlDataAdapter("SELECT * FROM detail_pembelian INNER JOIN roti ON detail_pembelian.id_roti=roti.id_roti  WHERE id_transaksi = '" & FPembelian.UrutanID & "'", conn)
            'DS = New DataSet
            ListView1.Items.Clear()
            DA.Fill(DS, "detail_pembelian")
            For Each DRow In DS.Tables(0).Rows
                Dim lvw As ListViewItem
                lvw = ListView1.Items.Add(DRow("id_roti").ToString)
                lvw.SubItems.Add(DRow("nama_roti").ToString)
                lvw.SubItems.Add(DRow("rasa").ToString)
                lvw.SubItems.Add(DRow("harga").ToString)
                lvw.SubItems.Add(DRow("jumlah_beli").ToString)
                lvw.SubItems.Add(DRow("jumlah_beli").ToString * DRow("harga").ToString)
            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles BtnKembali.Click
        FHome.Body.Controls.Clear()
        FPembelian.Location = New Point(0, 0)
        FPembelian.TopLevel = False
        FHome.Body.Controls.Add(FPembelian)
        FPembelian.WindowState = FormWindowState.Maximized
        FPembelian.Show()
        FPembelian.ClearMe()
        FHome.BCLabel.Text = "Home > Pembelian"
    End Sub

    Private Sub FHasilPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class