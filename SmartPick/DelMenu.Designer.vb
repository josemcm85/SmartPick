<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DelMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DelMenu))
        Me.txtrandom = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDesIng = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDesEsp = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.CombComida = New System.Windows.Forms.ComboBox()
        Me.CombCate = New System.Windows.Forms.ComboBox()
        Me.DatagridMenu = New System.Windows.Forms.DataGridView()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNombreIng = New System.Windows.Forms.TextBox()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatagridMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtrandom
        '
        Me.txtrandom.Location = New System.Drawing.Point(661, 38)
        Me.txtrandom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtrandom.Multiline = True
        Me.txtrandom.Name = "txtrandom"
        Me.txtrandom.ReadOnly = True
        Me.txtrandom.Size = New System.Drawing.Size(157, 29)
        Me.txtrandom.TabIndex = 60
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(659, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 17)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Codigo del item:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(988, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 17)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Descripción del item en Inglés:"
        '
        'txtDesIng
        '
        Me.txtDesIng.Location = New System.Drawing.Point(991, 165)
        Me.txtDesIng.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDesIng.Multiline = True
        Me.txtDesIng.Name = "txtDesIng"
        Me.txtDesIng.Size = New System.Drawing.Size(268, 120)
        Me.txtDesIng.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(672, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 17)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Descripción del item:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(674, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 17)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Nombre del item:"
        '
        'TxtDesEsp
        '
        Me.TxtDesEsp.Location = New System.Drawing.Point(675, 165)
        Me.TxtDesEsp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDesEsp.Multiline = True
        Me.TxtDesEsp.Name = "TxtDesEsp"
        Me.TxtDesEsp.Size = New System.Drawing.Size(268, 120)
        Me.TxtDesEsp.TabIndex = 54
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(675, 113)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(268, 22)
        Me.txtNombre.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(988, 302)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 17)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Imagen del item:"
        '
        'PicBox
        '
        Me.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBox.Location = New System.Drawing.Point(991, 321)
        Me.PicBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(279, 208)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox.TabIndex = 50
        Me.PicBox.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(684, 432)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 17)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Precio del item:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(684, 371)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Tipo de comida:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(684, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 17)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Categoría del item:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(687, 453)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(268, 22)
        Me.txtPrecio.TabIndex = 46
        '
        'CombComida
        '
        Me.CombComida.FormattingEnabled = True
        Me.CombComida.Items.AddRange(New Object() {"Sopa", "Mariscos", "Tacos", "Carnes", "Vegetariano", "Untable", "Nachos", "Bebida Natural", "Gaseosa", "Con Alcohol", "Postre", "Para Compartir"})
        Me.CombComida.Location = New System.Drawing.Point(687, 392)
        Me.CombComida.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CombComida.Name = "CombComida"
        Me.CombComida.Size = New System.Drawing.Size(268, 24)
        Me.CombComida.TabIndex = 45
        '
        'CombCate
        '
        Me.CombCate.FormattingEnabled = True
        Me.CombCate.Items.AddRange(New Object() {"Plato Fuerte", "Entrada", "Bebidas", "Postres", "Para Compartir "})
        Me.CombCate.Location = New System.Drawing.Point(687, 330)
        Me.CombCate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CombCate.Name = "CombCate"
        Me.CombCate.Size = New System.Drawing.Size(268, 24)
        Me.CombCate.TabIndex = 44
        '
        'DatagridMenu
        '
        Me.DatagridMenu.AllowUserToAddRows = False
        Me.DatagridMenu.AllowUserToDeleteRows = False
        Me.DatagridMenu.AllowUserToOrderColumns = True
        Me.DatagridMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridMenu.Location = New System.Drawing.Point(12, 60)
        Me.DatagridMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DatagridMenu.Name = "DatagridMenu"
        Me.DatagridMenu.ReadOnly = True
        Me.DatagridMenu.RowTemplate.Height = 24
        Me.DatagridMenu.Size = New System.Drawing.Size(603, 425)
        Me.DatagridMenu.TabIndex = 40
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(701, 564)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(173, 50)
        Me.BtnEliminar.TabIndex = 63
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(680, 487)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 17)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Calorias del item:"
        '
        'txtCal
        '
        Me.txtCal.Location = New System.Drawing.Point(683, 507)
        Me.txtCal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCal.Name = "txtCal"
        Me.txtCal.Size = New System.Drawing.Size(268, 22)
        Me.txtCal.TabIndex = 61
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(192, 17)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Seleccione el item a Eliminar:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(988, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(176, 17)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Nombre del item en inglés:"
        '
        'txtNombreIng
        '
        Me.txtNombreIng.Location = New System.Drawing.Point(991, 113)
        Me.txtNombreIng.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombreIng.Name = "txtNombreIng"
        Me.txtNombreIng.Size = New System.Drawing.Size(268, 22)
        Me.txtNombreIng.TabIndex = 65
        '
        'DelMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1303, 641)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNombreIng)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCal)
        Me.Controls.Add(Me.txtrandom)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDesIng)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDesEsp)
        Me.Controls.Add(Me.txtNombre)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "DelMenu"
        Me.Text = "Borrar del Menu"
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatagridMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtrandom As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDesIng As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtDesEsp As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PicBox As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents CombComida As ComboBox
    Friend WithEvents CombCate As ComboBox
    Friend WithEvents DatagridMenu As DataGridView
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNombreIng As TextBox
End Class
