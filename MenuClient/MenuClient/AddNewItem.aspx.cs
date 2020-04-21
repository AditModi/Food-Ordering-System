using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MenuClient
{
    public partial class AddNewItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtCg.Text = "";
                txtDesc.Text = "";
                txtName.Text = "";
                txtPrice.Text = "";
                txtName.Focus();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if(txtPrice.Text!="" && txtName.Text != "")
            {
                MenuService.Item item = new MenuService.Item()
                {
                    Name = txtName.Text,
                    Description = txtDesc.Text,
                    Price = Convert.ToInt32(txtPrice.Text),
                    Category = txtCg.Text,
                    Status = rbtnSt.SelectedItem.Text,
                    Type = rbtnTp.SelectedItem.Text
                };
                MenuService.Service1Client client = new MenuService.Service1Client();
                lblMsg.Text=client.AddItem(item);
            }
            else
            {

                lblMsg.Text = "All fields are mandatory! ";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void bntReset_Click(object sender, EventArgs e)
        {
            txtCg.Text = "";
            txtDesc.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtName.Focus();
        }

        
    }
}