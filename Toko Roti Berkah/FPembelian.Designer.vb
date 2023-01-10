<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FPembelian
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
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P_TotalTagihan = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.P_NamaPembeli = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.P_JumlahBeli = New System.Windows.Forms.NumericUpDown()
        Me.P_Keterangan = New System.Windows.Forms.Label()
        Me.P_Harga = New System.Windows.Forms.Label()
        Me.P_Rasa = New System.Windows.Forms.Label()
        Me.P_NamaRoti = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.P_IDRoti = New System.Windows.Forms.ComboBox()
        Me.BtnBeli = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P_JumlahBeli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Column2
        '
        Me.Column2.HeaderText = "Jumlah Beli"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID Roti"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'BtnClear
        '
        Me.BtnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(561, 315)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 26)
        Me.BtnClear.TabIndex = 78
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(293, 64)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(343, 243)
        Me.DataGridView1.TabIndex = 77
        '
        'Column3
        '
        Me.Column3.HeaderText = "Total Harga(Rp.)"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'P_TotalTagihan
        '
        Me.P_TotalTagihan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P_TotalTagihan.AutoSize = True
        Me.P_TotalTagihan.Location = New System.Drawing.Point(385, 322)
        Me.P_TotalTagihan.Name = "P_TotalTagihan"
        Me.P_TotalTagihan.Size = New System.Drawing.Size(13, 13)
        Me.P_TotalTagihan.TabIndex = 76
        Me.P_TotalTagihan.Text = "_"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(369, 322)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(10, 13)
        Me.Label13.TabIndex = 75
        Me.Label13.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(290, 322)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Total Tagihan"
        '
        'P_NamaPembeli
        '
        Me.P_NamaPembeli.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P_NamaPembeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_NamaPembeli.Location = New System.Drawing.Point(371, 348)
        Me.P_NamaPembeli.Name = "P_NamaPembeli"
        Me.P_NamaPembeli.Size = New System.Drawing.Size(265, 21)
        Me.P_NamaPembeli.TabIndex = 73
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(290, 353)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Nama Pembeli"
        '
        'BtnTambah
        '
        Me.BtnTambah.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnTambah.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnTambah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambah.Location = New System.Drawing.Point(212, 281)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(75, 26)
        Me.BtnTambah.TabIndex = 71
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Jumlah Beli"
        '
        'P_JumlahBeli
        '
        Me.P_JumlahBeli.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P_JumlahBeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_JumlahBeli.Location = New System.Drawing.Point(108, 254)
        Me.P_JumlahBeli.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.P_JumlahBeli.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.P_JumlahBeli.Name = "P_JumlahBeli"
        Me.P_JumlahBeli.Size = New System.Drawing.Size(179, 21)
        Me.P_JumlahBeli.TabIndex = 69
        Me.P_JumlahBeli.ThousandsSeparator = True
        Me.P_JumlahBeli.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'P_Keterangan
        '
        Me.P_Keterangan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P_Keterangan.AutoSize = True
        Me.P_Keterangan.Location = New System.Drawing.Point(105, 169)
        Me.P_Keterangan.MaximumSize = New System.Drawing.Size(180, 0)
        Me.P_Keterangan.Name = "P_Keterangan"
        Me.P_Keterangan.Size = New System.Drawing.Size(13, 13)
        Me.P_Keterangan.TabIndex = 68
        Me.P_Keterangan.Text = "_"
        '
        'P_Harga
        '
        Me.P_Harga.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P_Harga.AutoSize = True
        Me.P_Harga.Location = New System.Drawing.Point(105, 144)
        Me.P_Harga.Name = "P_Harga"
        Me.P_Harga.Size = New System.Drawing.Size(13, 13)
        Me.P_Harga.TabIndex = 67
        Me.P_Harga.Text = "_"
        '
        'P_Rasa
        '
        Me.P_Rasa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P_Rasa.AutoSize = True
        Me.P_Rasa.Location = New System.Drawing.Point(105, 119)
        Me.P_Rasa.Name = "P_Rasa"
        Me.P_Rasa.Size = New System.Drawing.Size(13, 13)
        Me.P_Rasa.TabIndex = 66
        Me.P_Rasa.Text = "_"
        '
        'P_NamaRoti
        '
        Me.P_NamaRoti.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P_NamaRoti.AutoSize = True
        Me.P_NamaRoti.Location = New System.Drawing.Point(105, 94)
        Me.P_NamaRoti.Name = "P_NamaRoti"
        Me.P_NamaRoti.Size = New System.Drawing.Size(13, 13)
        Me.P_NamaRoti.TabIndex = 65
        Me.P_NamaRoti.Text = "_"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Keterangan"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Rasa"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Nama Roti"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "ID Roti"
        '
        'P_IDRoti
        '
        Me.P_IDRoti.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.P_IDRoti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.P_IDRoti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_IDRoti.FormattingEnabled = True
        Me.P_IDRoti.Location = New System.Drawing.Point(108, 64)
        Me.P_IDRoti.Name = "P_IDRoti"
        Me.P_IDRoti.Size = New System.Drawing.Size(179, 24)
        Me.P_IDRoti.TabIndex = 59
        '
        'BtnBeli
        '
        Me.BtnBeli.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnBeli.Enabled = False
        Me.BtnBeli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnBeli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnBeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBeli.Location = New System.Drawing.Point(561, 375)
        Me.BtnBeli.Name = "BtnBeli"
        Me.BtnBeli.Size = New System.Drawing.Size(75, 26)
        Me.BtnBeli.TabIndex = 58
        Me.BtnBeli.Text = "Beli"
        Me.BtnBeli.UseVisualStyleBackColor = True
        '
        'FPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 465)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.P_TotalTagihan)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.P_NamaPembeli)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.P_JumlahBeli)
        Me.Controls.Add(Me.P_Keterangan)
        Me.Controls.Add(Me.P_Harga)
        Me.Controls.Add(Me.P_Rasa)
        Me.Controls.Add(Me.P_NamaRoti)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.P_IDRoti)
        Me.Controls.Add(Me.BtnBeli)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FPembelian"
        Me.Text = "FPembelian"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P_JumlahBeli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents BtnClear As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents P_TotalTagihan As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents P_NamaPembeli As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnTambah As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents P_JumlahBeli As NumericUpDown
    Friend WithEvents P_Keterangan As Label
    Friend WithEvents P_Harga As Label
    Friend WithEvents P_Rasa As Label
    Friend WithEvents P_NamaRoti As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents P_IDRoti As ComboBox
    Friend WithEvents BtnBeli As Button
End Class
