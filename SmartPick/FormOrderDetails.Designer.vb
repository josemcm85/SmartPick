<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrderDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOrderDetails))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnClose3 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.DGOrderDetails = New System.Windows.Forms.DataGridView()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.DGOrders = New System.Windows.Forms.DataGridView()
        Me.IdOrdenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoTableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaHoraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ListaOrdenesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuTTSDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuTTSDataSet1 = New SmartPick.MenuTTSDataSet1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaOrdenesTableAdapter = New SmartPick.MenuTTSDataSet1TableAdapters.ListaOrdenesTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        CType(Me.DGOrderDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.DGOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaOrdenesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuTTSDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuTTSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.BtnClose3)
        Me.Panel1.Controls.Add(Me.BunifuCards2)
        Me.Panel1.Controls.Add(Me.BunifuCards1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(26, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1085, 568)
        Me.Panel1.TabIndex = 0
        '
        'BtnClose3
        '
        Me.BtnClose3.ActiveBorderThickness = 1
        Me.BtnClose3.ActiveCornerRadius = 7
        Me.BtnClose3.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnClose3.ActiveForecolor = System.Drawing.Color.White
        Me.BtnClose3.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnClose3.BackColor = System.Drawing.Color.Snow
        Me.BtnClose3.BackgroundImage = CType(resources.GetObject("BtnClose3.BackgroundImage"), System.Drawing.Image)
        Me.BtnClose3.ButtonText = "Cerrar"
        Me.BtnClose3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose3.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnClose3.IdleBorderThickness = 1
        Me.BtnClose3.IdleCornerRadius = 7
        Me.BtnClose3.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnClose3.IdleForecolor = System.Drawing.Color.White
        Me.BtnClose3.IdleLineColor = System.Drawing.Color.Lavender
        Me.BtnClose3.Location = New System.Drawing.Point(868, 491)
        Me.BtnClose3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnClose3.Name = "BtnClose3"
        Me.BtnClose3.Size = New System.Drawing.Size(134, 50)
        Me.BtnClose3.TabIndex = 72
        Me.BtnClose3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.White
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.Tomato
        Me.BunifuCards2.Controls.Add(Me.DGOrderDetails)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(571, 59)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(431, 397)
        Me.BunifuCards2.TabIndex = 46
        '
        'DGOrderDetails
        '
        Me.DGOrderDetails.AllowUserToAddRows = False
        Me.DGOrderDetails.AllowUserToDeleteRows = False
        Me.DGOrderDetails.AllowUserToResizeRows = False
        Me.DGOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGOrderDetails.BackgroundColor = System.Drawing.Color.White
        Me.DGOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGOrderDetails.Location = New System.Drawing.Point(0, 4)
        Me.DGOrderDetails.Name = "DGOrderDetails"
        Me.DGOrderDetails.ReadOnly = True
        Me.DGOrderDetails.RowHeadersVisible = False
        Me.DGOrderDetails.Size = New System.Drawing.Size(428, 390)
        Me.DGOrderDetails.TabIndex = 1
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Tomato
        Me.BunifuCards1.Controls.Add(Me.DGOrders)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(50, 59)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(431, 397)
        Me.BunifuCards1.TabIndex = 45
        '
        'DGOrders
        '
        Me.DGOrders.AllowUserToAddRows = False
        Me.DGOrders.AllowUserToDeleteRows = False
        Me.DGOrders.AllowUserToResizeColumns = False
        Me.DGOrders.AllowUserToResizeRows = False
        Me.DGOrders.AutoGenerateColumns = False
        Me.DGOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGOrders.BackgroundColor = System.Drawing.Color.White
        Me.DGOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdOrdenDataGridViewTextBoxColumn, Me.NoTableDataGridViewTextBoxColumn, Me.FechaHoraDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.DGOrders.DataSource = Me.ListaOrdenesBindingSource
        Me.DGOrders.Location = New System.Drawing.Point(0, 3)
        Me.DGOrders.Name = "DGOrders"
        Me.DGOrders.ReadOnly = True
        Me.DGOrders.RowHeadersVisible = False
        Me.DGOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGOrders.Size = New System.Drawing.Size(428, 391)
        Me.DGOrders.TabIndex = 1
        '
        'IdOrdenDataGridViewTextBoxColumn
        '
        Me.IdOrdenDataGridViewTextBoxColumn.DataPropertyName = "idOrden"
        Me.IdOrdenDataGridViewTextBoxColumn.HeaderText = "# Orden"
        Me.IdOrdenDataGridViewTextBoxColumn.Name = "IdOrdenDataGridViewTextBoxColumn"
        Me.IdOrdenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoTableDataGridViewTextBoxColumn
        '
        Me.NoTableDataGridViewTextBoxColumn.DataPropertyName = "NoTable"
        Me.NoTableDataGridViewTextBoxColumn.HeaderText = "# Mesa"
        Me.NoTableDataGridViewTextBoxColumn.Name = "NoTableDataGridViewTextBoxColumn"
        Me.NoTableDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaHoraDataGridViewTextBoxColumn
        '
        Me.FechaHoraDataGridViewTextBoxColumn.DataPropertyName = "FechaHora"
        Me.FechaHoraDataGridViewTextBoxColumn.HeaderText = "Fecha / Hora"
        Me.FechaHoraDataGridViewTextBoxColumn.Name = "FechaHoraDataGridViewTextBoxColumn"
        Me.FechaHoraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ListaOrdenesBindingSource
        '
        Me.ListaOrdenesBindingSource.DataMember = "ListaOrdenes"
        Me.ListaOrdenesBindingSource.DataSource = Me.MenuTTSDataSet1BindingSource
        '
        'MenuTTSDataSet1BindingSource
        '
        Me.MenuTTSDataSet1BindingSource.DataSource = Me.MenuTTSDataSet1
        Me.MenuTTSDataSet1BindingSource.Position = 0
        '
        'MenuTTSDataSet1
        '
        Me.MenuTTSDataSet1.DataSetName = "MenuTTSDataSet1"
        Me.MenuTTSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(568, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 16)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Detalle de la orden:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(47, 39)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(142, 16)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Seleccione la orden:"
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 20
        Me.BunifuElipse2.TargetControl = Me.Panel1
        '
        'ListaOrdenesTableAdapter
        '
        Me.ListaOrdenesTableAdapter.ClearBeforeFill = True
        '
        'FormOrderDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SmartPick.My.Resources.Resources.MANDALAS21
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1137, 619)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormOrderDetails"
        Me.Text = "FormOrderDetails"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BunifuCards2.ResumeLayout(False)
        CType(Me.DGOrderDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards1.ResumeLayout(False)
        CType(Me.DGOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaOrdenesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuTTSDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuTTSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BtnClose3 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents DGOrderDetails As DataGridView
    Friend WithEvents DGOrders As DataGridView
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents MenuTTSDataSet1BindingSource As BindingSource
    Friend WithEvents MenuTTSDataSet1 As MenuTTSDataSet1
    Friend WithEvents ListaOrdenesBindingSource As BindingSource
    Friend WithEvents ListaOrdenesTableAdapter As MenuTTSDataSet1TableAdapters.ListaOrdenesTableAdapter
    Friend WithEvents IdOrdenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoTableDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaHoraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
