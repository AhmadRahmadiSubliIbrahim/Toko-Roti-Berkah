<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FInputPetugas
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
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.IP_Ulangi = New System.Windows.Forms.TextBox()
        Me.IP_Password = New System.Windows.Forms.TextBox()
        Me.IP_Username = New System.Windows.Forms.TextBox()
        Me.IP_Nama = New System.Windows.Forms.TextBox()
        Me.IP_NIK = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnSimpan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.BtnSimpan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.BtnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Location = New System.Drawing.Point(225, 317)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(72, 25)
        Me.BtnSimpan.TabIndex = 17
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.IP_Ulangi)
        Me.GroupBox1.Controls.Add(Me.IP_Password)
        Me.GroupBox1.Controls.Add(Me.IP_Username)
        Me.GroupBox1.Controls.Add(Me.IP_Nama)
        Me.GroupBox1.Controls.Add(Me.IP_NIK)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BtnSimpan)
        Me.GroupBox1.Location = New System.Drawing.Point(160, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 385)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Calligraphy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(88, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 24)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Input Petugas"
        '
        'IP_Ulangi
        '
        Me.IP_Ulangi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IP_Ulangi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP_Ulangi.Location = New System.Drawing.Point(91, 261)
        Me.IP_Ulangi.MaxLength = 100
        Me.IP_Ulangi.Name = "IP_Ulangi"
        Me.IP_Ulangi.Size = New System.Drawing.Size(206, 22)
        Me.IP_Ulangi.TabIndex = 27
        Me.IP_Ulangi.UseSystemPasswordChar = True
        '
        'IP_Password
        '
        Me.IP_Password.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IP_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP_Password.Location = New System.Drawing.Point(91, 215)
        Me.IP_Password.MaxLength = 100
        Me.IP_Password.Name = "IP_Password"
        Me.IP_Password.Size = New System.Drawing.Size(206, 22)
        Me.IP_Password.TabIndex = 26
        Me.IP_Password.UseSystemPasswordChar = True
        '
        'IP_Username
        '
        Me.IP_Username.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IP_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP_Username.Location = New System.Drawing.Point(91, 169)
        Me.IP_Username.MaxLength = 100
        Me.IP_Username.Name = "IP_Username"
        Me.IP_Username.Size = New System.Drawing.Size(206, 22)
        Me.IP_Username.TabIndex = 25
        '
        'IP_Nama
        '
        Me.IP_Nama.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IP_Nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP_Nama.Location = New System.Drawing.Point(91, 123)
        Me.IP_Nama.MaxLength = 100
        Me.IP_Nama.Name = "IP_Nama"
        Me.IP_Nama.Size = New System.Drawing.Size(206, 22)
        Me.IP_Nama.TabIndex = 24
        '
        'IP_NIK
        '
        Me.IP_NIK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IP_NIK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP_NIK.Location = New System.Drawing.Point(91, 77)
        Me.IP_NIK.Name = "IP_NIK"
        Me.IP_NIK.Size = New System.Drawing.Size(206, 22)
        Me.IP_NIK.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Ulangi"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "NIK"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'FInputPetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 465)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FInputPetugas"
        Me.Text = "FInputPetugas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSimpan As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents IP_Ulangi As TextBox
    Friend WithEvents IP_Password As TextBox
    Friend WithEvents IP_Username As TextBox
    Friend WithEvents IP_Nama As TextBox
    Friend WithEvents IP_NIK As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
End Class
