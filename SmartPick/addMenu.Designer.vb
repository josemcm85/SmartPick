<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addMenu))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonClose = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnDespejar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnIngresar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnBuscar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnGenerar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnOkload = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.DataGridMenu = New System.Windows.Forms.DataGridView()
        Me.selecIdiom = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecio = New MetroFramework.Controls.MetroTextBox()
        Me.txtCal = New MetroFramework.Controls.MetroTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDesEsp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.CombCate = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.txtNomENG = New MetroFramework.Controls.MetroTextBox()
        Me.txtrandom = New MetroFramework.Controls.MetroTextBox()
        Me.txtDesIng = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CombComida = New System.Windows.Forms.ComboBox()
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.DataGridMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 20
        Me.BunifuElipse2.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.ButtonClose)
        Me.Panel1.Controls.Add(Me.BtnDespejar)
        Me.Panel1.Controls.Add(Me.BtnIngresar)
        Me.Panel1.Controls.Add(Me.BtnBuscar)
        Me.Panel1.Controls.Add(Me.btnGenerar)
        Me.Panel1.Controls.Add(Me.BtnOkload)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.BunifuSeparator1)
        Me.Panel1.Controls.Add(Me.BunifuCards1)
        Me.Panel1.Controls.Add(Me.selecIdiom)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtPrecio)
        Me.Panel1.Controls.Add(Me.txtCal)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TxtDesEsp)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.CombCate)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PicBox)
        Me.Panel1.Controls.Add(Me.txtNomENG)
        Me.Panel1.Controls.Add(Me.txtrandom)
        Me.Panel1.Controls.Add(Me.txtDesIng)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.CombComida)
        Me.Panel1.Location = New System.Drawing.Point(23, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1160, 628)
        Me.Panel1.TabIndex = 45
        '
        'ButtonClose
        '
        Me.ButtonClose.ActiveBorderThickness = 1
        Me.ButtonClose.ActiveCornerRadius = 7
        Me.ButtonClose.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ButtonClose.ActiveForecolor = System.Drawing.Color.White
        Me.ButtonClose.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ButtonClose.BackColor = System.Drawing.Color.Snow
        Me.ButtonClose.BackgroundImage = CType(resources.GetObject("ButtonClose.BackgroundImage"), System.Drawing.Image)
        Me.ButtonClose.ButtonText = "CERRAR"
        Me.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClose.ForeColor = System.Drawing.Color.SeaGreen
        Me.ButtonClose.IdleBorderThickness = 1
        Me.ButtonClose.IdleCornerRadius = 7
        Me.ButtonClose.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.ButtonClose.IdleForecolor = System.Drawing.Color.White
        Me.ButtonClose.IdleLineColor = System.Drawing.Color.Lavender
        Me.ButtonClose.Location = New System.Drawing.Point(1011, 552)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(134, 50)
        Me.ButtonClose.TabIndex = 54
        Me.ButtonClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnDespejar
        '
        Me.BtnDespejar.ActiveBorderThickness = 1
        Me.BtnDespejar.ActiveCornerRadius = 7
        Me.BtnDespejar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnDespejar.ActiveForecolor = System.Drawing.Color.White
        Me.BtnDespejar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnDespejar.BackColor = System.Drawing.Color.Snow
        Me.BtnDespejar.BackgroundImage = CType(resources.GetObject("BtnDespejar.BackgroundImage"), System.Drawing.Image)
        Me.BtnDespejar.ButtonText = "DESPEJAR"
        Me.BtnDespejar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDespejar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDespejar.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnDespejar.IdleBorderThickness = 1
        Me.BtnDespejar.IdleCornerRadius = 7
        Me.BtnDespejar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnDespejar.IdleForecolor = System.Drawing.Color.White
        Me.BtnDespejar.IdleLineColor = System.Drawing.Color.Lavender
        Me.BtnDespejar.Location = New System.Drawing.Point(851, 552)
        Me.BtnDespejar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnDespejar.Name = "BtnDespejar"
        Me.BtnDespejar.Size = New System.Drawing.Size(134, 50)
        Me.BtnDespejar.TabIndex = 53
        Me.BtnDespejar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnIngresar
        '
        Me.BtnIngresar.ActiveBorderThickness = 1
        Me.BtnIngresar.ActiveCornerRadius = 7
        Me.BtnIngresar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnIngresar.ActiveForecolor = System.Drawing.Color.White
        Me.BtnIngresar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnIngresar.BackColor = System.Drawing.Color.Snow
        Me.BtnIngresar.BackgroundImage = CType(resources.GetObject("BtnIngresar.BackgroundImage"), System.Drawing.Image)
        Me.BtnIngresar.ButtonText = "INGRESAR"
        Me.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIngresar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnIngresar.IdleBorderThickness = 1
        Me.BtnIngresar.IdleCornerRadius = 7
        Me.BtnIngresar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnIngresar.IdleForecolor = System.Drawing.Color.White
        Me.BtnIngresar.IdleLineColor = System.Drawing.Color.Lavender
        Me.BtnIngresar.Location = New System.Drawing.Point(681, 552)
        Me.BtnIngresar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(134, 50)
        Me.BtnIngresar.TabIndex = 52
        Me.BtnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnBuscar
        '
        Me.BtnBuscar.ActiveBorderThickness = 1
        Me.BtnBuscar.ActiveCornerRadius = 30
        Me.BtnBuscar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnBuscar.ActiveForecolor = System.Drawing.Color.White
        Me.BtnBuscar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnBuscar.BackColor = System.Drawing.Color.Snow
        Me.BtnBuscar.BackgroundImage = CType(resources.GetObject("BtnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.BtnBuscar.ButtonText = "Buscar"
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnBuscar.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnBuscar.IdleBorderThickness = 1
        Me.BtnBuscar.IdleCornerRadius = 30
        Me.BtnBuscar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnBuscar.IdleForecolor = System.Drawing.Color.White
        Me.BtnBuscar.IdleLineColor = System.Drawing.Color.Lavender
        Me.BtnBuscar.Location = New System.Drawing.Point(1054, 493)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(68, 42)
        Me.BtnBuscar.TabIndex = 51
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGenerar
        '
        Me.btnGenerar.ActiveBorderThickness = 1
        Me.btnGenerar.ActiveCornerRadius = 30
        Me.btnGenerar.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnGenerar.ActiveForecolor = System.Drawing.Color.White
        Me.btnGenerar.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnGenerar.BackColor = System.Drawing.Color.Snow
        Me.btnGenerar.BackgroundImage = CType(resources.GetObject("btnGenerar.BackgroundImage"), System.Drawing.Image)
        Me.btnGenerar.ButtonText = "Generar"
        Me.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerar.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnGenerar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnGenerar.IdleBorderThickness = 1
        Me.btnGenerar.IdleCornerRadius = 30
        Me.btnGenerar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnGenerar.IdleForecolor = System.Drawing.Color.White
        Me.btnGenerar.IdleLineColor = System.Drawing.Color.Lavender
        Me.btnGenerar.Location = New System.Drawing.Point(816, 50)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(78, 42)
        Me.btnGenerar.TabIndex = 50
        Me.btnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnOkload
        '
        Me.BtnOkload.ActiveBorderThickness = 1
        Me.BtnOkload.ActiveCornerRadius = 30
        Me.BtnOkload.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnOkload.ActiveForecolor = System.Drawing.Color.White
        Me.BtnOkload.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnOkload.BackColor = System.Drawing.Color.Snow
        Me.BtnOkload.BackgroundImage = CType(resources.GetObject("BtnOkload.BackgroundImage"), System.Drawing.Image)
        Me.BtnOkload.ButtonText = "Ok"
        Me.BtnOkload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOkload.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOkload.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnOkload.IdleBorderThickness = 1
        Me.BtnOkload.IdleCornerRadius = 30
        Me.BtnOkload.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnOkload.IdleForecolor = System.Drawing.Color.White
        Me.BtnOkload.IdleLineColor = System.Drawing.Color.Lavender
        Me.BtnOkload.Location = New System.Drawing.Point(274, 46)
        Me.BtnOkload.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnOkload.Name = "BtnOkload"
        Me.BtnOkload.Size = New System.Drawing.Size(80, 41)
        Me.BtnOkload.TabIndex = 49
        Me.BtnOkload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(678, 32)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(122, 16)
        Me.BunifuCustomLabel1.TabIndex = 47
        Me.BunifuCustomLabel1.Text = "Código del ítem:*"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(654, 31)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(23, 560)
        Me.BunifuSeparator1.TabIndex = 46
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Tomato
        Me.BunifuCards1.Controls.Add(Me.DataGridMenu)
        Me.BunifuCards1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCards1.LeftSahddow = True
        Me.BunifuCards1.Location = New System.Drawing.Point(26, 101)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(611, 462)
        Me.BunifuCards1.TabIndex = 45
        '
        'DataGridMenu
        '
        Me.DataGridMenu.AllowUserToAddRows = False
        Me.DataGridMenu.AllowUserToDeleteRows = False
        Me.DataGridMenu.AllowUserToOrderColumns = True
        Me.DataGridMenu.BackgroundColor = System.Drawing.Color.Snow
        Me.DataGridMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMenu.Location = New System.Drawing.Point(0, 2)
        Me.DataGridMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridMenu.Name = "DataGridMenu"
        Me.DataGridMenu.ReadOnly = True
        Me.DataGridMenu.RowTemplate.Height = 24
        Me.DataGridMenu.Size = New System.Drawing.Size(612, 459)
        Me.DataGridMenu.TabIndex = 0
        '
        'selecIdiom
        '
        Me.selecIdiom.FormattingEnabled = True
        Me.selecIdiom.Items.AddRange(New Object() {"Español", "Inglés"})
        Me.selecIdiom.Location = New System.Drawing.Point(26, 58)
        Me.selecIdiom.Margin = New System.Windows.Forms.Padding(2)
        Me.selecIdiom.Name = "selecIdiom"
        Me.selecIdiom.Size = New System.Drawing.Size(230, 21)
        Me.selecIdiom.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Selecciona el idioma a mostrar:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(678, 296)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Categoría del ítem:*"
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPrecio.CustomButton.Image = Nothing
        Me.txtPrecio.CustomButton.Location = New System.Drawing.Point(169, 1)
        Me.txtPrecio.CustomButton.Name = ""
        Me.txtPrecio.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPrecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrecio.CustomButton.TabIndex = 1
        Me.txtPrecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrecio.CustomButton.UseSelectable = True
        Me.txtPrecio.CustomButton.Visible = False
        Me.txtPrecio.DisplayIcon = True
        Me.txtPrecio.Icon = Global.SmartPick.My.Resources.Resources.icons8_cheap_2_48px_3
        Me.txtPrecio.IconRight = True
        Me.txtPrecio.Lines = New String(-1) {}
        Me.txtPrecio.Location = New System.Drawing.Point(692, 445)
        Me.txtPrecio.MaxLength = 32767
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrecio.SelectedText = ""
        Me.txtPrecio.SelectionLength = 0
        Me.txtPrecio.SelectionStart = 0
        Me.txtPrecio.ShortcutsEnabled = True
        Me.txtPrecio.Size = New System.Drawing.Size(191, 23)
        Me.txtPrecio.TabIndex = 37
        Me.txtPrecio.UseSelectable = True
        Me.txtPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrecio.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCal
        '
        Me.txtCal.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtCal.CustomButton.Image = Nothing
        Me.txtCal.CustomButton.Location = New System.Drawing.Point(169, 1)
        Me.txtCal.CustomButton.Name = ""
        Me.txtCal.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCal.CustomButton.TabIndex = 1
        Me.txtCal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCal.CustomButton.UseSelectable = True
        Me.txtCal.CustomButton.Visible = False
        Me.txtCal.DisplayIcon = True
        Me.txtCal.Icon = Global.SmartPick.My.Resources.Resources.icons8_caloric_energy_50px_11
        Me.txtCal.IconRight = True
        Me.txtCal.Lines = New String(-1) {}
        Me.txtCal.Location = New System.Drawing.Point(694, 508)
        Me.txtCal.MaxLength = 32767
        Me.txtCal.Name = "txtCal"
        Me.txtCal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCal.SelectedText = ""
        Me.txtCal.SelectionLength = 0
        Me.txtCal.SelectionStart = 0
        Me.txtCal.ShortcutsEnabled = True
        Me.txtCal.Size = New System.Drawing.Size(191, 23)
        Me.txtCal.TabIndex = 40
        Me.txtCal.UseSelectable = True
        Me.txtCal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(679, 357)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Tipo de comida:*"
        '
        'TxtDesEsp
        '
        Me.TxtDesEsp.BackColor = System.Drawing.Color.White
        Me.TxtDesEsp.Location = New System.Drawing.Point(691, 185)
        Me.TxtDesEsp.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDesEsp.Multiline = True
        Me.TxtDesEsp.Name = "TxtDesEsp"
        Me.TxtDesEsp.Size = New System.Drawing.Size(190, 98)
        Me.TxtDesEsp.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(679, 158)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Descripción del ítem:*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(918, 95)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(189, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Nombre del ítem en inglés:*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(679, 481)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 16)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Calorías del ítem:*"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNombre.CustomButton.Image = Nothing
        Me.txtNombre.CustomButton.Location = New System.Drawing.Point(168, 1)
        Me.txtNombre.CustomButton.Name = ""
        Me.txtNombre.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombre.CustomButton.TabIndex = 1
        Me.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombre.CustomButton.UseSelectable = True
        Me.txtNombre.CustomButton.Visible = False
        Me.txtNombre.DisplayIcon = True
        Me.txtNombre.Icon = Global.SmartPick.My.Resources.Resources.icons8_language_48px_1
        Me.txtNombre.IconRight = True
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(692, 122)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.SelectionLength = 0
        Me.txtNombre.SelectionStart = 0
        Me.txtNombre.ShortcutsEnabled = True
        Me.txtNombre.Size = New System.Drawing.Size(190, 23)
        Me.txtNombre.TabIndex = 41
        Me.txtNombre.UseSelectable = True
        Me.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'CombCate
        '
        Me.CombCate.BackColor = System.Drawing.Color.White
        Me.CombCate.FormattingEnabled = True
        Me.CombCate.Items.AddRange(New Object() {"Plato Fuerte", "Entrada", "Bebidas", "Postres", "Para Compartir"})
        Me.CombCate.Location = New System.Drawing.Point(693, 323)
        Me.CombCate.Margin = New System.Windows.Forms.Padding(2)
        Me.CombCate.Name = "CombCate"
        Me.CombCate.Size = New System.Drawing.Size(190, 21)
        Me.CombCate.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(679, 418)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Precio del ítem:*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(918, 296)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Imagen del ítem:*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(678, 95)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre del ítem en español:*"
        '
        'PicBox
        '
        Me.PicBox.BackColor = System.Drawing.Color.White
        Me.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBox.Location = New System.Drawing.Point(933, 323)
        Me.PicBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(190, 169)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox.TabIndex = 16
        Me.PicBox.TabStop = False
        '
        'txtNomENG
        '
        Me.txtNomENG.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNomENG.CustomButton.Image = Nothing
        Me.txtNomENG.CustomButton.Location = New System.Drawing.Point(168, 1)
        Me.txtNomENG.CustomButton.Name = ""
        Me.txtNomENG.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNomENG.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNomENG.CustomButton.TabIndex = 1
        Me.txtNomENG.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNomENG.CustomButton.UseSelectable = True
        Me.txtNomENG.CustomButton.Visible = False
        Me.txtNomENG.DisplayIcon = True
        Me.txtNomENG.Icon = Global.SmartPick.My.Resources.Resources.icons8_language_48px_1
        Me.txtNomENG.IconRight = True
        Me.txtNomENG.Lines = New String(-1) {}
        Me.txtNomENG.Location = New System.Drawing.Point(933, 122)
        Me.txtNomENG.MaxLength = 32767
        Me.txtNomENG.Name = "txtNomENG"
        Me.txtNomENG.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNomENG.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNomENG.SelectedText = ""
        Me.txtNomENG.SelectionLength = 0
        Me.txtNomENG.SelectionStart = 0
        Me.txtNomENG.ShortcutsEnabled = True
        Me.txtNomENG.Size = New System.Drawing.Size(190, 23)
        Me.txtNomENG.TabIndex = 42
        Me.txtNomENG.UseSelectable = True
        Me.txtNomENG.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNomENG.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtrandom
        '
        Me.txtrandom.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtrandom.CustomButton.Image = Nothing
        Me.txtrandom.CustomButton.Location = New System.Drawing.Point(78, 1)
        Me.txtrandom.CustomButton.Name = ""
        Me.txtrandom.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtrandom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtrandom.CustomButton.TabIndex = 1
        Me.txtrandom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtrandom.CustomButton.UseSelectable = True
        Me.txtrandom.CustomButton.Visible = False
        Me.txtrandom.DisplayIcon = True
        Me.txtrandom.Icon = Global.SmartPick.My.Resources.Resources.icons8_price_tag_50px_11
        Me.txtrandom.IconRight = True
        Me.txtrandom.Lines = New String(-1) {}
        Me.txtrandom.Location = New System.Drawing.Point(697, 59)
        Me.txtrandom.MaxLength = 32767
        Me.txtrandom.Name = "txtrandom"
        Me.txtrandom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtrandom.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtrandom.SelectedText = ""
        Me.txtrandom.SelectionLength = 0
        Me.txtrandom.SelectionStart = 0
        Me.txtrandom.ShortcutsEnabled = True
        Me.txtrandom.Size = New System.Drawing.Size(100, 23)
        Me.txtrandom.TabIndex = 43
        Me.txtrandom.UseSelectable = True
        Me.txtrandom.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtrandom.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtDesIng
        '
        Me.txtDesIng.BackColor = System.Drawing.Color.White
        Me.txtDesIng.Location = New System.Drawing.Point(933, 185)
        Me.txtDesIng.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDesIng.Multiline = True
        Me.txtDesIng.Name = "txtDesIng"
        Me.txtDesIng.Size = New System.Drawing.Size(190, 98)
        Me.txtDesIng.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(918, 158)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(214, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Descripción del ítem en Inglés:*"
        '
        'CombComida
        '
        Me.CombComida.BackColor = System.Drawing.Color.White
        Me.CombComida.FormattingEnabled = True
        Me.CombComida.Items.AddRange(New Object() {"Sopa", "Mariscos", "Tacos", "Carnes", "Vegetariano", "Nachos", "Bebida Natural", "Gaseosa", "Con Alcohol", "Postre", "Para Compartir"})
        Me.CombComida.Location = New System.Drawing.Point(691, 384)
        Me.CombComida.Margin = New System.Windows.Forms.Padding(2)
        Me.CombComida.Name = "CombComida"
        Me.CombComida.Size = New System.Drawing.Size(190, 21)
        Me.CombComida.TabIndex = 7
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 20
        Me.BunifuElipse3.TargetControl = Me.Panel1
        '
        'addMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.SmartPick.My.Resources.Resources.MANDALAS21
        Me.ClientSize = New System.Drawing.Size(1208, 675)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "addMenu"
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BunifuCards1.ResumeLayout(False)
        CType(Me.DataGridMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents TxtDesEsp As TextBox
    Friend WithEvents selecIdiom As ComboBox
    Friend WithEvents CombCate As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridMenu As DataGridView
    Friend WithEvents CombComida As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDesIng As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PicBox As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BtnOkload As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnGenerar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnBuscar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnIngresar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnDespejar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents ButtonClose As Bunifu.Framework.UI.BunifuThinButton2
    Private WithEvents txtrandom As MetroFramework.Controls.MetroTextBox
    Private WithEvents txtNomENG As MetroFramework.Controls.MetroTextBox
    Private WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Private WithEvents txtCal As MetroFramework.Controls.MetroTextBox
    Private WithEvents txtPrecio As MetroFramework.Controls.MetroTextBox
End Class
