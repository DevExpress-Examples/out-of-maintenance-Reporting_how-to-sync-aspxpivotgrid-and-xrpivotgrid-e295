Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.Data
Imports DevExpress.XtraReports.UI
Imports dxKB2796
Imports DevExpress.XtraReports.UI.PivotGrid
' ...

Namespace WebApplication1
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			' Call the DataBind() method before trying to access the report and the grid.
			DataBind()

			Dim s As New XmlXtraSerializer()
			Using stream As New MemoryStream()
				s.SerializeObject(ASPxPivotGrid1, stream, "PivotGrid")

				Using collapsed As New MemoryStream()
					Me.ASPxPivotGrid1.Data.SaveCollapsedStateToStream(collapsed)

					stream.Position = 0

					Dim pivotGrid As XRPivotGrid = (CType(ReportViewer1.Report, XtraReport1)).xrPivotGrid1
					Dim data As PivotGridData = (CType(pivotGrid, IPivotGridDataContainer)).Data
					s.DeserializeObject(pivotGrid, stream, "PivotGrid")

					collapsed.Position = 0

					Dim adapter As WebApplication1.DataSet1TableAdapters.ProductReportsTableAdapter = CType(pivotGrid.DataAdapter, WebApplication1.DataSet1TableAdapters.ProductReportsTableAdapter)
					Dim dataSet As WebApplication1.DataSet1 = CType(pivotGrid.DataSource, WebApplication1.DataSet1)
					adapter.Fill(dataSet.ProductReports)
					data.LoadCollapsedStateFromStream(collapsed)
					data.LayoutChanged()
				End Using
			End Using
		End Sub
	End Class
End Namespace
