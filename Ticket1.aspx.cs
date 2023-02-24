using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicketBooking
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Calendar1.SelectedDate > Calendar1.TodaysDate)
            {
                Label5.Text = "<h3>Person Name</h3>"+TextBox1.Text + "<br>"+ "<h3>From</h3>" + TextBox2.Text + "<br>"+ "<h3>To</h3>" + TextBox3.Text + "<br> Tickets Booked for" + Calendar1.SelectedDate.ToShortDateString();

            }
            else
            {
                Label5.Text = "Sorry ! Ticket Not Available";
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox4.Text = Calendar1.SelectedDate.ToLongDateString();
        }
    }
}