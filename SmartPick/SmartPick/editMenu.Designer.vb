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
        Me.DatagridMenu = New System.Windows.Forms.DataGridView()
        Me.BtnOkload = New System.Windows.Forms.Button()
        Me.selecIdiom = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PicBox = New System.Windows.Forms.PictureBox()
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
        Me.DatagridMenu.Location = New System.Drawing.Point(12, 138)
        Me.DatagridMenu.Name = "DatagridMenu"
        Me.DatagridMenu.ReadOnly = True
        Me.DatagridMenu.RowTemplate.Height = 24
        Me.DatagridMenu.Size = New System.Drawing.Size(602, 425)
        Me.DatagridMenu.TabIndex = 0
        '
        'BtnOkload
        '
        Me.BtnOkload.Location = New System.Drawing.Point(339, 60)
        Me.BtnOkload.Name = "BtnOkload"
        Me.BtnOkload.Size = New System.Drawing.Size(106, 25)
        Me.BtnOkload.TabIndex = 6
        Me.BtnOkload.Text = "Ok"
        Me.BtnOkload.UseVisualStyleBackColor = True
        '
        'selecIdiom
        '
        Me.selecIdiom.FormattingEnabled = True
        Me.selecIdiom.Items.AddRange(New Object() {"Español", "Inglés"})
        Me.selecIdiom.Location = New System.Drawing.Point(12, 61)
        Me.selecIdiom.Name = "selecIdiom"
        Me.selecIdiom.Size = New System.Drawing.Size(306, 24)
        Me.selecIdiom.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Selecciona el idioma a mostar:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(672, 479)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 17)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Calorias del Plato:"
        '
        'txtCal
        '
        Me.txtCal.Location = New System.Drawing.Point(675, 499)
        Me.txtCal.Name = "txtCal"
        Me.txtCal.Size = New System.Drawing.Size(268, 22)
        Me.txtCal.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(988, 296)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 17)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Imagen del Plato:"
        '
        'PicBox
        '
        Me.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBox.Location = New System.Drawing.Point(979, 334)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(280, 207)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox.TabIndex = 27
        Me.PicBox.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(672, 412)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 17)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Precio del Plato:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(672, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Tipo de comida:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(672, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 17)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Categoría del Plato:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(675, 432)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(268, 22)
        Me.txtPrecio.TabIndex = 23
        '
        'CombComida
        '
        Me.CombComida.FormattingEnabled = True
        Me.CombComida.Items.AddRange(New Object() {"Sopa"})
        Me.CombComida.Location = New System.Drawing.Point(675, 372)
        Me.CombComida.Name = "CombComida"
        Me.CombComida.Size = New System.Drawing.Size(268, 24)
        Me.CombComida.TabIndex = 22
        '
        'CombCate
        '
        Me.CombCate.FormattingEnabled = True
        Me.CombCate.Items.AddRange(New Object() {"Plato Fuerte "})
        Me.CombCate.Location = New System.Drawing.Point(675, 309)
        Me.CombCate.Name = "CombCate"
        Me.CombCate.Size = New System.Drawing.Size(268, 24)
        Me.CombCate.TabIndex = 21
        '
        'txtrandom
        '
        Me.txtrandom.Location = New System.Drawing.Point(661, 62)
        Me.txtrandom.Multiline = True
        Me.txtrandom.Name = "txtrandom"
        Me.txtrandom.Size = New System.Drawing.Size(157, 28)
        Me.txtrandom.TabIndex = 39
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(658, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 17)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Codigo del Plato:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(988, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(206, 17)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Descripción del Plato en Inglés:"
        '
        'txtDesIng
        '
        Me.txtDesIng.Location = New System.Drawing.Point(991, 138)
        Me.txtDesIng.Multiline = True
        Me.txtDesIng.Name = "txtDesIng"
        Me.txtDesIng.Size = New System.Drawing.Size(268, 120)
        Me.txtDesIng.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(662, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 17)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Descripción del Plato:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(988, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Nombre del Plato:"
        '
        'TxtDesEsp
        '
        Me.TxtDesEsp.Location = New System.Drawing.Point(665, 138)
        Me.TxtDesEsp.Multiline = True
        Me.TxtDesEsp.Name = "TxtDesEsp"
        Me.TxtDesEsp.Size = New System.Drawing.Size(268, 120)
        Me.TxtDesEsp.TabIndex = 33
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(991, 62)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(268, 22)
        Me.txtNombre.TabIndex = 32
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Location = New System.Drawing.Point(716, 569)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(173, 50)
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
        Me.BtnBuscar.Location = New System.Drawing.Point(1111, 291)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(86, 28)
        Me.BtnBuscar.TabIndex = 29
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnDespejar
        '
        Me.BtnDespejar.Location = New System.Drawing.Point(966, 569)
        Me.BtnDespejar.Name = "BtnDespejar"
        Me.BtnDespejar.Size = New System.Drawing.Size(124, 50)
        Me.BtnDespejar.TabIndex = 41
        Me.BtnDespejar.Text = "Despejar"
        Me.BtnDespejar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(184, 17)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Seleccione el Plato a editar:"
        '
        'editMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1303, 631)
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
        Me.Controls.Add(Me.BtnOkload)
        Me.Controls.Add(Me.selecIdiom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DatagridMenu)
        Me.Name = "editMenu"
        Me.Text = "editMenu"
        CType(Me.DatagridMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatagridMenu As DataGridView
    Friend WithEvents BtnOkload As Button
    Friend WithEvents selecIdiom As ComboBox
    Friend WithEvents Label1 As Label
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
End Class
