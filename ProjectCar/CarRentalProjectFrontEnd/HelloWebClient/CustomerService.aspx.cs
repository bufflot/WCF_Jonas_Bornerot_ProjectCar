using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

namespace HelloWebClient
{
    public partial class CustomerService : System.Web.UI.Page
    {
        WcfServiceCustomerHost.ServiceCustomerClient client = new WcfServiceCustomerHost.ServiceCustomerClient("WSHttpBinding_IServiceCustomer");


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCustomers();
            }
        }

        protected void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbTel.Text == "")
                {
                    tbTel.Text = "0";
                };
                client.AddCustomer(tbFirstName.Text, tbLastName.Text, tbEmail.Text, (Convert.ToInt32(tbTel.Text)));
                tbFirstName.Text = "";
                tbLastName.Text = "";
                tbEmail.Text = "";
                tbTel.Text = "";
                lblError.Text = "Customer Added to Database";
                LoadCustomers();
            }
            catch (Exception a)
            {
                lblError.Text = a.Message;
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            WcfServiceCustomerHost.Customer customer = client.GetCustomerById(lbCustomer.SelectedValue);
            lblFname.Text = customer.FirstName;
            lblLname.Text = customer.LastName;
            lblEmail.Text = customer.Email;
            lblTel.Text = customer.Tel.ToString();
            btnSaveEdit.Visible = true;
            lblError.Text = "Editing customer " + customer.FirstName +" "+ customer.LastName + ". Write the new info and remember to press SaveEdit";
        }

        protected void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "User ID: " + lbCustomer.SelectedItem.Value + "Deleted";
                client.DeleteCustomer(lbCustomer.SelectedItem.Value);
                LoadCustomers();
            }
            catch (Exception a)
            {
                lblError.Text = a.Message;
            }
        }

        protected void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            try
            {
            WcfServiceCustomerHost.Customer customer = client.GetCustomerByLastName(tbLastName.Text);
            lbCustomer.SelectedValue = customer.ID.ToString();
            lblError.Text = "Found Customer: " + customer.FirstName + " " + customer.LastName;
            }
            catch (Exception a)
            {
                lblError.Text = "Could not find any customer. Did you spell the last name correct? Log:" + a.Message;
            }
        }

        protected void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (tbTel.Text == "")
            {
                tbTel.Text = "0";
            };
            WcfServiceCustomerHost.Customer customer = new WcfServiceCustomerHost.Customer()
            {
                ID = int.Parse(lbCustomer.SelectedValue),
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Email = tbEmail.Text,
                Tel = int.Parse(tbTel.Text)
            };
            client.UpdateCustomer(customer);
            lblFname.Text = "First Name";
            lblLname.Text = "Last Name";
            lblEmail.Text = "Email";
            lblTel.Text = "Tel";
            btnSaveEdit.Visible = false;
            LoadCustomers();
            lblError.Text = "Customer with ID: " + customer.ID + " Updated";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void LoadCustomers()
        {
            try
            {
                lbCustomer.Items.Clear();
                WcfServiceCustomerHost.Customer[] customers = client.GetCustomerList();
                for (int i = 0; i < customers.Count(); i++)
                {
                    lbCustomer.Items.Add(new ListItem {
                        Text = (i + 1) + ") " + customers[i].FirstName + " " + customers[i].LastName +", " + customers[i].Email,
                        Value = customers[i].ID.ToString(),
                        Enabled = true
                    });
                }
                lblError.Text = "Loaded Customer List";
            }
            catch (Exception a)
            {
                lblError.Text = a.Message;
            }
        }
    }
}