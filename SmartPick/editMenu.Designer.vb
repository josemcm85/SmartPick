<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editMenu))
        Me.DatagridMenu = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CombComida = New System.Windows.Forms.ComboBox()
        Me.CombCate = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDesIng = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDesEsp = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtCal = New MetroFramework.Controls.MetroTextBox()
        Me.txtPrecio = New MetroFramework.Controls.MetroTextBox()
        Me.txtNombreIng = New MetroFramework.Controls.MetroTextBox()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.txtrandom = New MetroFramework.Controls.MetroTextBox()
        Me.BtnBuscar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnClose3 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnIngresar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnDespejar = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        CType(Me.DatagridMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DatagridMenu
        '
        Me.DatagridMenu.AllowUserToAddRows = False
        Me.DatagridMenu.AllowUserToDeleteRows = False
        Me.DatagridMenu.AllowUserToOrderColumns = True
        Me.DatagridMenu.BackgroundColor = System.Drawing.Color.Snow
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DatagridMenu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DatagridMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DatagridMenu.DefaultCellStyle = DataGridViewCellStyle2
        Me.DatagridMenu.Location = New System.Drawing.Point(0, 2)
        Me.DatagridMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.DatagridMenu.Name = "DatagridMenu"
        Me.DatagridMenu.ReadOnly = True
        Me.DatagridMenu.RowTemplate.Height = 24
        Me.DatagridMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatagridMenu.Size = New System.Drawing.Size(467, 393)
        Me.DatagridMenu.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Snow
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(492, 410)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 16)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "*Calorías del ítem:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Snow
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(790, 252)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 16)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "*Imagen del ítem:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Snow
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(492, 342)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "*Precio del ítem:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Snow
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(521, 315)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "*Tipo de comida:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Snow
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(521, 264)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "*Categoría del ítem:"
        '
        'CombComida
        '
        Me.CombComida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CombComida.FormattingEnabled = True
        Me.CombComida.Items.AddRange(New Object() {"Sopa", "Mariscos", "Tacos", "Carnes", "Vegetariano", "Untable", "Nachos", "Bebida Natural", "Gaseosa", "Con Alcohol", "Postre", "Para Compartir"})
        Me.CombComida.Location = New System.Drawing.Point(494, 305)
        Me.CombComida.Margin = New System.Windows.Forms.Padding(2)
        Me.CombComida.Name = "CombComida"
        Me.CombComida.Size = New System.Drawing.Size(202, 24)
        Me.CombComida.TabIndex = 22
        '
        'CombCate
        '
        Me.CombCate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CombCate.FormattingEnabled = True
        Me.CombCate.Items.AddRange(New Object() {"Plato Fuerte", "Entrada", "Bebidas", "Postres", "Para Compartir"})
        Me.CombCate.Location = New System.Drawing.Point(523, 280)
        Me.CombCate.Margin = New System.Windows.Forms.Padding(2)
        Me.CombCate.Name = "CombCate"
        Me.CombCate.Size = New System.Drawing.Size(202, 24)
        Me.CombCate.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(492, 9)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 16)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "*Código del ítem:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Snow
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(781, 112)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(214, 16)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "*Descripción del ítem en Inglés:"
        '
        'txtDesIng
        '
        Me.txtDesIng.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesIng.Location = New System.Drawing.Point(784, 141)
        Me.txtDesIng.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDesIng.Multiline = True
        Me.txtDesIng.Name = "txtDesIng"
        Me.txtDesIng.Size = New System.Drawing.Size(202, 98)
        Me.txtDesIng.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Snow
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(491, 112)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Descripción del ítem:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(492, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "*Nombre del item:"
        '
        'TxtDesEsp
        '
        Me.TxtDesEsp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesEsp.Location = New System.Drawing.Point(494, 130)
        Me.TxtDesEsp.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDesEsp.Multiline = True
        Me.TxtDesEsp.Name = "TxtDesEsp"
        Me.TxtDesEsp.Size = New System.Drawing.Size(202, 98)
        Me.TxtDesEsp.TabIndex = 33
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(8, 46)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(186, 16)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Seleccione el ítem a editar:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(781, 65)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(189, 16)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "*Nombre del ítem en inglés:"
        '
        'PicBox
        '
        Me.PicBox.BackColor = System.Drawing.Color.White
        Me.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBox.Location = New System.Drawing.Point(784, 287)
        Me.PicBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(210, 169)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox.TabIndex = 27
        Me.PicBox.TabStop = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TxtDesEsp)
        Me.Panel1.Controls.Add(Me.PicBox)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.CombComida)
        Me.Panel1.Controls.Add(Me.txtDesIng)
        Me.Panel1.Controls.Add(Me.txtCal)
        Me.Panel1.Controls.Add(Me.txtPrecio)
        Me.Panel1.Controls.Add(Me.txtNombreIng)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtrandom)
        Me.Panel1.Controls.Add(Me.BtnBuscar)
        Me.Panel1.Controls.Add(Me.BtnClose3)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.BtnIngresar)
        Me.Panel1.Controls.Add(Me.BtnDespejar)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.BunifuCards1)
        Me.Panel1.Location = New System.Drawing.Point(29, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1052, 594)
        Me.Panel1.TabIndex = 69
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(958, 540)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 42)
        Me.Button1.TabIndex = 78
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.txtCal.Location = New System.Drawing.Point(494, 433)
        Me.txtCal.MaxLength = 32767
        Me.txtCal.Name = "txtCal"
        Me.txtCal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCal.SelectedText = ""
        Me.txtCal.SelectionLength = 0
        Me.txtCal.SelectionStart = 0
        Me.txtCal.ShortcutsEnabled = True
        Me.txtCal.Size = New System.Drawing.Size(191, 23)
        Me.txtCal.TabIndex = 76
        Me.txtCal.UseSelectable = True
        Me.txtCal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtPrecio.Location = New System.Drawing.Point(494, 361)
        Me.txtPrecio.MaxLength = 32767
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrecio.SelectedText = ""
        Me.txtPrecio.SelectionLength = 0
        Me.txtPrecio.SelectionStart = 0
        Me.txtPrecio.ShortcutsEnabled = True
        Me.txtPrecio.Size = New System.Drawing.Size(191, 23)
        Me.txtPrecio.TabIndex = 75
        Me.txtPrecio.UseSelectable = True
        Me.txtPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrecio.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtNombreIng
        '
        Me.txtNombreIng.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtNombreIng.CustomButton.Image = Nothing
        Me.txtNombreIng.CustomButton.Location = New System.Drawing.Point(168, 1)
        Me.txtNombreIng.CustomButton.Name = ""
        Me.txtNombreIng.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNombreIng.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombreIng.CustomButton.TabIndex = 1
        Me.txtNombreIng.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombreIng.CustomButton.UseSelectable = True
        Me.txtNombreIng.CustomButton.Visible = False
        Me.txtNombreIng.DisplayIcon = True
        Me.txtNombreIng.Icon = Global.SmartPick.My.Resources.Resources.icons8_language_48px_1
        Me.txtNombreIng.IconRight = True
        Me.txtNombreIng.Lines = New String(-1) {}
        Me.txtNombreIng.Location = New System.Drawing.Point(784, 84)
        Me.txtNombreIng.MaxLength = 32767
        Me.txtNombreIng.Name = "txtNombreIng"
        Me.txtNombreIng.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombreIng.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombreIng.SelectedText = ""
        Me.txtNombreIng.SelectionLength = 0
        Me.txtNombreIng.SelectionStart = 0
        Me.txtNombreIng.ShortcutsEnabled = True
        Me.txtNombreIng.Size = New System.Drawing.Size(190, 23)
        Me.txtNombreIng.TabIndex = 74
        Me.txtNombreIng.UseSelectable = True
        Me.txtNombreIng.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombreIng.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.txtNombre.Location = New System.Drawing.Point(494, 86)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.SelectionLength = 0
        Me.txtNombre.SelectionStart = 0
        Me.txtNombre.ShortcutsEnabled = True
        Me.txtNombre.Size = New System.Drawing.Size(190, 23)
        Me.txtNombre.TabIndex = 73
        Me.txtNombre.UseSelectable = True
        Me.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtrandom
        '
        Me.txtrandom.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtrandom.CustomButton.Image = Nothing
        Me.txtrandom.CustomButton.Location = New System.Drawing.Point(98, 1)
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
        Me.txtrandom.Location = New System.Drawing.Point(494, 28)
        Me.txtrandom.MaxLength = 32767
        Me.txtrandom.Name = "txtrandom"
        Me.txtrandom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtrandom.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtrandom.SelectedText = ""
        Me.txtrandom.SelectionLength = 0
        Me.txtrandom.SelectionStart = 0
        Me.txtrandom.ShortcutsEnabled = True
        Me.txtrandom.Size = New System.Drawing.Size(120, 23)
        Me.txtrandom.TabIndex = 72
        Me.txtrandom.UseSelectable = True
        Me.txtrandom.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtrandom.WaterMarkFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BtnBuscar.Location = New System.Drawing.Point(932, 236)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(54, 42)
        Me.BtnBuscar.TabIndex = 70
        Me.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnClose3
        '
        Me.BtnClose3.ActiveBorderThickness = 1
        Me.BtnClose3.ActiveCornerRadius = 7
        Me.BtnClose3.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnClose3.ActiveForecolor = System.Drawing.Color.White
        Me.BtnClose3.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnClose3.BackColor = System.Drawing.Color.Snow
        Me.BtnClose3.BackgroundImage = CType(resources.GetObject("BtnClose3.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose3.ButtonText = "Cerrar"
        Me.BtnClose3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose3.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnClose3.IdleBorderThickness = 1
        Me.BtnClose3.IdleCornerRadius = 7
        Me.BtnClose3.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnClose3.IdleForecolor = System.Drawing.Color.White
        Me.BtnClose3.IdleLineColor = System.Drawing.Color.Lavender
        Me.BtnClose3.Location = New System.Drawing.Point(869, 474)
        Me.BtnClose3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnClose3.Name = "BtnClose3"
        Me.BtnClose3.Size = New System.Drawing.Size(134, 50)
        Me.BtnClose3.TabIndex = 71
        Me.BtnClose3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.BtnIngresar.ButtonText = "Editar"
        Me.BtnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIngresar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnIngresar.IdleBorderThickness = 1
        Me.BtnIngresar.IdleCornerRadius = 7
        Me.BtnIngresar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnIngresar.IdleForecolor = System.Drawing.Color.White
        Me.BtnIngresar.IdleLineColor = System.Drawing.Color.Lavender
        Me.BtnIngresar.Location = New System.Drawing.Point(469, 474)
        Me.BtnIngresar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(134, 50)
        Me.BtnIngresar.TabIndex = 70
        Me.BtnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.BtnDespejar.ButtonText = "Despejar"
        Me.BtnDespejar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDespejar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDespejar.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnDespejar.IdleBorderThickness = 1
        Me.BtnDespejar.IdleCornerRadius = 7
        Me.BtnDespejar.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnDespejar.IdleForecolor = System.Drawing.Color.White
        Me.BtnDespejar.IdleLineColor = System.Drawing.Color.Lavender
        Me.BtnDespejar.Location = New System.Drawing.Point(669, 474)
        Me.BtnDespejar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnDespejar.Name = "BtnDespejar"
        Me.BtnDespejar.Size = New System.Drawing.Size(134, 50)
        Me.BtnDespejar.TabIndex = 69
        Me.BtnDespejar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.Snow
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Tomato
        Me.BunifuCards1.Controls.Add(Me.DatagridMenu)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(3, 69)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(469, 397)
        Me.BunifuCards1.TabIndex = 77
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 20
        Me.BunifuElipse2.TargetControl = Me.Panel1
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'editMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SmartPick.My.Resources.Resources.MANDALAS2
        Me.ClientSize = New System.Drawing.Size(1112, 648)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CombCate)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "editMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editar Menu"
        CType(Me.DatagridMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BunifuCards1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatagridMenu As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PicBox As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CombComida As ComboBox
    Friend WithEvents CombCate As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDesIng As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDesEsp As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnIngresar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnDespejar As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnClose3 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnBuscar As Bunifu.Framework.UI.BunifuThinButton2
    Private WithEvents txtrandom As MetroFramework.Controls.MetroTextBox
    Private WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Private WithEvents txtNombreIng As MetroFramework.Controls.MetroTextBox
    Private WithEvents txtPrecio As MetroFramework.Controls.MetroTextBox
    Private WithEvents txtCal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Button1 As Button
End Class
