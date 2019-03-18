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
        Me.BtnClose2 = New Bunifu.Framework.UI.BunifuThinButton2()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatagridMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtrandom
        '
        Me.txtrandom.Location = New System.Drawing.Point(496, 31)
        Me.txtrandom.Margin = New System.Windows.Forms.Padding(2)
        Me.txtrandom.Multiline = True
        Me.txtrandom.Name = "txtrandom"
        Me.txtrandom.ReadOnly = True
        Me.txtrandom.Size = New System.Drawing.Size(119, 24)
        Me.txtrandom.TabIndex = 60
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(494, 10)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Código del ítem:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(741, 119)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Descripción del ítem en Inglés:"
        '
        'txtDesIng
        '
        Me.txtDesIng.Location = New System.Drawing.Point(743, 134)
        Me.txtDesIng.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDesIng.Multiline = True
        Me.txtDesIng.Name = "txtDesIng"
        Me.txtDesIng.Size = New System.Drawing.Size(202, 98)
        Me.txtDesIng.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(504, 119)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Descripción del item:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(506, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Nombre del ítem:"
        '
        'TxtDesEsp
        '
        Me.TxtDesEsp.Location = New System.Drawing.Point(506, 134)
        Me.TxtDesEsp.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDesEsp.Multiline = True
        Me.TxtDesEsp.Name = "TxtDesEsp"
        Me.TxtDesEsp.Size = New System.Drawing.Size(202, 98)
        Me.TxtDesEsp.TabIndex = 54
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(506, 92)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(202, 20)
        Me.txtNombre.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(741, 245)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Imagen del ítem:"
        '
        'PicBox
        '
        Me.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicBox.Location = New System.Drawing.Point(743, 261)
        Me.PicBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(210, 169)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox.TabIndex = 50
        Me.PicBox.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(513, 351)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Precio del ítem:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(513, 301)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Tipo de comida:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(513, 251)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Categoría del ítem:"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(515, 368)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(202, 20)
        Me.txtPrecio.TabIndex = 46
        '
        'CombComida
        '
        Me.CombComida.FormattingEnabled = True
        Me.CombComida.Items.AddRange(New Object() {"Sopa", "Mariscos", "Tacos", "Carnes", "Vegetariano", "Untable", "Nachos", "Bebida Natural", "Gaseosa", "Con Alcohol", "Postre", "Para Compartir"})
        Me.CombComida.Location = New System.Drawing.Point(515, 318)
        Me.CombComida.Margin = New System.Windows.Forms.Padding(2)
        Me.CombComida.Name = "CombComida"
        Me.CombComida.Size = New System.Drawing.Size(202, 21)
        Me.CombComida.TabIndex = 45
        '
        'CombCate
        '
        Me.CombCate.FormattingEnabled = True
        Me.CombCate.Items.AddRange(New Object() {"Plato Fuerte", "Entrada", "Bebidas", "Postres", "Para Compartir "})
        Me.CombCate.Location = New System.Drawing.Point(515, 268)
        Me.CombCate.Margin = New System.Windows.Forms.Padding(2)
        Me.CombCate.Name = "CombCate"
        Me.CombCate.Size = New System.Drawing.Size(202, 21)
        Me.CombCate.TabIndex = 44
        '
        'DatagridMenu
        '
        Me.DatagridMenu.AllowUserToAddRows = False
        Me.DatagridMenu.AllowUserToDeleteRows = False
        Me.DatagridMenu.AllowUserToOrderColumns = True
        Me.DatagridMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatagridMenu.Location = New System.Drawing.Point(9, 49)
        Me.DatagridMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.DatagridMenu.Name = "DatagridMenu"
        Me.DatagridMenu.ReadOnly = True
        Me.DatagridMenu.RowTemplate.Height = 24
        Me.DatagridMenu.Size = New System.Drawing.Size(452, 345)
        Me.DatagridMenu.TabIndex = 40
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(526, 458)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(130, 41)
        Me.BtnEliminar.TabIndex = 63
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(510, 396)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 13)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Calorías del ítem:"
        '
        'txtCal
        '
        Me.txtCal.Location = New System.Drawing.Point(512, 412)
        Me.txtCal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCal.Name = "txtCal"
        Me.txtCal.Size = New System.Drawing.Size(202, 20)
        Me.txtCal.TabIndex = 61
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 33)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(145, 13)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Seleccione el ítem a eliminar:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(741, 76)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 13)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Nombre del ítem en inglés:"
        '
        'txtNombreIng
        '
        Me.txtNombreIng.Location = New System.Drawing.Point(743, 92)
        Me.txtNombreIng.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreIng.Name = "txtNombreIng"
        Me.txtNombreIng.Size = New System.Drawing.Size(202, 20)
        Me.txtNombreIng.TabIndex = 65
        '
        'BtnClose2
        '
        Me.BtnClose2.ActiveBorderThickness = 1
        Me.BtnClose2.ActiveCornerRadius = 7
        Me.BtnClose2.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnClose2.ActiveForecolor = System.Drawing.Color.White
        Me.BtnClose2.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnClose2.BackColor = System.Drawing.SystemColors.Control
        Me.BtnClose2.BackgroundImage = CType(resources.GetObject("BtnClose2.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose2.ButtonText = "CERRAR"
        Me.BtnClose2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose2.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnClose2.IdleBorderThickness = 1
        Me.BtnClose2.IdleCornerRadius = 7
        Me.BtnClose2.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnClose2.IdleForecolor = System.Drawing.Color.White
        Me.BtnClose2.IdleLineColor = System.Drawing.Color.Lavender
        Me.BtnClose2.Location = New System.Drawing.Point(811, 457)
        Me.BtnClose2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnClose2.Name = "BtnClose2"
        Me.BtnClose2.Size = New System.Drawing.Size(134, 50)
        Me.BtnClose2.TabIndex = 67
        Me.BtnClose2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DelMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 521)
        Me.Controls.Add(Me.BtnClose2)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents BtnClose2 As Bunifu.Framework.UI.BunifuThinButton2
End Class
