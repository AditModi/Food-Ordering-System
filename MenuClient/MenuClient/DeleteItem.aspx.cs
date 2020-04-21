using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MenuClient
{
    public partial class DeleteItem : System.Web.UI.Page
    {
        MenuService.Item item = new MenuService.Item();
        MenuService.Service1Client client = new MenuService.Service1Client();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            grdItems.Visible = false;
            btnCancel.Visible = false;
            btnDelete.Visible = false;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                item.Id = Convert.ToInt32(txtSearch.Text.Trim());
                lblResult.Text=client.DeleteItem(item);
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            grdItems.Visible = false;
            btnCancel.Visible = false;
            btnDelete.Visible = false;
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                item.Id = Convert.ToInt32(txtSearch.Text.Trim());
                ds = new DataSet();
                ds = client.SearchItem(item);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    grdItems.DataSource = ds;
                    grdItems.DataBind();
                    grdItems.Visible = true;
                    btnCancel.Visible = true;
                    btnDelete.Visible = true;
                    
                   
                    
                }
                else
                {
                    lblSearchResult.Text = "Please Enter valid Item ID !";
                    lblSearchResult.ForeColor = System.Drawing.Color.White;
                }

            }
            else
            {
                lblSearchResult.Text = "Please Enter Item ID !";
            }
        }
    }
    
}