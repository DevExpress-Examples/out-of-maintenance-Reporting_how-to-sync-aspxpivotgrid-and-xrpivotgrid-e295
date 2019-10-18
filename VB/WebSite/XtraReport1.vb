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
		Private topMarginBand1 As TopMarginBand
		Private bottomMarginBand1 As BottomMarginBand
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private components As IContainer

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
			Me.components = New System.ComponentModel.Container()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrPivotGrid1 = New DevExpress.XtraReports.UI.XRPivotGrid()
			Me.fieldCategoryName = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldProductName = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldProductSales = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.pivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPivotGrid1})
			Me.Detail.HeightF = 245F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
			' 
			' xrPivotGrid1
			' 
			Me.xrPivotGrid1.Appearance.Cell.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.xrPivotGrid1.Appearance.CustomTotalCell.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.xrPivotGrid1.Appearance.FieldHeader.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.xrPivotGrid1.Appearance.FieldValue.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.xrPivotGrid1.Appearance.FieldValueGrandTotal.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.xrPivotGrid1.Appearance.FieldValueTotal.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.xrPivotGrid1.Appearance.GrandTotalCell.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.xrPivotGrid1.Appearance.Lines.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.xrPivotGrid1.Appearance.TotalCell.Font = New System.Drawing.Font("Tahoma", 8.25F)
			Me.xrPivotGrid1.DataMember = "ProductReports"
			Me.xrPivotGrid1.DataSource = Me.sqlDataSource1
			Me.xrPivotGrid1.Fields.AddRange(New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField() { Me.fieldCategoryName, Me.fieldProductName, Me.fieldProductSales})
			Me.xrPivotGrid1.LocationFloat = New DevExpress.Utils.PointFloat(7.999992F, 7.999992F)
			Me.xrPivotGrid1.Name = "xrPivotGrid1"
			Me.xrPivotGrid1.SizeF = New System.Drawing.SizeF(733F, 117F)
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
			Me.topMarginBand1.HeightF = 48F
			Me.topMarginBand1.Name = "topMarginBand1"
			' 
			' bottomMarginBand1
			' 
			Me.bottomMarginBand1.HeightF = 48F
			Me.bottomMarginBand1.Name = "bottomMarginBand1"
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "nwindConnectionString"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression1.ColumnName = "CategoryName"
			table1.Name = "ProductReports"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "ProductName"
			columnExpression2.Table = table1
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "ProductSales"
			columnExpression3.Table = table1
			column3.Expression = columnExpression3
			columnExpression4.ColumnName = "ShippedDate"
			columnExpression4.Table = table1
			column4.Expression = columnExpression4
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Columns.Add(column4)
			selectQuery1.Name = "ProductReports"
			selectQuery1.Tables.Add(table1)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.topMarginBand1, Me.bottomMarginBand1})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.Margins = New System.Drawing.Printing.Margins(50, 49, 48, 48)
			Me.Version = "18.1"
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub
		#End Region

		Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
		End Sub
	End Class
End Namespace

