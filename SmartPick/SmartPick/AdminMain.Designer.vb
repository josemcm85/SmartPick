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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministrarMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarPlatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarPlatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarPlatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministrarMenuToolStripMenuItem
        '
        Me.AdministrarMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPlatoToolStripMenuItem, Me.EditarPlatoToolStripMenuItem, Me.EliminarPlatoToolStripMenuItem})
        Me.AdministrarMenuToolStripMenuItem.Name = "AdministrarMenuToolStripMenuItem"
        Me.AdministrarMenuToolStripMenuItem.Size = New System.Drawing.Size(139, 24)
        Me.AdministrarMenuToolStripMenuItem.Text = "Administrar Menu"
        '
        'AgregarPlatoToolStripMenuItem
        '
        Me.AgregarPlatoToolStripMenuItem.Name = "AgregarPlatoToolStripMenuItem"
        Me.AgregarPlatoToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.AgregarPlatoToolStripMenuItem.Text = "Agregar Plato"
        '
        'EditarPlatoToolStripMenuItem
        '
        Me.EditarPlatoToolStripMenuItem.Name = "EditarPlatoToolStripMenuItem"
        Me.EditarPlatoToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.EditarPlatoToolStripMenuItem.Text = "Editar Plato"
        '
        'EliminarPlatoToolStripMenuItem
        '
        Me.EliminarPlatoToolStripMenuItem.Name = "EliminarPlatoToolStripMenuItem"
        Me.EliminarPlatoToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.EliminarPlatoToolStripMenuItem.Text = "Eliminar Plato"
        '
        'AdminMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "AdminMain"
        Me.Text = "AdminMain"
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
End Class
