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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F);
            this.txtPassengerName.Location = new System.Drawing.Point(151, 33);
            this.txtPassengerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(110, 21);
            this.txtPassengerName.TabIndex = 0;
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F);
            this.txtFlightNumber.Location = new System.Drawing.Point(151, 99);
            this.txtFlightNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(110, 21);
            this.txtFlightNumber.TabIndex = 2;
            this.txtFlightNumber.TextChanged += new System.EventHandler(this.txtFlightNumber_TextChanged);
            // 
            // txtPassengerSurname
            // 
            this.txtPassengerSurname.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPassengerSurname.Location = new System.Drawing.Point(151, 67);
            this.txtPassengerSurname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassengerSurname.Name = "txtPassengerSurname";
            this.txtPassengerSurname.Size = new System.Drawing.Size(110, 21);
            this.txtPassengerSurname.TabIndex = 1;
            // 
            // btnBookFlight
            // 
            this.btnBookFlight.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBookFlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBookFlight.Location = new System.Drawing.Point(353, 230);
            this.btnBookFlight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBookFlight.Name = "btnBookFlight";
            this.btnBookFlight.Size = new System.Drawing.Size(161, 43);
            this.btnBookFlight.TabIndex = 5;
            this.btnBookFlight.Text = "Search";
            this.btnBookFlight.UseVisualStyleBackColor = true;
            this.btnBookFlight.Click += new System.EventHandler(this.btnBookFlight_Click);
            // 
            // txtDeparure
            // 
            this.txtDeparure.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F);
            this.txtDeparure.Location = new System.Drawing.Point(151, 155);
            this.txtDeparure.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeparure.Name = "txtDeparure";
            this.txtDeparure.Size = new System.Drawing.Size(110, 21);
            this.txtDeparure.TabIndex = 3;
            // 
            // txtArrival
            // 
            this.txtArrival.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F);
            this.txtArrival.Location = new System.Drawing.Point(151, 187);
            this.txtArrival.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.Size = new System.Drawing.Size(110, 21);
            this.txtArrival.TabIndex = 4;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(43, 230);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(249, 21);
            this.dtpDate.TabIndex = 5;
            // 
            // dgvFlights
            // 
            this.dgvFlights.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Location = new System.Drawing.Point(26, 297);
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.RowHeadersWidth = 51;
            this.dgvFlights.Size = new System.Drawing.Size(488, 275);
            this.dgvFlights.TabIndex = 7;
            this.dgvFlights.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFlights_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(39, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(39, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Flight number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(39, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Departure:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(39, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Arrival:";
            // 
            // Book_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KURSOVA.Properties.Resources.book;
            this.ClientSize = new System.Drawing.Size(556, 593);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Book_Ticket_KeyDown);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}