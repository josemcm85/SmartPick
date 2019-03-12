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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.AgregarPlatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarPlatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPlatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarTipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(342, 151)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(154, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SmartPick.My.Resources.Resources._14650771_10157489166520161_9089602778382653312_n
        Me.PictureBox1.Location = New System.Drawing.Point(12, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(310, 228)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.BunifuSeparator1)
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.MenuStrip1)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(603, 366)
        Me.BunifuGradientPanel1.TabIndex = 13
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.DimGray
        Me.BunifuSeparator1.LineThickness = 3
        Me.BunifuSeparator1.Location = New System.Drawing.Point(303, 75)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(19, 221)
        Me.BunifuSeparator1.TabIndex = 2
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'AgregarPlatoToolStripMenuItem
        '
        Me.AgregarPlatoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.AgregarPlatoToolStripMenuItem.Name = "AgregarPlatoToolStripMenuItem"
        Me.AgregarPlatoToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.AgregarPlatoToolStripMenuItem.Text = "Agregar Plato"
        '
        'EditarPlatoToolStripMenuItem
        '
        Me.EditarPlatoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.EditarPlatoToolStripMenuItem.Name = "EditarPlatoToolStripMenuItem"
        Me.EditarPlatoToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.EditarPlatoToolStripMenuItem.Text = "Editar Plato"
        '
        'EliminarPlatoToolStripMenuItem
        '
        Me.EliminarPlatoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.EliminarPlatoToolStripMenuItem.Name = "EliminarPlatoToolStripMenuItem"
        Me.EliminarPlatoToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.EliminarPlatoToolStripMenuItem.Text = "Eliminar Plato"
        '
        'CategoriaToolStripMenuItem
        '
        Me.CategoriaToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        Me.CategoriaToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.CategoriaToolStripMenuItem.Text = "Modificar Categoria"
        '
        'ModificarTipoToolStripMenuItem
        '
        Me.ModificarTipoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ModificarTipoToolStripMenuItem.Name = "ModificarTipoToolStripMenuItem"
        Me.ModificarTipoToolStripMenuItem.Size = New System.Drawing.Size(217, 26)
        Me.ModificarTipoToolStripMenuItem.Text = "Modificar Tipo"
        '
        'AdministrarMenuToolStripMenuItem
        '
        Me.AdministrarMenuToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.AdministrarMenuToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AdministrarMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPlatoToolStripMenuItem, Me.EditarPlatoToolStripMenuItem, Me.EliminarPlatoToolStripMenuItem, Me.CategoriaToolStripMenuItem, Me.ModificarTipoToolStripMenuItem})
        Me.AdministrarMenuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdministrarMenuToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.AdministrarMenuToolStripMenuItem.Name = "AdministrarMenuToolStripMenuItem"
        Me.AdministrarMenuToolStripMenuItem.Size = New System.Drawing.Size(148, 25)
        Me.AdministrarMenuToolStripMenuItem.Text = "Administrar Menu"
        '
        'AdminMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AdminMain"
        Me.Text = "Administrar Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents AdministrarMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarPlatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarPlatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarPlatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarTipoToolStripMenuItem As ToolStripMenuItem
End Class
