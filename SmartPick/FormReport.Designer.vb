<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReport
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
        Dim ReportDataSource9 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource10 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReport))
        Me.OrdenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuTTSDataSet = New SmartPick.MenuTTSDataSet()
        Me.OrdenTableAdapter = New SmartPick.MenuTTSDataSetTableAdapters.OrdenTableAdapter()
        Me.customerSatisfactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.customerSatisfactionTableAdapter = New SmartPick.MenuTTSDataSetTableAdapters.customerSatisfactionTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnClose3 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        CType(Me.OrdenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuTTSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customerSatisfactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'OrdenBindingSource
        '
        Me.OrdenBindingSource.DataMember = "Orden"
        Me.OrdenBindingSource.DataSource = Me.MenuTTSDataSet
        '
        'MenuTTSDataSet
        '
        Me.MenuTTSDataSet.DataSetName = "MenuTTSDataSet"
        Me.MenuTTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdenTableAdapter
        '
        Me.OrdenTableAdapter.ClearBeforeFill = True
        '
        'customerSatisfactionBindingSource
        '
        Me.customerSatisfactionBindingSource.DataMember = "customerSatisfaction"
        Me.customerSatisfactionBindingSource.DataSource = Me.MenuTTSDataSet
        '
        'customerSatisfactionTableAdapter
        '
        Me.customerSatisfactionTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Left
        ReportDataSource9.Name = "MenuTTSDataSet"
        ReportDataSource9.Value = Me.OrdenBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource9)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SmartPick.ReportSP.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(525, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'ReportViewer2
        '
        Me.ReportViewer2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Right
        ReportDataSource10.Name = "DataSet1"
        ReportDataSource10.Value = Me.customerSatisfactionBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource10)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "SmartPick.Report1.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(530, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ServerReport.BearerToken = Nothing
        Me.ReportViewer2.Size = New System.Drawing.Size(525, 450)
        Me.ReportViewer2.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.BtnClose3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(43, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1055, 520)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Snow
        Me.Panel2.Controls.Add(Me.ReportViewer1)
        Me.Panel2.Controls.Add(Me.ReportViewer2)
        Me.Panel2.Location = New System.Drawing.Point(0, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1055, 450)
        Me.Panel2.TabIndex = 0
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
        Me.BtnClose3.Location = New System.Drawing.Point(908, 484)
        Me.BtnClose3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnClose3.Name = "BtnClose3"
        Me.BtnClose3.Size = New System.Drawing.Size(143, 36)
        Me.BtnClose3.TabIndex = 73
        Me.BtnClose3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(2, 15)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(226, 16)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Reporte de items más solicitados:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(527, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 16)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Satisfacción del Cliente:"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 20
        Me.BunifuElipse2.TargetControl = Me.Panel1
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'FormReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SmartPick.My.Resources.Resources.MANDALAS2
        Me.ClientSize = New System.Drawing.Size(1137, 562)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormReport"
        CType(Me.OrdenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuTTSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customerSatisfactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OrdenBindingSource As BindingSource
    Friend WithEvents MenuTTSDataSet As MenuTTSDataSet
    Friend WithEvents OrdenTableAdapter As MenuTTSDataSetTableAdapters.OrdenTableAdapter
    Friend WithEvents customerSatisfactionBindingSource As BindingSource
    Friend WithEvents customerSatisfactionTableAdapter As MenuTTSDataSetTableAdapters.customerSatisfactionTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnClose3 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
