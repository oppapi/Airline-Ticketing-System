using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticketing_System
{
    public partial class bookingPanel : UserControl
    {
        public bookingPanel()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void setMainForm()
        {

        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)this.FindForm();
            accessDB db = new accessDB();
            db.setBooking(txtFullname.Text, Convert.ToInt32(txtNumPass.Text), txtDeparture.Text, txtDestination.Text, txtDepartureDate.Text);
            form1.showSearch();
        }
    }
}
