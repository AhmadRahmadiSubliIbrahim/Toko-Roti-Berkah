<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FInputRoti
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
        Me.components = New System.ComponentModel.Container()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.P_Keterangan = New System.Windows.Forms.Label()
        Me.P_Harga = New System.Windows.Forms.Label()
        Me.P_Rasa = New System.Windows.Forms.Label()
        Me.P_NamaRoti = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.P_IDRoti = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.IRT_Keterangan = New System.Windows.Forms.RichTextBox()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.IRT_Harga = New System.Windows.Forms.NumericUpDown()
        Me.IRT_Rasa = New System.Windows.Forms.TextBox()
        Me.IRT_Nama = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IRT_Harga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Location = New System.Drawing.Point(168, 219)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(72, 25)
        Me.BtnDelete.TabIndex = 52
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'P_Keterangan
        '
        Me.P_Keterangan.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.P_Keterangan.AutoSize = True
        Me.P_Keterangan.Location = New System.Drawing.Point(105, 177)
        Me.P_Keterangan.Name = "P_Keterangan"
        Me.P_Keterangan.Size = New System.Drawing.Size(13, 13)
        Me.P_Keterangan.TabIndex = 51
        Me.P_Keterangan.Text = "_"
        '
        'P_Harga
        '
        Me.P_Harga.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.P_Harga.AutoSize = True
        Me.P_Harga.Location = New System.Drawing.Point(105, 152)
        Me.P_Harga.Name = "P_Harga"
        Me.P_Harga.Size = New System.Drawing.Size(13, 13)
        Me.P_Harga.TabIndex = 50
        Me.P_Harga.Text = "_"
        '
        'P_Rasa
        '
        Me.P_Rasa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.P_Rasa.AutoSize = True
        Me.P_Rasa.Location = New System.Drawing.Point(105, 127)
        Me.P_Rasa.Name = "P_Rasa"
        Me.P_Rasa.Size = New System.Drawing.Size(13, 13)
        Me.P_Rasa.TabIndex = 49
        Me.P_Rasa.Text = "_"
        '
        'P_NamaRoti
        '
        Me.P_NamaRoti.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.P_NamaRoti.AutoSize = True
        Me.P_NamaRoti.Location = New System.Drawing.Point(105, 102)
        Me.P_NamaRoti.Name = "P_NamaRoti"
        Me.P_NamaRoti.Size = New System.Drawing.Size(13, 13)
        Me.P_NamaRoti.TabIndex = 48
        Me.P_NamaRoti.Text = "_"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Keterangan"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Rasa"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Nama Roti"
        '
        'P_IDRoti
        '
        Me.P_IDRoti.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.P_IDRoti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.P_IDRoti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_IDRoti.FormattingEnabled = True
        Me.P_IDRoti.Location = New System.Drawing.Point(61, 65)
        Me.P_IDRoti.Name = "P_IDRoti"
        Me.P_IDRoti.Size = New System.Drawing.Size(179, 24)
        Me.P_IDRoti.TabIndex = 42
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnDelete)
        Me.GroupBox1.Controls.Add(Me.P_Keterangan)
        Me.GroupBox1.Controls.Add(Me.P_Harga)
        Me.GroupBox1.Controls.Add(Me.P_Rasa)
        Me.GroupBox1.Controls.Add(Me.P_NamaRoti)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.P_IDRoti)
        Me.GroupBox1.Location = New System.Drawing.Point(358, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(254, 290)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Roti"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "ID Roti"
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'IRT_Keterangan
        '
        Me.IRT_Keterangan.Location = New System.Drawing.Point(44, 242)
        Me.IRT_Keterangan.Name = "IRT_Keterangan"
        Me.IRT_Keterangan.Size = New System.Drawing.Size(229, 77)
        Me.IRT_Keterangan.TabIndex = 41
        Me.IRT_Keterangan.Text = ""
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSimpan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnSimpan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Location = New System.Drawing.Point(201, 325)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(72, 25)
        Me.BtnSimpan.TabIndex = 40
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(41, 187)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 13)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Rp."
        '
        'IRT_Harga
        '
        Me.IRT_Harga.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IRT_Harga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IRT_Harga.Location = New System.Drawing.Point(65, 183)
        Me.IRT_Harga.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.IRT_Harga.Name = "IRT_Harga"
        Me.IRT_Harga.Size = New System.Drawing.Size(208, 22)
        Me.IRT_Harga.TabIndex = 38
        Me.IRT_Harga.ThousandsSeparator = True
        '
        'IRT_Rasa
        '
        Me.IRT_Rasa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IRT_Rasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IRT_Rasa.Location = New System.Drawing.Point(44, 124)
        Me.IRT_Rasa.MaxLength = 50
        Me.IRT_Rasa.Name = "IRT_Rasa"
        Me.IRT_Rasa.Size = New System.Drawing.Size(229, 22)
        Me.IRT_Rasa.TabIndex = 35
        '
        'IRT_Nama
        '
        Me.IRT_Nama.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IRT_Nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IRT_Nama.Location = New System.Drawing.Point(44, 65)
        Me.IRT_Nama.MaxLength = 100
        Me.IRT_Nama.Name = "IRT_Nama"
        Me.IRT_Nama.Size = New System.Drawing.Size(229, 22)
        Me.IRT_Nama.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(41, 226)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Keterangan"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(41, 167)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Harga"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(41, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Rasa"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(41, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Nama Roti"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.IRT_Keterangan)
        Me.GroupBox2.Controls.Add(Me.BtnSimpan)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.IRT_Harga)
        Me.GroupBox2.Controls.Add(Me.IRT_Rasa)
        Me.GroupBox2.Controls.Add(Me.IRT_Nama)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(38, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(314, 413)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Input Roti"
        '
        'FInputRoti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 465)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FInputRoti"
        Me.Text = "FInputRoti"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IRT_Harga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnDelete As Button
    Friend WithEvents P_Keterangan As Label
    Friend WithEvents P_Harga As Label
    Friend WithEvents P_Rasa As Label
    Friend WithEvents P_NamaRoti As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents P_IDRoti As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents IRT_Keterangan As RichTextBox
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents IRT_Harga As NumericUpDown
    Friend WithEvents IRT_Rasa As TextBox
    Friend WithEvents IRT_Nama As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
