<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuGradientPanel2 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.ButtonMenu = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.BtnLogin = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.txtPass = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtUser = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuImageButton1 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuGradientPanel2.SuspendLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(708, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 17)
        Me.Label3.TabIndex = 4
        '
        'BunifuGradientPanel2
        '
        Me.BunifuGradientPanel2.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel2.Controls.Add(Me.ButtonMenu)
        Me.BunifuGradientPanel2.Controls.Add(Me.LinkLabel1)
        Me.BunifuGradientPanel2.Controls.Add(Me.BtnLogin)
        Me.BunifuGradientPanel2.Controls.Add(Me.txtPass)
        Me.BunifuGradientPanel2.Controls.Add(Me.txtUser)
        Me.BunifuGradientPanel2.Controls.Add(Me.BunifuImageButton1)
        Me.BunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.BunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White
        Me.BunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel2.Location = New System.Drawing.Point(349, 0)
        Me.BunifuGradientPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuGradientPanel2.Name = "BunifuGradientPanel2"
        Me.BunifuGradientPanel2.Quality = 10
        Me.BunifuGradientPanel2.Size = New System.Drawing.Size(483, 463)
        Me.BunifuGradientPanel2.TabIndex = 13
        '
        'ButtonMenu
        '
        Me.ButtonMenu.AutoSize = True
        Me.ButtonMenu.BackColor = System.Drawing.Color.Transparent
        Me.ButtonMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ButtonMenu.LinkColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.ButtonMenu.Location = New System.Drawing.Point(272, 354)
        Me.ButtonMenu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ButtonMenu.Name = "ButtonMenu"
        Me.ButtonMenu.Size = New System.Drawing.Size(150, 18)
        Me.ButtonMenu.TabIndex = 18
        Me.ButtonMenu.TabStop = True
        Me.ButtonMenu.Text = "Ingresar como cliente"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(43, 354)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(175, 18)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "¿Has olvidado tus datos?"
        '
        'BtnLogin
        '
        Me.BtnLogin.ActiveBorderThickness = 1
        Me.BtnLogin.ActiveCornerRadius = 20
        Me.BtnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnLogin.ActiveForecolor = System.Drawing.Color.White
        Me.BtnLogin.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnLogin.BackColor = System.Drawing.SystemColors.Control
        Me.BtnLogin.BackgroundImage = CType(resources.GetObject("BtnLogin.BackgroundImage"), System.Drawing.Image)
        Me.BtnLogin.ButtonText = "Login"
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnLogin.IdleBorderThickness = 1
        Me.BtnLogin.IdleCornerRadius = 20
        Me.BtnLogin.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnLogin.IdleForecolor = System.Drawing.Color.White
        Me.BtnLogin.IdleLineColor = System.Drawing.Color.Transparent
        Me.BtnLogin.Location = New System.Drawing.Point(79, 257)
        Me.BtnLogin.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(171, 50)
        Me.BtnLogin.TabIndex = 14
        Me.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.White
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPass.HintForeColor = System.Drawing.Color.Black
        Me.txtPass.HintText = "Password"
        Me.txtPass.isPassword = True
        Me.txtPass.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtPass.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtPass.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtPass.LineThickness = 3
        Me.txtPass.Location = New System.Drawing.Point(79, 170)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(268, 41)
        Me.txtPass.TabIndex = 10
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.White
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUser.HintForeColor = System.Drawing.Color.Empty
        Me.txtUser.HintText = "Username"
        Me.txtUser.isPassword = False
        Me.txtUser.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtUser.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtUser.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.txtUser.LineThickness = 3
        Me.txtUser.Location = New System.Drawing.Point(81, 74)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(268, 41)
        Me.txtUser.TabIndex = 9
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton1.Image = Global.SmartPick.My.Resources.Resources.icons8_visible_100px_3
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.Location = New System.Drawing.Point(352, 174)
        Me.BunifuImageButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Size = New System.Drawing.Size(20, 37)
        Me.BunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuImageButton1.TabIndex = 11
        Me.BunifuImageButton1.TabStop = False
        Me.BunifuImageButton1.Zoom = 10
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(353, 463)
        Me.BunifuGradientPanel1.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SmartPick.My.Resources.Resources.logoblack
        Me.PictureBox1.Location = New System.Drawing.Point(29, 94)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(264, 245)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 463)
        Me.Controls.Add(Me.BunifuGradientPanel2)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.BunifuGradientPanel2.ResumeLayout(False)
        Me.BunifuGradientPanel2.PerformLayout()
        CType(Me.BunifuImageButton1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUser As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtPass As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuImageButton1 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuGradientPanel2 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BtnLogin As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents ButtonMenu As LinkLabel
End Class
