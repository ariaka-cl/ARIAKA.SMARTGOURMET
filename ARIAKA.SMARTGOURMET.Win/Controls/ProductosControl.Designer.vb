Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ProductosControl
        Inherits DevExpress.XtraEditors.XtraUserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.GridControl_Producto = New DevExpress.XtraGrid.GridControl()
            Me.ProductoDTOBindingSource = New System.Windows.Forms.BindingSource()
            Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.GridColumn_ID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn_Codigo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn_Precio = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn_Categoria = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn_Stock = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridColumn_Nombre = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.TableLayoutPanel_Container = New System.Windows.Forms.TableLayoutPanel()
            CType(Me.GridControl_Producto, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ProductoDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel_Container.SuspendLayout()
            Me.SuspendLayout()
            '
            'GridControl_Producto
            '
            Me.GridControl_Producto.DataSource = Me.ProductoDTOBindingSource
            Me.GridControl_Producto.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl_Producto.Location = New System.Drawing.Point(3, 3)
            Me.GridControl_Producto.MainView = Me.GridView1
            Me.GridControl_Producto.Name = "GridControl_Producto"
            Me.GridControl_Producto.Size = New System.Drawing.Size(735, 373)
            Me.GridControl_Producto.TabIndex = 0
            Me.GridControl_Producto.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
            '
            'ProductoDTOBindingSource
            '
            Me.ProductoDTOBindingSource.DataSource = GetType(ARIAKA.SMARTGOURMET.Win.Models.ProductosDTO)
            '
            'GridView1
            '
            Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_ID, Me.GridColumn_Codigo, Me.GridColumn_Precio, Me.GridColumn_Categoria, Me.GridColumn_Stock, Me.GridColumn_Nombre})
            Me.GridView1.GridControl = Me.GridControl_Producto
            Me.GridView1.Name = "GridView1"
            Me.GridView1.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_ID
            '
            Me.GridColumn_ID.Caption = "ID"
            Me.GridColumn_ID.FieldName = "Id"
            Me.GridColumn_ID.Name = "GridColumn_ID"
            Me.GridColumn_ID.Visible = True
            Me.GridColumn_ID.VisibleIndex = 0
            Me.GridColumn_ID.Width = 30
            '
            'GridColumn_Codigo
            '
            Me.GridColumn_Codigo.Caption = "Codigo"
            Me.GridColumn_Codigo.FieldName = "ProducCodigo"
            Me.GridColumn_Codigo.Name = "GridColumn_Codigo"
            Me.GridColumn_Codigo.UnboundExpression = "1"
            Me.GridColumn_Codigo.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
            Me.GridColumn_Codigo.Visible = True
            Me.GridColumn_Codigo.VisibleIndex = 1
            Me.GridColumn_Codigo.Width = 136
            '
            'GridColumn_Precio
            '
            Me.GridColumn_Precio.Caption = "Precio"
            Me.GridColumn_Precio.FieldName = "Precio"
            Me.GridColumn_Precio.Name = "GridColumn_Precio"
            Me.GridColumn_Precio.Visible = True
            Me.GridColumn_Precio.VisibleIndex = 3
            Me.GridColumn_Precio.Width = 136
            '
            'GridColumn_Categoria
            '
            Me.GridColumn_Categoria.Caption = "Categoria"
            Me.GridColumn_Categoria.FieldName = "Categoria.Nombre"
            Me.GridColumn_Categoria.Name = "GridColumn_Categoria"
            Me.GridColumn_Categoria.Visible = True
            Me.GridColumn_Categoria.VisibleIndex = 4
            Me.GridColumn_Categoria.Width = 136
            '
            'GridColumn_Stock
            '
            Me.GridColumn_Stock.Caption = "Stock"
            Me.GridColumn_Stock.FieldName = "Stock"
            Me.GridColumn_Stock.Name = "GridColumn_Stock"
            Me.GridColumn_Stock.Visible = True
            Me.GridColumn_Stock.VisibleIndex = 5
            Me.GridColumn_Stock.Width = 143
            '
            'GridColumn_Nombre
            '
            Me.GridColumn_Nombre.Caption = "Nombre"
            Me.GridColumn_Nombre.FieldName = "Nombre"
            Me.GridColumn_Nombre.Name = "GridColumn_Nombre"
            Me.GridColumn_Nombre.Visible = True
            Me.GridColumn_Nombre.VisibleIndex = 2
            Me.GridColumn_Nombre.Width = 136
            '
            'TableLayoutPanel_Container
            '
            Me.TableLayoutPanel_Container.ColumnCount = 1
            Me.TableLayoutPanel_Container.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel_Container.Controls.Add(Me.GridControl_Producto, 0, 0)
            Me.TableLayoutPanel_Container.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_Container.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel_Container.Name = "TableLayoutPanel_Container"
            Me.TableLayoutPanel_Container.RowCount = 1
            Me.TableLayoutPanel_Container.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel_Container.Size = New System.Drawing.Size(741, 379)
            Me.TableLayoutPanel_Container.TabIndex = 1
            '
            'ProductosControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel_Container)
            Me.Name = "ProductosControl"
            Me.Size = New System.Drawing.Size(741, 379)
            CType(Me.GridControl_Producto, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ProductoDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel_Container.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents GridControl_Producto As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_ID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Codigo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Precio As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Categoria As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents ProductoDTOBindingSource As Windows.Forms.BindingSource
        Friend WithEvents GridColumn_Stock As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Nombre As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents TableLayoutPanel_Container As Windows.Forms.TableLayoutPanel
    End Class
End Namespace