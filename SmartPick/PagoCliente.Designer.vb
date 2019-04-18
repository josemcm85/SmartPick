<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PagoCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PagoCliente))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNoOrden = New System.Windows.Forms.TextBox()
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
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Btn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBoxClose = New System.Windows.Forms.PictureBox()
        Me.PictureBoxMinimize = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.DTGList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Por favor espera a que tu orden esté terminada: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 157)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Estado de orden: "
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(11, 183)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(164, 30)
        Me.TextBox1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 100)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ingresa tu número de orden: "
        '
        'txtNoOrden
        '
        Me.txtNoOrden.Location = New System.Drawing.Point(11, 118)
        Me.txtNoOrden.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNoOrden.Name = "txtNoOrden"
        Me.txtNoOrden.Size = New System.Drawing.Size(164, 20)
        Me.txtNoOrden.TabIndex = 5
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
        Me.buttonValidateCpn.Location = New System.Drawing.Point(614, 291)
        Me.buttonValidateCpn.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonValidateCpn.Name = "buttonValidateCpn"
        Me.buttonValidateCpn.Size = New System.Drawing.Size(68, 27)
        Me.buttonValidateCpn.TabIndex = 55
        Me.buttonValidateCpn.Text = "Validar"
        Me.buttonValidateCpn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(527, 269)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 19)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Cupones: "
        '
        'textboxCoupon
        '
        Me.textboxCoupon.BorderColor = System.Drawing.Color.SeaGreen
        Me.textboxCoupon.Location = New System.Drawing.Point(524, 296)
        Me.textboxCoupon.Margin = New System.Windows.Forms.Padding(2)
        Me.textboxCoupon.Name = "textboxCoupon"
        Me.textboxCoupon.Size = New System.Drawing.Size(86, 20)
        Me.textboxCoupon.TabIndex = 53
        '
        'txtDescuento
        '
        Me.txtDescuento.AutoSize = True
        Me.txtDescuento.BackColor = System.Drawing.Color.Transparent
        Me.txtDescuento.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtDescuento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDescuento.Location = New System.Drawing.Point(406, 175)
        Me.txtDescuento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(101, 19)
        Me.txtDescuento.TabIndex = 62
        Me.txtDescuento.Text = "Descuento ₡:"
        '
        'txtPrecio
        '
        Me.txtPrecio.AutoSize = True
        Me.txtPrecio.BackColor = System.Drawing.Color.Transparent
        Me.txtPrecio.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPrecio.Location = New System.Drawing.Point(406, 151)
        Me.txtPrecio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(69, 19)
        Me.txtPrecio.TabIndex = 61
        Me.txtPrecio.Text = "Precio ₡:"
        '
        'txtImpuesto
        '
        Me.txtImpuesto.AutoSize = True
        Me.txtImpuesto.BackColor = System.Drawing.Color.Transparent
        Me.txtImpuesto.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtImpuesto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtImpuesto.Location = New System.Drawing.Point(406, 200)
        Me.txtImpuesto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.Size = New System.Drawing.Size(95, 19)
        Me.txtImpuesto.TabIndex = 60
        Me.txtImpuesto.Text = "Impuestos ₡:"
        '
        'txtTotal
        '
        Me.txtTotal.AutoSize = True
        Me.txtTotal.BackColor = System.Drawing.Color.Transparent
        Me.txtTotal.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.txtTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTotal.Location = New System.Drawing.Point(407, 227)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(59, 19)
        Me.txtTotal.TabIndex = 59
        Me.txtTotal.Text = "Total ₡:"
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.BackColor = System.Drawing.Color.Transparent
        Me.lblSum.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.lblSum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSum.Location = New System.Drawing.Point(458, 151)
        Me.lblSum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(14, 19)
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
        Me.lblPriceTotalDiscount.Location = New System.Drawing.Point(449, 227)
        Me.lblPriceTotalDiscount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPriceTotalDiscount.Name = "lblPriceTotalDiscount"
        Me.lblPriceTotalDiscount.Size = New System.Drawing.Size(14, 19)
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
        Me.lblNotice.Location = New System.Drawing.Point(406, 126)
        Me.lblNotice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNotice.Name = "lblNotice"
        Me.lblNotice.Size = New System.Drawing.Size(76, 19)
        Me.lblNotice.TabIndex = 56
        Me.lblNotice.Text = "Resumen:"
        '
        'DTGList
        '
        Me.DTGList.BackgroundColor = System.Drawing.Color.White
        Me.DTGList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGList.Location = New System.Drawing.Point(13, 227)
        Me.DTGList.Margin = New System.Windows.Forms.Padding(2)
        Me.DTGList.Name = "DTGList"
        Me.DTGList.RowTemplate.Height = 24
        Me.DTGList.Size = New System.Drawing.Size(316, 184)
        Me.DTGList.TabIndex = 63
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
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
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(186, 183)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(32, 29)
        Me.BunifuFlatButton1.TabIndex = 3
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Button1
        '
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.BackColor = System.Drawing.Color.Orange
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Snow
        Me.Button1.Location = New System.Drawing.Point(474, 366)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 34)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "Pagar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Btn
        '
        Me.Btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Btn.BackColor = System.Drawing.Color.Orange
        Me.Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn.ForeColor = System.Drawing.Color.Snow
        Me.Btn.Location = New System.Drawing.Point(186, 114)
        Me.Btn.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn.Name = "Btn"
        Me.Btn.Size = New System.Drawing.Size(62, 25)
        Me.Btn.TabIndex = 66
        Me.Btn.Text = "Ok"
        Me.Btn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBoxClose)
        Me.Panel2.Controls.Add(Me.PictureBoxMinimize)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(702, 24)
        Me.Panel2.TabIndex = 67
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Image = Global.SmartPick.My.Resources.Resources.Close
        Me.PictureBoxClose.Location = New System.Drawing.Point(1197, 3)
        Me.PictureBoxClose.Name = "PictureBoxClose"
        Me.PictureBoxClose.Size = New System.Drawing.Size(28, 25)
        Me.PictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxClose.TabIndex = 1
        Me.PictureBoxClose.TabStop = False
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.Image = Global.SmartPick.My.Resources.Resources.Minimize
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(1162, 3)
        Me.PictureBoxMinimize.Name = "PictureBoxMinimize"
        Me.PictureBoxMinimize.Size = New System.Drawing.Size(28, 25)
        Me.PictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxMinimize.TabIndex = 0
        Me.PictureBoxMinimize.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(0, 2)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 20)
        Me.Label10.TabIndex = 24
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'btnClose
        '
        Me.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnClose.BackColor = System.Drawing.Color.Orange
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Snow
        Me.btnClose.Location = New System.Drawing.Point(568, 366)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(76, 34)
        Me.btnClose.TabIndex = 69
        Me.btnClose.Text = "Cerrar"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'PagoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SmartPick.My.Resources.Resources.fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(702, 490)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Btn)
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
        Me.Controls.Add(Me.txtNoOrden)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "PagoCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DTGList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNoOrden As TextBox
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
    Friend WithEvents Btn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBoxClose As PictureBox
    Friend WithEvents PictureBoxMinimize As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents btnClose As Button
End Class
