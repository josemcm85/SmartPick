<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Recuperar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recuperar))
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblcorreo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblasunto = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BtnSend = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(168, 108)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(340, 20)
        Me.txtID.TabIndex = 0
        '
        'txtto
        '
        Me.txtto.BackColor = System.Drawing.Color.White
        Me.txtto.Location = New System.Drawing.Point(127, 152)
        Me.txtto.Name = "txtto"
        Me.txtto.ReadOnly = True
        Me.txtto.Size = New System.Drawing.Size(337, 20)
        Me.txtto.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(315, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.BunifuThinButton21)
        Me.Panel1.Controls.Add(Me.BtnSend)
        Me.Panel1.Controls.Add(Me.lblasunto)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel5)
        Me.Panel1.Controls.Add(Me.lblcorreo)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.txtto)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Location = New System.Drawing.Point(44, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(639, 339)
        Me.Panel1.TabIndex = 10
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(124, 58)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(95, 16)
        Me.BunifuCustomLabel1.TabIndex = 48
        Me.BunifuCustomLabel1.Text = "Inserta tu ID:*"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(124, 133)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(120, 16)
        Me.BunifuCustomLabel2.TabIndex = 49
        Me.BunifuCustomLabel2.Text = "Ingresar Correo:*"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(68, 267)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(165, 16)
        Me.BunifuCustomLabel3.TabIndex = 50
        Me.BunifuCustomLabel3.Text = "Te llegará un correo de:"
        '
        'lblcorreo
        '
        Me.lblcorreo.AutoSize = True
        Me.lblcorreo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcorreo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblcorreo.Location = New System.Drawing.Point(229, 267)
        Me.lblcorreo.Name = "lblcorreo"
        Me.lblcorreo.Size = New System.Drawing.Size(172, 16)
        Me.lblcorreo.TabIndex = 51
        Me.lblcorreo.Text = "SmartPickCo@Gmail.com"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(407, 267)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(99, 16)
        Me.BunifuCustomLabel5.TabIndex = 52
        Me.BunifuCustomLabel5.Text = "con el asunto:"
        '
        'lblasunto
        '
        Me.lblasunto.AutoSize = True
        Me.lblasunto.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblasunto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblasunto.Location = New System.Drawing.Point(509, 267)
        Me.lblasunto.Name = "lblasunto"
        Me.lblasunto.Size = New System.Drawing.Size(78, 16)
        Me.lblasunto.TabIndex = 53
        Me.lblasunto.Text = """Tus Datos"""
        '
        'BtnSend
        '
        Me.BtnSend.ActiveBorderThickness = 1
        Me.BtnSend.ActiveCornerRadius = 7
        Me.BtnSend.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnSend.ActiveForecolor = System.Drawing.Color.White
        Me.BtnSend.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnSend.BackColor = System.Drawing.Color.Snow
        Me.BtnSend.BackgroundImage = CType(resources.GetObject("BtnSend.BackgroundImage"), System.Drawing.Image)
        Me.BtnSend.ButtonText = "Enviar"
        Me.BtnSend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSend.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSend.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnSend.IdleBorderThickness = 1
        Me.BtnSend.IdleCornerRadius = 7
        Me.BtnSend.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnSend.IdleForecolor = System.Drawing.Color.White
        Me.BtnSend.IdleLineColor = System.Drawing.Color.Lavender
        Me.BtnSend.Location = New System.Drawing.Point(330, 193)
        Me.BtnSend.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(134, 50)
        Me.BtnSend.TabIndex = 55
        Me.BtnSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 7
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.Snow
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Cancelar"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 7
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.Lavender
        Me.BunifuThinButton21.Location = New System.Drawing.Point(127, 193)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(134, 50)
        Me.BunifuThinButton21.TabIndex = 56
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Recuperar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SmartPick.My.Resources.Resources.MANDALAS2
        Me.ClientSize = New System.Drawing.Size(733, 408)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Recuperar"
        Me.Text = "Recuperar Contraseña"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents txtto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblasunto As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblcorreo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BtnSend As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
End Class
