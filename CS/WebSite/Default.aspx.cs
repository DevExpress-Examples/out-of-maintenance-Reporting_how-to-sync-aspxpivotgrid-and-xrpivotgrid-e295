using System;
using System.IO;
using DevExpress.Utils.Serializing;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Data;
using DevExpress.XtraReports.UI;
using dxKB2796;
using DevExpress.XtraReports.UI.PivotGrid;
using DevExpress.Web.ASPxPivotGrid;
// ...

namespace WebApplication1 {
    public partial class _Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
        }

        protected void ASPxPivotGrid1_AfterPerformCallback(object sender, EventArgs e) {
            ASPxPivotGrid pivot = sender as ASPxPivotGrid;

            XmlXtraSerializer s = new XmlXtraSerializer();
            using (MemoryStream stream = new MemoryStream()) {
                s.SerializeObject(pivot, stream, "PivotGrid");
                Session["Layout"] = stream.ToArray();
            }

            using (MemoryStream collapsed = new MemoryStream()) {
                pivot.Data.SaveCollapsedStateToStream(collapsed);
                Session["CollapsedState"] = collapsed.ToArray();
            }
        }
    }
}
