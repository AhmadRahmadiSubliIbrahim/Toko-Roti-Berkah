<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_loading = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Myprogress = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(142, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 36)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Toko Roti Berkah"
        '
        'lbl_loading
        '
        Me.lbl_loading.AutoSize = True
        Me.lbl_loading.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_loading.ForeColor = System.Drawing.Color.LightGray
        Me.lbl_loading.Location = New System.Drawing.Point(194, 232)
        Me.lbl_loading.Name = "lbl_loading"
        Me.lbl_loading.Size = New System.Drawing.Size(144, 33)
        Me.lbl_loading.TabIndex = 12
        Me.lbl_loading.Text = "Loading..."
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'Myprogress
        '
        Me.Myprogress.animated = False
        Me.Myprogress.animationIterval = 5
        Me.Myprogress.animationSpeed = 300
        Me.Myprogress.BackColor = System.Drawing.Color.Transparent
        Me.Myprogress.BackgroundImage = CType(resources.GetObject("Myprogress.BackgroundImage"), System.Drawing.Image)
        Me.Myprogress.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.Myprogress.ForeColor = System.Drawing.Color.LightGray
        Me.Myprogress.LabelVisible = True
        Me.Myprogress.LineProgressThickness = 14
        Me.Myprogress.LineThickness = 8
        Me.Myprogress.Location = New System.Drawing.Point(178, 49)
        Me.Myprogress.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.Myprogress.MaxValue = 100
        Me.Myprogress.Name = "Myprogress"
        Me.Myprogress.ProgressBackColor = System.Drawing.Color.Gray
        Me.Myprogress.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Myprogress.Size = New System.Drawing.Size(177, 177)
        Me.Myprogress.TabIndex = 13
        Me.Myprogress.Value = 0
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 50
        Me.BunifuElipse1.TargetControl = Me
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(532, 277)
        Me.Controls.Add(Me.Myprogress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_loading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_loading As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Myprogress As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
End Class
