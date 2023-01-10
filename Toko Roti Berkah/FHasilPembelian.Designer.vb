<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FHasilPembelian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.HP_TotalJumlahBeli = New System.Windows.Forms.Label()
        Me.HP_TotalTagihan = New System.Windows.Forms.Label()
        Me.HP_Tanggal = New System.Windows.Forms.Label()
        Me.HP_NamaPembeli = New System.Windows.Forms.Label()
        Me.HP_IDTransaksi = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(55, 131)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(543, 235)
        Me.ListView1.TabIndex = 65
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'HP_TotalJumlahBeli
        '
        Me.HP_TotalJumlahBeli.AutoSize = True
        Me.HP_TotalJumlahBeli.Location = New System.Drawing.Point(459, 67)
        Me.HP_TotalJumlahBeli.Name = "HP_TotalJumlahBeli"
        Me.HP_TotalJumlahBeli.Size = New System.Drawing.Size(13, 13)
        Me.HP_TotalJumlahBeli.TabIndex = 64
        Me.HP_TotalJumlahBeli.Text = "_"
        '
        'HP_TotalTagihan
        '
        Me.HP_TotalTagihan.AutoSize = True
        Me.HP_TotalTagihan.Location = New System.Drawing.Point(459, 86)
        Me.HP_TotalTagihan.Name = "HP_TotalTagihan"
        Me.HP_TotalTagihan.Size = New System.Drawing.Size(13, 13)
        Me.HP_TotalTagihan.TabIndex = 63
        Me.HP_TotalTagihan.Text = "_"
        '
        'HP_Tanggal
        '
        Me.HP_Tanggal.AutoSize = True
        Me.HP_Tanggal.Location = New System.Drawing.Point(146, 102)
        Me.HP_Tanggal.Name = "HP_Tanggal"
        Me.HP_Tanggal.Size = New System.Drawing.Size(13, 13)
        Me.HP_Tanggal.TabIndex = 62
        Me.HP_Tanggal.Text = "_"
        '
        'HP_NamaPembeli
        '
        Me.HP_NamaPembeli.AutoSize = True
        Me.HP_NamaPembeli.Location = New System.Drawing.Point(146, 85)
        Me.HP_NamaPembeli.Name = "HP_NamaPembeli"
        Me.HP_NamaPembeli.Size = New System.Drawing.Size(13, 13)
        Me.HP_NamaPembeli.TabIndex = 61
        Me.HP_NamaPembeli.Text = "_"
        '
        'HP_IDTransaksi
        '
        Me.HP_IDTransaksi.AutoSize = True
        Me.HP_IDTransaksi.Location = New System.Drawing.Point(146, 68)
        Me.HP_IDTransaksi.Name = "HP_IDTransaksi"
        Me.HP_IDTransaksi.Size = New System.Drawing.Size(13, 13)
        Me.HP_IDTransaksi.TabIndex = 60
        Me.HP_IDTransaksi.Text = "_"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(365, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Total Jumlah Beli"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Tanggal"
        '
        'BtnKembali
        '
        Me.BtnKembali.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnKembali.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembali.Location = New System.Drawing.Point(55, 372)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(75, 25)
        Me.BtnKembali.TabIndex = 57
        Me.BtnKembali.Text = "Kembali"
        Me.BtnKembali.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(365, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Total Tagihan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Nama Pembeli"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "ID Transaksi"
        '
        'FHasilPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 465)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.HP_TotalJumlahBeli)
        Me.Controls.Add(Me.HP_TotalTagihan)
        Me.Controls.Add(Me.HP_Tanggal)
        Me.Controls.Add(Me.HP_NamaPembeli)
        Me.Controls.Add(Me.HP_IDTransaksi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FHasilPembelian"
        Me.Text = "FHasilPembelian"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents HP_TotalJumlahBeli As Label
    Friend WithEvents HP_TotalTagihan As Label
    Friend WithEvents HP_Tanggal As Label
    Friend WithEvents HP_NamaPembeli As Label
    Friend WithEvents HP_IDTransaksi As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnKembali As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
