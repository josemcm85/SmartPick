﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tipo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tipo))
        Me.TypesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TypesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TypesDataGridView = New System.Windows.Forms.DataGridView()
        Me.idCategories = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuTTSDataSet1 = New SmartPick.MenuTTSDataSet1()
        Me.TypesTableAdapter = New SmartPick.MenuTTSDataSet1TableAdapters.TypesTableAdapter()
        Me.TableAdapterManager = New SmartPick.MenuTTSDataSet1TableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuTTSDataSetCate1 = New SmartPick.MenuTTSDataSetCate()
        Me.BindingSourceCate = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriesTableAdapter = New SmartPick.MenuTTSDataSetCateTableAdapters.CategoriesTableAdapter()
        Me.IdCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategorySpaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryEngDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TypesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TypesBindingNavigator.SuspendLayout()
        CType(Me.TypesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuTTSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuTTSDataSetCate1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceCate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TypesBindingNavigator
        '
        Me.TypesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TypesBindingNavigator.BindingSource = Me.TypesBindingSource
        Me.TypesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TypesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TypesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TypesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TypesBindingNavigatorSaveItem})
        Me.TypesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TypesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TypesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TypesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TypesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TypesBindingNavigator.Name = "TypesBindingNavigator"
        Me.TypesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TypesBindingNavigator.Size = New System.Drawing.Size(1326, 27)
        Me.TypesBindingNavigator.TabIndex = 0
        Me.TypesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'TypesBindingNavigatorSaveItem
        '
        Me.TypesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TypesBindingNavigatorSaveItem.Image = CType(resources.GetObject("TypesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TypesBindingNavigatorSaveItem.Name = "TypesBindingNavigatorSaveItem"
        Me.TypesBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.TypesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'TypesDataGridView
        '
        Me.TypesDataGridView.AllowUserToAddRows = False
        Me.TypesDataGridView.AutoGenerateColumns = False
        Me.TypesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TypesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.idCategories})
        Me.TypesDataGridView.DataSource = Me.TypesBindingSource
        Me.TypesDataGridView.Location = New System.Drawing.Point(13, 72)
        Me.TypesDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.TypesDataGridView.Name = "TypesDataGridView"
        Me.TypesDataGridView.Size = New System.Drawing.Size(807, 376)
        Me.TypesDataGridView.TabIndex = 1
        '
        'idCategories
        '
        Me.idCategories.DataPropertyName = "idCategories"
        Me.idCategories.HeaderText = "idCategories"
        Me.idCategories.Name = "idCategories"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdType"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdType"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TypeSpa"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TypeSpa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TypeEng"
        Me.DataGridViewTextBoxColumn3.HeaderText = "TypeEng"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'TypesBindingSource
        '
        Me.TypesBindingSource.DataMember = "Types"
        Me.TypesBindingSource.DataSource = Me.MenuTTSDataSet1
        '
        'MenuTTSDataSet1
        '
        Me.MenuTTSDataSet1.DataSetName = "MenuTTSDataSet1"
        Me.MenuTTSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TypesTableAdapter
        '
        Me.TypesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriesTableAdapter = Nothing
        Me.TableAdapterManager.FotosMenuTableAdapter = Nothing
        Me.TableAdapterManager.MenuEngTableAdapter = Nothing
        Me.TableAdapterManager.MenuEspTableAdapter = Nothing
        Me.TableAdapterManager.TypesTableAdapter = Me.TypesTableAdapter
        Me.TableAdapterManager.UpdateOrder = SmartPick.MenuTTSDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Listado de tipos de plato:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(880, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Listado de categorías:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCategoryDataGridViewTextBoxColumn, Me.CategorySpaDataGridViewTextBoxColumn, Me.CategoryEngDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CategoriesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(883, 72)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(390, 376)
        Me.DataGridView1.TabIndex = 4
        '
        'MenuTTSDataSetCate1
        '
        Me.MenuTTSDataSetCate1.DataSetName = "MenuTTSDataSetCate"
        Me.MenuTTSDataSetCate1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSourceCate
        '
        Me.BindingSourceCate.DataSource = Me.MenuTTSDataSetCate1
        Me.BindingSourceCate.Position = 0
        '
        'CategoriesBindingSource
        '
        Me.CategoriesBindingSource.DataMember = "Categories"
        Me.CategoriesBindingSource.DataSource = Me.BindingSourceCate
        '
        'CategoriesTableAdapter
        '
        Me.CategoriesTableAdapter.ClearBeforeFill = True
        '
        'IdCategoryDataGridViewTextBoxColumn
        '
        Me.IdCategoryDataGridViewTextBoxColumn.DataPropertyName = "IdCategory"
        Me.IdCategoryDataGridViewTextBoxColumn.HeaderText = "IdCategory"
        Me.IdCategoryDataGridViewTextBoxColumn.Name = "IdCategoryDataGridViewTextBoxColumn"
        Me.IdCategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategorySpaDataGridViewTextBoxColumn
        '
        Me.CategorySpaDataGridViewTextBoxColumn.DataPropertyName = "CategorySpa"
        Me.CategorySpaDataGridViewTextBoxColumn.HeaderText = "CategorySpa"
        Me.CategorySpaDataGridViewTextBoxColumn.Name = "CategorySpaDataGridViewTextBoxColumn"
        Me.CategorySpaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoryEngDataGridViewTextBoxColumn
        '
        Me.CategoryEngDataGridViewTextBoxColumn.DataPropertyName = "CategoryEng"
        Me.CategoryEngDataGridViewTextBoxColumn.HeaderText = "CategoryEng"
        Me.CategoryEngDataGridViewTextBoxColumn.Name = "CategoryEngDataGridViewTextBoxColumn"
        Me.CategoryEngDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Tipo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1326, 554)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TypesDataGridView)
        Me.Controls.Add(Me.TypesBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Tipo"
        Me.Text = "Tipo"
        CType(Me.TypesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TypesBindingNavigator.ResumeLayout(False)
        Me.TypesBindingNavigator.PerformLayout()
        CType(Me.TypesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuTTSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuTTSDataSetCate1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceCate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuTTSDataSet1 As MenuTTSDataSet1
    Friend WithEvents TypesBindingSource As BindingSource
    Friend WithEvents TypesTableAdapter As MenuTTSDataSet1TableAdapters.TypesTableAdapter
    Friend WithEvents TableAdapterManager As MenuTTSDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents TypesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TypesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TypesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents idCategories As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuTTSDataSetCate1 As MenuTTSDataSetCate
    Friend WithEvents BindingSourceCate As BindingSource
    Friend WithEvents CategoriesBindingSource As BindingSource
    Friend WithEvents CategoriesTableAdapter As MenuTTSDataSetCateTableAdapters.CategoriesTableAdapter
    Friend WithEvents IdCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategorySpaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryEngDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class