﻿Namespace PDF
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
            Me.XrTableTotales = New DevExpress.XtraReports.UI.XRTable()
            Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell_Total = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell_Propina = New DevExpress.XtraReports.UI.XRTableCell()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.GroupHeaderBand1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.PageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
            Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
            Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
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
            Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell_Fecha = New DevExpress.XtraReports.UI.XRTableCell()
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
            Me.ObjectDataSourceMesaDetalle = New DevExpress.DataAccess.ObjectBinding.ObjectDataSource(Me.components)
            CType(Me.XrTableTotales, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.Detail.HeightF = 22.99998!
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Detail.StyleName = "DataField"
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'XrTableTotales
            '
            Me.XrTableTotales.Dpi = 100.0!
            Me.XrTableTotales.LocationFloat = New DevExpress.Utils.PointFloat(155.2083!, 36.45833!)
            Me.XrTableTotales.Name = "XrTableTotales"
            Me.XrTableTotales.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3, Me.XrTableRow4})
            Me.XrTableTotales.SizeF = New System.Drawing.SizeF(197.7917!, 50.0!)
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
            Me.XrTableCell8.Text = "Total:"
            Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.XrTableCell8.Weight = 1.812385301615064R
            '
            'XrTableCell_Total
            '
            Me.XrTableCell_Total.Dpi = 100.0!
            Me.XrTableCell_Total.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell_Total.Name = "XrTableCell_Total"
            Me.XrTableCell_Total.StylePriority.UseFont = False
            Me.XrTableCell_Total.StylePriority.UseTextAlignment = False
            Me.XrTableCell_Total.Text = "0"
            Me.XrTableCell_Total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            Me.XrTableCell_Total.Weight = 0.88886680078970637R
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
            Me.XrTableCell7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell7.Name = "XrTableCell7"
            Me.XrTableCell7.StylePriority.UseFont = False
            Me.XrTableCell7.StylePriority.UseTextAlignment = False
            Me.XrTableCell7.Text = "Propina 10%:"
            Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.XrTableCell7.Weight = 1.812385301615064R
            '
            'XrTableCell_Propina
            '
            Me.XrTableCell_Propina.Dpi = 100.0!
            Me.XrTableCell_Propina.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell_Propina.Name = "XrTableCell_Propina"
            Me.XrTableCell_Propina.StylePriority.UseFont = False
            Me.XrTableCell_Propina.StylePriority.UseTextAlignment = False
            Me.XrTableCell_Propina.Text = "0"
            Me.XrTableCell_Propina.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            Me.XrTableCell_Propina.Weight = 0.88886680078970637R
            '
            'TopMargin
            '
            Me.TopMargin.Dpi = 100.0!
            Me.TopMargin.HeightF = 54.0!
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'BottomMargin
            '
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
            Me.BottomMargin.Dpi = 100.0!
            Me.BottomMargin.HeightF = 58.41668!
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'GroupHeaderBand1
            '
            Me.GroupHeaderBand1.Dpi = 100.0!
            Me.GroupHeaderBand1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("Precio", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
            Me.GroupHeaderBand1.HeightF = 0!
            Me.GroupHeaderBand1.Name = "GroupHeaderBand1"
            Me.GroupHeaderBand1.StyleName = "DataField"
            '
            'XrTable1
            '
            Me.XrTable1.Dpi = 100.0!
            Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.0001271566!, 0!)
            Me.XrTable1.Name = "XrTable1"
            Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
            Me.XrTable1.SizeF = New System.Drawing.SizeF(353.0!, 22.99998!)
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
            Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SumaProductos")})
            Me.XrTableCell4.Dpi = 100.0!
            Me.XrTableCell4.Name = "XrTableCell4"
            Me.XrTableCell4.StylePriority.UseTextAlignment = False
            Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            Me.XrTableCell4.Weight = 0.75447187921940273R
            '
            'XrTableCell5
            '
            Me.XrTableCell5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Nombre")})
            Me.XrTableCell5.Dpi = 100.0!
            Me.XrTableCell5.Name = "XrTableCell5"
            Me.XrTableCell5.StylePriority.UseTextAlignment = False
            Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            Me.XrTableCell5.Weight = 1.6923997872541028R
            '
            'XrTableCell6
            '
            Me.XrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Precio")})
            Me.XrTableCell6.Dpi = 100.0!
            Me.XrTableCell6.Name = "XrTableCell6"
            Me.XrTableCell6.StylePriority.UseTextAlignment = False
            Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
            Me.XrTableCell6.Weight = 0.55312833352649449R
            '
            'PageFooterBand1
            '
            Me.PageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTableTotales})
            Me.PageFooterBand1.Dpi = 100.0!
            Me.PageFooterBand1.HeightF = 86.45834!
            Me.PageFooterBand1.Name = "PageFooterBand1"
            '
            'XrTable3
            '
            Me.XrTable3.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
            Me.XrTable3.Dpi = 100.0!
            Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(5.999883!, 23.41677!)
            Me.XrTable3.Name = "XrTable3"
            Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow7})
            Me.XrTable3.SizeF = New System.Drawing.SizeF(347.0001!, 24.99994!)
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
            Me.XrTableCell15.Name = "XrTableCell15"
            Me.XrTableCell15.Text = "************ Gracias por su preferencia****************"
            Me.XrTableCell15.Weight = 3.0R
            '
            'ReportHeaderBand1
            '
            Me.ReportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel15, Me.XrLine3})
            Me.ReportHeaderBand1.Dpi = 100.0!
            Me.ReportHeaderBand1.HeightF = 48.6667!
            Me.ReportHeaderBand1.Name = "ReportHeaderBand1"
            '
            'XrLabel15
            '
            Me.XrLabel15.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
            Me.XrLabel15.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
            Me.XrLabel15.AutoWidth = True
            Me.XrLabel15.CanGrow = False
            Me.XrLabel15.Dpi = 100.0!
            Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(9.999974!, 10.00001!)
            Me.XrLabel15.Name = "XrLabel15"
            Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel15.SizeF = New System.Drawing.SizeF(336.0!, 38.66669!)
            Me.XrLabel15.StyleName = "Title"
            Me.XrLabel15.StylePriority.UseTextAlignment = False
            Me.XrLabel15.Text = "Cafe Late"
            Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'XrLine3
            '
            Me.XrLine3.Dpi = 100.0!
            Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(9.999974!, 10.00001!)
            Me.XrLine3.Name = "XrLine3"
            Me.XrLine3.SizeF = New System.Drawing.SizeF(333.0!, 2.0!)
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
            Me.GroupHeader1.HeightF = 100.0!
            Me.GroupHeader1.Level = 1
            Me.GroupHeader1.Name = "GroupHeader1"
            '
            'XrLine1
            '
            Me.XrLine1.Dpi = 100.0!
            Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(13.54167!, 0!)
            Me.XrLine1.Name = "XrLine1"
            Me.XrLine1.SizeF = New System.Drawing.SizeF(329.4583!, 4.166667!)
            '
            'XrTable2
            '
            Me.XrTable2.Dpi = 100.0!
            Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(6.00001!, 10.00001!)
            Me.XrTable2.Name = "XrTable2"
            Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow5, Me.XrTableRow6})
            Me.XrTable2.SizeF = New System.Drawing.SizeF(347.0!, 50.0!)
            '
            'XrTableRow5
            '
            Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell9, Me.XrTableCell_MesaNumero, Me.XrTableCell10, Me.XrTableCell_Fecha})
            Me.XrTableRow5.Dpi = 100.0!
            Me.XrTableRow5.Name = "XrTableRow5"
            Me.XrTableRow5.Weight = 1.0R
            '
            'XrTableCell9
            '
            Me.XrTableCell9.Dpi = 100.0!
            Me.XrTableCell9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
            Me.XrTableCell_MesaNumero.Weight = 1.0R
            '
            'XrTableCell10
            '
            Me.XrTableCell10.Dpi = 100.0!
            Me.XrTableCell10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell10.Name = "XrTableCell10"
            Me.XrTableCell10.StylePriority.UseFont = False
            Me.XrTableCell10.Text = "Fecha:"
            Me.XrTableCell10.Weight = 0.579731086489103R
            '
            'XrTableCell_Fecha
            '
            Me.XrTableCell_Fecha.Dpi = 100.0!
            Me.XrTableCell_Fecha.Name = "XrTableCell_Fecha"
            Me.XrTableCell_Fecha.Weight = 1.420268913510897R
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
            Me.XrTableCell13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
            Me.XrTableCell_Garzon.Name = "XrTableCell_Garzon"
            Me.XrTableCell_Garzon.Weight = 3.0R
            '
            'XrTableHeader
            '
            Me.XrTableHeader.Dpi = 100.0!
            Me.XrTableHeader.LocationFloat = New DevExpress.Utils.PointFloat(0!, 75.0!)
            Me.XrTableHeader.Name = "XrTableHeader"
            Me.XrTableHeader.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
            Me.XrTableHeader.SizeF = New System.Drawing.SizeF(353.0001!, 25.0!)
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
            Me.XrTableCell1.Name = "XrTableCell1"
            Me.XrTableCell1.Text = "Cantidad"
            Me.XrTableCell1.Weight = 1.0377998436726075R
            '
            'XrTableCell2
            '
            Me.XrTableCell2.Dpi = 100.0!
            Me.XrTableCell2.Name = "XrTableCell2"
            Me.XrTableCell2.Text = "Nombre"
            Me.XrTableCell2.Weight = 2.3279492208627444R
            '
            'XrTableCell3
            '
            Me.XrTableCell3.Dpi = 100.0!
            Me.XrTableCell3.Name = "XrTableCell3"
            Me.XrTableCell3.Text = "Precio"
            Me.XrTableCell3.Weight = 0.76084700480058554R
            '
            'SumaProductos
            '
            Me.SumaProductos.Name = "SumaProductos"
            '
            'Cantidad
            '
            Me.Cantidad.DisplayName = "Cantidad"
            Me.Cantidad.Name = "Cantidad"
            '
            'ObjectDataSourceMesaDetalle
            '
            Me.ObjectDataSourceMesaDetalle.DataMember = "Producto"
            Me.ObjectDataSourceMesaDetalle.DataSource = GetType(ARIAKA.SMARTGOURMET.Win.Models.MesaDetalleDTO)
            Me.ObjectDataSourceMesaDetalle.Name = "ObjectDataSourceMesaDetalle"
            '
            'BoletaReport
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeaderBand1, Me.PageFooterBand1, Me.ReportHeaderBand1, Me.GroupHeader1})
            Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.SumaProductos, Me.Cantidad})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.ObjectDataSourceMesaDetalle})
            Me.DataSource = Me.ObjectDataSourceMesaDetalle
            Me.Margins = New System.Drawing.Printing.Margins(0, 3, 54, 58)
            Me.PageHeight = 600
            Me.PageWidth = 359
            Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
            Me.PaperName = "4x6pulg."
            Me.RollPaper = True
            Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
            Me.Version = "16.1"
            CType(Me.XrTableTotales, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
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
        Friend WithEvents GroupHeaderBand1 As DevExpress.XtraReports.UI.GroupHeaderBand
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
        Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_Fecha As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_Garzon As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
        Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    End Class
End Namespace