<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministrarOrdenes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListaOrdenes = New System.Windows.Forms.DataGridView()
        Me.Detalle = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnFinalizar = New System.Windows.Forms.Button()
        CType(Me.ListaOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lista de ordenes pendientes: "
        '
        'ListaOrdenes
        '
        Me.ListaOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListaOrdenes.Location = New System.Drawing.Point(3, 82)
        Me.ListaOrdenes.Name = "ListaOrdenes"
        Me.ListaOrdenes.Size = New System.Drawing.Size(423, 279)
        Me.ListaOrdenes.TabIndex = 1
        '
        'Detalle
        '
        Me.Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Detalle.Location = New System.Drawing.Point(445, 82)
        Me.Detalle.Name = "Detalle"
        Me.Detalle.Size = New System.Drawing.Size(461, 279)
        Me.Detalle.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(442, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Detalle de orden: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 385)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Estado de orden: "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(39, 402)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(186, 20)
        Me.TextBox1.TabIndex = 5
        '
        'BtnFinalizar
        '
        Me.BtnFinalizar.Location = New System.Drawing.Point(653, 400)
        Me.BtnFinalizar.Name = "BtnFinalizar"
        Me.BtnFinalizar.Size = New System.Drawing.Size(108, 22)
        Me.BtnFinalizar.TabIndex = 6
        Me.BtnFinalizar.Text = "Finalizar Orden"
        Me.BtnFinalizar.UseVisualStyleBackColor = True
        '
        'AdministrarOrdenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 450)
        Me.Controls.Add(Me.BtnFinalizar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Detalle)
        Me.Controls.Add(Me.ListaOrdenes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AdministrarOrdenes"
        Me.Text = "AdministrarOrdenes"
        CType(Me.ListaOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListaOrdenes As DataGridView
    Friend WithEvents Detalle As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnFinalizar As Button
End Class
