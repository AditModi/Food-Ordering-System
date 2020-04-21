using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MenuClient
{
    public partial class UpdateItem : System.Web.UI.Page
    {
        MenuService.Item item = new MenuService.Item();
        MenuService.Service1Client client = new MenuService.Service1Client();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SetPanel(true, false);
            }
        }

        private void SetPanel(bool pSearch, bool pUpdate)
        {
            panSearch.Visible = pSearch;
            panUpdate.Visible = pUpdate;
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
                    txtName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                    txtDesc.Text = ds.Tables[0].Rows[0]["Description"].ToString();
                    txtPrice.Text = ds.Tables[0].Rows[0]["Price"].ToString();
                    txtCg.Text = ds.Tables[0].Rows[0]["Category"].ToString();
                    rbtnSt.Text = ds.Tables[0].Rows[0]["Status"].ToString();
                    rbtnTp.Text = ds.Tables[0].Rows[0]["Type"].ToString();
                    SetPanel(false, true);
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

        protected void bntReset_Click(object sender, EventArgs e)
        {
            SetPanel(true, false);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            SetPanel(true, false);
            lblMsg.Text = "";
        }

        protected void bntUpdated_Click(object sender, EventArgs e)
        {
            if(txtPrice.Text!="" && txtName.Text != "")
            {
                item.Id = Convert.ToInt32(txtSearch.Text.Trim());
                item.Name = txtName.Text;
                item.Status = rbtnSt.SelectedItem.Text;
                item.Description = txtDesc.Text;
                item.Price = Convert.ToInt32(txtPrice.Text);
                item.Category = txtCg.Text;
                item.Type = rbtnTp.SelectedItem.Text;
                lblMsg.Text=client.UpdateItem(item);
            }
            else
            {
                lblMsg.Text = "Please enter valid details";
            }
        }
    }
}