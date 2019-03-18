<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loading))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Load = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(58, 97)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(392, 23)
        Me.ProgressBar1.Step = 100
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 100
        Me.ProgressBar1.Value = 50
        '
        'Load
        '
        Me.Load.ActiveBorderThickness = 1
        Me.Load.ActiveCornerRadius = 7
        Me.Load.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Load.ActiveForecolor = System.Drawing.Color.White
        Me.Load.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Load.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Load.BackColor = System.Drawing.Color.Teal
        Me.Load.BackgroundImage = CType(resources.GetObject("Load.BackgroundImage"), System.Drawing.Image)
        Me.Load.ButtonText = "CARGANDO ..."
        Me.Load.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Load.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Load.ForeColor = System.Drawing.Color.SeaGreen
        Me.Load.IdleBorderThickness = 1
        Me.Load.IdleCornerRadius = 7
        Me.Load.IdleFillColor = System.Drawing.Color.DarkCyan
        Me.Load.IdleForecolor = System.Drawing.Color.White
        Me.Load.IdleLineColor = System.Drawing.Color.Lavender
        Me.Load.Location = New System.Drawing.Point(166, 39)
        Me.Load.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Load.Name = "Load"
        Me.Load.Size = New System.Drawing.Size(175, 50)
        Me.Load.TabIndex = 55
        Me.Load.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 40
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(495, 136)
        Me.Controls.Add(Me.Load)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "Loading"
        Me.Text = "Loading"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Load As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Timer1 As Timer
End Class
