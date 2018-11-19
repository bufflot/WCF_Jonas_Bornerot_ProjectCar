using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWebClient
{
    public partial class BookingService : System.Web.UI.Page
    {
        WcfServiceBookingHost.ServiceBookingClient client = new WcfServiceBookingHost.ServiceBookingClient("NetTcpBinding_IServiceBooking");
        public static List<DateTime> list = new List<DateTime>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            PopulateLists();
            }
        }

        protected void calBooking_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsSelected == true)
            {
                e.Cell.BackColor = System.Drawing.Color.ForestGreen;
                list.Add(e.Day.Date);
            }
            Session["SelectedDates"] = list;
        }

        protected void calBooking_SelectionChanged(object sender, EventArgs e)
        {
            if (Session["SelectedDates"] != null)
            {
                List<DateTime> newList = (List<DateTime>)Session["SelectedDates"];
                foreach (DateTime dt in newList)
                {
                    if  (calBooking.SelectedDates.Contains(dt) || (calBooking.SelectedDate == dt))
                    {
                    calBooking.SelectedDates.Remove(dt);
                    }
                    else
                    {
                    calBooking.SelectedDates.Add(dt);
                    }
                }
                list.Clear();
            }
            lblInfo.Text = null;
            foreach (DateTime dt in calBooking.SelectedDates) 
            {
                lblInfo.Text += ", " + dt.ToShortDateString();
            }
        }

        protected void btnCreateBooking_Click(object sender, EventArgs e)
        {
            
            var x = client.GetCarList(); 
            WcfServiceBookingHost.Car car = new WcfServiceBookingHost.Car { };
            foreach (var v in x)
            {
                if (v.ID == int.Parse(lbxCar.SelectedValue))
                {
                     car = v;
                }
            }
            var y = client.GetCustomerList();
            WcfServiceBookingHost.Customer customer = new WcfServiceBookingHost.Customer { };
            foreach (var v in y)
            {
                if (v.ID == int.Parse(lbxCustomer.SelectedValue))
                {
                    customer = v;
                }
            }
            WcfServiceBookingHost.Booking booking = new WcfServiceBookingHost.Booking
            {
                StartTime = calBooking.SelectedDates[0],
                EndTime = calBooking.SelectedDates[calBooking.SelectedDates.Count - 1],
                Car = car,
                CarID = car.ID,
                Customer = customer,
                CustomerID = customer.ID
            };
            lblInfo.Text = "Error with create booking code";
            client.CreateBooking(booking);
            lblInfo.Text = "Booking complete";
        }
    
                

        

        protected void btnEditBooking_Click(object sender, EventArgs e)
        {

        }

        protected void btnCompleteBooking_Click(object sender, EventArgs e)
        {

        }

        private void PopulateLists()
        {
            lbxCar.Items.Clear();
            lbxCustomer.Items.Clear();
            var x = client.GetCarList();
            var y = client.GetCustomerList();
            for (int i = 0; i < x.Count(); i++)
            {
                lbxCar.Items.Add(new ListItem
                {
                    Text = x[i].Brand + " " + x[i].Model + ", year " + x[i].Year,
                    Value = x[i].ID.ToString(),
                    Enabled = x[i].Avaliable
                });
            }
            for (int i = 0; i < y.Count(); i++)
            {
                lbxCustomer.Items.Add(new ListItem
                {
                    Text = y[i].FirstName + " " + y[i].LastName + ", " + y[i].Email,
                    Value = y[i].ID.ToString(),
                    Enabled = true
                });
            }

        }

        protected void lbxCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCarPlaceHolder.Text = lbxCar.SelectedValue;
        }

        protected void lbxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCustomerPlaceHolder.Text = lbxCustomer.SelectedValue;
        }
    }
}