<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministrarMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarPlatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarPlatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPlatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarTipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearCuponesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarOrdenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarOrdenesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SatisfacciónAlClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarPersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerSolicitudesDePersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton1 = New System.Windows.Forms.Button()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarMenuToolStripMenuItem, Me.AdministrarOrdenesToolStripMenuItem, Me.AdministrarPersonalToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(390, 159)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(512, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministrarMenuToolStripMenuItem
        '
        Me.AdministrarMenuToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.AdministrarMenuToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AdministrarMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPlatoToolStripMenuItem, Me.EditarPlatoToolStripMenuItem, Me.EliminarPlatoToolStripMenuItem, Me.ModificarTipoToolStripMenuItem, Me.CrearCuponesToolStripMenuItem})
        Me.AdministrarMenuToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdministrarMenuToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.AdministrarMenuToolStripMenuItem.Name = "AdministrarMenuToolStripMenuItem"
        Me.AdministrarMenuToolStripMenuItem.Size = New System.Drawing.Size(175, 25)
        Me.AdministrarMenuToolStripMenuItem.Text = "| Administrar Menú"
        '
        'AgregarPlatoToolStripMenuItem
        '
        Me.AgregarPlatoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.AgregarPlatoToolStripMenuItem.Name = "AgregarPlatoToolStripMenuItem"
        Me.AgregarPlatoToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.AgregarPlatoToolStripMenuItem.Text = "Agregar Plato"
        '
        'EditarPlatoToolStripMenuItem
        '
        Me.EditarPlatoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.EditarPlatoToolStripMenuItem.Name = "EditarPlatoToolStripMenuItem"
        Me.EditarPlatoToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.EditarPlatoToolStripMenuItem.Text = "Editar Plato"
        '
        'EliminarPlatoToolStripMenuItem
        '
        Me.EliminarPlatoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.EliminarPlatoToolStripMenuItem.Name = "EliminarPlatoToolStripMenuItem"
        Me.EliminarPlatoToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.EliminarPlatoToolStripMenuItem.Text = "Eliminar Plato"
        '
        'ModificarTipoToolStripMenuItem
        '
        Me.ModificarTipoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ModificarTipoToolStripMenuItem.Name = "ModificarTipoToolStripMenuItem"
        Me.ModificarTipoToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.ModificarTipoToolStripMenuItem.Text = "Modificar Tipo"
        '
        'CrearCuponesToolStripMenuItem
        '
        Me.CrearCuponesToolStripMenuItem.Name = "CrearCuponesToolStripMenuItem"
        Me.CrearCuponesToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.CrearCuponesToolStripMenuItem.Text = "Crear cupones"
        '
        'AdministrarOrdenesToolStripMenuItem
        '
        Me.AdministrarOrdenesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarOrdenesToolStripMenuItem1, Me.SatisfacciónAlClienteToolStripMenuItem, Me.ReporteToolStripMenuItem})
        Me.AdministrarOrdenesToolStripMenuItem.Name = "AdministrarOrdenesToolStripMenuItem"
        Me.AdministrarOrdenesToolStripMenuItem.Size = New System.Drawing.Size(122, 25)
        Me.AdministrarOrdenesToolStripMenuItem.Text = "|  Órdenes |"
        '
        'AdministrarOrdenesToolStripMenuItem1
        '
        Me.AdministrarOrdenesToolStripMenuItem1.Name = "AdministrarOrdenesToolStripMenuItem1"
        Me.AdministrarOrdenesToolStripMenuItem1.Size = New System.Drawing.Size(249, 26)
        Me.AdministrarOrdenesToolStripMenuItem1.Text = "Administrar Órdenes"
        '
        'SatisfacciónAlClienteToolStripMenuItem
        '
        Me.SatisfacciónAlClienteToolStripMenuItem.Name = "SatisfacciónAlClienteToolStripMenuItem"
        Me.SatisfacciónAlClienteToolStripMenuItem.Size = New System.Drawing.Size(249, 26)
        Me.SatisfacciónAlClienteToolStripMenuItem.Text = "Satisfacción al cliente"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(249, 26)
        Me.ReporteToolStripMenuItem.Text = "Reporte"
        '
        'AdministrarPersonalToolStripMenuItem
        '
        Me.AdministrarPersonalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerSolicitudesDePersonalToolStripMenuItem})
        Me.AdministrarPersonalToolStripMenuItem.Name = "AdministrarPersonalToolStripMenuItem"
        Me.AdministrarPersonalToolStripMenuItem.Size = New System.Drawing.Size(209, 25)
        Me.AdministrarPersonalToolStripMenuItem.Text = "| Administrar Personal |"
        '
        'VerSolicitudesDePersonalToolStripMenuItem
        '
        Me.VerSolicitudesDePersonalToolStripMenuItem.Name = "VerSolicitudesDePersonalToolStripMenuItem"
        Me.VerSolicitudesDePersonalToolStripMenuItem.Size = New System.Drawing.Size(284, 26)
        Me.VerSolicitudesDePersonalToolStripMenuItem.Text = "Ver solicitudes de personal"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SmartPick.My.Resources.Resources.logoRes
        Me.PictureBox1.Location = New System.Drawing.Point(43, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(276, 286)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 3
        Me.BunifuSeparator1.Location = New System.Drawing.Point(352, 63)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(19, 221)
        Me.BunifuSeparator1.TabIndex = 2
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.BunifuFlatButton1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BunifuSeparator1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(33, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(986, 323)
        Me.Panel1.TabIndex = 46
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.BackgroundImage = CType(resources.GetObject("BunifuFlatButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BunifuFlatButton1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BunifuFlatButton1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton1.ForeColor = System.Drawing.Color.Snow
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(941, 10)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(43, 28)
        Me.BunifuFlatButton1.TabIndex = 55
        Me.BunifuFlatButton1.UseVisualStyleBackColor = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 15
        Me.BunifuElipse2.TargetControl = Me.Panel1
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'AdminMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SmartPick.My.Resources.Resources.MANDALAS22
        Me.ClientSize = New System.Drawing.Size(1050, 377)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AdminMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents AdministrarMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarPlatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarPlatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarPlatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarTipoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents CrearCuponesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarOrdenesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarPersonalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BunifuFlatButton1 As Button
    Friend WithEvents VerSolicitudesDePersonalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SatisfacciónAlClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarOrdenesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As ToolStripMenuItem
End Class
