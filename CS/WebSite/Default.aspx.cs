using System;
using System.IO;
using DevExpress.Utils.Serializing;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Data;
using DevExpress.XtraReports.UI;
using dxKB2796;
using DevExpress.XtraReports.UI.PivotGrid;
// ...

namespace WebApplication1 {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            // Call the DataBind() method before trying to access the report and the grid.
            DataBind();

            XmlXtraSerializer s = new XmlXtraSerializer();
            using (MemoryStream stream = new MemoryStream()) {
                s.SerializeObject(ASPxPivotGrid1, stream, "PivotGrid");

                using (MemoryStream collapsed = new MemoryStream()) {
                    this.ASPxPivotGrid1.Data.SaveCollapsedStateToStream(collapsed);

                    stream.Position = 0;

                    XRPivotGrid pivotGrid = ((XtraReport1)ReportViewer1.Report).xrPivotGrid1;
                    PivotGridData data = ((IPivotGridDataContainer)pivotGrid).Data;
                    s.DeserializeObject(pivotGrid, stream, "PivotGrid");

                    collapsed.Position = 0;

                    WebApplication1.DataSet1TableAdapters.ProductReportsTableAdapter adapter =
                        (WebApplication1.DataSet1TableAdapters.ProductReportsTableAdapter)pivotGrid.DataAdapter;
                    WebApplication1.DataSet1 dataSet = (WebApplication1.DataSet1)pivotGrid.DataSource;
                    adapter.Fill(dataSet.ProductReports);
                    data.LoadCollapsedStateFromStream(collapsed);
                    data.LayoutChanged();
                    }
                }
            }
        }
    }
