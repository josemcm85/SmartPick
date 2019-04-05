<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CallMesero
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
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ComboMesa = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(12, 27)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(273, 17)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Selecciona la mesa en que te encuentras:"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(372, 27)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(222, 17)
        Me.BunifuCustomLabel2.TabIndex = 1
        Me.BunifuCustomLabel2.Text = "Please select the table you are in:"
        '
        'ComboMesa
        '
        Me.ComboMesa.FormattingEnabled = True
        Me.ComboMesa.Location = New System.Drawing.Point(195, 92)
        Me.ComboMesa.Name = "ComboMesa"
        Me.ComboMesa.Size = New System.Drawing.Size(224, 24)
        Me.ComboMesa.TabIndex = 2
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(12, 154)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(205, 17)
        Me.BunifuCustomLabel3.TabIndex = 3
        Me.BunifuCustomLabel3.Text = "Deja un comentario: (Opcional)"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(412, 154)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(191, 17)
        Me.BunifuCustomLabel4.TabIndex = 4
        Me.BunifuCustomLabel4.Text = "Leave a comment: (Optional)"
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(124, 208)
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(374, 62)
        Me.txtComentario.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(265, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(115, 346)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 39)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Pagar cuenta"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(507, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 8
        '
        'CallMesero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 410)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtComentario)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.ComboMesa)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Name = "CallMesero"
        Me.Text = "CallMesero"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ComboMesa As ComboBox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtComentario As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
End Class
