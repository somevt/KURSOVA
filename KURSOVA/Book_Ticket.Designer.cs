namespace KURSOVA
{
    partial class Book_Ticket
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
            this.txtPassengerName = new System.Windows.Forms.TextBox();
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.txtPassengerSurname = new System.Windows.Forms.TextBox();
            this.btnBookFlight = new System.Windows.Forms.Button();
            this.txtDeparure = new System.Windows.Forms.TextBox();
            this.txtArrival = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgvFlights = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F);
            this.txtPassengerName.Location = new System.Drawing.Point(43, 46);
            this.txtPassengerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(110, 21);
            this.txtPassengerName.TabIndex = 0;
            this.txtPassengerName.Text = "Name";
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F);
            this.txtFlightNumber.Location = new System.Drawing.Point(43, 112);
            this.txtFlightNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(110, 21);
            this.txtFlightNumber.TabIndex = 1;
            this.txtFlightNumber.Text = "Flight number";
            this.txtFlightNumber.TextChanged += new System.EventHandler(this.txtFlightNumber_TextChanged);
            // 
            // txtPassengerSurname
            // 
            this.txtPassengerSurname.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassengerSurname.Location = new System.Drawing.Point(215, 46);
            this.txtPassengerSurname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassengerSurname.Name = "txtPassengerSurname";
            this.txtPassengerSurname.Size = new System.Drawing.Size(100, 21);
            this.txtPassengerSurname.TabIndex = 2;
            this.txtPassengerSurname.Text = "Surname";
            // 
            // btnBookFlight
            // 
            this.btnBookFlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBookFlight.Location = new System.Drawing.Point(353, 134);
            this.btnBookFlight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBookFlight.Name = "btnBookFlight";
            this.btnBookFlight.Size = new System.Drawing.Size(161, 43);
            this.btnBookFlight.TabIndex = 3;
            this.btnBookFlight.Text = "Search";
            this.btnBookFlight.UseVisualStyleBackColor = true;
            this.btnBookFlight.Click += new System.EventHandler(this.btnBookFlight_Click);
            // 
            // txtDeparure
            // 
            this.txtDeparure.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F);
            this.txtDeparure.Location = new System.Drawing.Point(26, 190);
            this.txtDeparure.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeparure.Name = "txtDeparure";
            this.txtDeparure.Size = new System.Drawing.Size(110, 21);
            this.txtDeparure.TabIndex = 4;
            this.txtDeparure.Text = "Deparure";
            // 
            // txtArrival
            // 
            this.txtArrival.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F);
            this.txtArrival.Location = new System.Drawing.Point(165, 190);
            this.txtArrival.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.Size = new System.Drawing.Size(110, 21);
            this.txtArrival.TabIndex = 5;
            this.txtArrival.Text = "Arrival";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(26, 230);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(249, 21);
            this.dtpDate.TabIndex = 6;
            // 
            // dgvFlights
            // 
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Location = new System.Drawing.Point(26, 297);
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.Size = new System.Drawing.Size(488, 275);
            this.dgvFlights.TabIndex = 7;
            this.dgvFlights.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFlights_CellClick);
            // 
            // Book_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KURSOVA.Properties.Resources.book;
            this.ClientSize = new System.Drawing.Size(556, 593);
            this.Controls.Add(this.dgvFlights);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtArrival);
            this.Controls.Add(this.txtDeparure);
            this.Controls.Add(this.btnBookFlight);
            this.Controls.Add(this.txtPassengerSurname);
            this.Controls.Add(this.txtFlightNumber);
            this.Controls.Add(this.txtPassengerName);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Book_Ticket";
            this.ShowIcon = false;
            this.Text = "Book Ticket";
            this.Load += new System.EventHandler(this.Book_Ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassengerName;
        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.TextBox txtPassengerSurname;
        private System.Windows.Forms.Button btnBookFlight;
        private System.Windows.Forms.TextBox txtDeparure;
        private System.Windows.Forms.TextBox txtArrival;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView dgvFlights;
    }
}