<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FInputResep
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.IRS_KetBahan = New System.Windows.Forms.RichTextBox()
        Me.IRS_TakaranGram = New System.Windows.Forms.NumericUpDown()
        Me.IRS_TanggalProduksi = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.IRS_NamaResep = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.IRS_KetResep = New System.Windows.Forms.RichTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IRS_NamaBahan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IRS_IDRoti = New System.Windows.Forms.ComboBox()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IRS_TakaranGram, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnClear
        '
        Me.BtnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(444, 416)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 26)
        Me.BtnClear.TabIndex = 76
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Keterangan"
        '
        'IRS_KetBahan
        '
        Me.IRS_KetBahan.Location = New System.Drawing.Point(45, 314)
        Me.IRS_KetBahan.Name = "IRS_KetBahan"
        Me.IRS_KetBahan.Size = New System.Drawing.Size(185, 55)
        Me.IRS_KetBahan.TabIndex = 74
        Me.IRS_KetBahan.Text = ""
        '
        'IRS_TakaranGram
        '
        Me.IRS_TakaranGram.Location = New System.Drawing.Point(45, 275)
        Me.IRS_TakaranGram.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.IRS_TakaranGram.Name = "IRS_TakaranGram"
        Me.IRS_TakaranGram.Size = New System.Drawing.Size(185, 20)
        Me.IRS_TakaranGram.TabIndex = 73
        '
        'IRS_TanggalProduksi
        '
        Me.IRS_TanggalProduksi.CustomFormat = "dddd, dd MMM yyyy"
        Me.IRS_TanggalProduksi.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.IRS_TanggalProduksi.Location = New System.Drawing.Point(232, 76)
        Me.IRS_TanggalProduksi.Name = "IRS_TanggalProduksi"
        Me.IRS_TanggalProduksi.Size = New System.Drawing.Size(324, 20)
        Me.IRS_TanggalProduksi.TabIndex = 72
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(94, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Tanggal Produksi"
        '
        'BtnTambah
        '
        Me.BtnTambah.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnTambah.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnTambah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Location = New System.Drawing.Point(47, 375)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(72, 25)
        Me.BtnTambah.TabIndex = 70
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'IRS_NamaResep
        '
        Me.IRS_NamaResep.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IRS_NamaResep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IRS_NamaResep.Location = New System.Drawing.Point(232, 22)
        Me.IRS_NamaResep.Name = "IRS_NamaResep"
        Me.IRS_NamaResep.Size = New System.Drawing.Size(324, 21)
        Me.IRS_NamaResep.TabIndex = 69
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Nama Resep"
        '
        'IRS_KetResep
        '
        Me.IRS_KetResep.Location = New System.Drawing.Point(232, 102)
        Me.IRS_KetResep.Name = "IRS_KetResep"
        Me.IRS_KetResep.Size = New System.Drawing.Size(324, 95)
        Me.IRS_KetResep.TabIndex = 67
        Me.IRS_KetResep.Text = ""
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(94, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "Keterangan"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Takaran(Gram)"
        '
        'IRS_NamaBahan
        '
        Me.IRS_NamaBahan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IRS_NamaBahan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IRS_NamaBahan.Location = New System.Drawing.Point(45, 234)
        Me.IRS_NamaBahan.Name = "IRS_NamaBahan"
        Me.IRS_NamaBahan.Size = New System.Drawing.Size(185, 21)
        Me.IRS_NamaBahan.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Nama Bahan"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(94, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "ID Roti"
        '
        'IRS_IDRoti
        '
        Me.IRS_IDRoti.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IRS_IDRoti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IRS_IDRoti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IRS_IDRoti.FormattingEnabled = True
        Me.IRS_IDRoti.Location = New System.Drawing.Point(232, 47)
        Me.IRS_IDRoti.Name = "IRS_IDRoti"
        Me.IRS_IDRoti.Size = New System.Drawing.Size(324, 24)
        Me.IRS_IDRoti.TabIndex = 61
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSimpan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnSimpan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Location = New System.Drawing.Point(535, 417)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(72, 25)
        Me.BtnSimpan.TabIndex = 60
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 162.5756!
        Me.Column3.HeaderText = "Keterangan"
        Me.Column3.Name = "Column3"
        '
        'Column2
        '
        Me.Column2.FillWeight = 68.52792!
        Me.Column2.HeaderText = "Takaran (Gram)"
        Me.Column2.Name = "Column2"
        '
        'Column1
        '
        Me.Column1.FillWeight = 68.89648!
        Me.Column1.HeaderText = "Nama Bahan"
        Me.Column1.Name = "Column1"
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(248, 207)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(357, 193)
        Me.DataGridView1.TabIndex = 59
        '
        'FInputResep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 465)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.IRS_KetBahan)
        Me.Controls.Add(Me.IRS_TakaranGram)
        Me.Controls.Add(Me.IRS_TanggalProduksi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.IRS_NamaResep)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.IRS_KetResep)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IRS_NamaBahan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IRS_IDRoti)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FInputResep"
        Me.Text = "FInputResep"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IRS_TakaranGram, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnClear As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label6 As Label
    Friend WithEvents IRS_KetBahan As RichTextBox
    Friend WithEvents IRS_TakaranGram As NumericUpDown
    Friend WithEvents IRS_TanggalProduksi As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnTambah As Button
    Friend WithEvents IRS_NamaResep As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents IRS_KetResep As RichTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents IRS_NamaBahan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents IRS_IDRoti As ComboBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider2 As ErrorProvider
End Class
