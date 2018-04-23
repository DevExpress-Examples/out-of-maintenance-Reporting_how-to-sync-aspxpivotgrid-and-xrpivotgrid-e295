Imports Microsoft.VisualBasic
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
		Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
		Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand
		Private pivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField
		Public xrPivotGrid1 As XRPivotGrid
		Private fieldCategoryName As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldProductName As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldProductSales As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private productReportsTableAdapter As WebApplication1.DataSet1TableAdapters.ProductReportsTableAdapter
		Private dataSet11 As WebApplication1.DataSet1
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
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
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
			Me.fieldCategoryName = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldProductName = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldProductSales = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
			Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
			Me.pivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.dataSet11 = New WebApplication1.DataSet1()
			Me.productReportsTableAdapter = New WebApplication1.DataSet1TableAdapters.ProductReportsTableAdapter()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPivotGrid1})
			Me.Detail.Height = 245
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
'			Me.Detail.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.Detail_BeforePrint);
			' 
			' xrPivotGrid1
			' 
			Me.xrPivotGrid1.DataAdapter = Me.productReportsTableAdapter
			Me.xrPivotGrid1.DataMember = "ProductReports"
			Me.xrPivotGrid1.DataSource = Me.dataSet11
			Me.xrPivotGrid1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCategoryName, Me.fieldProductName, Me.fieldProductSales})
			Me.xrPivotGrid1.Location = New System.Drawing.Point(8, 8)
			Me.xrPivotGrid1.Name = "xrPivotGrid1"
			Me.xrPivotGrid1.Size = New System.Drawing.Size(342, 117)
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
			' PageHeader
			' 
			Me.PageHeader.Height = 30
			Me.PageHeader.Name = "PageHeader"
			Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' PageFooter
			' 
			Me.PageFooter.Height = 30
			Me.PageFooter.Name = "PageFooter"
			Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' pivotGridField3
			' 
			Me.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.pivotGridField3.AreaIndex = 0
			Me.pivotGridField3.FieldName = "CategoryName"
			Me.pivotGridField3.Name = "pivotGridField3"
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' productReportsTableAdapter
			' 
			Me.productReportsTableAdapter.ClearBeforeFill = True
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.PageHeader, Me.PageFooter})
			Me.Version = "8.1"
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub
		#End Region

		Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
		End Sub
	End Class
End Namespace

