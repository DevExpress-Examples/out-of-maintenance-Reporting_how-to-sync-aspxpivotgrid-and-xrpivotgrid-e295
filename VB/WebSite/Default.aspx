<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication1._Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v13.1.Web" Namespace="DevExpress.XtraReports.Web"
	TagPrefix="dxxr" %>

<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dxwpg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Untitled Page</title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<dxwpg:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" CssClass="" DataSourceID="AccessDataSource1" 
		EnableCallBacks="False" >
			<Fields>
				<dxwpg:PivotGridField ID="fieldCategoryName" Area="RowArea" AreaIndex="0" FieldName="CategoryName">
				</dxwpg:PivotGridField>
				<dxwpg:PivotGridField ID="fieldProductName" Area="FilterArea" AreaIndex="1" FieldName="ProductName">
				</dxwpg:PivotGridField>
				<dxwpg:PivotGridField ID="fieldProductSales" Area="DataArea" AreaIndex="0" FieldName="ProductSales">
				</dxwpg:PivotGridField>
				<dxwpg:PivotGridField ID="fieldShippedDate" Area="FilterArea" AreaIndex="0" FieldName="ShippedDate">
				</dxwpg:PivotGridField>
			</Fields>
			<%--<OptionsView ShowContextMenusForAllFieldValues="False" />--%>
		</dxwpg:ASPxPivotGrid>
		&nbsp;<br />
		<br />
		<dxxr:ReportViewer ID="ReportViewer1" runat="server" Report="<%#New dxKB2796.XtraReport1()%>" ReportName="dxKB2796.XtraReport1" >
		</dxxr:ReportViewer>
		<br />
		<br />
		<asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/nwind.mdb" SelectCommand="SELECT * FROM [ProductReports]"></asp:AccessDataSource>
	</div>
	</form>
</body>
</html>