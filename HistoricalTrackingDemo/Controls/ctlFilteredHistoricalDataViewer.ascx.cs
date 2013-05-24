using HistoricalTrackingDemoLibrary.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HistoricalTrackingDemo.Controls
{
    public partial class ctlFilteredHistoricalDataViewer : System.Web.UI.UserControl
    {
        public IEnumerable<HistoricalData> DataSource { get; set; }

        public delegate void OnRemoveFilter();
        public event OnRemoveFilter OnRemoveFilterEventHandler;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public override void DataBind()
        {
            base.DataBind();

            this.rptSessionKeys.DataSource = this.DataSource;
            this.rptSessionKeys.DataBind();
        }

        protected void lnkRemoveFilter_Command(object sender, CommandEventArgs e)
        {
            if ("RemoveFilter" == e.CommandArgument.ToString())
                if (null != OnRemoveFilterEventHandler)
                    this.OnRemoveFilterEventHandler();
        }
    }
}