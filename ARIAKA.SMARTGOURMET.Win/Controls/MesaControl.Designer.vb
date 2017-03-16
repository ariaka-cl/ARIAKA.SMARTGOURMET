<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MesaControl
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MesaControl))
        Me.TableLayoutPanel_MesaMain = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel_MesaRow1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel_Row1Buttons = New System.Windows.Forms.TableLayoutPanel()
        Me.SimpleButton_Pagar = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton_Print = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton_Cocina = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton_Guardar = New DevExpress.XtraEditors.SimpleButton()
        Me.TableLayoutPanel_Row1_Total = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelControl_NumeroMesa = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl_Total = New DevExpress.XtraEditors.LabelControl()
        Me.TextBox_NumeroMesa = New System.Windows.Forms.TextBox()
        Me.LabelControl_Suma = New DevExpress.XtraEditors.LabelControl()
        Me.TableLayoutPanel_Mesa_Row2 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelControl_Fecha = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl_Garzon = New DevExpress.XtraEditors.LabelControl()
        Me.DateTimePicker_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox_Garzones = New System.Windows.Forms.ComboBox()
        Me.UserDTOBindingSource = New System.Windows.Forms.BindingSource()
        Me.SearchLookUpEdit_Producto = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.ProductosDTOBindingSource = New System.Windows.Forms.BindingSource()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProducCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategoria = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TableLayoutPanel_ButtonsProdu = New System.Windows.Forms.TableLayoutPanel()
        Me.SimpleButton_Plus = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton_Minus = New DevExpress.XtraEditors.SimpleButton()
        Me.ProductosMesaControl1 = New ARIAKA.SMARTGOURMET.Win.ProductosMesaControl()
        Me.RichTextBox_Comentarios = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel_MesaMain.SuspendLayout()
        Me.TableLayoutPanel_MesaRow1.SuspendLayout()
        Me.TableLayoutPanel_Row1Buttons.SuspendLayout()
        Me.TableLayoutPanel_Row1_Total.SuspendLayout()
        Me.TableLayoutPanel_Mesa_Row2.SuspendLayout()
        CType(Me.UserDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit_Producto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel_ButtonsProdu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel_MesaMain
        '
        Me.TableLayoutPanel_MesaMain.ColumnCount = 1
        Me.TableLayoutPanel_MesaMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_MesaMain.Controls.Add(Me.TableLayoutPanel_MesaRow1, 0, 0)
        Me.TableLayoutPanel_MesaMain.Controls.Add(Me.TableLayoutPanel_Mesa_Row2, 0, 1)
        Me.TableLayoutPanel_MesaMain.Controls.Add(Me.ProductosMesaControl1, 0, 2)
        Me.TableLayoutPanel_MesaMain.Controls.Add(Me.RichTextBox_Comentarios, 0, 3)
        Me.TableLayoutPanel_MesaMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_MesaMain.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel_MesaMain.Name = "TableLayoutPanel_MesaMain"
        Me.TableLayoutPanel_MesaMain.RowCount = 4
        Me.TableLayoutPanel_MesaMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel_MesaMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel_MesaMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_MesaMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanel_MesaMain.Size = New System.Drawing.Size(935, 532)
        Me.TableLayoutPanel_MesaMain.TabIndex = 0
        '
        'TableLayoutPanel_MesaRow1
        '
        Me.TableLayoutPanel_MesaRow1.ColumnCount = 2
        Me.TableLayoutPanel_MesaRow1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.98063!))
        Me.TableLayoutPanel_MesaRow1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.01937!))
        Me.TableLayoutPanel_MesaRow1.Controls.Add(Me.TableLayoutPanel_Row1Buttons, 1, 0)
        Me.TableLayoutPanel_MesaRow1.Controls.Add(Me.TableLayoutPanel_Row1_Total, 0, 0)
        Me.TableLayoutPanel_MesaRow1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_MesaRow1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel_MesaRow1.Name = "TableLayoutPanel_MesaRow1"
        Me.TableLayoutPanel_MesaRow1.RowCount = 1
        Me.TableLayoutPanel_MesaRow1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel_MesaRow1.Size = New System.Drawing.Size(929, 54)
        Me.TableLayoutPanel_MesaRow1.TabIndex = 0
        '
        'TableLayoutPanel_Row1Buttons
        '
        Me.TableLayoutPanel_Row1Buttons.ColumnCount = 5
        Me.TableLayoutPanel_Row1Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel_Row1Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813!))
        Me.TableLayoutPanel_Row1Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063!))
        Me.TableLayoutPanel_Row1Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063!))
        Me.TableLayoutPanel_Row1Buttons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063!))
        Me.TableLayoutPanel_Row1Buttons.Controls.Add(Me.SimpleButton_Pagar, 4, 0)
        Me.TableLayoutPanel_Row1Buttons.Controls.Add(Me.SimpleButton_Print, 3, 0)
        Me.TableLayoutPanel_Row1Buttons.Controls.Add(Me.SimpleButton_Cocina, 2, 0)
        Me.TableLayoutPanel_Row1Buttons.Controls.Add(Me.SimpleButton_Guardar, 1, 0)
        Me.TableLayoutPanel_Row1Buttons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_Row1Buttons.Location = New System.Drawing.Point(393, 3)
        Me.TableLayoutPanel_Row1Buttons.Name = "TableLayoutPanel_Row1Buttons"
        Me.TableLayoutPanel_Row1Buttons.RowCount = 1
        Me.TableLayoutPanel_Row1Buttons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_Row1Buttons.Size = New System.Drawing.Size(533, 48)
        Me.TableLayoutPanel_Row1Buttons.TabIndex = 0
        '
        'SimpleButton_Pagar
        '
        Me.SimpleButton_Pagar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SimpleButton_Pagar.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton_Pagar.Appearance.Options.UseFont = True
        Me.SimpleButton_Pagar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.SimpleButton_Pagar.Image = CType(resources.GetObject("SimpleButton_Pagar.Image"), System.Drawing.Image)
        Me.SimpleButton_Pagar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton_Pagar.Location = New System.Drawing.Point(418, 3)
        Me.SimpleButton_Pagar.Name = "SimpleButton_Pagar"
        Me.SimpleButton_Pagar.Size = New System.Drawing.Size(104, 42)
        Me.SimpleButton_Pagar.TabIndex = 3
        Me.SimpleButton_Pagar.Text = "Pagar"
        '
        'SimpleButton_Print
        '
        Me.SimpleButton_Print.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SimpleButton_Print.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton_Print.Appearance.Options.UseFont = True
        Me.SimpleButton_Print.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.SimpleButton_Print.Image = CType(resources.GetObject("SimpleButton_Print.Image"), System.Drawing.Image)
        Me.SimpleButton_Print.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton_Print.Location = New System.Drawing.Point(293, 3)
        Me.SimpleButton_Print.Name = "SimpleButton_Print"
        Me.SimpleButton_Print.Size = New System.Drawing.Size(104, 42)
        Me.SimpleButton_Print.TabIndex = 2
        Me.SimpleButton_Print.Text = "Imprimir"
        '
        'SimpleButton_Cocina
        '
        Me.SimpleButton_Cocina.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SimpleButton_Cocina.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton_Cocina.Appearance.Options.UseFont = True
        Me.SimpleButton_Cocina.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.SimpleButton_Cocina.Image = CType(resources.GetObject("SimpleButton_Cocina.Image"), System.Drawing.Image)
        Me.SimpleButton_Cocina.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton_Cocina.Location = New System.Drawing.Point(170, 3)
        Me.SimpleButton_Cocina.Name = "SimpleButton_Cocina"
        Me.SimpleButton_Cocina.Size = New System.Drawing.Size(104, 42)
        Me.SimpleButton_Cocina.TabIndex = 1
        Me.SimpleButton_Cocina.Text = "Cocina"
        '
        'SimpleButton_Guardar
        '
        Me.SimpleButton_Guardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SimpleButton_Guardar.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton_Guardar.Appearance.Options.UseFont = True
        Me.SimpleButton_Guardar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.SimpleButton_Guardar.Image = CType(resources.GetObject("SimpleButton_Guardar.Image"), System.Drawing.Image)
        Me.SimpleButton_Guardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.SimpleButton_Guardar.Location = New System.Drawing.Point(47, 3)
        Me.SimpleButton_Guardar.Name = "SimpleButton_Guardar"
        Me.SimpleButton_Guardar.Size = New System.Drawing.Size(104, 42)
        Me.SimpleButton_Guardar.TabIndex = 0
        Me.SimpleButton_Guardar.Text = "Guardar"
        '
        'TableLayoutPanel_Row1_Total
        '
        Me.TableLayoutPanel_Row1_Total.ColumnCount = 4
        Me.TableLayoutPanel_Row1_Total.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.69792!))
        Me.TableLayoutPanel_Row1_Total.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.21875!))
        Me.TableLayoutPanel_Row1_Total.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel_Row1_Total.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.5625!))
        Me.TableLayoutPanel_Row1_Total.Controls.Add(Me.LabelControl_NumeroMesa, 2, 0)
        Me.TableLayoutPanel_Row1_Total.Controls.Add(Me.LabelControl_Total, 0, 0)
        Me.TableLayoutPanel_Row1_Total.Controls.Add(Me.TextBox_NumeroMesa, 3, 0)
        Me.TableLayoutPanel_Row1_Total.Controls.Add(Me.LabelControl_Suma, 1, 0)
        Me.TableLayoutPanel_Row1_Total.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_Row1_Total.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel_Row1_Total.Name = "TableLayoutPanel_Row1_Total"
        Me.TableLayoutPanel_Row1_Total.RowCount = 1
        Me.TableLayoutPanel_Row1_Total.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_Row1_Total.Size = New System.Drawing.Size(384, 48)
        Me.TableLayoutPanel_Row1_Total.TabIndex = 1
        '
        'LabelControl_NumeroMesa
        '
        Me.LabelControl_NumeroMesa.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelControl_NumeroMesa.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl_NumeroMesa.Location = New System.Drawing.Point(189, 11)
        Me.LabelControl_NumeroMesa.Name = "LabelControl_NumeroMesa"
        Me.LabelControl_NumeroMesa.Size = New System.Drawing.Size(88, 25)
        Me.LabelControl_NumeroMesa.TabIndex = 0
        Me.LabelControl_NumeroMesa.Text = "Mesa N°"
        '
        'LabelControl_Total
        '
        Me.LabelControl_Total.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelControl_Total.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl_Total.Location = New System.Drawing.Point(12, 11)
        Me.LabelControl_Total.Name = "LabelControl_Total"
        Me.LabelControl_Total.Size = New System.Drawing.Size(76, 25)
        Me.LabelControl_Total.TabIndex = 0
        Me.LabelControl_Total.Text = "TOTAL:"
        '
        'TextBox_NumeroMesa
        '
        Me.TextBox_NumeroMesa.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox_NumeroMesa.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_NumeroMesa.Location = New System.Drawing.Point(283, 7)
        Me.TextBox_NumeroMesa.Name = "TextBox_NumeroMesa"
        Me.TextBox_NumeroMesa.Size = New System.Drawing.Size(70, 33)
        Me.TextBox_NumeroMesa.TabIndex = 3
        '
        'LabelControl_Suma
        '
        Me.LabelControl_Suma.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelControl_Suma.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl_Suma.Location = New System.Drawing.Point(94, 11)
        Me.LabelControl_Suma.Name = "LabelControl_Suma"
        Me.LabelControl_Suma.Size = New System.Drawing.Size(13, 25)
        Me.LabelControl_Suma.TabIndex = 1
        Me.LabelControl_Suma.Text = "0"
        '
        'TableLayoutPanel_Mesa_Row2
        '
        Me.TableLayoutPanel_Mesa_Row2.ColumnCount = 6
        Me.TableLayoutPanel_Mesa_Row2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.57697!))
        Me.TableLayoutPanel_Mesa_Row2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.57697!))
        Me.TableLayoutPanel_Mesa_Row2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel_Mesa_Row2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel_Mesa_Row2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.59419!))
        Me.TableLayoutPanel_Mesa_Row2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.31324!))
        Me.TableLayoutPanel_Mesa_Row2.Controls.Add(Me.LabelControl_Fecha, 2, 0)
        Me.TableLayoutPanel_Mesa_Row2.Controls.Add(Me.LabelControl_Garzon, 4, 0)
        Me.TableLayoutPanel_Mesa_Row2.Controls.Add(Me.DateTimePicker_Fecha, 3, 0)
        Me.TableLayoutPanel_Mesa_Row2.Controls.Add(Me.ComboBox_Garzones, 5, 0)
        Me.TableLayoutPanel_Mesa_Row2.Controls.Add(Me.SearchLookUpEdit_Producto, 0, 0)
        Me.TableLayoutPanel_Mesa_Row2.Controls.Add(Me.TableLayoutPanel_ButtonsProdu, 1, 0)
        Me.TableLayoutPanel_Mesa_Row2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel_Mesa_Row2.Location = New System.Drawing.Point(3, 63)
        Me.TableLayoutPanel_Mesa_Row2.Name = "TableLayoutPanel_Mesa_Row2"
        Me.TableLayoutPanel_Mesa_Row2.RowCount = 1
        Me.TableLayoutPanel_Mesa_Row2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_Mesa_Row2.Size = New System.Drawing.Size(929, 64)
        Me.TableLayoutPanel_Mesa_Row2.TabIndex = 1
        '
        'LabelControl_Fecha
        '
        Me.LabelControl_Fecha.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelControl_Fecha.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl_Fecha.Location = New System.Drawing.Point(396, 19)
        Me.LabelControl_Fecha.Name = "LabelControl_Fecha"
        Me.LabelControl_Fecha.Size = New System.Drawing.Size(61, 25)
        Me.LabelControl_Fecha.TabIndex = 1
        Me.LabelControl_Fecha.Text = "Fecha"
        '
        'LabelControl_Garzon
        '
        Me.LabelControl_Garzon.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelControl_Garzon.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl_Garzon.Location = New System.Drawing.Point(652, 19)
        Me.LabelControl_Garzon.Name = "LabelControl_Garzon"
        Me.LabelControl_Garzon.Size = New System.Drawing.Size(75, 25)
        Me.LabelControl_Garzon.TabIndex = 2
        Me.LabelControl_Garzon.Text = "Garzón"
        '
        'DateTimePicker_Fecha
        '
        Me.DateTimePicker_Fecha.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DateTimePicker_Fecha.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker_Fecha.Location = New System.Drawing.Point(463, 17)
        Me.DateTimePicker_Fecha.Name = "DateTimePicker_Fecha"
        Me.DateTimePicker_Fecha.Size = New System.Drawing.Size(148, 30)
        Me.DateTimePicker_Fecha.TabIndex = 4
        '
        'ComboBox_Garzones
        '
        Me.ComboBox_Garzones.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ComboBox_Garzones.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.UserDTOBindingSource, "ID", True))
        Me.ComboBox_Garzones.DataSource = Me.UserDTOBindingSource
        Me.ComboBox_Garzones.DisplayMember = "Nombre"
        Me.ComboBox_Garzones.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox_Garzones.FormattingEnabled = True
        Me.ComboBox_Garzones.Location = New System.Drawing.Point(733, 18)
        Me.ComboBox_Garzones.Name = "ComboBox_Garzones"
        Me.ComboBox_Garzones.Size = New System.Drawing.Size(175, 27)
        Me.ComboBox_Garzones.TabIndex = 5
        Me.ComboBox_Garzones.ValueMember = "ID"
        '
        'UserDTOBindingSource
        '
        Me.UserDTOBindingSource.DataSource = GetType(ARIAKA.SMARTGOURMET.Win.Models.UserDTO)
        '
        'SearchLookUpEdit_Producto
        '
        Me.SearchLookUpEdit_Producto.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.SearchLookUpEdit_Producto.EditValue = "Buscar..."
        Me.SearchLookUpEdit_Producto.Location = New System.Drawing.Point(3, 19)
        Me.SearchLookUpEdit_Producto.Name = "SearchLookUpEdit_Producto"
        Me.SearchLookUpEdit_Producto.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLookUpEdit_Producto.Properties.Appearance.Options.UseFont = True
        Me.SearchLookUpEdit_Producto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SearchLookUpEdit_Producto.Properties.DataSource = Me.ProductosDTOBindingSource
        Me.SearchLookUpEdit_Producto.Properties.DisplayMember = "Nombre"
        Me.SearchLookUpEdit_Producto.Properties.ValueMember = "Id"
        Me.SearchLookUpEdit_Producto.Properties.View = Me.SearchLookUpEdit1View
        Me.SearchLookUpEdit_Producto.Size = New System.Drawing.Size(142, 26)
        Me.SearchLookUpEdit_Producto.TabIndex = 6
        '
        'ProductosDTOBindingSource
        '
        Me.ProductosDTOBindingSource.DataSource = GetType(ARIAKA.SMARTGOURMET.Win.Models.ProductosDTO)
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colProducCodigo, Me.colNombre, Me.colCategoria, Me.colPrecio, Me.colStock})
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'colId
        '
        Me.colId.Caption = "Id"
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'colProducCodigo
        '
        Me.colProducCodigo.Caption = "Codigo Producto"
        Me.colProducCodigo.FieldName = "ProducCodigo"
        Me.colProducCodigo.Name = "colProducCodigo"
        '
        'colNombre
        '
        Me.colNombre.Caption = "Nombre"
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 0
        '
        'colCategoria
        '
        Me.colCategoria.Caption = "Categoria"
        Me.colCategoria.FieldName = "Categoria.Nombre"
        Me.colCategoria.Name = "colCategoria"
        Me.colCategoria.Visible = True
        Me.colCategoria.VisibleIndex = 1
        '
        'colPrecio
        '
        Me.colPrecio.Caption = "Precio"
        Me.colPrecio.FieldName = "Precio"
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.Visible = True
        Me.colPrecio.VisibleIndex = 2
        '
        'colStock
        '
        Me.colStock.Caption = "Stock"
        Me.colStock.FieldName = "Stock"
        Me.colStock.Name = "colStock"
        '
        'TableLayoutPanel_ButtonsProdu
        '
        Me.TableLayoutPanel_ButtonsProdu.ColumnCount = 3
        Me.TableLayoutPanel_ButtonsProdu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel_ButtonsProdu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel_ButtonsProdu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel_ButtonsProdu.Controls.Add(Me.SimpleButton_Plus, 0, 0)
        Me.TableLayoutPanel_ButtonsProdu.Controls.Add(Me.SimpleButton_Minus, 1, 0)
        Me.TableLayoutPanel_ButtonsProdu.Location = New System.Drawing.Point(156, 3)
        Me.TableLayoutPanel_ButtonsProdu.Name = "TableLayoutPanel_ButtonsProdu"
        Me.TableLayoutPanel_ButtonsProdu.RowCount = 1
        Me.TableLayoutPanel_ButtonsProdu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel_ButtonsProdu.Size = New System.Drawing.Size(147, 58)
        Me.TableLayoutPanel_ButtonsProdu.TabIndex = 7
        '
        'SimpleButton_Plus
        '
        Me.SimpleButton_Plus.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.SimpleButton_Plus.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.SimpleButton_Plus.Image = CType(resources.GetObject("SimpleButton_Plus.Image"), System.Drawing.Image)
        Me.SimpleButton_Plus.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton_Plus.Location = New System.Drawing.Point(3, 7)
        Me.SimpleButton_Plus.Name = "SimpleButton_Plus"
        Me.SimpleButton_Plus.Size = New System.Drawing.Size(43, 43)
        Me.SimpleButton_Plus.TabIndex = 0
        '
        'SimpleButton_Minus
        '
        Me.SimpleButton_Minus.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.SimpleButton_Minus.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.SimpleButton_Minus.Image = CType(resources.GetObject("SimpleButton_Minus.Image"), System.Drawing.Image)
        Me.SimpleButton_Minus.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton_Minus.Location = New System.Drawing.Point(52, 7)
        Me.SimpleButton_Minus.Name = "SimpleButton_Minus"
        Me.SimpleButton_Minus.Size = New System.Drawing.Size(43, 43)
        Me.SimpleButton_Minus.TabIndex = 1
        '
        'ProductosMesaControl1
        '
        Me.ProductosMesaControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductosMesaControl1.Location = New System.Drawing.Point(3, 133)
        Me.ProductosMesaControl1.Name = "ProductosMesaControl1"
        Me.ProductosMesaControl1.Size = New System.Drawing.Size(929, 306)
        Me.ProductosMesaControl1.TabIndex = 2
        '
        'RichTextBox_Comentarios
        '
        Me.RichTextBox_Comentarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox_Comentarios.Location = New System.Drawing.Point(3, 445)
        Me.RichTextBox_Comentarios.Name = "RichTextBox_Comentarios"
        Me.RichTextBox_Comentarios.Size = New System.Drawing.Size(929, 84)
        Me.RichTextBox_Comentarios.TabIndex = 3
        Me.RichTextBox_Comentarios.Text = ""
        '
        'MesaControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel_MesaMain)
        Me.Name = "MesaControl"
        Me.Size = New System.Drawing.Size(935, 532)
        Me.TableLayoutPanel_MesaMain.ResumeLayout(False)
        Me.TableLayoutPanel_MesaRow1.ResumeLayout(False)
        Me.TableLayoutPanel_Row1Buttons.ResumeLayout(False)
        Me.TableLayoutPanel_Row1_Total.ResumeLayout(False)
        Me.TableLayoutPanel_Row1_Total.PerformLayout()
        Me.TableLayoutPanel_Mesa_Row2.ResumeLayout(False)
        Me.TableLayoutPanel_Mesa_Row2.PerformLayout()
        CType(Me.UserDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit_Producto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel_ButtonsProdu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel_MesaMain As Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel_MesaRow1 As Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel_Row1Buttons As Windows.Forms.TableLayoutPanel
    Friend WithEvents SimpleButton_Pagar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton_Print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton_Cocina As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton_Guardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TableLayoutPanel_Row1_Total As Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelControl_Total As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl_Suma As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TableLayoutPanel_Mesa_Row2 As Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelControl_NumeroMesa As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl_Fecha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl_Garzon As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextBox_NumeroMesa As Windows.Forms.TextBox
    Friend WithEvents DateTimePicker_Fecha As Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox_Garzones As Windows.Forms.ComboBox
    Friend WithEvents ProductosMesaControl1 As ProductosMesaControl
    Friend WithEvents SearchLookUpEdit_Producto As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TableLayoutPanel_ButtonsProdu As Windows.Forms.TableLayoutPanel
    Friend WithEvents SimpleButton_Plus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton_Minus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RichTextBox_Comentarios As Windows.Forms.RichTextBox
    Friend WithEvents UserDTOBindingSource As Windows.Forms.BindingSource
    Friend WithEvents ProductosDTOBindingSource As Windows.Forms.BindingSource
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCategoria As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStock As DevExpress.XtraGrid.Columns.GridColumn
End Class
