Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace dxKB2796
    ''' <summary>
    ''' Summary description for XtraReport3.
    ''' </summary>
    Public Class XtraReport1
        Inherits DevExpress.XtraReports.UI.XtraReport

        Private WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
        Private pivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
        Public xrPivotGrid1 As XRPivotGrid
        Private fieldCategoryName As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Private fieldProductName As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Private fieldProductSales As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
        Private productReportsTableAdapter As DataSet1TableAdapters.ProductReportsTableAdapter
        Private dataSet11 As DataSet1
        Private topMarginBand1 As TopMarginBand
        Private bottomMarginBand1 As BottomMarginBand
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New()
            ''' <summary>
            ''' Required for Windows.Forms Class Composition Designer support
            ''' </summary>
            InitializeComponent()
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrPivotGrid1 = New DevExpress.XtraReports.UI.XRPivotGrid()
            Me.productReportsTableAdapter = New DataSet1TableAdapters.ProductReportsTableAdapter()
            Me.dataSet11 = New DataSet1()
            Me.fieldCategoryName = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.fieldProductName = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.fieldProductSales = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
            Me.pivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            DirectCast(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPivotGrid1})
            Me.Detail.HeightF = 245.0F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F)
            Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrPivotGrid1
            ' 
            Me.xrPivotGrid1.DataAdapter = Me.productReportsTableAdapter
            Me.xrPivotGrid1.DataMember = "ProductReports"
            Me.xrPivotGrid1.DataSource = Me.dataSet11
            Me.xrPivotGrid1.Fields.AddRange(New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField() {Me.fieldCategoryName, Me.fieldProductName, Me.fieldProductSales})
            Me.xrPivotGrid1.LocationFloat = New DevExpress.Utils.PointFloat(7.999992F, 7.999992F)
            Me.xrPivotGrid1.Name = "xrPivotGrid1"
            Me.xrPivotGrid1.OptionsChartDataSource.UpdateDelay = 300
            Me.xrPivotGrid1.SizeF = New System.Drawing.SizeF(733.0F, 117.0F)
            ' 
            ' productReportsTableAdapter
            ' 
            Me.productReportsTableAdapter.ClearBeforeFill = True
            ' 
            ' dataSet11
            ' 
            Me.dataSet11.DataSetName = "DataSet1"
            Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' fieldCategoryName
            ' 
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName.AreaIndex = 0
            Me.fieldCategoryName.FieldName = "CategoryName"
            Me.fieldCategoryName.Name = "fieldCategoryName"
            ' 
            ' fieldProductName
            ' 
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName.AreaIndex = 1
            Me.fieldProductName.FieldName = "ProductName"
            Me.fieldProductName.Name = "fieldProductName"
            ' 
            ' fieldProductSales
            ' 
            Me.fieldProductSales.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldProductSales.AreaIndex = 0
            Me.fieldProductSales.FieldName = "ProductSales"
            Me.fieldProductSales.Name = "fieldProductSales"
            ' 
            ' pivotGridField3
            ' 
            Me.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.pivotGridField3.AreaIndex = 0
            Me.pivotGridField3.FieldName = "CategoryName"
            Me.pivotGridField3.Name = "pivotGridField3"
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.HeightF = 48.0F
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' bottomMarginBand1
            ' 
            Me.bottomMarginBand1.HeightF = 48.0F
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.topMarginBand1, Me.bottomMarginBand1})
            Me.Margins = New System.Drawing.Printing.Margins(50, 49, 48, 48)
            Me.Version = "11.1"
            DirectCast(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
#End Region

        Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
        End Sub
    End Class
End Namespace

