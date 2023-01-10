Imports MySql.Data.MySqlClient

Public Class FGrafikPembelian
    Dim Bulan As String
    Dim Tahun As String
    Sub ListRoti()
        Try
            If ListView1.Columns.Count <= 0 Then
                ListView1.Columns.Add("ID Roti", 50, HorizontalAlignment.Center)
                ListView1.Columns.Add("Nama Roti", 100, HorizontalAlignment.Left)
            End If
            DA = New MySqlDataAdapter("SELECT * FROM roti", conn)
            DS = New DataSet
            ListView1.Items.Clear()
            DA.Fill(DS, "roti")
            For Each DRow In DS.Tables(0).Rows
                Dim lvw As ListViewItem
                lvw = ListView1.Items.Add(DRow("id_roti").ToString)
                lvw.SubItems.Add(DRow("nama_roti").ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub GrafikPembelian()
        CMD = New MySqlCommand("SELECT * FROM roti", conn)
        DR = CMD.ExecuteReader
        Chart1.Series.Clear()
        Do While DR.Read
            Chart1.Series.Add(DR.Item("nama_roti"))
        Loop
        DR.Close()
        CMD = New MySqlCommand("SELECT nama_roti, SUM(jumlah_beli) AS JB FROM pembelian INNER JOIN detail_pembelian ON pembelian.id_transaksi = detail_pembelian.id_transaksi JOIN roti ON detail_pembelian.id_roti = roti.id_roti WHERE MONTH(tanggal) = '" & Bulan & "' AND YEAR(tanggal) = '" & Format(Now, "yyyy") & "' GROUP BY detail_pembelian.id_roti ", conn)
        DR = CMD.ExecuteReader

        Do While DR.Read
            With Chart1.Series(DR.Item("nama_roti"))
                .Points.AddY(DR.Item("JB"))
            End With
        Loop
        DR.Close()
    End Sub
    Private Sub FGrafikPembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListRoti()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Bulan = "01"
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Bulan = "02"
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Bulan = "03"
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Bulan = "04"
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Bulan = "05"
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Bulan = "06"
        ElseIf ComboBox1.SelectedIndex = 6 Then
            Bulan = "07"
        ElseIf ComboBox1.SelectedIndex = 8 Then
            Bulan = "09"
        ElseIf ComboBox1.SelectedIndex = 9 Then
            Bulan = "10"
        ElseIf ComboBox1.SelectedIndex = 10 Then
            Bulan = "11"
        ElseIf ComboBox1.SelectedIndex = 11 Then
            Bulan = "12"
        End If
        Try
            GrafikPembelian()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class