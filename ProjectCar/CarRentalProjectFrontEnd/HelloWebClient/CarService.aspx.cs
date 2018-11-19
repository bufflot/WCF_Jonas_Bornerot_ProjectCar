using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Serialization;

namespace HelloWebClient
{
    public partial class CarService : System.Web.UI.Page
    {
        WcfServiceCarHost.ServiceCarClient client = new WcfServiceCarHost.ServiceCarClient("BasicHttpBinding_IServiceCar");
        //public string CarId { get; set; }
        public bool available = false;



        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            LoadCars();
            }
        }

        protected void btnAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                client.AddCar(TbReg.Text, TbBrand.Text, TbModel.Text, (Convert.ToInt32(TbYear.Text)));
                TbReg.Text = "";
                TbBrand.Text = "";
                TbModel.Text = "";
                TbYear.Text = "";
                LoadCars();
                Label1.Text = "New Car added.";
                LoadCars();
            }
            catch (Exception a)
            {
                Label1.Text = "Incorrect input. Pleas try again" + a.Message;
            }
        }

        protected void btnDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                client.DeleteCar(ListBox1.SelectedItem.Value);
                LoadCars();
            }
            catch (Exception a)
            {
                Label3.Text = a.Message;
            }
        }

        protected void btnFindCar_Click(object sender, EventArgs e)
        {
            try
            {
               WcfServiceCarHost.Car car = client.GetCarByRegNr(TbReg.Text);
                if (car != null)
                {
                    ListBox1.SelectedValue = car.ID.ToString();
                    Label3.Text = "Found car: " + car.Brand + " "+ car.Model + " " + car.Year;
                }
                else
                {
                    Label3.Text = "Could not find car";
                }
            }
            catch (Exception a)
            {
                Label3.Text = a.Message;
            }
        }


        //The method to populate the list.
        private void LoadCars()
        {
            try
            {
                ListBox1.Items.Clear();
                ListBox1.Width = 300;
                WcfServiceCarHost.Car[] carList = client.GetCarList();

                for (int i = 0; i < carList.Count(); i++)
                {
                    ListBox1.Items.Add(new ListItem
                    {
                        Text = (i + 1) + ", " + carList[i].Brand + ", " + carList[i].Model + ", " + carList[i].Year,
                        Value = carList[i].ID.ToString(),
                        Enabled = carList[i].Avaliable || available
                    });
                }
            }
            catch (Exception a)
            {
                Label2.Text = a.Message;
            }
        }

        protected void chkShowAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowAll.Checked)
            {
                available = true;
                Label2.Text = "Showing All Cars";
            }
            else
            {
                Label2.Text = "Showing Available Cars";
            }
            LoadCars();
        }

        protected void btnReturnCar_Click(object sender, EventArgs e)
        {
            client.ReturnCar(ListBox1.SelectedValue);
            Label5.Text = "Car with Id: " + ListBox1.SelectedValue + "new status: AVAILABLE";
        }
    }
}