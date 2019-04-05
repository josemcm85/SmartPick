<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagoCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PagoCliente))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNoOrden = New System.Windows.Forms.TextBox()
        Me.Btn = New System.Windows.Forms.Button()
        Me.buttonValidateCpn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textboxCoupon = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtDescuento = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.Label()
        Me.txtImpuesto = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.lblPriceTotalDiscount = New System.Windows.Forms.Label()
        Me.lblNotice = New System.Windows.Forms.Label()
        Me.DTGList = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DTGList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Porfavor espera a que tu orden esté terminada: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Estado de orden: "
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(12, 157)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(217, 36)
        Me.TextBox1.TabIndex = 2
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.BackgroundImage = CType(resources.GetObject("BunifuFlatButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = ""
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = CType(resources.GetObject("BunifuFlatButton1.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(246, 157)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(42, 36)
        Me.BunifuFlatButton1.TabIndex = 3
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ingresa tu número de orden: "
        '
        'txtNoOrden
        '
        Me.txtNoOrden.Location = New System.Drawing.Point(12, 78)
        Me.txtNoOrden.Name = "txtNoOrden"
        Me.txtNoOrden.Size = New System.Drawing.Size(217, 22)
        Me.txtNoOrden.TabIndex = 5
        '
        'Btn
        '
        Me.Btn.Location = New System.Drawing.Point(236, 76)
        Me.Btn.Name = "Btn"
        Me.Btn.Size = New System.Drawing.Size(75, 23)
        Me.Btn.TabIndex = 6
        Me.Btn.Text = "OK"
        Me.Btn.UseVisualStyleBackColor = True
        '
        'buttonValidateCpn
        '
        Me.buttonValidateCpn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.buttonValidateCpn.BackColor = System.Drawing.Color.Orange
        Me.buttonValidateCpn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.buttonValidateCpn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.buttonValidateCpn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.buttonValidateCpn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.buttonValidateCpn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonValidateCpn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonValidateCpn.ForeColor = System.Drawing.Color.Snow
        Me.buttonValidateCpn.Location = New System.Drawing.Point(792, 216)
        Me.buttonValidateCpn.Name = "buttonValidateCpn"
        Me.buttonValidateCpn.Size = New System.Drawing.Size(90, 26)
        Me.buttonValidateCpn.TabIndex = 55
        Me.buttonValidateCpn.Text = "Validar"
        Me.buttonValidateCpn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(680, 187)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 22)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Cupones: "
        '
        'textboxCoupon
        '
        Me.textboxCoupon.BorderColor = System.Drawing.Color.SeaGreen
        Me.textboxCoupon.Location = New System.Drawing.Point(676, 220)
        Me.textboxCoupon.Margin = New System.Windows.Forms.Padding(2)
        Me.textboxCoupon.Name = "textboxCoupon"
        Me.textboxCoupon.Size = New System.Drawing.Size(114, 22)
        Me.textboxCoupon.TabIndex = 53
        '
        'txtDescuento
        '
        Me.txtDescuento.AutoSize = True
        Me.txtDescuento.BackColor = System.Drawing.Color.Transparent
        Me.txtDescuento.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtDescuento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDescuento.Location = New System.Drawing.Point(500, 335)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(123, 21)
        Me.txtDescuento.TabIndex = 62
        Me.txtDescuento.Text = "Descuento ₡:"
        '
        'txtPrecio
        '
        Me.txtPrecio.AutoSize = True
        Me.txtPrecio.BackColor = System.Drawing.Color.Transparent
        Me.txtPrecio.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPrecio.Location = New System.Drawing.Point(500, 305)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(83, 21)
        Me.txtPrecio.TabIndex = 61
        Me.txtPrecio.Text = "Precio ₡:"
        '
        'txtImpuesto
        '
        Me.txtImpuesto.AutoSize = True
        Me.txtImpuesto.BackColor = System.Drawing.Color.Transparent
        Me.txtImpuesto.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtImpuesto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtImpuesto.Location = New System.Drawing.Point(500, 365)
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.Size = New System.Drawing.Size(117, 21)
        Me.txtImpuesto.TabIndex = 60
        Me.txtImpuesto.Text = "Impuestos ₡:"
        '
        'txtTotal
        '
        Me.txtTotal.AutoSize = True
        Me.txtTotal.BackColor = System.Drawing.Color.Transparent
        Me.txtTotal.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTotal.Location = New System.Drawing.Point(501, 399)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(73, 21)
        Me.txtTotal.TabIndex = 59
        Me.txtTotal.Text = "Total ₡:"
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.BackColor = System.Drawing.Color.Transparent
        Me.lblSum.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.lblSum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSum.Location = New System.Drawing.Point(569, 305)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(16, 21)
        Me.lblSum.TabIndex = 58
        Me.lblSum.Text = "-"
        Me.lblSum.Visible = False
        '
        'lblPriceTotalDiscount
        '
        Me.lblPriceTotalDiscount.AutoSize = True
        Me.lblPriceTotalDiscount.BackColor = System.Drawing.Color.Transparent
        Me.lblPriceTotalDiscount.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.lblPriceTotalDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPriceTotalDiscount.Location = New System.Drawing.Point(558, 399)
        Me.lblPriceTotalDiscount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPriceTotalDiscount.Name = "lblPriceTotalDiscount"
        Me.lblPriceTotalDiscount.Size = New System.Drawing.Size(16, 21)
        Me.lblPriceTotalDiscount.TabIndex = 57
        Me.lblPriceTotalDiscount.Text = "-"
        Me.lblPriceTotalDiscount.Visible = False
        '
        'lblNotice
        '
        Me.lblNotice.AutoSize = True
        Me.lblNotice.BackColor = System.Drawing.Color.Transparent
        Me.lblNotice.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.lblNotice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNotice.Location = New System.Drawing.Point(500, 275)
        Me.lblNotice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNotice.Name = "lblNotice"
        Me.lblNotice.Size = New System.Drawing.Size(89, 21)
        Me.lblNotice.TabIndex = 56
        Me.lblNotice.Text = "Resumen:"
        '
        'DTGList
        '
        Me.DTGList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGList.Location = New System.Drawing.Point(15, 212)
        Me.DTGList.Name = "DTGList"
        Me.DTGList.RowTemplate.Height = 24
        Me.DTGList.Size = New System.Drawing.Size(421, 226)
        Me.DTGList.TabIndex = 63
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(661, 474)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 32)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "Pagar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PagoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 518)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DTGList)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtImpuesto)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.lblPriceTotalDiscount)
        Me.Controls.Add(Me.lblNotice)
        Me.Controls.Add(Me.buttonValidateCpn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.textboxCoupon)
        Me.Controls.Add(Me.Btn)
        Me.Controls.Add(Me.txtNoOrden)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PagoCliente"
        CType(Me.DTGList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNoOrden As TextBox
    Friend WithEvents Btn As Button
    Friend WithEvents buttonValidateCpn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents textboxCoupon As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents txtDescuento As Label
    Friend WithEvents txtPrecio As Label
    Friend WithEvents txtImpuesto As Label
    Friend WithEvents txtTotal As Label
    Friend WithEvents lblSum As Label
    Friend WithEvents lblPriceTotalDiscount As Label
    Friend WithEvents lblNotice As Label
    Friend WithEvents DTGList As DataGridView
    Friend WithEvents Button1 As Button
End Class
