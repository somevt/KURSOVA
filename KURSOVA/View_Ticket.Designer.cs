namespace KURSOVA
{
    partial class View_Ticket
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
            this.components = new System.ComponentModel.Container();
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.txtTicketID = new System.Windows.Forms.TextBox();
            this.btnSearchByNum = new System.Windows.Forms.Button();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchByID = new System.Windows.Forms.Button();
            this.btnPassengerName = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.MaskedTextBox();
            this.txtStop = new System.Windows.Forms.TextBox();
            this.btnSearchByStops = new System.Windows.Forms.Button();
            this.btnSearchByDate = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.bookingManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassengerSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Location = new System.Drawing.Point(7, 126);
            this.txtFlightNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(253, 21);
            this.txtFlightNumber.TabIndex = 2;
            // 
            // txtTicketID
            // 
            this.txtTicketID.BackColor = System.Drawing.Color.White;
            this.txtTicketID.Location = new System.Drawing.Point(7, 39);
            this.txtTicketID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.Size = new System.Drawing.Size(253, 21);
            this.txtTicketID.TabIndex = 1;
            // 
            // btnSearchByNum
            // 
            this.btnSearchByNum.Location = new System.Drawing.Point(79, 240);
            this.btnSearchByNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchByNum.Name = "btnSearchByNum";
            this.btnSearchByNum.Size = new System.Drawing.Size(166, 36);
            this.btnSearchByNum.TabIndex = 8;
            this.btnSearchByNum.Text = "Search by Number";
            this.btnSearchByNum.UseVisualStyleBackColor = true;
            this.btnSearchByNum.Click += new System.EventHandler(this.btnSearchByNum_Click);
            // 
            // dgvTickets
            // 
            this.dgvTickets.AutoGenerateColumns = false;
            this.dgvTickets.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIDDataGridViewTextBoxColumn,
            this.PassengerSurname,
            this.flightDataGridViewTextBoxColumn,
            this.passengerNameDataGridViewTextBoxColumn,
            this.bookingDateDataGridViewTextBoxColumn});
            this.dgvTickets.DataSource = this.ticketsBindingSource;
            this.dgvTickets.Location = new System.Drawing.Point(36, 296);
            this.dgvTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.RowHeadersWidth = 51;
            this.dgvTickets.RowTemplate.Height = 24;
            this.dgvTickets.Size = new System.Drawing.Size(876, 255);
            this.dgvTickets.TabIndex = 12;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.bookingManagerBindingSource;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTicketID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFlightNumber);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(36, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(267, 165);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ticket ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Flight number:";
            // 
            // btnSearchByID
            // 
            this.btnSearchByID.Location = new System.Drawing.Point(79, 197);
            this.btnSearchByID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSearchByID.Name = "btnSearchByID";
            this.btnSearchByID.Size = new System.Drawing.Size(166, 38);
            this.btnSearchByID.TabIndex = 7;
            this.btnSearchByID.Text = "Search by ID";
            this.btnSearchByID.UseVisualStyleBackColor = true;
            this.btnSearchByID.Click += new System.EventHandler(this.btnSearchByID_Click);
            // 
            // btnPassengerName
            // 
            this.btnPassengerName.Location = new System.Drawing.Point(697, 197);
            this.btnPassengerName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnPassengerName.Name = "btnPassengerName";
            this.btnPassengerName.Size = new System.Drawing.Size(158, 38);
            this.btnPassengerName.TabIndex = 11;
            this.btnPassengerName.Text = "Search by Name";
            this.btnPassengerName.UseVisualStyleBackColor = true;
            this.btnPassengerName.Click += new System.EventHandler(this.btnPassengerName_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtSurname);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(645, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox2.Size = new System.Drawing.Size(267, 165);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Surname:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(7, 51);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(249, 21);
            this.txtName.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(7, 126);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(249, 21);
            this.txtSurname.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtStartDate);
            this.groupBox3.Controls.Add(this.txtStop);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(340, 17);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox3.Size = new System.Drawing.Size(267, 165);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date:";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(7, 127);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtStartDate.Mask = "00/00/0000";
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(248, 23);
            this.txtStartDate.TabIndex = 5;
            this.txtStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtStop
            // 
            this.txtStop.Location = new System.Drawing.Point(6, 42);
            this.txtStop.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtStop.Name = "txtStop";
            this.txtStop.Size = new System.Drawing.Size(249, 23);
            this.txtStop.TabIndex = 3;
            // 
            // btnSearchByStops
            // 
            this.btnSearchByStops.Location = new System.Drawing.Point(385, 197);
            this.btnSearchByStops.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSearchByStops.Name = "btnSearchByStops";
            this.btnSearchByStops.Size = new System.Drawing.Size(176, 38);
            this.btnSearchByStops.TabIndex = 9;
            this.btnSearchByStops.Text = "Search by City";
            this.btnSearchByStops.UseVisualStyleBackColor = true;
            this.btnSearchByStops.Click += new System.EventHandler(this.btnSearchByStops_Click);
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.Location = new System.Drawing.Point(385, 240);
            this.btnSearchByDate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(176, 36);
            this.btnSearchByDate.TabIndex = 10;
            this.btnSearchByDate.Text = "Search by Date";
            this.btnSearchByDate.UseVisualStyleBackColor = true;
            this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(697, 239);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(158, 36);
            this.btnView.TabIndex = 13;
            this.btnView.Text = "View All";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // bookingManagerBindingSource
            // 
            this.bookingManagerBindingSource.DataSource = typeof(KURSOVA.BookingManager);
            // 
            // ticketIDDataGridViewTextBoxColumn
            // 
            this.ticketIDDataGridViewTextBoxColumn.DataPropertyName = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.HeaderText = "TicketID";
            this.ticketIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ticketIDDataGridViewTextBoxColumn.Name = "ticketIDDataGridViewTextBoxColumn";
            this.ticketIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ticketIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // PassengerSurname
            // 
            this.PassengerSurname.DataPropertyName = "PassengerSurname";
            this.PassengerSurname.HeaderText = "PassengerSurname";
            this.PassengerSurname.Name = "PassengerSurname";
            this.PassengerSurname.ReadOnly = true;
            // 
            // flightDataGridViewTextBoxColumn
            // 
            this.flightDataGridViewTextBoxColumn.DataPropertyName = "Flight";
            this.flightDataGridViewTextBoxColumn.HeaderText = "Flight";
            this.flightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.flightDataGridViewTextBoxColumn.Name = "flightDataGridViewTextBoxColumn";
            this.flightDataGridViewTextBoxColumn.ReadOnly = true;
            this.flightDataGridViewTextBoxColumn.Width = 200;
            // 
            // passengerNameDataGridViewTextBoxColumn
            // 
            this.passengerNameDataGridViewTextBoxColumn.DataPropertyName = "PassengerName";
            this.passengerNameDataGridViewTextBoxColumn.HeaderText = "PassengerName";
            this.passengerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passengerNameDataGridViewTextBoxColumn.Name = "passengerNameDataGridViewTextBoxColumn";
            this.passengerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.passengerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn.HeaderText = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            this.bookingDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookingDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // View_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KURSOVA.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(943, 616);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSearchByDate);
            this.Controls.Add(this.btnSearchByStops);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPassengerName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTickets);
            this.Controls.Add(this.btnSearchByID);
            this.Controls.Add(this.btnSearchByNum);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "View_Ticket";
            this.ShowIcon = false;
            this.Text = "Your tickets";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.View_Ticket_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingManagerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.TextBox txtTicketID;
        private System.Windows.Forms.Button btnSearchByNum;
        private System.Windows.Forms.DataGridView dgvTickets;
        
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private System.Windows.Forms.BindingSource bookingManagerBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchByID;
        private System.Windows.Forms.Button btnPassengerName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtStop;
        private System.Windows.Forms.Button btnSearchByStops;
        private System.Windows.Forms.Button btnSearchByDate;
        private System.Windows.Forms.MaskedTextBox txtStartDate;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassengerSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
    }
}