Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports dxKB2796
Imports DevExpress.Utils.Serializing
Imports System.IO
Imports DevExpress.XtraPivotGrid.Data
Imports System.Reflection
Imports DevExpress.Web.ASPxPivotGrid.Data
Imports DevExpress.XtraReports.UI

Namespace WebApplication1
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Private Sub SyncPivots()
			Dim s As New XmlXtraSerializer()
			Using stream As New MemoryStream()
				s.SerializeObject(ASPxPivotGrid1, stream, "PivotGrid")

				Dim collapsed As New MemoryStream()
				Me.ASPxPivotGrid1.Data.SaveCollapsedStateToStream(collapsed)

				  stream.Position = 0

				Dim xrPivotGrid1 As XRPivotGrid = (CType(ReportViewer1.Report, XtraReport1)).xrPivotGrid1
				Dim prop As PropertyInfo = xrPivotGrid1.GetType().GetProperty("Data", BindingFlags.Instance Or BindingFlags.NonPublic)
				Dim data As PivotGridViewInfoData = CType(prop.GetValue(xrPivotGrid1, Nothing), PivotGridViewInfoData)
				s.DeserializeObject(data, stream, "PivotGrid")


				collapsed.Position = 0
				Dim adapter As WebApplication1.DataSet1TableAdapters.ProductReportsTableAdapter = CType(xrPivotGrid1.DataAdapter, WebApplication1.DataSet1TableAdapters.ProductReportsTableAdapter)
				Dim dataSet As WebApplication1.DataSet1 = CType(xrPivotGrid1.DataSource, WebApplication1.DataSet1)
				adapter.Fill(dataSet.ProductReports)
				data.LoadCollapsedStateFromStream(collapsed)
				data.LayoutChanged()
				collapsed.Close()
			End Using


		End Sub

		Protected Sub ASPxPivotGrid1_PreRender(ByVal sender As Object, ByVal e As EventArgs)
			SyncPivots()
		End Sub
	End Class
End Namespace
