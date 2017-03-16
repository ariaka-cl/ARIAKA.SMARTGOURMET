Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class DeliveryControl
        Inherits System.Windows.Forms.UserControl

        'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeliveryControl))
            Me.TableLayoutPanel_Container = New System.Windows.Forms.TableLayoutPanel()
            Me.TableLayoutPanel_Header = New System.Windows.Forms.TableLayoutPanel()
            Me.SearchLookUpEdit_Productos = New DevExpress.XtraEditors.SearchLookUpEdit()
            Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProducCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategoriaID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrecio = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStock = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.SimpleButton_Plus = New DevExpress.XtraEditors.SimpleButton()
            Me.SimpleButton_Minus = New DevExpress.XtraEditors.SimpleButton()
            Me.LabelControl_Total = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl_Total_Value = New DevExpress.XtraEditors.LabelControl()
            Me.SimpleButton_Print = New DevExpress.XtraEditors.SimpleButton()
            Me.DeliveryProductosControl1 = New ARIAKA.SMARTGOURMET.Win.DeliveryProductosControl()
            Me.ProductosDTOBindingSource = New System.Windows.Forms.BindingSource()
            Me.colCategoria = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.TableLayoutPanel_Container.SuspendLayout()
            Me.TableLayoutPanel_Header.SuspendLayout()
            CType(Me.SearchLookUpEdit_Productos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ProductosDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'TableLayoutPanel_Container
            '
            Me.TableLayoutPanel_Container.ColumnCount = 1
            Me.TableLayoutPanel_Container.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel_Container.Controls.Add(Me.DeliveryProductosControl1, 0, 1)
            Me.TableLayoutPanel_Container.Controls.Add(Me.TableLayoutPanel_Header, 0, 0)
            Me.TableLayoutPanel_Container.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_Container.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel_Container.Name = "TableLayoutPanel_Container"
            Me.TableLayoutPanel_Container.RowCount = 2
            Me.TableLayoutPanel_Container.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
            Me.TableLayoutPanel_Container.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel_Container.Size = New System.Drawing.Size(748, 407)
            Me.TableLayoutPanel_Container.TabIndex = 0
            '
            'TableLayoutPanel_Header
            '
            Me.TableLayoutPanel_Header.ColumnCount = 6
            Me.TableLayoutPanel_Header.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.21024!))
            Me.TableLayoutPanel_Header.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.355795!))
            Me.TableLayoutPanel_Header.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.51213!))
            Me.TableLayoutPanel_Header.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.09434!))
            Me.TableLayoutPanel_Header.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.47709!))
            Me.TableLayoutPanel_Header.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.12087!))
            Me.TableLayoutPanel_Header.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel_Header.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel_Header.Controls.Add(Me.SearchLookUpEdit_Productos, 0, 0)
            Me.TableLayoutPanel_Header.Controls.Add(Me.SimpleButton_Plus, 1, 0)
            Me.TableLayoutPanel_Header.Controls.Add(Me.SimpleButton_Minus, 2, 0)
            Me.TableLayoutPanel_Header.Controls.Add(Me.LabelControl_Total, 3, 0)
            Me.TableLayoutPanel_Header.Controls.Add(Me.LabelControl_Total_Value, 4, 0)
            Me.TableLayoutPanel_Header.Controls.Add(Me.SimpleButton_Print, 5, 0)
            Me.TableLayoutPanel_Header.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_Header.Location = New System.Drawing.Point(3, 3)
            Me.TableLayoutPanel_Header.Name = "TableLayoutPanel_Header"
            Me.TableLayoutPanel_Header.RowCount = 1
            Me.TableLayoutPanel_Header.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel_Header.Size = New System.Drawing.Size(742, 68)
            Me.TableLayoutPanel_Header.TabIndex = 1
            '
            'SearchLookUpEdit_Productos
            '
            Me.SearchLookUpEdit_Productos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.SearchLookUpEdit_Productos.EditValue = "Buscar..."
            Me.SearchLookUpEdit_Productos.Location = New System.Drawing.Point(3, 21)
            Me.SearchLookUpEdit_Productos.Name = "SearchLookUpEdit_Productos"
            Me.SearchLookUpEdit_Productos.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SearchLookUpEdit_Productos.Properties.Appearance.Options.UseFont = True
            Me.SearchLookUpEdit_Productos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.SearchLookUpEdit_Productos.Properties.DataSource = Me.ProductosDTOBindingSource
            Me.SearchLookUpEdit_Productos.Properties.DisplayMember = "Nombre"
            Me.SearchLookUpEdit_Productos.Properties.ValueMember = "Id"
            Me.SearchLookUpEdit_Productos.Properties.View = Me.SearchLookUpEdit1View
            Me.SearchLookUpEdit_Productos.Size = New System.Drawing.Size(233, 26)
            Me.SearchLookUpEdit_Productos.TabIndex = 0
            '
            'SearchLookUpEdit1View
            '
            Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colProducCodigo, Me.colNombre, Me.colCategoriaID, Me.colCategoria, Me.colPrecio, Me.colStock})
            Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
            Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
            '
            'colId
            '
            Me.colId.FieldName = "Id"
            Me.colId.Name = "colId"
            '
            'colProducCodigo
            '
            Me.colProducCodigo.FieldName = "ProducCodigo"
            Me.colProducCodigo.Name = "colProducCodigo"
            '
            'colNombre
            '
            Me.colNombre.FieldName = "Nombre"
            Me.colNombre.Name = "colNombre"
            Me.colNombre.Visible = True
            Me.colNombre.VisibleIndex = 0
            '
            'colCategoriaID
            '
            Me.colCategoriaID.FieldName = "CategoriaID"
            Me.colCategoriaID.Name = "colCategoriaID"
            '
            'colPrecio
            '
            Me.colPrecio.FieldName = "Precio"
            Me.colPrecio.Name = "colPrecio"
            Me.colPrecio.Visible = True
            Me.colPrecio.VisibleIndex = 1
            '
            'colStock
            '
            Me.colStock.FieldName = "Stock"
            Me.colStock.Name = "colStock"
            '
            'SimpleButton_Plus
            '
            Me.SimpleButton_Plus.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.SimpleButton_Plus.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton_Plus.Image = CType(resources.GetObject("SimpleButton_Plus.Image"), System.Drawing.Image)
            Me.SimpleButton_Plus.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.SimpleButton_Plus.Location = New System.Drawing.Point(244, 13)
            Me.SimpleButton_Plus.Name = "SimpleButton_Plus"
            Me.SimpleButton_Plus.Size = New System.Drawing.Size(54, 41)
            Me.SimpleButton_Plus.TabIndex = 1
            '
            'SimpleButton_Minus
            '
            Me.SimpleButton_Minus.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.SimpleButton_Minus.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton_Minus.Image = CType(resources.GetObject("SimpleButton_Minus.Image"), System.Drawing.Image)
            Me.SimpleButton_Minus.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.SimpleButton_Minus.Location = New System.Drawing.Point(304, 13)
            Me.SimpleButton_Minus.Name = "SimpleButton_Minus"
            Me.SimpleButton_Minus.Size = New System.Drawing.Size(54, 41)
            Me.SimpleButton_Minus.TabIndex = 2
            Me.SimpleButton_Minus.Text = "SimpleButton2"
            '
            'LabelControl_Total
            '
            Me.LabelControl_Total.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.LabelControl_Total.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl_Total.Location = New System.Drawing.Point(418, 22)
            Me.LabelControl_Total.Name = "LabelControl_Total"
            Me.LabelControl_Total.Size = New System.Drawing.Size(70, 23)
            Me.LabelControl_Total.TabIndex = 3
            Me.LabelControl_Total.Text = "TOTAL:"
            '
            'LabelControl_Total_Value
            '
            Me.LabelControl_Total_Value.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.LabelControl_Total_Value.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LabelControl_Total_Value.Location = New System.Drawing.Point(494, 22)
            Me.LabelControl_Total_Value.Name = "LabelControl_Total_Value"
            Me.LabelControl_Total_Value.Size = New System.Drawing.Size(12, 23)
            Me.LabelControl_Total_Value.TabIndex = 4
            Me.LabelControl_Total_Value.Text = "0"
            '
            'SimpleButton_Print
            '
            Me.SimpleButton_Print.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.SimpleButton_Print.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SimpleButton_Print.Appearance.Options.UseFont = True
            Me.SimpleButton_Print.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
            Me.SimpleButton_Print.Image = CType(resources.GetObject("SimpleButton_Print.Image"), System.Drawing.Image)
            Me.SimpleButton_Print.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.SimpleButton_Print.Location = New System.Drawing.Point(594, 12)
            Me.SimpleButton_Print.Name = "SimpleButton_Print"
            Me.SimpleButton_Print.Size = New System.Drawing.Size(124, 44)
            Me.SimpleButton_Print.TabIndex = 6
            Me.SimpleButton_Print.Text = "Imprimir"
            '
            'DeliveryProductosControl1
            '
            Me.DeliveryProductosControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DeliveryProductosControl1.Location = New System.Drawing.Point(3, 77)
            Me.DeliveryProductosControl1.Name = "DeliveryProductosControl1"
            Me.DeliveryProductosControl1.Size = New System.Drawing.Size(742, 327)
            Me.DeliveryProductosControl1.TabIndex = 0
            '
            'ProductosDTOBindingSource
            '
            Me.ProductosDTOBindingSource.DataSource = GetType(ARIAKA.SMARTGOURMET.Win.Models.ProductosDTO)
            '
            'colCategoria
            '
            Me.colCategoria.FieldName = "Categoria.Nombre"
            Me.colCategoria.Name = "colCategoria"
            '
            'DeliveryControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel_Container)
            Me.Name = "DeliveryControl"
            Me.Size = New System.Drawing.Size(748, 407)
            Me.TableLayoutPanel_Container.ResumeLayout(False)
            Me.TableLayoutPanel_Header.ResumeLayout(False)
            Me.TableLayoutPanel_Header.PerformLayout()
            CType(Me.SearchLookUpEdit_Productos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ProductosDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents TableLayoutPanel_Container As Windows.Forms.TableLayoutPanel
        Friend WithEvents DeliveryProductosControl1 As DeliveryProductosControl
        Friend WithEvents TableLayoutPanel_Header As Windows.Forms.TableLayoutPanel
        Friend WithEvents SearchLookUpEdit_Productos As DevExpress.XtraEditors.SearchLookUpEdit
        Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents SimpleButton_Plus As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents SimpleButton_Minus As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents LabelControl_Total As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl_Total_Value As DevExpress.XtraEditors.LabelControl
        Friend WithEvents SimpleButton_Print As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents ProductosDTOBindingSource As Windows.Forms.BindingSource
        Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colProducCodigo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCategoriaID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCategoria As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrecio As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colStock As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace
