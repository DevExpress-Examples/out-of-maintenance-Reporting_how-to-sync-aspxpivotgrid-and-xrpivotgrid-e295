<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v18.1.Web.WebForms" Namespace="DevExpress.XtraReports.Web"
    TagPrefix="dxxr" %>

<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v18.1, Version=18.1.18.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dxwpg" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>

    <script type="text/javascript">
        function onInit(s, e) {
            viewer.OpenReport("PivotGrid");
        }
        function onEndCallback(s, e) {
            viewer.Close();
            viewer.OpenReport("PivotGrid");
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dxwpg:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" CssClass="" DataSourceID="AccessDataSource1" OnAfterPerformCallback="ASPxPivotGrid1_AfterPerformCallback">
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
                <ClientSideEvents Init="onInit" EndCallback="onEndCallback" />
            </dxwpg:ASPxPivotGrid>
            <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/nwind.mdb" SelectCommand="SELECT * FROM [ProductReports]"></asp:AccessDataSource>

            <dxxr:ASPxWebDocumentViewer ID="ASPxWebDocumentViewer1" runat="server" ClientInstanceName="viewer">
            </dxxr:ASPxWebDocumentViewer>
        </div>
    </form>
</body>
</html>
