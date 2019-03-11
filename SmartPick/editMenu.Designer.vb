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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editMenu))
        Me.DatagridMenu = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.CombComida = New System.Windows.Forms.ComboBox()
        Me.CombCate = New System.Windows.Forms.ComboBox()
        Me.txtrandom = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDesIng = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDesEsp = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnDespejar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNombreIng = New System.Windows.Forms.TextBox()
        Me.PicBox = New System.Windows.Forms.PictureBox()
        CType(Me.DatagridMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatagridMenu
        '
        Me.DatagridMenu.AllowUserToAddRows = False
        Me.DatagridMenu.AllowUserToDeleteRows = False
        Me.DatagridMenu.AllowUserToOrderColumns = True
        Me.DatagridMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridMenu.Location = New System.Drawing.Point(9, 50)
        Me.DatagridMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.DatagridMenu.Name = "DatagridMenu"
        Me.DatagridMenu.ReadOnly = True
        Me.DatagridMenu.RowTemplate.Height = 24
        Me.DatagridMenu.Size = New System.Drawing.Size(452, 345)
        Me.DatagridMenu.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(505, 419)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Calorias del item:"
        '
        'txtCal
        '
        Me.txtCal.Location = New System.Drawing.Point(507, 435)
        Me.txtCal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCal.Name = "txtCal"
        Me.txtCal.Size = New System.Drawing.Size(202, 20)
        Me.txtCal.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(751, 269)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Imagen del item:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(505, 365)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Precio del item:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(505, 316)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Tipo de comida:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(505, 265)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Categoría del item:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(507, 381)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(202, 20)
        Me.txtPrecio.TabIndex = 23
        '
        'CombComida
        '
        Me.CombComida.FormattingEnabled = True
        Me.CombComida.Items.AddRange(New Object() {"Sopa", "Mariscos", "Tacos", "Carnes", "Vegetariano", "Untable", "Nachos", "Bebida Natural", "Gaseosa", "Con Alcohol", "Postre", "Para Compartir"})
        Me.CombComida.Location = New System.Drawing.Point(507, 332)
        Me.CombComida.Margin = New System.Windows.Forms.Padding(2)
        Me.CombComida.Name = "CombComida"
        Me.CombComida.Size = New System.Drawing.Size(202, 21)
        Me.CombComida.TabIndex = 22
        '
        'CombCate
        '
        Me.CombCate.FormattingEnabled = True
        Me.CombCate.Items.AddRange(New Object() {"Plato Fuerte", "Entrada", "Bebidas", "Postres", "Para Compartir"})
        Me.CombCate.Location = New System.Drawing.Point(507, 281)
        Me.CombCate.Margin = New System.Windows.Forms.Padding(2)
        Me.CombCate.Name = "CombCate"
        Me.CombCate.Size = New System.Drawing.Size(202, 21)
        Me.CombCate.TabIndex = 21
        '
        'txtrandom
        '
        Me.txtrandom.Location = New System.Drawing.Point(496, 50)
        Me.txtrandom.Margin = New System.Windows.Forms.Padding(2)
        Me.txtrandom.Multiline = True
        Me.txtrandom.Name = "txtrandom"
        Me.txtrandom.ReadOnly = True
        Me.txtrandom.Size = New System.Drawing.Size(119, 24)
        Me.txtrandom.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(494, 29)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Codigo del item:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(742, 141)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Descripción del item en Inglés:"
        '
        'txtDesIng
        '
        Me.txtDesIng.Location = New System.Drawing.Point(744, 158)
        Me.txtDesIng.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDesIng.Multiline = True
        Me.txtDesIng.Name = "txtDesIng"
        Me.txtDesIng.Size = New System.Drawing.Size(202, 98)
        Me.txtDesIng.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(496, 141)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Descripción del item:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(496, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Nombre del item:"
        '
        'TxtDesEsp
        '
        Me.TxtDesEsp.Location = New System.Drawing.Point(500, 158)
        Me.TxtDesEsp.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDesEsp.Multiline = True
        Me.TxtDesEsp.Name = "TxtDesEsp"
        Me.TxtDesEsp.Size = New System.Drawing.Size(202, 98)
        Me.TxtDesEsp.TabIndex = 33
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(499, 112)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(202, 20)
        Me.txtNombre.TabIndex = 32
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Location = New System.Drawing.Point(538, 492)
        Me.BtnIngresar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(130, 41)
        Me.BtnIngresar.TabIndex = 40
        Me.BtnIngresar.Text = "Editar"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(843, 265)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(64, 23)
        Me.BtnBuscar.TabIndex = 29
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnDespejar
        '
        Me.BtnDespejar.Location = New System.Drawing.Point(820, 492)
        Me.BtnDespejar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDespejar.Name = "BtnDespejar"
        Me.BtnDespejar.Size = New System.Drawing.Size(93, 41)
        Me.BtnDespejar.TabIndex = 41
        Me.BtnDespejar.Text = "Despejar"
        Me.BtnDespejar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 31)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 13)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Seleccione el item a editar:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(742, 97)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 13)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Nombre del item en inglés:"
        '
        'txtNombreIng
        '
        Me.txtNombreIng.Location = New System.Drawing.Point(744, 112)
        Me.txtNombreIng.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreIng.Name = "txtNombreIng"
        Me.txtNombreIng.Size = New System.Drawing.Size(202, 20)
        Me.txtNombreIng.TabIndex = 43
        '
        'PicBox
        '
        Me.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBox.Location = New System.Drawing.Point(744, 301)
        Me.PicBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(210, 169)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox.TabIndex = 27
        Me.PicBox.TabStop = False
        '
        'editMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 557)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNombreIng)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BtnDespejar)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.txtrandom)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDesIng)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDesEsp)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCal)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PicBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.CombComida)
        Me.Controls.Add(Me.CombCate)
        Me.Controls.Add(Me.DatagridMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "editMenu"
        Me.Text = "Editar Menu"
        CType(Me.DatagridMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatagridMenu As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PicBox As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents CombComida As ComboBox
    Friend WithEvents CombCate As ComboBox
    Friend WithEvents txtrandom As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDesIng As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDesEsp As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnDespejar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNombreIng As TextBox
End Class
