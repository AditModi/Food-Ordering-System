using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MenuClient
{
    public partial class DisplayItems : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MenuService.Service1Client client = new MenuService.Service1Client();
            grdItems.DataSource = client.getItems();
            grdItems.DataBind();
        }
    }
}