﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.CategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarTipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearCuponesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarOrdenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.AdministrarPersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.MenuStrip1.Location = New System.Drawing.Point(520, 196)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(727, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministrarMenuToolStripMenuItem
        '
        Me.AdministrarMenuToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.AdministrarMenuToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AdministrarMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPlatoToolStripMenuItem, Me.EditarPlatoToolStripMenuItem, Me.EliminarPlatoToolStripMenuItem, Me.CategoriaToolStripMenuItem, Me.ModificarTipoToolStripMenuItem, Me.CrearCuponesToolStripMenuItem, Me.CerrarToolStripMenuItem})
        Me.AdministrarMenuToolStripMenuItem.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdministrarMenuToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.AdministrarMenuToolStripMenuItem.Name = "AdministrarMenuToolStripMenuItem"
        Me.AdministrarMenuToolStripMenuItem.Size = New System.Drawing.Size(208, 27)
        Me.AdministrarMenuToolStripMenuItem.Text = "| Administrar Menú"
        '
        'AgregarPlatoToolStripMenuItem
        '
        Me.AgregarPlatoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.AgregarPlatoToolStripMenuItem.Name = "AgregarPlatoToolStripMenuItem"
        Me.AgregarPlatoToolStripMenuItem.Size = New System.Drawing.Size(280, 28)
        Me.AgregarPlatoToolStripMenuItem.Text = "Agregar Plato"
        '
        'EditarPlatoToolStripMenuItem
        '
        Me.EditarPlatoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.EditarPlatoToolStripMenuItem.Name = "EditarPlatoToolStripMenuItem"
        Me.EditarPlatoToolStripMenuItem.Size = New System.Drawing.Size(280, 28)
        Me.EditarPlatoToolStripMenuItem.Text = "Editar Plato"
        '
        'EliminarPlatoToolStripMenuItem
        '
        Me.EliminarPlatoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.EliminarPlatoToolStripMenuItem.Name = "EliminarPlatoToolStripMenuItem"
        Me.EliminarPlatoToolStripMenuItem.Size = New System.Drawing.Size(280, 28)
        Me.EliminarPlatoToolStripMenuItem.Text = "Eliminar Plato"
        '
        'CategoriaToolStripMenuItem
        '
        Me.CategoriaToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        Me.CategoriaToolStripMenuItem.Size = New System.Drawing.Size(280, 28)
        Me.CategoriaToolStripMenuItem.Text = "Modificar Categoria"
        '
        'ModificarTipoToolStripMenuItem
        '
        Me.ModificarTipoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ModificarTipoToolStripMenuItem.Name = "ModificarTipoToolStripMenuItem"
        Me.ModificarTipoToolStripMenuItem.Size = New System.Drawing.Size(280, 28)
        Me.ModificarTipoToolStripMenuItem.Text = "Modificar Tipo"
        '
        'CrearCuponesToolStripMenuItem
        '
        Me.CrearCuponesToolStripMenuItem.Name = "CrearCuponesToolStripMenuItem"
        Me.CrearCuponesToolStripMenuItem.Size = New System.Drawing.Size(280, 28)
        Me.CrearCuponesToolStripMenuItem.Text = "Crear cupones"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(280, 28)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        '
        'AdministrarOrdenesToolStripMenuItem
        '
        Me.AdministrarOrdenesToolStripMenuItem.Name = "AdministrarOrdenesToolStripMenuItem"
        Me.AdministrarOrdenesToolStripMenuItem.Size = New System.Drawing.Size(256, 27)
        Me.AdministrarOrdenesToolStripMenuItem.Text = "| Administrar Ordenes |"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SmartPick.My.Resources.Resources._14650771_10157489166520161_9089602778382653312_n
        Me.PictureBox1.Location = New System.Drawing.Point(43, 73)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(413, 281)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 3
        Me.BunifuSeparator1.Location = New System.Drawing.Point(469, 78)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(25, 272)
        Me.BunifuSeparator1.TabIndex = 2
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BunifuSeparator1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(44, 31)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1315, 398)
        Me.Panel1.TabIndex = 46
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
        'AdministrarPersonalToolStripMenuItem
        '
        Me.AdministrarPersonalToolStripMenuItem.Name = "AdministrarPersonalToolStripMenuItem"
        Me.AdministrarPersonalToolStripMenuItem.Size = New System.Drawing.Size(256, 27)
        Me.AdministrarPersonalToolStripMenuItem.Text = "| Administrar Personal |"
        '
        'AdminMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SmartPick.My.Resources.Resources.MANDALAS22
        Me.ClientSize = New System.Drawing.Size(1400, 487)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AdminMain"
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
    Friend WithEvents CategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarTipoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents CrearCuponesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarOrdenesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarPersonalToolStripMenuItem As ToolStripMenuItem
End Class
