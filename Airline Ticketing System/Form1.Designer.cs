namespace Airline_Ticketing_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnFlights = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnRebook = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnFlight = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bookingPanel1 = new Airline_Ticketing_System.bookingPanel();
            this.searchPanel1 = new Airline_Ticketing_System.searchPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.btnLogs);
            this.panel1.Controls.Add(this.btnBooking);
            this.panel1.Controls.Add(this.btnFlights);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.btnRebook);
            this.panel1.Controls.Add(this.btnTicket);
            this.panel1.Controls.Add(this.btnFlight);
            this.panel1.Controls.Add(this.btnPayment);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 650);
            this.panel1.TabIndex = 0;
            // 
            // btnLogs
            // 
            this.btnLogs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogs.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogs.ForeColor = System.Drawing.Color.White;
            this.btnLogs.Location = new System.Drawing.Point(3, 496);
            this.btnLogs.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(220, 50);
            this.btnLogs.TabIndex = 8;
            this.btnLogs.Text = "LOGS";
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Visible = false;
            // 
            // btnBooking
            // 
            this.btnBooking.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.Color.White;
            this.btnBooking.Location = new System.Drawing.Point(3, 438);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(4);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(220, 50);
            this.btnBooking.TabIndex = 7;
            this.btnBooking.Text = "MANAGE BOOKS";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Visible = false;
            // 
            // btnFlights
            // 
            this.btnFlights.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btnFlights.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlights.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlights.ForeColor = System.Drawing.Color.White;
            this.btnFlights.Location = new System.Drawing.Point(3, 380);
            this.btnFlights.Margin = new System.Windows.Forms.Padding(4);
            this.btnFlights.Name = "btnFlights";
            this.btnFlights.Size = new System.Drawing.Size(220, 50);
            this.btnFlights.TabIndex = 6;
            this.btnFlights.Text = "MANAGE FLIGHTS";
            this.btnFlights.UseVisualStyleBackColor = true;
            this.btnFlights.Visible = false;
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(3, 322);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(220, 50);
            this.btnAdmin.TabIndex = 5;
            this.btnAdmin.Text = "ADMIN";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnRebook
            // 
            this.btnRebook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btnRebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRebook.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRebook.ForeColor = System.Drawing.Color.White;
            this.btnRebook.Location = new System.Drawing.Point(3, 264);
            this.btnRebook.Margin = new System.Windows.Forms.Padding(4);
            this.btnRebook.Name = "btnRebook";
            this.btnRebook.Size = new System.Drawing.Size(220, 50);
            this.btnRebook.TabIndex = 4;
            this.btnRebook.Text = "CANCEL or REBOOK";
            this.btnRebook.UseVisualStyleBackColor = true;
            // 
            // btnTicket
            // 
            this.btnTicket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicket.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.ForeColor = System.Drawing.Color.White;
            this.btnTicket.Location = new System.Drawing.Point(3, 206);
            this.btnTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(220, 50);
            this.btnTicket.TabIndex = 3;
            this.btnTicket.Text = "E-TCIKET";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnFlight
            // 
            this.btnFlight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btnFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlight.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlight.ForeColor = System.Drawing.Color.White;
            this.btnFlight.Location = new System.Drawing.Point(3, 90);
            this.btnFlight.Margin = new System.Windows.Forms.Padding(4);
            this.btnFlight.Name = "btnFlight";
            this.btnFlight.Size = new System.Drawing.Size(220, 50);
            this.btnFlight.TabIndex = 2;
            this.btnFlight.Text = "FLIGHT SEARCH";
            this.btnFlight.UseVisualStyleBackColor = true;
            this.btnFlight.Click += new System.EventHandler(this.btnFlight_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Quicksand", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(3, 148);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(220, 50);
            this.btnPayment.TabIndex = 1;
            this.btnPayment.Text = "BOOKING and PAYMENT";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.panel2.Location = new System.Drawing.Point(223, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 82);
            this.panel2.TabIndex = 1;
            // 
            // bookingPanel1
            // 
            this.bookingPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(232)))));
            this.bookingPanel1.Location = new System.Drawing.Point(231, 89);
            this.bookingPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.bookingPanel1.Name = "bookingPanel1";
            this.bookingPanel1.Size = new System.Drawing.Size(1040, 542);
            this.bookingPanel1.TabIndex = 2;
            this.bookingPanel1.Visible = false;
            // 
            // searchPanel1
            // 
            this.searchPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(232)))));
            this.searchPanel1.Location = new System.Drawing.Point(231, 89);
            this.searchPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.searchPanel1.Name = "searchPanel1";
            this.searchPanel1.Size = new System.Drawing.Size(1040, 542);
            this.searchPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(1287, 644);
            this.Controls.Add(this.searchPanel1);
            this.Controls.Add(this.bookingPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnFlight;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnFlights;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnRebook;
        private bookingPanel bookingPanel1;
        private searchPanel searchPanel1;
    }
}

