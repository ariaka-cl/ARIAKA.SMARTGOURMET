Namespace PDF
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Public Class BoletaReport
        Inherits DevExpress.XtraReports.UI.XtraReport

        'XtraReport overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Designer
        'It can be modified using the Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableTotales = New DevExpress.XtraReports.UI.XRTable()
            Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell_Total = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell_Propina = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell_TotalAll = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell_TotalAll_Value = New DevExpress.XtraReports.UI.XRTableCell()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
            Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.PageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
            Me.ReportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
            Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
            Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
            Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell_MesaNumero = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell_Hora = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell_Hora_Value = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell_Garzon = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableHeader = New DevExpress.XtraReports.UI.XRTable()
            Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.SumaProductos = New DevExpress.XtraReports.UI.CalculatedField()
            Me.Cantidad = New DevExpress.XtraReports.UI.CalculatedField()
            Me.FormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
            Me.NombreGroup = New DevExpress.XtraReports.UI.CalculatedField()
            Me.ObjectDataSourceMesaDetalle = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
            Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell_Fecha = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell_Fecha_Value = New DevExpress.XtraReports.UI.XRTableCell()
            CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XrTableTotales, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XrTableHeader, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ObjectDataSourceMesaDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
            Me.Detail.Dpi = 100.0!
            Me.Detail.HeightF = 22.99999!
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("Nombre", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.Detail.StyleName = "DataField"
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'XrTable1
            '
            Me.XrTable1.Dpi = 100.0!
            Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(5.999883!, 0!)
            Me.XrTable1.Name = "XrTable1"
            Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
            Me.XrTable1.SizeF = New System.Drawing.SizeF(286.0001!, 22.99998!)
            '
            'XrTableRow2
            '
            Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6})
            Me.XrTableRow2.Dpi = 100.0!
            Me.XrTableRow2.Name = "XrTableRow2"
            Me.XrTableRow2.Weight = 1.0R
            '
            'XrTableCell4
            '
            Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Cantidad")})
            Me.XrTableCell4.Dpi = 100.0!
            Me.XrTableCell4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell4.Name = "XrTableCell4"
            Me.XrTableCell4.StylePriority.UseFont = False
            Me.XrTableCell4.StylePriority.UseTextAlignment = False
            Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            Me.XrTableCell4.Weight = 0.67239972595022046R
            '
            'XrTableCell5
            '
            Me.XrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "NombreGroup")})
            Me.XrTableCell5.Dpi = 100.0!
            Me.XrTableCell5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell5.Name = "XrTableCell5"
            Me.XrTableCell5.StylePriority.UseFont = False
            Me.XrTableCell5.StylePriority.UseTextAlignment = False
            Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.XrTableCell5.Weight = 1.8760492002848888R
            '
            'XrTableCell6
            '
            Me.XrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SumaProductos")})
            Me.XrTableCell6.Dpi = 100.0!
            Me.XrTableCell6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell6.Name = "XrTableCell6"
            Me.XrTableCell6.StylePriority.UseFont = False
            Me.XrTableCell6.StylePriority.UseTextAlignment = False
            Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            Me.XrTableCell6.Weight = 0.76695927653450857R
            '
            'XrTableTotales
            '
            Me.XrTableTotales.Dpi = 100.0!
            Me.XrTableTotales.LocationFloat = New DevExpress.Utils.PointFloat(77.4999!, 61.87503!)
            Me.XrTableTotales.Name = "XrTableTotales"
            Me.XrTableTotales.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3, Me.XrTableRow4, Me.XrTableRow8})
            Me.XrTableTotales.SizeF = New System.Drawing.SizeF(214.5002!, 75.0!)
            '
            'XrTableRow3
            '
            Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell8, Me.XrTableCell_Total})
            Me.XrTableRow3.Dpi = 100.0!
            Me.XrTableRow3.Name = "XrTableRow3"
            Me.XrTableRow3.Weight = 1.0R
            '
            'XrTableCell8
            '
            Me.XrTableCell8.Dpi = 100.0!
            Me.XrTableCell8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell8.Name = "XrTableCell8"
            Me.XrTableCell8.StylePriority.UseFont = False
            Me.XrTableCell8.StylePriority.UseTextAlignment = False
            Me.XrTableCell8.Text = "Sub Total: "
            Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.XrTableCell8.Weight = 1.6758155879080634R
            '
            'XrTableCell_Total
            '
            Me.XrTableCell_Total.Dpi = 100.0!
            Me.XrTableCell_Total.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell_Total.Name = "XrTableCell_Total"
            Me.XrTableCell_Total.StylePriority.UseFont = False
            Me.XrTableCell_Total.StylePriority.UseTextAlignment = False
            Me.XrTableCell_Total.Text = "0"
            Me.XrTableCell_Total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.XrTableCell_Total.Weight = 1.025436514496707R
            '
            'XrTableRow4
            '
            Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.XrTableCell_Propina})
            Me.XrTableRow4.Dpi = 100.0!
            Me.XrTableRow4.Name = "XrTableRow4"
            Me.XrTableRow4.Weight = 1.0R
            '
            'XrTableCell7
            '
            Me.XrTableCell7.Dpi = 100.0!
            Me.XrTableCell7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell7.Name = "XrTableCell7"
            Me.XrTableCell7.StylePriority.UseFont = False
            Me.XrTableCell7.StylePriority.UseTextAlignment = False
            Me.XrTableCell7.Text = "Propina 10% : "
            Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.XrTableCell7.Weight = 1.6758155879080634R
            '
            'XrTableCell_Propina
            '
            Me.XrTableCell_Propina.Dpi = 100.0!
            Me.XrTableCell_Propina.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell_Propina.Name = "XrTableCell_Propina"
            Me.XrTableCell_Propina.StylePriority.UseFont = False
            Me.XrTableCell_Propina.StylePriority.UseTextAlignment = False
            Me.XrTableCell_Propina.Text = "0"
            Me.XrTableCell_Propina.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.XrTableCell_Propina.Weight = 1.025436514496707R
            '
            'XrTableRow8
            '
            Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell_TotalAll, Me.XrTableCell_TotalAll_Value})
            Me.XrTableRow8.Dpi = 100.0!
            Me.XrTableRow8.Name = "XrTableRow8"
            Me.XrTableRow8.Weight = 1.0R
            '
            'XrTableCell_TotalAll
            '
            Me.XrTableCell_TotalAll.Dpi = 100.0!
            Me.XrTableCell_TotalAll.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell_TotalAll.Name = "XrTableCell_TotalAll"
            Me.XrTableCell_TotalAll.StylePriority.UseFont = False
            Me.XrTableCell_TotalAll.StylePriority.UseTextAlignment = False
            Me.XrTableCell_TotalAll.Text = "Total: "
            Me.XrTableCell_TotalAll.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.XrTableCell_TotalAll.Weight = 1.6758145459574769R
            '
            'XrTableCell_TotalAll_Value
            '
            Me.XrTableCell_TotalAll_Value.Dpi = 100.0!
            Me.XrTableCell_TotalAll_Value.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell_TotalAll_Value.Name = "XrTableCell_TotalAll_Value"
            Me.XrTableCell_TotalAll_Value.StylePriority.UseFont = False
            Me.XrTableCell_TotalAll_Value.StylePriority.UseTextAlignment = False
            Me.XrTableCell_TotalAll_Value.Text = "0"
            Me.XrTableCell_TotalAll_Value.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell_TotalAll_Value.Weight = 1.0254375564472935R
            '
            'TopMargin
            '
            Me.TopMargin.Dpi = 100.0!
            Me.TopMargin.HeightF = 9.833336!
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'BottomMargin
            '
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
            Me.BottomMargin.Dpi = 100.0!
            Me.BottomMargin.HeightF = 51.0!
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'XrTable3
            '
            Me.XrTable3.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
            Me.XrTable3.Dpi = 100.0!
            Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(5.999883!, 16.00005!)
            Me.XrTable3.Name = "XrTable3"
            Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow7})
            Me.XrTable3.SizeF = New System.Drawing.SizeF(286.0002!, 24.99994!)
            '
            'XrTableRow7
            '
            Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell15})
            Me.XrTableRow7.Dpi = 100.0!
            Me.XrTableRow7.Name = "XrTableRow7"
            Me.XrTableRow7.Weight = 1.0R
            '
            'XrTableCell15
            '
            Me.XrTableCell15.CanGrow = False
            Me.XrTableCell15.Dpi = 100.0!
            Me.XrTableCell15.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell15.Name = "XrTableCell15"
            Me.XrTableCell15.StylePriority.UseFont = False
            Me.XrTableCell15.Text = "********Gracias por su ferencia***********"
            Me.XrTableCell15.Weight = 3.0R
            '
            'PageFooterBand1
            '
            Me.PageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTableTotales})
            Me.PageFooterBand1.Dpi = 100.0!
            Me.PageFooterBand1.HeightF = 146.875!
            Me.PageFooterBand1.Name = "PageFooterBand1"
            '
            'ReportHeaderBand1
            '
            Me.ReportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel15, Me.XrLine3})
            Me.ReportHeaderBand1.Dpi = 100.0!
            Me.ReportHeaderBand1.HeightF = 49.70837!
            Me.ReportHeaderBand1.Name = "ReportHeaderBand1"
            '
            'XrLabel15
            '
            Me.XrLabel15.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.XrLabel15.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.XrLabel15.AutoWidth = True
            Me.XrLabel15.CanGrow = False
            Me.XrLabel15.Dpi = 100.0!
            Me.XrLabel15.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(9.999974!, 10.00001!)
            Me.XrLabel15.Name = "XrLabel15"
            Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel15.SizeF = New System.Drawing.SizeF(282.0!, 39.70835!)
            Me.XrLabel15.StyleName = "Title"
            Me.XrLabel15.StylePriority.UseFont = False
            Me.XrLabel15.StylePriority.UseTextAlignment = False
            Me.XrLabel15.Text = "Caffellatte"
            Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'XrLine3
            '
            Me.XrLine3.Dpi = 100.0!
            Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(10.00023!, 0!)
            Me.XrLine3.Name = "XrLine3"
            Me.XrLine3.SizeF = New System.Drawing.SizeF(277.9151!, 2.000006!)
            '
            'Title
            '
            Me.Title.BackColor = System.Drawing.Color.Transparent
            Me.Title.BorderColor = System.Drawing.Color.Black
            Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Title.BorderWidth = 1.0!
            Me.Title.Font = New System.Drawing.Font("Times New Roman", 24.0!)
            Me.Title.ForeColor = System.Drawing.Color.Black
            Me.Title.Name = "Title"
            '
            'FieldCaption
            '
            Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
            Me.FieldCaption.BorderColor = System.Drawing.Color.Black
            Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.FieldCaption.BorderWidth = 1.0!
            Me.FieldCaption.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
            Me.FieldCaption.ForeColor = System.Drawing.Color.Black
            Me.FieldCaption.Name = "FieldCaption"
            '
            'PageInfo
            '
            Me.PageInfo.BackColor = System.Drawing.Color.Transparent
            Me.PageInfo.BorderColor = System.Drawing.Color.Black
            Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.PageInfo.BorderWidth = 1.0!
            Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 8.0!)
            Me.PageInfo.ForeColor = System.Drawing.Color.Black
            Me.PageInfo.Name = "PageInfo"
            '
            'DataField
            '
            Me.DataField.BackColor = System.Drawing.Color.Transparent
            Me.DataField.BorderColor = System.Drawing.Color.Black
            Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.DataField.BorderWidth = 1.0!
            Me.DataField.Font = New System.Drawing.Font("Times New Roman", 8.0!)
            Me.DataField.ForeColor = System.Drawing.Color.Black
            Me.DataField.Name = "DataField"
            Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            '
            'GroupHeader1
            '
            Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine1, Me.XrTable2, Me.XrTableHeader})
            Me.GroupHeader1.Dpi = 100.0!
            Me.GroupHeader1.HeightF = 137.5!
            Me.GroupHeader1.Name = "GroupHeader1"
            '
            'XrLine1
            '
            Me.XrLine1.Dpi = 100.0!
            Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(13.54179!, 0!)
            Me.XrLine1.Name = "XrLine1"
            Me.XrLine1.SizeF = New System.Drawing.SizeF(274.3736!, 10.0!)
            '
            'XrTable2
            '
            Me.XrTable2.Dpi = 100.0!
            Me.XrTable2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(5.999883!, 10.00001!)
            Me.XrTable2.Name = "XrTable2"
            Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow5, Me.XrTableRow6, Me.XrTableRow9})
            Me.XrTable2.SizeF = New System.Drawing.SizeF(286.0002!, 75.00003!)
            Me.XrTable2.StylePriority.UseFont = False
            '
            'XrTableRow5
            '
            Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell9, Me.XrTableCell_MesaNumero, Me.XrTableCell_Hora, Me.XrTableCell_Hora_Value})
            Me.XrTableRow5.Dpi = 100.0!
            Me.XrTableRow5.Name = "XrTableRow5"
            Me.XrTableRow5.Weight = 1.0R
            '
            'XrTableCell9
            '
            Me.XrTableCell9.Dpi = 100.0!
            Me.XrTableCell9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell9.Name = "XrTableCell9"
            Me.XrTableCell9.StylePriority.UseFont = False
            Me.XrTableCell9.StylePriority.UseTextAlignment = False
            Me.XrTableCell9.Text = "Mesa:"
            Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.XrTableCell9.Weight = 1.0R
            '
            'XrTableCell_MesaNumero
            '
            Me.XrTableCell_MesaNumero.Dpi = 100.0!
            Me.XrTableCell_MesaNumero.Name = "XrTableCell_MesaNumero"
            Me.XrTableCell_MesaNumero.Weight = 0.84390003743020536R
            '
            'XrTableCell_Hora
            '
            Me.XrTableCell_Hora.Dpi = 100.0!
            Me.XrTableCell_Hora.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell_Hora.Name = "XrTableCell_Hora"
            Me.XrTableCell_Hora.StylePriority.UseFont = False
            Me.XrTableCell_Hora.Text = "Hora: "
            Me.XrTableCell_Hora.Weight = 0.73583104905889762R
            '
            'XrTableCell_Hora_Value
            '
            Me.XrTableCell_Hora_Value.Dpi = 100.0!
            Me.XrTableCell_Hora_Value.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell_Hora_Value.Name = "XrTableCell_Hora_Value"
            Me.XrTableCell_Hora_Value.StylePriority.UseFont = False
            Me.XrTableCell_Hora_Value.Weight = 1.420268913510897R
            '
            'XrTableRow6
            '
            Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell13, Me.XrTableCell_Garzon})
            Me.XrTableRow6.Dpi = 100.0!
            Me.XrTableRow6.Name = "XrTableRow6"
            Me.XrTableRow6.Weight = 1.0R
            '
            'XrTableCell13
            '
            Me.XrTableCell13.Dpi = 100.0!
            Me.XrTableCell13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell13.Name = "XrTableCell13"
            Me.XrTableCell13.StylePriority.UseFont = False
            Me.XrTableCell13.StylePriority.UseTextAlignment = False
            Me.XrTableCell13.Text = "Atiende:"
            Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.XrTableCell13.Weight = 1.0R
            '
            'XrTableCell_Garzon
            '
            Me.XrTableCell_Garzon.Dpi = 100.0!
            Me.XrTableCell_Garzon.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell_Garzon.Name = "XrTableCell_Garzon"
            Me.XrTableCell_Garzon.StylePriority.UseFont = False
            Me.XrTableCell_Garzon.Weight = 3.0R
            '
            'XrTableHeader
            '
            Me.XrTableHeader.Dpi = 100.0!
            Me.XrTableHeader.LocationFloat = New DevExpress.Utils.PointFloat(5.999883!, 100.4166!)
            Me.XrTableHeader.Name = "XrTableHeader"
            Me.XrTableHeader.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
            Me.XrTableHeader.SizeF = New System.Drawing.SizeF(286.0002!, 27.08334!)
            Me.XrTableHeader.StylePriority.UseTextAlignment = False
            Me.XrTableHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'XrTableRow1
            '
            Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3})
            Me.XrTableRow1.Dpi = 100.0!
            Me.XrTableRow1.Name = "XrTableRow1"
            Me.XrTableRow1.Weight = 1.0R
            '
            'XrTableCell1
            '
            Me.XrTableCell1.Dpi = 100.0!
            Me.XrTableCell1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell1.Name = "XrTableCell1"
            Me.XrTableCell1.StylePriority.UseFont = False
            Me.XrTableCell1.Text = "Cant."
            Me.XrTableCell1.Weight = 1.0377998436726075R
            '
            'XrTableCell2
            '
            Me.XrTableCell2.Dpi = 100.0!
            Me.XrTableCell2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell2.Name = "XrTableCell2"
            Me.XrTableCell2.StylePriority.UseFont = False
            Me.XrTableCell2.StylePriority.UseTextAlignment = False
            Me.XrTableCell2.Text = "Nombre"
            Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell2.Weight = 2.895544316383754R
            '
            'XrTableCell3
            '
            Me.XrTableCell3.Dpi = 100.0!
            Me.XrTableCell3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell3.Name = "XrTableCell3"
            Me.XrTableCell3.StylePriority.UseFont = False
            Me.XrTableCell3.Text = "Precio"
            Me.XrTableCell3.Weight = 1.1837474128687067R
            '
            'SumaProductos
            '
            Me.SumaProductos.Expression = "[][[^.Id]==[Id]].Sum([Precio])"
            Me.SumaProductos.Name = "SumaProductos"
            '
            'Cantidad
            '
            Me.Cantidad.DisplayName = "Cantidad"
            Me.Cantidad.Expression = "[][[^.Id]==[Id]].Count()"
            Me.Cantidad.Name = "Cantidad"
            '
            'FormattingRule1
            '
            Me.FormattingRule1.Name = "FormattingRule1"
            '
            'NombreGroup
            '
            Me.NombreGroup.Expression = "Iif([Cantidad]>1,[Nombre]  ,? )"
            Me.NombreGroup.Name = "NombreGroup"
            '
            'ObjectDataSourceMesaDetalle
            '
            Me.ObjectDataSourceMesaDetalle.DataMember = "Producto"
            Me.ObjectDataSourceMesaDetalle.DataSource = GetType(ARIAKA.SMARTGOURMET.Win.Models.MesaDetalleDTO)
            Me.ObjectDataSourceMesaDetalle.Name = "ObjectDataSourceMesaDetalle"
            '
            'XrTableRow9
            '
            Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell_Fecha, Me.XrTableCell_Fecha_Value})
            Me.XrTableRow9.Dpi = 100.0!
            Me.XrTableRow9.Name = "XrTableRow9"
            Me.XrTableRow9.Weight = 1.0R
            '
            'XrTableCell_Fecha
            '
            Me.XrTableCell_Fecha.Dpi = 100.0!
            Me.XrTableCell_Fecha.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell_Fecha.Name = "XrTableCell_Fecha"
            Me.XrTableCell_Fecha.StylePriority.UseFont = False
            Me.XrTableCell_Fecha.StylePriority.UseTextAlignment = False
            Me.XrTableCell_Fecha.Text = "Fecha:"
            Me.XrTableCell_Fecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.XrTableCell_Fecha.Weight = 1.0R
            '
            'XrTableCell_Fecha_Value
            '
            Me.XrTableCell_Fecha_Value.Dpi = 100.0!
            Me.XrTableCell_Fecha_Value.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell_Fecha_Value.Name = "XrTableCell_Fecha_Value"
            Me.XrTableCell_Fecha_Value.StylePriority.UseFont = False
            Me.XrTableCell_Fecha_Value.Weight = 3.0R
            '
            'BoletaReport
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooterBand1, Me.ReportHeaderBand1, Me.GroupHeader1})
            Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.SumaProductos, Me.Cantidad, Me.NombreGroup})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.ObjectDataSourceMesaDetalle})
            Me.DataSource = Me.ObjectDataSourceMesaDetalle
            Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.FormattingRule1})
            Me.Margins = New System.Drawing.Printing.Margins(0, 0, 10, 51)
            Me.PageHeight = 600
            Me.PageWidth = 302
            Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
            Me.PaperName = "4x6pulg."
            Me.PrinterName = "POS-80"
            Me.RollPaper = True
            Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
            Me.Version = "16.1"
            CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XrTableTotales, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XrTableHeader, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ObjectDataSourceMesaDetalle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
        Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Friend WithEvents ObjectDataSourceMesaDetalle As DevExpress.DataAccess.ObjectBinding.ObjectDataSource
        Friend WithEvents PageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
        Friend WithEvents ReportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
        Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
        Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
        Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
        Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
        Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
        Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
        Friend WithEvents SumaProductos As DevExpress.XtraReports.UI.CalculatedField
        Friend WithEvents XrTableHeader As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Cantidad As DevExpress.XtraReports.UI.CalculatedField
        Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableTotales As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_Total As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_Propina As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_MesaNumero As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_Hora As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_Hora_Value As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_Garzon As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
        Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell_TotalAll As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_TotalAll_Value As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents FormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
        Friend WithEvents NombreGroup As DevExpress.XtraReports.UI.CalculatedField
        Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell_Fecha As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_Fecha_Value As DevExpress.XtraReports.UI.XRTableCell
    End Class
End Namespace