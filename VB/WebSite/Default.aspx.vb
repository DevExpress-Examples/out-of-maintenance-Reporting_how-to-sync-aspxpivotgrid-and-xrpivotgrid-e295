Imports System
Imports System.IO
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.Data
Imports DevExpress.XtraReports.UI
Imports dxKB2796
Imports DevExpress.XtraReports.UI.PivotGrid
Imports DevExpress.Web.ASPxPivotGrid
' ...

Namespace WebApplication1
	Partial Public Class _Default
		Inherits System.Web.UI.Page

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		End Sub

		Protected Sub ASPxPivotGrid1_AfterPerformCallback(ByVal sender As Object, ByVal e As EventArgs)
			Dim pivot As ASPxPivotGrid = TryCast(sender, ASPxPivotGrid)

			Dim s As New XmlXtraSerializer()
			Using stream As New MemoryStream()
				s.SerializeObject(pivot, stream, "PivotGrid")
				Session("Layout") = stream.ToArray()
			End Using

			Using collapsed As New MemoryStream()
				pivot.Data.SaveCollapsedStateToStream(collapsed)
				Session("CollapsedState") = collapsed.ToArray()
			End Using
		End Sub
	End Class
End Namespace
