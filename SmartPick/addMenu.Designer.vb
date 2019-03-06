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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addMenu))
        Me.DataGridMenu = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.selecIdiom = New System.Windows.Forms.ComboBox()
        Me.BtnOkload = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.TxtDesEsp = New System.Windows.Forms.TextBox()
        Me.CombCate = New System.Windows.Forms.ComboBox()
        Me.CombComida = New System.Windows.Forms.ComboBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDesIng = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCal = New System.Windows.Forms.TextBox()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtrandom = New System.Windows.Forms.TextBox()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnDespejar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNomEng = New System.Windows.Forms.TextBox()
        Me.PicBox = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridMenu
        '
        Me.DataGridMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMenu.Location = New System.Drawing.Point(9, 89)
        Me.DataGridMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridMenu.Name = "DataGridMenu"
        Me.DataGridMenu.RowTemplate.Height = 24
        Me.DataGridMenu.Size = New System.Drawing.Size(587, 376)
        Me.DataGridMenu.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Selecciona el idioma a mostrar:"
        '
        'selecIdiom
        '
        Me.selecIdiom.FormattingEnabled = True
        Me.selecIdiom.Items.AddRange(New Object() {"Español", "Inglés"})
        Me.selecIdiom.Location = New System.Drawing.Point(11, 51)
        Me.selecIdiom.Margin = New System.Windows.Forms.Padding(2)
        Me.selecIdiom.Name = "selecIdiom"
        Me.selecIdiom.Size = New System.Drawing.Size(230, 21)
        Me.selecIdiom.TabIndex = 2
        '
        'BtnOkload
        '
        Me.BtnOkload.Location = New System.Drawing.Point(256, 50)
        Me.BtnOkload.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnOkload.Name = "BtnOkload"
        Me.BtnOkload.Size = New System.Drawing.Size(80, 20)
        Me.BtnOkload.TabIndex = 3
        Me.BtnOkload.Text = "Ok"
        Me.BtnOkload.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(622, 176)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(202, 20)
        Me.txtNombre.TabIndex = 4
        '
        'TxtDesEsp
        '
        Me.TxtDesEsp.Location = New System.Drawing.Point(622, 231)
        Me.TxtDesEsp.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDesEsp.Multiline = True
        Me.TxtDesEsp.Name = "TxtDesEsp"
        Me.TxtDesEsp.Size = New System.Drawing.Size(202, 98)
        Me.TxtDesEsp.TabIndex = 5
        '
        'CombCate
        '
        Me.CombCate.FormattingEnabled = True
        Me.CombCate.Items.AddRange(New Object() {"Plato Fuerte", "Entrada", "Bebidas", "Postres", "Para Compartir"})
        Me.CombCate.Location = New System.Drawing.Point(629, 360)
        Me.CombCate.Margin = New System.Windows.Forms.Padding(2)
        Me.CombCate.Name = "CombCate"
        Me.CombCate.Size = New System.Drawing.Size(202, 21)
        Me.CombCate.TabIndex = 6
        '
        'CombComida
        '
        Me.CombComida.FormattingEnabled = True
        Me.CombComida.Items.AddRange(New Object() {"Sopa", "Mariscos", "Tacos", "Carnes", "Vegetariano", "Nachos", "Bebida Natural", "Gaseosa", "Con Alcohol", "Postre", "Para Compartir"})
        Me.CombComida.Location = New System.Drawing.Point(629, 411)
        Me.CombComida.Margin = New System.Windows.Forms.Padding(2)
        Me.CombComida.Name = "CombComida"
        Me.CombComida.Size = New System.Drawing.Size(202, 21)
        Me.CombComida.TabIndex = 7
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(629, 461)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(202, 20)
        Me.txtPrecio.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(620, 151)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre del item en español:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(620, 214)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Descripción del item:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(627, 344)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Categoría del item:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(627, 396)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Tipo de comida:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(627, 444)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Precio del item:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(864, 214)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Descripción del item en Inglés:"
        '
        'txtDesIng
        '
        Me.txtDesIng.Location = New System.Drawing.Point(857, 231)
        Me.txtDesIng.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDesIng.Multiline = True
        Me.txtDesIng.Name = "txtDesIng"
        Me.txtDesIng.Size = New System.Drawing.Size(202, 98)
        Me.txtDesIng.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(864, 349)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Imagen del item:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(956, 345)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(64, 23)
        Me.BtnBuscar.TabIndex = 18
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(627, 498)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Calorias del item:"
        '
        'txtCal
        '
        Me.txtCal.Location = New System.Drawing.Point(629, 514)
        Me.txtCal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCal.Name = "txtCal"
        Me.txtCal.Size = New System.Drawing.Size(202, 20)
        Me.txtCal.TabIndex = 19
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Location = New System.Drawing.Point(644, 578)
        Me.BtnIngresar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(130, 41)
        Me.BtnIngresar.TabIndex = 21
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(623, 81)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Codigo del item:"
        '
        'txtrandom
        '
        Me.txtrandom.Location = New System.Drawing.Point(626, 102)
        Me.txtrandom.Margin = New System.Windows.Forms.Padding(2)
        Me.txtrandom.Multiline = True
        Me.txtrandom.Name = "txtrandom"
        Me.txtrandom.Size = New System.Drawing.Size(119, 24)
        Me.txtrandom.TabIndex = 23
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(748, 102)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(82, 23)
        Me.btnGenerar.TabIndex = 24
        Me.btnGenerar.Text = "Autogenerar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnDespejar
        '
        Me.BtnDespejar.Location = New System.Drawing.Point(895, 578)
        Me.BtnDespejar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDespejar.Name = "BtnDespejar"
        Me.BtnDespejar.Size = New System.Drawing.Size(113, 41)
        Me.BtnDespejar.TabIndex = 25
        Me.BtnDespejar.Text = "Despejar"
        Me.BtnDespejar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(855, 151)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Nombre del item en inglés:"
        '
        'txtNomEng
        '
        Me.txtNomEng.Location = New System.Drawing.Point(857, 176)
        Me.txtNomEng.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNomEng.Name = "txtNomEng"
        Me.txtNomEng.Size = New System.Drawing.Size(202, 20)
        Me.txtNomEng.TabIndex = 26
        '
        'PicBox
        '
        Me.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBox.Location = New System.Drawing.Point(857, 380)
        Me.PicBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(210, 169)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox.TabIndex = 16
        Me.PicBox.TabStop = False
        '
        'addMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 652)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtNomEng)
        Me.Controls.Add(Me.BtnDespejar)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.txtrandom)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCal)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PicBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDesIng)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.CombComida)
        Me.Controls.Add(Me.CombCate)
        Me.Controls.Add(Me.TxtDesEsp)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.BtnOkload)
        Me.Controls.Add(Me.selecIdiom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "addMenu"
        Me.Text = "Agregar al Menu"
        CType(Me.DataGridMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridMenu As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents selecIdiom As ComboBox
    Friend WithEvents BtnOkload As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents TxtDesEsp As TextBox
    Friend WithEvents CombCate As ComboBox
    Friend WithEvents CombComida As ComboBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDesIng As TextBox
    Friend WithEvents PicBox As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCal As TextBox
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtrandom As TextBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BtnDespejar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNomEng As TextBox
End Class
