<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAddUser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAddUser))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.DGUsers = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserTableShowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuTTSDataSet11 = New SmartPick.MenuTTSDataSet1()
        Me.BtnCancel = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnDelUser = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BtnAdd = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.MenuTTSDataSet1 = New SmartPick.MenuTTSDataSet1()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.UserTableShowTableAdapter = New SmartPick.MenuTTSDataSet1TableAdapters.UserTableShowTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.DGUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserTableShowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuTTSDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuTTSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.BunifuCards1)
        Me.Panel1.Controls.Add(Me.BtnCancel)
        Me.Panel1.Controls.Add(Me.BtnDelUser)
        Me.Panel1.Controls.Add(Me.BtnAdd)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbltitle)
        Me.Panel1.Location = New System.Drawing.Point(22, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 551)
        Me.Panel1.TabIndex = 0
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Tomato
        Me.BunifuCards1.Controls.Add(Me.DGUsers)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(30, 88)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(347, 413)
        Me.BunifuCards1.TabIndex = 56
        '
        'DGUsers
        '
        Me.DGUsers.AllowUserToAddRows = False
        Me.DGUsers.AllowUserToDeleteRows = False
        Me.DGUsers.AutoGenerateColumns = False
        Me.DGUsers.BackgroundColor = System.Drawing.Color.Snow
        Me.DGUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.IdUsuarioDataGridViewTextBoxColumn})
        Me.DGUsers.DataSource = Me.UserTableShowBindingSource
        Me.DGUsers.Location = New System.Drawing.Point(0, 4)
        Me.DGUsers.Name = "DGUsers"
        Me.DGUsers.ReadOnly = True
        Me.DGUsers.RowHeadersVisible = False
        Me.DGUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGUsers.Size = New System.Drawing.Size(344, 406)
        Me.DGUsers.TabIndex = 1
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdUsuarioDataGridViewTextBoxColumn
        '
        Me.IdUsuarioDataGridViewTextBoxColumn.DataPropertyName = "idUsuario"
        Me.IdUsuarioDataGridViewTextBoxColumn.HeaderText = "idUsuario"
        Me.IdUsuarioDataGridViewTextBoxColumn.Name = "IdUsuarioDataGridViewTextBoxColumn"
        Me.IdUsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdUsuarioDataGridViewTextBoxColumn.Visible = False
        '
        'UserTableShowBindingSource
        '
        Me.UserTableShowBindingSource.DataMember = "UserTableShow"
        Me.UserTableShowBindingSource.DataSource = Me.MenuTTSDataSet11
        '
        'MenuTTSDataSet11
        '
        Me.MenuTTSDataSet11.DataSetName = "MenuTTSDataSet1"
        Me.MenuTTSDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnCancel
        '
        Me.BtnCancel.ActiveBorderThickness = 1
        Me.BtnCancel.ActiveCornerRadius = 7
        Me.BtnCancel.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnCancel.ActiveForecolor = System.Drawing.Color.White
        Me.BtnCancel.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnCancel.BackColor = System.Drawing.Color.Snow
        Me.BtnCancel.BackgroundImage = CType(resources.GetObject("BtnCancel.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancel.ButtonText = "CANCELAR"
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnCancel.IdleBorderThickness = 1
        Me.BtnCancel.IdleCornerRadius = 7
        Me.BtnCancel.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnCancel.IdleForecolor = System.Drawing.Color.White
        Me.BtnCancel.IdleLineColor = System.Drawing.Color.Lavender
        Me.BtnCancel.Location = New System.Drawing.Point(384, 451)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(134, 50)
        Me.BtnCancel.TabIndex = 55
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnDelUser
        '
        Me.BtnDelUser.ActiveBorderThickness = 1
        Me.BtnDelUser.ActiveCornerRadius = 7
        Me.BtnDelUser.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnDelUser.ActiveForecolor = System.Drawing.Color.White
        Me.BtnDelUser.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnDelUser.BackColor = System.Drawing.Color.Snow
        Me.BtnDelUser.BackgroundImage = CType(resources.GetObject("BtnDelUser.BackgroundImage"), System.Drawing.Image)
        Me.BtnDelUser.ButtonText = "Eliminar Usuario"
        Me.BtnDelUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelUser.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelUser.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnDelUser.IdleBorderThickness = 1
        Me.BtnDelUser.IdleCornerRadius = 7
        Me.BtnDelUser.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnDelUser.IdleForecolor = System.Drawing.Color.White
        Me.BtnDelUser.IdleLineColor = System.Drawing.Color.Lavender
        Me.BtnDelUser.Location = New System.Drawing.Point(384, 148)
        Me.BtnDelUser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnDelUser.Name = "BtnDelUser"
        Me.BtnDelUser.Size = New System.Drawing.Size(134, 50)
        Me.BtnDelUser.TabIndex = 54
        Me.BtnDelUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnAdd
        '
        Me.BtnAdd.ActiveBorderThickness = 1
        Me.BtnAdd.ActiveCornerRadius = 7
        Me.BtnAdd.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnAdd.ActiveForecolor = System.Drawing.Color.White
        Me.BtnAdd.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnAdd.BackColor = System.Drawing.Color.Snow
        Me.BtnAdd.BackgroundImage = CType(resources.GetObject("BtnAdd.BackgroundImage"), System.Drawing.Image)
        Me.BtnAdd.ButtonText = "Agregar Usuario"
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.SeaGreen
        Me.BtnAdd.IdleBorderThickness = 1
        Me.BtnAdd.IdleCornerRadius = 7
        Me.BtnAdd.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BtnAdd.IdleForecolor = System.Drawing.Color.White
        Me.BtnAdd.IdleLineColor = System.Drawing.Color.Lavender
        Me.BtnAdd.Location = New System.Drawing.Point(384, 88)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(134, 50)
        Me.BtnAdd.TabIndex = 53
        Me.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(121, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Lista de Usuarios Activos"
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbltitle.Location = New System.Drawing.Point(219, 15)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(182, 16)
        Me.lbltitle.TabIndex = 0
        Me.lbltitle.Text = "Agregar / Eliminar Usuario"
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 20
        Me.BunifuElipse2.TargetControl = Me.Panel1
        '
        'MenuTTSDataSet1
        '
        Me.MenuTTSDataSet1.DataSetName = "MenuTTSDataSet1"
        Me.MenuTTSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'UserTableShowTableAdapter
        '
        Me.UserTableShowTableAdapter.ClearBeforeFill = True
        '
        'FormAddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.SmartPick.My.Resources.Resources.MANDALAS21
        Me.ClientSize = New System.Drawing.Size(626, 591)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAddUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar/Eliminar Usuario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.BunifuCards1.ResumeLayout(False)
        CType(Me.DGUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserTableShowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuTTSDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuTTSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents lbltitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuTTSDataSet1 As MenuTTSDataSet1
    Friend WithEvents BtnCancel As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnDelUser As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BtnAdd As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents DGUsers As DataGridView
    Friend WithEvents MenuTTSDataSet11 As MenuTTSDataSet1
    Friend WithEvents UserTableShowBindingSource As BindingSource
    Friend WithEvents UserTableShowTableAdapter As MenuTTSDataSet1TableAdapters.UserTableShowTableAdapter
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdUsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
