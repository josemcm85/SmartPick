<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCoupons
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCoupons))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtCoupon = New MetroFramework.Controls.MetroTextBox()
        Me.txtPercentage = New MetroFramework.Controls.MetroTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.dgvCoupons = New System.Windows.Forms.DataGridView()
        Me.BtnCancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnDelCoupon = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnAddCoupon = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.dgvCoupons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.txtCoupon)
        Me.Panel1.Controls.Add(Me.txtPercentage)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BunifuCards1)
        Me.Panel1.Controls.Add(Me.BtnCancel)
        Me.Panel1.Controls.Add(Me.BtnDelCoupon)
        Me.Panel1.Controls.Add(Me.BtnAddCoupon)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbltitle)
        Me.Panel1.Location = New System.Drawing.Point(25, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 551)
        Me.Panel1.TabIndex = 1
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(390, 93)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(55, 16)
        Me.BunifuCustomLabel1.TabIndex = 60
        Me.BunifuCustomLabel1.Text = "Cupón:"
        '
        'txtCoupon
        '
        Me.txtCoupon.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCoupon.CustomButton.Image = Nothing
        Me.txtCoupon.CustomButton.Location = New System.Drawing.Point(108, 1)
        Me.txtCoupon.CustomButton.Name = ""
        Me.txtCoupon.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCoupon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCoupon.CustomButton.TabIndex = 1
        Me.txtCoupon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCoupon.CustomButton.UseSelectable = True
        Me.txtCoupon.CustomButton.Visible = False
        Me.txtCoupon.DisplayIcon = True
        Me.txtCoupon.Icon = Global.SmartPick.My.Resources.Resources.icons8_price_tag_50px_11
        Me.txtCoupon.IconRight = True
        Me.txtCoupon.Lines = New String(-1) {}
        Me.txtCoupon.Location = New System.Drawing.Point(394, 123)
        Me.txtCoupon.MaxLength = 32767
        Me.txtCoupon.Name = "txtCoupon"
        Me.txtCoupon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCoupon.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCoupon.SelectedText = ""
        Me.txtCoupon.SelectionLength = 0
        Me.txtCoupon.SelectionStart = 0
        Me.txtCoupon.ShortcutsEnabled = True
        Me.txtCoupon.Size = New System.Drawing.Size(130, 23)
        Me.txtCoupon.TabIndex = 59
        Me.txtCoupon.UseSelectable = True
        Me.txtCoupon.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCoupon.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPercentage
        '
        Me.txtPercentage.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPercentage.CustomButton.Image = Nothing
        Me.txtPercentage.CustomButton.Location = New System.Drawing.Point(110, 1)
        Me.txtPercentage.CustomButton.Name = ""
        Me.txtPercentage.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPercentage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPercentage.CustomButton.TabIndex = 1
        Me.txtPercentage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPercentage.CustomButton.UseSelectable = True
        Me.txtPercentage.CustomButton.Visible = False
        Me.txtPercentage.DisplayIcon = True
        Me.txtPercentage.Icon = Global.SmartPick.My.Resources.Resources.icons8_percentage_26px_5
        Me.txtPercentage.IconRight = True
        Me.txtPercentage.Lines = New String(-1) {}
        Me.txtPercentage.Location = New System.Drawing.Point(393, 192)
        Me.txtPercentage.MaxLength = 32767
        Me.txtPercentage.Name = "txtPercentage"
        Me.txtPercentage.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPercentage.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPercentage.SelectedText = ""
        Me.txtPercentage.SelectionLength = 0
        Me.txtPercentage.SelectionStart = 0
        Me.txtPercentage.ShortcutsEnabled = True
        Me.txtPercentage.Size = New System.Drawing.Size(132, 23)
        Me.txtPercentage.TabIndex = 58
        Me.txtPercentage.UseSelectable = True
        Me.txtPercentage.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPercentage.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(390, 163)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Porcentaje:"
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Tomato
        Me.BunifuCards1.Controls.Add(Me.dgvCoupons)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(30, 88)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(347, 413)
        Me.BunifuCards1.TabIndex = 56
        '
        'dgvCoupons
        '
        Me.dgvCoupons.AllowUserToAddRows = False
        Me.dgvCoupons.AllowUserToDeleteRows = False
        Me.dgvCoupons.BackgroundColor = System.Drawing.Color.Snow
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCoupons.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCoupons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCoupons.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCoupons.Location = New System.Drawing.Point(0, 4)
        Me.dgvCoupons.Name = "dgvCoupons"
        Me.dgvCoupons.ReadOnly = True
        Me.dgvCoupons.RowHeadersVisible = False
        Me.dgvCoupons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCoupons.Size = New System.Drawing.Size(344, 406)
        Me.dgvCoupons.TabIndex = 1
        '
        'BtnCancel
        '
        Me.BtnCancel.ActiveBorderThickness = 1
        Me.BtnCancel.ActiveCornerRadius = 7
        Me.BtnCancel.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnCancel.ActiveForecolor = System.Drawing.Color.White
        Me.BtnCancel.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnCancel.BackColor = System.Drawing.Color.Snow
        Me.BtnCancel.BackgroundImage = CType(resources.GetObject("BtnCancel.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancel.ButtonText = "CANCELAR"
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnCancel.IdleBorderThickness = 1
        Me.BtnCancel.IdleCornerRadius = 7
        Me.BtnCancel.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnCancel.IdleForecolor = System.Drawing.Color.White
        Me.BtnCancel.IdleLineColor = System.Drawing.Color.Lavender
        Me.BtnCancel.Location = New System.Drawing.Point(390, 451)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(134, 50)
        Me.BtnCancel.TabIndex = 55
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnDelCoupon
        '
        Me.BtnDelCoupon.ActiveBorderThickness = 1
        Me.BtnDelCoupon.ActiveCornerRadius = 7
        Me.BtnDelCoupon.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnDelCoupon.ActiveForecolor = System.Drawing.Color.White
        Me.BtnDelCoupon.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnDelCoupon.BackColor = System.Drawing.Color.Snow
        Me.BtnDelCoupon.BackgroundImage = CType(resources.GetObject("BtnDelCoupon.BackgroundImage"), System.Drawing.Image)
        Me.BtnDelCoupon.ButtonText = "Eliminar Cupón"
        Me.BtnDelCoupon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelCoupon.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelCoupon.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnDelCoupon.IdleBorderThickness = 1
        Me.BtnDelCoupon.IdleCornerRadius = 7
        Me.BtnDelCoupon.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnDelCoupon.IdleForecolor = System.Drawing.Color.White
        Me.BtnDelCoupon.IdleLineColor = System.Drawing.Color.Lavender
        Me.BtnDelCoupon.Location = New System.Drawing.Point(390, 366)
        Me.BtnDelCoupon.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnDelCoupon.Name = "BtnDelCoupon"
        Me.BtnDelCoupon.Size = New System.Drawing.Size(134, 50)
        Me.BtnDelCoupon.TabIndex = 54
        Me.BtnDelCoupon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnAddCoupon
        '
        Me.BtnAddCoupon.ActiveBorderThickness = 1
        Me.BtnAddCoupon.ActiveCornerRadius = 7
        Me.BtnAddCoupon.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnAddCoupon.ActiveForecolor = System.Drawing.Color.White
        Me.BtnAddCoupon.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnAddCoupon.BackColor = System.Drawing.Color.Snow
        Me.BtnAddCoupon.BackgroundImage = CType(resources.GetObject("BtnAddCoupon.BackgroundImage"), System.Drawing.Image)
        Me.BtnAddCoupon.ButtonText = "Crear Cupón"
        Me.BtnAddCoupon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddCoupon.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddCoupon.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnAddCoupon.IdleBorderThickness = 1
        Me.BtnAddCoupon.IdleCornerRadius = 7
        Me.BtnAddCoupon.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnAddCoupon.IdleForecolor = System.Drawing.Color.White
        Me.BtnAddCoupon.IdleLineColor = System.Drawing.Color.Lavender
        Me.BtnAddCoupon.Location = New System.Drawing.Point(390, 234)
        Me.BtnAddCoupon.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAddCoupon.Name = "BtnAddCoupon"
        Me.BtnAddCoupon.Size = New System.Drawing.Size(134, 50)
        Me.BtnAddCoupon.TabIndex = 53
        Me.BtnAddCoupon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(121, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cupones guardados"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbltitle.Location = New System.Drawing.Point(219, 15)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(106, 16)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "Crear Cupones"
        '
        'FormCoupons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SmartPick.My.Resources.Resources.MANDALAS2
        Me.ClientSize = New System.Drawing.Size(626, 590)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCoupons"
        Me.Text = "FormCoupons"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BunifuCards1.ResumeLayout(False)
        CType(Me.dgvCoupons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents dgvCoupons As DataGridView
    Friend WithEvents BtnCancel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnDelCoupon As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnAddCoupon As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label1 As Label
    Friend WithEvents lbltitle As Label
    Private WithEvents txtPercentage As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Private WithEvents txtCoupon As MetroFramework.Controls.MetroTextBox
End Class
