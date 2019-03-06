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
        Me.AdministrarMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarPlatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarPlatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPlatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarTipoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministrarMenuToolStripMenuItem
        '
        Me.AdministrarMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPlatoToolStripMenuItem, Me.EditarPlatoToolStripMenuItem, Me.EliminarPlatoToolStripMenuItem, Me.CategoriaToolStripMenuItem, Me.ModificarTipoToolStripMenuItem})
        Me.AdministrarMenuToolStripMenuItem.Name = "AdministrarMenuToolStripMenuItem"
        Me.AdministrarMenuToolStripMenuItem.Size = New System.Drawing.Size(115, 20)
        Me.AdministrarMenuToolStripMenuItem.Text = "Administrar Menu"
        '
        'AgregarPlatoToolStripMenuItem
        '
        Me.AgregarPlatoToolStripMenuItem.Name = "AgregarPlatoToolStripMenuItem"
        Me.AgregarPlatoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AgregarPlatoToolStripMenuItem.Text = "Agregar Plato"
        '
        'EditarPlatoToolStripMenuItem
        '
        Me.EditarPlatoToolStripMenuItem.Name = "EditarPlatoToolStripMenuItem"
        Me.EditarPlatoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EditarPlatoToolStripMenuItem.Text = "Editar Plato"
        '
        'EliminarPlatoToolStripMenuItem
        '
        Me.EliminarPlatoToolStripMenuItem.Name = "EliminarPlatoToolStripMenuItem"
        Me.EliminarPlatoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EliminarPlatoToolStripMenuItem.Text = "Eliminar Plato"
        '
        'CategoriaToolStripMenuItem
        '
        Me.CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        Me.CategoriaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CategoriaToolStripMenuItem.Text = "Modificar Categoria"
        '
        'ModificarTipoToolStripMenuItem
        '
        Me.ModificarTipoToolStripMenuItem.Name = "ModificarTipoToolStripMenuItem"
        Me.ModificarTipoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ModificarTipoToolStripMenuItem.Text = "Modificar Tipo"
        '
        'AdminMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AdminMain"
        Me.Text = "Administrar Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AdministrarMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarPlatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarPlatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarPlatoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarTipoToolStripMenuItem As ToolStripMenuItem
End Class
