Imports System
Imports System.IO
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.Data
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UI.PivotGrid
Imports WebApplication1.dxKB2796

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

                    Dim pivotGrid As XRPivotGrid = CType(ReportViewer1.Report, XtraReport1).xrPivotGrid1
                    Dim data As PivotGridData = DirectCast(pivotGrid, IPivotGridDataContainer).Data
                    s.DeserializeObject(pivotGrid, stream, "PivotGrid")

                    collapsed.Position = 0


                    Dim adapter_Renamed As DataSet1TableAdapters.ProductReportsTableAdapter = CType(pivotGrid.DataAdapter, DataSet1TableAdapters.ProductReportsTableAdapter)
                    Dim dataSet As DataSet1 = CType(pivotGrid.DataSource, DataSet1)
                    adapter_Renamed.Fill(dataSet.ProductReports)
                    data.LoadCollapsedStateFromStream(collapsed)
                    data.LayoutChanged()
                End Using
            End Using
        End Sub
    End Class
End Namespace
