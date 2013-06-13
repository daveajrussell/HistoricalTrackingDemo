using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeV2_WebForm.Controls
{
    public class SiteSelection
    {
        public string Display { get; set; }
        public string URL { get; set; }
        public string Target { get; set; }
    }

    public partial class ctlSiteSelection : System.Web.UI.UserControl
    {
        private List<SiteSelection> _siteItems = new List<SiteSelection>()
        {
            new SiteSelection()
            {
                Display = "Projects",
                URL = "http://www.daveajrussell.com/Projects",
                Target = "_self"
            },
            new SiteSelection()
            {
                Display = "Contact",
                URL = "http://www.daveajrussell.com/Contact",
                Target = "_self"
            },
            new SiteSelection()
            {
                Display = "Blog",
                URL = "http://daveajrussell.wordpress.com/",
                Target = "_blank"
            },
            new SiteSelection()
            {
                Display = "Acknowledgements",
                URL = "http://www.daveajrussell.com/Acknowledgements",
                Target = "_self"
            }
        };

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Bind();
        }

        private void Bind()
        {
            this.rptSiteSelection.DataSource = _siteItems;
            this.rptSiteSelection.DataBind();
        }
    }
}