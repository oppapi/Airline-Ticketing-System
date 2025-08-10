using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticketing_System
{
    internal class accessDB
    {
        private string fullname;
        private int numPassenger;
        private string departure;
        private string destination;
        private string departureDate;

        private int planeNumber;

        public void setBooking(string fname, int numPass, string depart, string desti, string departDate)
        {
            fullname = fname;
            numPassenger = numPass;
            departure = depart;
            destination = desti;
            departureDate = departDate;
        }

        public void setPlaneNum(int planeNum)
        {
            planeNumber = planeNum;
        }

        public void insertPlane(string planeName)
        {
            SqlConnection conn = new SqlConnection("Server=OLA\\SQLEXPRESS;Database=airlineDB;Trusted_Connection=True;");
            using (conn)
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("insertPlane", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@planeName", planeName);
                        cmd.ExecuteNonQuery();

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Operation successful!");
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Operation failed!");
                            conn.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message);
                }
            }
        }

        public void insertBook()
        {
            SqlConnection conn = new SqlConnection("Server=OLA\\SQLEXPRESS;Database=airlineDB;Trusted_Connection=True;");
            using (conn)
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("insertBook", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@fullname", fullname);
                        cmd.Parameters.AddWithValue("@numPassenger", numPassenger);
                        cmd.Parameters.AddWithValue("@departure", departure);
                        cmd.Parameters.AddWithValue("@destination", destination);
                        cmd.Parameters.AddWithValue("@departureDate", departureDate);
                        cmd.Parameters.AddWithValue("@planeNum", planeNumber);
                        cmd.ExecuteNonQuery();

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Operation successful!");
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Operation failed!");
                            conn.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message);
                }
            }
        }
    }
}
