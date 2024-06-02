namespace KURSOVA
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
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.txtStops = new System.Windows.Forms.MaskedTextBox();
            this.txtDepartureDate = new System.Windows.Forms.MaskedTextBox();
            this.txtCarrier = new System.Windows.Forms.MaskedTextBox();
            this.txtTicketPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtAvailableSeats = new System.Windows.Forms.MaskedTextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.txtArrivalDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddFlight.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.2F, System.Drawing.FontStyle.Bold);
            this.btnAddFlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddFlight.Location = new System.Drawing.Point(380, 359);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(156, 43);
            this.btnAddFlight.TabIndex = 0;
            this.btnAddFlight.Text = "Add flight";
            this.btnAddFlight.UseVisualStyleBackColor = false;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Location = new System.Drawing.Point(56, 50);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(132, 22);
            this.txtFlightNumber.TabIndex = 1;
            this.txtFlightNumber.Text = "Flight number";
            // 
            // txtStops
            // 
            this.txtStops.Location = new System.Drawing.Point(56, 96);
            this.txtStops.Name = "txtStops";
            this.txtStops.Size = new System.Drawing.Size(132, 22);
            this.txtStops.TabIndex = 2;
            this.txtStops.Text = "Stops";
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.Location = new System.Drawing.Point(154, 249);
            this.txtDepartureDate.Mask = "00/00/0000 90:00";
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(132, 22);
            this.txtDepartureDate.TabIndex = 3;
            this.txtDepartureDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtCarrier
            // 
            this.txtCarrier.Location = new System.Drawing.Point(258, 50);
            this.txtCarrier.Name = "txtCarrier";
            this.txtCarrier.Size = new System.Drawing.Size(132, 22);
            this.txtCarrier.TabIndex = 6;
            this.txtCarrier.Text = "Carrier";
            // 
            // txtTicketPrice
            // 
            this.txtTicketPrice.Location = new System.Drawing.Point(258, 96);
            this.txtTicketPrice.Name = "txtTicketPrice";
            this.txtTicketPrice.Size = new System.Drawing.Size(132, 22);
            this.txtTicketPrice.TabIndex = 7;
            this.txtTicketPrice.Text = "Ticket price";
            // 
            // txtAvailableSeats
            // 
            this.txtAvailableSeats.Location = new System.Drawing.Point(56, 147);
            this.txtAvailableSeats.Name = "txtAvailableSeats";
            this.txtAvailableSeats.Size = new System.Drawing.Size(132, 22);
            this.txtAvailableSeats.TabIndex = 8;
            this.txtAvailableSeats.Text = "Available seats";
            this.txtAvailableSeats.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtAvailableSeats_MaskInputRejected);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(928, 461);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 89);
            this.checkedListBox1.TabIndex = 11;
            // 
            // txtArrivalDate
            // 
            this.txtArrivalDate.Location = new System.Drawing.Point(154, 289);
            this.txtArrivalDate.Mask = "00/00/0000 90:00";
            this.txtArrivalDate.Name = "txtArrivalDate";
            this.txtArrivalDate.Size = new System.Drawing.Size(132, 22);
            this.txtArrivalDate.TabIndex = 12;
            this.txtArrivalDate.ValidatingType = typeof(System.DateTime);
            this.txtArrivalDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtArrivalDate_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(53, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter the date and time of";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(53, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "departure:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(52, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "arrival:      ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KURSOVA.Properties.Resources.book;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArrivalDate);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.txtAvailableSeats);
            this.Controls.Add(this.txtTicketPrice);
            this.Controls.Add(this.txtCarrier);
            this.Controls.Add(this.txtDepartureDate);
            this.Controls.Add(this.txtStops);
            this.Controls.Add(this.txtFlightNumber);
            this.Controls.Add(this.btnAddFlight);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Add flight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.MaskedTextBox txtStops;
        private System.Windows.Forms.MaskedTextBox txtDepartureDate;
        private System.Windows.Forms.MaskedTextBox txtCarrier;
        private System.Windows.Forms.MaskedTextBox txtTicketPrice;
        private System.Windows.Forms.MaskedTextBox txtAvailableSeats;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.MaskedTextBox txtArrivalDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

