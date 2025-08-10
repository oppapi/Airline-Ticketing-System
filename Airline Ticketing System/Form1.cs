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
    public partial class Form1 : Form
    {
        private bookingPanel booking;
        private searchPanel search;
        private Form1 mainform;
        //private logsPanel logs;
        //private paymentPanel payment;
        //private rebookPanel rebook;
        //private ticketPanel ticket;
        public Form1()
        {
            InitializeComponent();
            booking = bookingPanel1;
            search = searchPanel1;
            mainform = this;
        }
        public void showSearch()
        {
            booking.Visible = false;
            search.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (btnFlights.Visible == false)
            {
                btnFlights.Visible = true;
                btnBooking.Visible = true;
                btnLogs.Visible = true;
            }
            else
            {
                btnFlights.Visible = false;
                btnBooking.Visible = false;
                btnLogs.Visible = false;
            }
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnFlight_Click(object sender, EventArgs e)
        {
            search.Visible = true;
            booking.Visible = false;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            booking.Visible = true;
            search.Visible = false;
        }
    }
}
