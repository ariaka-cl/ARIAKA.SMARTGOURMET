<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductosMesaControl
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
        Me.components = New System.ComponentModel.Container()
        Me.GridControl_DetallesMesa = New DevExpress.XtraGrid.GridControl()
        Me.MesaDetalleDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn_Producto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn_Cantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn_Precio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn_Fecha = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl_DetallesMesa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesaDetalleDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl_DetallesMesa
        '
        Me.GridControl_DetallesMesa.DataSource = Me.MesaDetalleDTOBindingSource
        Me.GridControl_DetallesMesa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl_DetallesMesa.Location = New System.Drawing.Point(0, 0)
        Me.GridControl_DetallesMesa.MainView = Me.GridView1
        Me.GridControl_DetallesMesa.Name = "GridControl_DetallesMesa"
        Me.GridControl_DetallesMesa.Size = New System.Drawing.Size(741, 379)
        Me.GridControl_DetallesMesa.TabIndex = 0
        Me.GridControl_DetallesMesa.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'MesaDetalleDTOBindingSource
        '
        Me.MesaDetalleDTOBindingSource.DataSource = GetType(ARIAKA.SMARTGOURMET.Win.Models.MesaDetalleDTO)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_Producto, Me.GridColumn_Cantidad, Me.GridColumn_Precio, Me.GridColumn_Fecha})
        Me.GridView1.GridControl = Me.GridControl_DetallesMesa
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn_Producto
        '
        Me.GridColumn_Producto.Caption = "Producto"
        Me.GridColumn_Producto.FieldName = "Producto.Nombre"
        Me.GridColumn_Producto.Name = "GridColumn_Producto"
        Me.GridColumn_Producto.Visible = True
        Me.GridColumn_Producto.VisibleIndex = 1
        '
        'GridColumn_Cantidad
        '
        Me.GridColumn_Cantidad.Caption = "Cantidad"
        Me.GridColumn_Cantidad.FieldName = "GridColumn_Cantidad"
        Me.GridColumn_Cantidad.Name = "GridColumn_Cantidad"
        Me.GridColumn_Cantidad.UnboundExpression = "1"
        Me.GridColumn_Cantidad.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
        Me.GridColumn_Cantidad.Visible = True
        Me.GridColumn_Cantidad.VisibleIndex = 0
        '
        'GridColumn_Precio
        '
        Me.GridColumn_Precio.Caption = "Precio"
        Me.GridColumn_Precio.FieldName = "Producto.Precio"
        Me.GridColumn_Precio.Name = "GridColumn_Precio"
        Me.GridColumn_Precio.Visible = True
        Me.GridColumn_Precio.VisibleIndex = 2
        '
        'GridColumn_Fecha
        '
        Me.GridColumn_Fecha.Caption = "Fecha"
        Me.GridColumn_Fecha.DisplayFormat.FormatString = "d"
        Me.GridColumn_Fecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn_Fecha.FieldName = "FechaPedido"
        Me.GridColumn_Fecha.Name = "GridColumn_Fecha"
        Me.GridColumn_Fecha.Visible = True
        Me.GridColumn_Fecha.VisibleIndex = 3
        '
        'ProductosMesaControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GridControl_DetallesMesa)
        Me.Name = "ProductosMesaControl"
        Me.Size = New System.Drawing.Size(741, 379)
        CType(Me.GridControl_DetallesMesa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesaDetalleDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControl_DetallesMesa As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn_Producto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn_Cantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn_Precio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn_Fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MesaDetalleDTOBindingSource As Windows.Forms.BindingSource
End Class
