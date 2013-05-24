using HistoricalTrackingDemoLibrary.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HistoricalTrackingDemo
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ctlHistoricalDataViewer.OnFilterDataEventHandler += ctlHistoricalDataViewer_OnFilterDataEventHandler;
            this.ctlFilteredHistoricalDataViewer.OnRemoveFilterEventHandler += ctlFilteredHistoricalDataViewer_OnRemoveFilterEventHandler;

            BindData();
        }

        void ctlFilteredHistoricalDataViewer_OnRemoveFilterEventHandler()
        {
            BindData();
        }

        void ctlHistoricalDataViewer_OnFilterDataEventHandler(int iSessionID)
        {
            BindFilteredData(iSessionID);
        }

        private void BindData()
        {
            var data = HistoricalDataServer.GetHistoricalDataList();

            this.ctlHistoricalDataViewer.Visible = true;
            this.ctlFilteredHistoricalDataViewer.Visible = false;

            this.ctlHistoricalDataViewer.DataSource = data;
            this.ctlHistoricalDataViewer.DataBind();
        }

        private void BindFilteredData(int iSessionID)
        {
            var data = HistoricalDataServer.GetFilteredHistoricalData(iSessionID);

            this.ctlHistoricalDataViewer.Visible = false;
            this.ctlFilteredHistoricalDataViewer.Visible = true;

            this.ctlFilteredHistoricalDataViewer.DataSource = data;
            this.ctlFilteredHistoricalDataViewer.DataBind();
        }
    }
}