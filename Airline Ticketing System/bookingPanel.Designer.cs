namespace Airline_Ticketing_System
{
    partial class bookingPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumPass = new System.Windows.Forms.TextBox();
            this.btnTicket = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.txtDestination = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeparture = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(232)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtNumPass);
            this.panel1.Controls.Add(this.btnTicket);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDepartureDate);
            this.panel1.Controls.Add(this.txtDestination);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDeparture);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFullname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Quicksand", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 536);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.label6.Location = new System.Drawing.Point(572, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Number of passenger";
            // 
            // txtNumPass
            // 
            this.txtNumPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.txtNumPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumPass.Font = new System.Drawing.Font("Quicksand SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.txtNumPass.Location = new System.Drawing.Point(577, 165);
            this.txtNumPass.Name = "txtNumPass";
            this.txtNumPass.Size = new System.Drawing.Size(186, 39);
            this.txtNumPass.TabIndex = 14;
            this.txtNumPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btnTicket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btnTicket.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTicket.ForeColor = System.Drawing.Color.White;
            this.btnTicket.Location = new System.Drawing.Point(655, 376);
            this.btnTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(220, 54);
            this.btnTicket.TabIndex = 13;
            this.btnTicket.Text = "BOOK";
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.label5.Location = new System.Drawing.Point(74, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Departure date";
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartureDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.txtDepartureDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.txtDepartureDate.CustomFormat = "ddd, d MMMM yyyy";
            this.txtDepartureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDepartureDate.Location = new System.Drawing.Point(79, 378);
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(377, 36);
            this.txtDepartureDate.TabIndex = 11;
            this.txtDepartureDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtDestination
            // 
            this.txtDestination.Font = new System.Drawing.Font("Quicksand SemiBold", 15F, System.Drawing.FontStyle.Bold);
            this.txtDestination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.txtDestination.FormattingEnabled = true;
            this.txtDestination.Location = new System.Drawing.Point(577, 267);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(377, 46);
            this.txtDestination.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(572, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Destination";
            // 
            // txtDeparture
            // 
            this.txtDeparture.Font = new System.Drawing.Font("Quicksand SemiBold", 15F, System.Drawing.FontStyle.Bold);
            this.txtDeparture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.txtDeparture.FormattingEnabled = true;
            this.txtDeparture.Location = new System.Drawing.Point(79, 267);
            this.txtDeparture.Name = "txtDeparture";
            this.txtDeparture.Size = new System.Drawing.Size(377, 46);
            this.txtDeparture.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(74, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Departure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(74, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Full name";
            // 
            // txtFullname
            // 
            this.txtFullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(254)))));
            this.txtFullname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullname.Font = new System.Drawing.Font("Quicksand SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.txtFullname.Location = new System.Drawing.Point(79, 165);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(377, 39);
            this.txtFullname.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(345, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "BOOKING and PAYMENT";
            // 
            // bookingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(87)))));
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "bookingPanel";
            this.Size = new System.Drawing.Size(1040, 542);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtDepartureDate;
        private System.Windows.Forms.ComboBox txtDestination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtDeparture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumPass;
    }
}
