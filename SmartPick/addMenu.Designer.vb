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
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.BtnOkload = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.selecIdiom = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecio = New MetroFramework.Controls.MetroTextBox()
        Me.DataGridMenu = New System.Windows.Forms.DataGridView()
        Me.txtCal = New MetroFramework.Controls.MetroTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDesEsp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.CombCate = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnDespejar = New System.Windows.Forms.Button()
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.txtNomENG = New MetroFramework.Controls.MetroTextBox()
        Me.txtrandom = New MetroFramework.Controls.MetroTextBox()
        Me.txtDesIng = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CombComida = New System.Windows.Forms.ComboBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.BunifuElipse3 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards1.SuspendLayout()
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
        Me.Panel1.Controls.Add(Me.BunifuSeparator1)
        Me.Panel1.Controls.Add(Me.BunifuCards1)
        Me.Panel1.Controls.Add(Me.BtnIngresar)
        Me.Panel1.Controls.Add(Me.BtnOkload)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.selecIdiom)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtPrecio)
        Me.Panel1.Controls.Add(Me.txtCal)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TxtDesEsp)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.BtnBuscar)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.CombCate)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnDespejar)
        Me.Panel1.Controls.Add(Me.PicBox)
        Me.Panel1.Controls.Add(Me.txtNomENG)
        Me.Panel1.Controls.Add(Me.txtrandom)
        Me.Panel1.Controls.Add(Me.txtDesIng)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.CombComida)
        Me.Panel1.Controls.Add(Me.btnGenerar)
        Me.Panel1.Location = New System.Drawing.Point(23, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1160, 628)
        Me.Panel1.TabIndex = 45
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Location = New System.Drawing.Point(728, 550)
        Me.BtnIngresar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(130, 41)
        Me.BtnIngresar.TabIndex = 21
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'BtnOkload
        '
        Me.BtnOkload.Location = New System.Drawing.Point(263, 50)
        Me.BtnOkload.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnOkload.Name = "BtnOkload"
        Me.BtnOkload.Size = New System.Drawing.Size(80, 20)
        Me.BtnOkload.TabIndex = 3
        Me.BtnOkload.Text = "Ok"
        Me.BtnOkload.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(691, 38)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Codigo del item:"
        '
        'selecIdiom
        '
        Me.selecIdiom.FormattingEnabled = True
        Me.selecIdiom.Items.AddRange(New Object() {"Español", "Inglés"})
        Me.selecIdiom.Location = New System.Drawing.Point(18, 50)
        Me.selecIdiom.Margin = New System.Windows.Forms.Padding(2)
        Me.selecIdiom.Name = "selecIdiom"
        Me.selecIdiom.Size = New System.Drawing.Size(230, 21)
        Me.selecIdiom.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Selecciona el idioma a mostrar:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(700, 306)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Categoría del item:"
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
        Me.txtPrecio.Location = New System.Drawing.Point(692, 432)
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
        'DataGridMenu
        '
        Me.DataGridMenu.BackgroundColor = System.Drawing.Color.Snow
        Me.DataGridMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMenu.Location = New System.Drawing.Point(0, 2)
        Me.DataGridMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridMenu.Name = "DataGridMenu"
        Me.DataGridMenu.RowTemplate.Height = 24
        Me.DataGridMenu.Size = New System.Drawing.Size(612, 459)
        Me.DataGridMenu.TabIndex = 0
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
        Me.txtCal.Location = New System.Drawing.Point(694, 498)
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
        Me.Label5.Location = New System.Drawing.Point(698, 361)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Tipo de comida:"
        '
        'TxtDesEsp
        '
        Me.TxtDesEsp.BackColor = System.Drawing.Color.White
        Me.TxtDesEsp.Location = New System.Drawing.Point(691, 183)
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
        Me.Label3.Location = New System.Drawing.Point(691, 166)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Descripción del item:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(1028, 301)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(64, 23)
        Me.BtnBuscar.TabIndex = 18
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(932, 103)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Nombre del item en inglés:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(701, 470)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Calorias del item:"
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
        Me.txtNombre.Location = New System.Drawing.Point(692, 128)
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
        Me.CombCate.Location = New System.Drawing.Point(693, 321)
        Me.CombCate.Margin = New System.Windows.Forms.Padding(2)
        Me.CombCate.Name = "CombCate"
        Me.CombCate.Size = New System.Drawing.Size(190, 21)
        Me.CombCate.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(699, 416)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Precio del item:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(936, 305)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Imagen del item:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(691, 103)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre del item en español:"
        '
        'BtnDespejar
        '
        Me.BtnDespejar.Location = New System.Drawing.Point(950, 550)
        Me.BtnDespejar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDespejar.Name = "BtnDespejar"
        Me.BtnDespejar.Size = New System.Drawing.Size(113, 41)
        Me.BtnDespejar.TabIndex = 25
        Me.BtnDespejar.Text = "Despejar"
        Me.BtnDespejar.UseVisualStyleBackColor = True
        '
        'PicBox
        '
        Me.PicBox.BackColor = System.Drawing.Color.White
        Me.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBox.Location = New System.Drawing.Point(934, 337)
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
        Me.txtNomENG.Location = New System.Drawing.Point(934, 128)
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
        Me.txtrandom.Location = New System.Drawing.Point(694, 54)
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
        Me.txtDesIng.Location = New System.Drawing.Point(934, 183)
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
        Me.Label7.Location = New System.Drawing.Point(941, 166)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Descripción del item en Inglés:"
        '
        'CombComida
        '
        Me.CombComida.BackColor = System.Drawing.Color.White
        Me.CombComida.FormattingEnabled = True
        Me.CombComida.Items.AddRange(New Object() {"Sopa", "Mariscos", "Tacos", "Carnes", "Vegetariano", "Nachos", "Bebida Natural", "Gaseosa", "Con Alcohol", "Postre", "Para Compartir"})
        Me.CombComida.Location = New System.Drawing.Point(691, 376)
        Me.CombComida.Margin = New System.Windows.Forms.Padding(2)
        Me.CombComida.Name = "CombComida"
        Me.CombComida.Size = New System.Drawing.Size(190, 21)
        Me.CombComida.TabIndex = 7
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(823, 54)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(83, 23)
        Me.btnGenerar.TabIndex = 24
        Me.btnGenerar.Text = "Autogenerar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'BunifuElipse3
        '
        Me.BunifuElipse3.ElipseRadius = 20
        Me.BunifuElipse3.TargetControl = Me.Panel1
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Tomato
        Me.BunifuCards1.Controls.Add(Me.DataGridMenu)
        Me.BunifuCards1.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuCards1.LeftSahddow = True
        Me.BunifuCards1.Location = New System.Drawing.Point(26, 101)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(611, 462)
        Me.BunifuCards1.TabIndex = 45
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.DimGray
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(654, 31)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(23, 560)
        Me.BunifuSeparator1.TabIndex = 46
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
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
        CType(Me.DataGridMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents BtnOkload As Button
    Friend WithEvents TxtDesEsp As TextBox
    Friend WithEvents selecIdiom As ComboBox
    Friend WithEvents CombCate As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtrandom As MetroFramework.Controls.MetroTextBox
    Friend WithEvents DataGridMenu As DataGridView
    Friend WithEvents CombComida As ComboBox
    Friend WithEvents txtNomENG As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrecio As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnDespejar As Button
    Friend WithEvents txtDesIng As TextBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PicBox As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuElipse3 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
End Class
