<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTable
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
        Me.tableComboBox = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.FotosMenuTableAdapter1 = New SmartPick.MenuTTSDataSet1TableAdapters.FotosMenuTableAdapter()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione la mesa en la que se ubica."
        '
        'tableComboBox
        '
        Me.tableComboBox.FormattingEnabled = True
        Me.tableComboBox.Location = New System.Drawing.Point(197, 90)
        Me.tableComboBox.Name = "tableComboBox"
        Me.tableComboBox.Size = New System.Drawing.Size(121, 21)
        Me.tableComboBox.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(169, 181)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(283, 181)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 23)
        Me.btnAccept.TabIndex = 3
        Me.btnAccept.Text = "Aceptar"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'FotosMenuTableAdapter1
        '
        Me.FotosMenuTableAdapter1.ClearBeforeFill = True
        '
        'FormTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 245)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.tableComboBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormTable"
        Me.Text = "Seleccion Mesa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tableComboBox As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAccept As Button
    Friend WithEvents FotosMenuTableAdapter1 As MenuTTSDataSet1TableAdapters.FotosMenuTableAdapter
End Class
