using HistoricalTrackingDemoLibrary.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HistoricalTrackingDemo.Controls
{
    public partial class ctlHistoricalDataViewer : System.Web.UI.UserControl
    {
        public IEnumerable<HistoricalData> DataSource { get; set; }

        public delegate void OnFilterData(int iSessionID);
        public event OnFilterData OnFilterDataEventHandler;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public override void DataBind()
        {
            base.DataBind();

            this.rptSessionKeys.DataSource = this.DataSource;
            this.rptSessionKeys.DataBind();
        }

        protected void lnkFilter_Command(object sender, CommandEventArgs e)
        {
            if ("SessionID" == e.CommandName)
                if (null != OnFilterDataEventHandler)
                    this.OnFilterDataEventHandler(int.Parse(e.CommandArgument.ToString()));
        }
    }
}