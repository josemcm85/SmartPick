<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLanguage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLanguage))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBoxClose = New System.Windows.Forms.PictureBox()
        Me.PictureBoxMinimize = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ButtonEngMenu = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.ButtonSpaMenu = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBoxClose)
        Me.Panel2.Controls.Add(Me.PictureBoxMinimize)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(857, 31)
        Me.Panel2.TabIndex = 22
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Image = Global.SmartPick.My.Resources.Resources.Close
        Me.PictureBoxClose.Location = New System.Drawing.Point(821, 3)
        Me.PictureBoxClose.Name = "PictureBoxClose"
        Me.PictureBoxClose.Size = New System.Drawing.Size(24, 22)
        Me.PictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxClose.TabIndex = 1
        Me.PictureBoxClose.TabStop = False
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.Image = Global.SmartPick.My.Resources.Resources.Minimize
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(791, 3)
        Me.PictureBoxMinimize.Name = "PictureBoxMinimize"
        Me.PictureBoxMinimize.Size = New System.Drawing.Size(24, 22)
        Me.PictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxMinimize.TabIndex = 0
        Me.PictureBoxMinimize.TabStop = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 15
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(514, 57)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(243, 42)
        Me.BunifuCustomLabel1.TabIndex = 26
        Me.BunifuCustomLabel1.Text = "¡Bienvenidos!"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(451, 230)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(351, 25)
        Me.BunifuCustomLabel2.TabIndex = 27
        Me.BunifuCustomLabel2.Text = "Por favor elegir el idioma del Menú."
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(418, 268)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(411, 25)
        Me.BunifuCustomLabel3.TabIndex = 28
        Me.BunifuCustomLabel3.Text = "Please choose the language of the Menu."
        '
        'ButtonEngMenu
        '
        Me.ButtonEngMenu.ActiveBorderThickness = 1
        Me.ButtonEngMenu.ActiveCornerRadius = 20
        Me.ButtonEngMenu.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.ButtonEngMenu.ActiveForecolor = System.Drawing.Color.White
        Me.ButtonEngMenu.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.ButtonEngMenu.BackColor = System.Drawing.Color.White
        Me.ButtonEngMenu.BackgroundImage = CType(resources.GetObject("ButtonEngMenu.BackgroundImage"), System.Drawing.Image)
        Me.ButtonEngMenu.ButtonText = "English"
        Me.ButtonEngMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEngMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEngMenu.ForeColor = System.Drawing.Color.SeaGreen
        Me.ButtonEngMenu.IdleBorderThickness = 1
        Me.ButtonEngMenu.IdleCornerRadius = 20
        Me.ButtonEngMenu.IdleFillColor = System.Drawing.Color.White
        Me.ButtonEngMenu.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.ButtonEngMenu.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.ButtonEngMenu.Location = New System.Drawing.Point(669, 361)
        Me.ButtonEngMenu.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonEngMenu.Name = "ButtonEngMenu"
        Me.ButtonEngMenu.Size = New System.Drawing.Size(146, 46)
        Me.ButtonEngMenu.TabIndex = 25
        Me.ButtonEngMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonSpaMenu
        '
        Me.ButtonSpaMenu.ActiveBorderThickness = 1
        Me.ButtonSpaMenu.ActiveCornerRadius = 20
        Me.ButtonSpaMenu.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.ButtonSpaMenu.ActiveForecolor = System.Drawing.Color.White
        Me.ButtonSpaMenu.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.ButtonSpaMenu.BackColor = System.Drawing.Color.White
        Me.ButtonSpaMenu.BackgroundImage = CType(resources.GetObject("ButtonSpaMenu.BackgroundImage"), System.Drawing.Image)
        Me.ButtonSpaMenu.ButtonText = "Español"
        Me.ButtonSpaMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSpaMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSpaMenu.ForeColor = System.Drawing.Color.SeaGreen
        Me.ButtonSpaMenu.IdleBorderThickness = 1
        Me.ButtonSpaMenu.IdleCornerRadius = 20
        Me.ButtonSpaMenu.IdleFillColor = System.Drawing.Color.White
        Me.ButtonSpaMenu.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.ButtonSpaMenu.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.ButtonSpaMenu.Location = New System.Drawing.Point(465, 361)
        Me.ButtonSpaMenu.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonSpaMenu.Name = "ButtonSpaMenu"
        Me.ButtonSpaMenu.Size = New System.Drawing.Size(146, 46)
        Me.ButtonSpaMenu.TabIndex = 24
        Me.ButtonSpaMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(412, 712)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'FormLanguage
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(857, 743)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.ButtonEngMenu)
        Me.Controls.Add(Me.ButtonSpaMenu)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLanguage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBoxClose As PictureBox
    Friend WithEvents PictureBoxMinimize As PictureBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ButtonEngMenu As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents ButtonSpaMenu As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents PictureBox1 As PictureBox
End Class
