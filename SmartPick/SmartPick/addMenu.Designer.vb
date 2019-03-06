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
        Me.PicBox = New System.Windows.Forms.PictureBox()
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
        CType(Me.DataGridMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridMenu
        '
        Me.DataGridMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridMenu.Location = New System.Drawing.Point(12, 110)
        Me.DataGridMenu.Name = "DataGridMenu"
        Me.DataGridMenu.RowTemplate.Height = 24
        Me.DataGridMenu.Size = New System.Drawing.Size(783, 463)
        Me.DataGridMenu.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Selecciona el idioma a mostrar:"
        '
        'selecIdiom
        '
        Me.selecIdiom.FormattingEnabled = True
        Me.selecIdiom.Items.AddRange(New Object() {"Español", "Inglés"})
        Me.selecIdiom.Location = New System.Drawing.Point(15, 63)
        Me.selecIdiom.Name = "selecIdiom"
        Me.selecIdiom.Size = New System.Drawing.Size(306, 24)
        Me.selecIdiom.TabIndex = 2
        '
        'BtnOkload
        '
        Me.BtnOkload.Location = New System.Drawing.Point(342, 62)
        Me.BtnOkload.Name = "BtnOkload"
        Me.BtnOkload.Size = New System.Drawing.Size(106, 25)
        Me.BtnOkload.TabIndex = 3
        Me.BtnOkload.Text = "Ok"
        Me.BtnOkload.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(1147, 126)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(268, 22)
        Me.txtNombre.TabIndex = 4
        '
        'TxtDesEsp
        '
        Me.TxtDesEsp.Location = New System.Drawing.Point(821, 202)
        Me.TxtDesEsp.Multiline = True
        Me.TxtDesEsp.Name = "TxtDesEsp"
        Me.TxtDesEsp.Size = New System.Drawing.Size(268, 120)
        Me.TxtDesEsp.TabIndex = 5
        '
        'CombCate
        '
        Me.CombCate.FormattingEnabled = True
        Me.CombCate.Items.AddRange(New Object() {"Plato Fuerte "})
        Me.CombCate.Location = New System.Drawing.Point(831, 386)
        Me.CombCate.Name = "CombCate"
        Me.CombCate.Size = New System.Drawing.Size(268, 24)
        Me.CombCate.TabIndex = 6
        '
        'CombComida
        '
        Me.CombComida.FormattingEnabled = True
        Me.CombComida.Items.AddRange(New Object() {"Sopa"})
        Me.CombComida.Location = New System.Drawing.Point(831, 449)
        Me.CombComida.Name = "CombComida"
        Me.CombComida.Size = New System.Drawing.Size(268, 24)
        Me.CombComida.TabIndex = 7
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(831, 509)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(268, 22)
        Me.txtPrecio.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1144, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre del Plato:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(818, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Descripción del Plato:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(828, 366)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Categoría del Plato:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(828, 429)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Tipo de comida:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(828, 489)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Precio del Plato:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1144, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(206, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Descripción del Plato en Inglés:"
        '
        'txtDesIng
        '
        Me.txtDesIng.Location = New System.Drawing.Point(1147, 202)
        Me.txtDesIng.Multiline = True
        Me.txtDesIng.Name = "txtDesIng"
        Me.txtDesIng.Size = New System.Drawing.Size(268, 120)
        Me.txtDesIng.TabIndex = 14
        '
        'PicBox
        '
        Me.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBox.Location = New System.Drawing.Point(1135, 411)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(280, 207)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox.TabIndex = 16
        Me.PicBox.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1144, 373)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Imagen del Plato:"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(1267, 368)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(86, 28)
        Me.BtnBuscar.TabIndex = 18
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(828, 556)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Calorias del Plato:"
        '
        'txtCal
        '
        Me.txtCal.Location = New System.Drawing.Point(831, 576)
        Me.txtCal.Name = "txtCal"
        Me.txtCal.Size = New System.Drawing.Size(268, 22)
        Me.txtCal.TabIndex = 19
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Location = New System.Drawing.Point(850, 653)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(173, 50)
        Me.BtnIngresar.TabIndex = 21
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(814, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Codigo del Plato:"
        '
        'txtrandom
        '
        Me.txtrandom.Location = New System.Drawing.Point(817, 126)
        Me.txtrandom.Multiline = True
        Me.txtrandom.Name = "txtrandom"
        Me.txtrandom.Size = New System.Drawing.Size(157, 28)
        Me.txtrandom.TabIndex = 23
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(980, 126)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(109, 28)
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
        Me.BtnDespejar.Location = New System.Drawing.Point(1185, 653)
        Me.BtnDespejar.Name = "BtnDespejar"
        Me.BtnDespejar.Size = New System.Drawing.Size(151, 50)
        Me.BtnDespejar.TabIndex = 25
        Me.BtnDespejar.Text = "Despejar"
        Me.BtnDespejar.UseVisualStyleBackColor = True
        '
        'addMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1427, 715)
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
        Me.Name = "addMenu"
        Me.Text = "addMenu"
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
End Class
