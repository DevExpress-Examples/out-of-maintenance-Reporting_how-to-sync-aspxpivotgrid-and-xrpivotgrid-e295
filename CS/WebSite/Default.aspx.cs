using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using dxKB2796;
using DevExpress.Utils.Serializing;
using System.IO;
using DevExpress.XtraPivotGrid.Data;
using System.Reflection;
using DevExpress.Web.ASPxPivotGrid.Data;
using DevExpress.XtraReports.UI;

namespace WebApplication1 {
	public partial class _Default : System.Web.UI.Page {
		protected void Page_Load(object sender, EventArgs e) {
			
		}

		private void SyncPivots() {
			XmlXtraSerializer s = new XmlXtraSerializer();
			using(MemoryStream stream = new MemoryStream()) {
				s.SerializeObject(ASPxPivotGrid1, stream, "PivotGrid");

                MemoryStream collapsed = new MemoryStream();
                this.ASPxPivotGrid1.Data.SaveCollapsedStateToStream(collapsed);

          		stream.Position = 0;

				XRPivotGrid xrPivotGrid1 = ((XtraReport1)ReportViewer1.Report).xrPivotGrid1;
				PropertyInfo prop = xrPivotGrid1.GetType().GetProperty("Data", BindingFlags.Instance | BindingFlags.NonPublic);
				PivotGridViewInfoData data = (PivotGridViewInfoData)prop.GetValue(xrPivotGrid1, null);
				s.DeserializeObject(data, stream, "PivotGrid");
                

                collapsed.Position = 0;
				WebApplication1.DataSet1TableAdapters.ProductReportsTableAdapter adapter = (WebApplication1.DataSet1TableAdapters.ProductReportsTableAdapter)xrPivotGrid1.DataAdapter;
                WebApplication1.DataSet1 dataSet = (WebApplication1.DataSet1)xrPivotGrid1.DataSource;
                adapter.Fill(dataSet.ProductReports);
                data.LoadCollapsedStateFromStream(collapsed);
                data.LayoutChanged();
                collapsed.Close();
			}

   
		}

		protected void ASPxPivotGrid1_PreRender(object sender, EventArgs e) {
			SyncPivots();
		}		
	}
}
