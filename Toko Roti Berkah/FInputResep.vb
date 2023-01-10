Imports System.Diagnostics.PerformanceData
Imports MySql.Data.MySqlClient

Public Class FInputResep
    Dim IDResep As String
    Private Sub RandomID()
        IDResep = Resep.RandomString(2, Resep._chars) & Format(Now, "ddMMyy")
    End Sub
    Sub ClearMe()
        DataGridView1.Rows.Clear()
        IRS_IDRoti.SelectedIndex = -1
        IRS_KetBahan.Clear()
        IRS_KetResep.Clear()
        IRS_NamaBahan.Clear()
        IRS_NamaResep.Clear()
        IRS_TakaranGram.Value = 0

    End Sub
    Private Sub IRS_IDRoti_Enter(sender As Object, e As EventArgs) Handles IRS_IDRoti.Enter
        IRS_IDRoti.Items.Clear()
        DR.Close()
        Resep.TampilID_Roti()
        Do While DR.Read
            IRS_IDRoti.Items.Add(DR.Item(0))
        Loop
        DR.Close()
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        DataGridView1.Rows.Add(1)
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = IRS_NamaBahan.Text
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = IRS_TakaranGram.Value
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = IRS_KetBahan.Text
        DataGridView1.Update()
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        RandomID()
        If IRS_IDRoti.Text = "" Or IRS_NamaResep.Text = "" Then
            If IRS_IDRoti.Text = "" Then
                ErrorProvider1.SetError(IRS_IDRoti, "Harap Pilih ID Roti Terlebih Dahulu!")
            End If
            If IRS_NamaResep.Text = "" Then
                ErrorProvider2.SetError(IRS_NamaResep, "Nama Resep Harus Diisi!")
            End If
        Else
            Try
                Resep.SelectIdRoti(IRS_IDRoti.Text)
                If DR.HasRows Then
                    MessageBox.Show("Resep Dengan ID Roti = " & IRS_IDRoti.Text & "Ingin Memperbarui Resep Roti?", "Gagal Menginput Resep!", MessageBoxButtons.OK)
                    Call Koneksi()
                    Dim delete = New Resep()
                    delete.Id_Resep = IRS_IDRoti.Text
                    delete.Delete()
                    'CMD = New MySqlCommand("DELETE FROM resep WHERE BINARY id_roti = '" & IRS_IDRoti.Text & "'", conn)
                    'CMD.ExecuteNonQuery()
                    Dim insert = New Resep()
                    insert.Id_Resep = IDResep
                    insert.Nama_Resep = IRS_NamaResep.Text
                    insert.Id_Roti = IRS_IDRoti.Text
                    insert.Keterangan = IRS_KetResep.Text
                    insert.Tgl_Update = Format(IRS_TanggalProduksi.Value, "yyyy-MM-dd HH:mm:ss")
                    insert.Insert()
                    'CMD = New MySqlCommand("INSERT INTO resep (id_resep,nama_resep,id_roti,keterangan,tanggal_update) VALUES ('" & IDResep & "','" & IRS_NamaResep.Text & "','" & IRS_IDRoti.Text & "','" & IRS_KetResep.Text & "','" & Format(IRS_TanggalProduksi.Value, "yyyy-MM-dd HH:mm:ss") & "')", conn)
                    'CMD.ExecuteNonQuery()
                    For i As Integer = 0 To DataGridView1.Rows.Count - 2 Step +1

                        Using CMD As New MySqlCommand("INSERT INTO resep_detail (id_resep,nama_bahan,takaran,keterangan) VALUES('" & IDResep & "',@nama_bahan, @takaran, @keterangan)", conn)
                            CMD.Parameters.AddWithValue("@nama_bahan", DataGridView1.Rows(i).Cells(0).Value)
                            CMD.Parameters.AddWithValue("@takaran", DataGridView1.Rows(i).Cells(1).Value)
                            CMD.Parameters.AddWithValue("@keterangan", DataGridView1.Rows(i).Cells(2).Value)
                            CMD.ExecuteNonQuery()
                        End Using
                    Next
                    MessageBox.Show("Resep untuk ID Roti : " & IRS_IDRoti.Text & "Berhasil Diperbarui Kedalam Database", "Berhasil Memperbarui Resep")
                    DR.Close()
                Else
                    DR.Close()
                    CMD = New MySqlCommand("INSERT INTO resep (id_resep,nama_resep,id_roti,keterangan,tanggal_update) VALUES ('" & IDResep & "','" & IRS_NamaResep.Text & "','" & IRS_IDRoti.Text & "','" & IRS_KetResep.Text & "','" & Format(IRS_TanggalProduksi.Value, "yyyy-MM-dd HH:mm:ss") & "')", conn)
                    CMD.ExecuteNonQuery()
                    For i As Integer = 0 To DataGridView1.Rows.Count - 2 Step +1
                        Using CMD As New MySqlCommand("INSERT INTO resep_detail (id_resep,nama_bahan,takaran,keterangan) VALUES('" & IDResep & "',@nama_bahan, @takaran, @keterangan)", conn)
                            CMD.Parameters.AddWithValue("@nama_bahan", DataGridView1.Rows(i).Cells(0).Value)
                            CMD.Parameters.AddWithValue("@takaran", DataGridView1.Rows(i).Cells(1).Value)
                            CMD.Parameters.AddWithValue("@keterangan", DataGridView1.Rows(i).Cells(2).Value)
                            CMD.ExecuteNonQuery()
                            MessageBox.Show("Resep untuk ID Roti : " & IRS_IDRoti.Text & "Berhasil Disimpan Kedalam Database", "Berhasil Menginput Resep")
                        End Using
                    Next
                End If
                DR.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Dim TJB As Integer
            For Each R As DataGridViewRow In DataGridView1.Rows
                TJB += R.Cells(1).Value
            Next
            ClearMe()
        End If
    End Sub

    Private Sub IRS_IDRoti_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IRS_IDRoti.SelectedIndexChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub IRS_NamaResep_TextChanged(sender As Object, e As EventArgs) Handles IRS_NamaResep.TextChanged
        ErrorProvider2.Clear()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        DataGridView1.Rows.Clear()
    End Sub
End Class