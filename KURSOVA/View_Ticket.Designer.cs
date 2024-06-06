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
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchByID = new System.Windows.Forms.Button();
            this.btnPassengerName = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.MaskedTextBox();
            this.txtStop = new System.Windows.Forms.TextBox();
            this.btnSearchByStops = new System.Windows.Forms.Button();
            this.btnSearchByDate = new System.Windows.Forms.Button();

            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();

            this.txtStartDate = new System.Windows.Forms.MaskedTextBox();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
>>>>>>> 3959582 (New filtering options have been added to the search for a ticket, and a search for the date and time has been added to the review of booked tickets.)
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingManagerBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFlightNumber
            // 
<<<<<<< HEAD
            this.txtFlightNumber.Location = new System.Drawing.Point(6, 87);
            this.txtFlightNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.txtFlightNumber.Location = new System.Drawing.Point(4, 40);
            this.txtFlightNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
>>>>>>> 3959582 (New filtering options have been added to the search for a ticket, and a search for the date and time has been added to the review of booked tickets.)
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(142, 20);
            this.txtFlightNumber.TabIndex = 0;
            // 
            // txtTicketID
            // 
            this.txtTicketID.BackColor = System.Drawing.Color.White;

            this.txtTicketID.Location = new System.Drawing.Point(6, 35);
            this.txtTicketID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);

            this.txtTicketID.Location = new System.Drawing.Point(4, 17);
            this.txtTicketID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.Size = new System.Drawing.Size(142, 20);
            this.txtTicketID.TabIndex = 1;
            // 
            // btnSearchByNum
            // 

            this.btnSearchByNum.Location = new System.Drawing.Point(52, 177);
            this.btnSearchByNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);

            this.btnSearchByNum.Location = new System.Drawing.Point(39, 144);
            this.btnSearchByNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

            this.btnSearchByNum.Name = "btnSearchByNum";
            this.btnSearchByNum.Size = new System.Drawing.Size(105, 24);
            this.btnSearchByNum.TabIndex = 2;
            this.btnSearchByNum.Text = "SearchByNumber";
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
            this.flightDataGridViewTextBoxColumn,
            this.passengerNameDataGridViewTextBoxColumn,
            this.bookingDateDataGridViewTextBoxColumn});
            this.dgvTickets.DataSource = this.ticketsBindingSource;

            this.dgvTickets.Location = new System.Drawing.Point(12, 223);
            this.dgvTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);

            this.dgvTickets.Location = new System.Drawing.Point(9, 181);
            this.dgvTickets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.RowHeadersWidth = 51;
            this.dgvTickets.RowTemplate.Height = 24;
            this.dgvTickets.Size = new System.Drawing.Size(624, 175);
            this.dgvTickets.TabIndex = 4;
            // 


            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.bookingManagerBindingSource;
            // 
            // checkedListBox1
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.txtTicketID);
            this.groupBox1.Controls.Add(this.txtFlightNumber);
            this.groupBox1.Location = new System.Drawing.Point(20, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(150, 91);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnSearchByID
            // 
            this.btnSearchByID.Location = new System.Drawing.Point(39, 115);
            this.btnSearchByID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchByID.Name = "btnSearchByID";
            this.btnSearchByID.Size = new System.Drawing.Size(105, 24);
            this.btnSearchByID.TabIndex = 3;
            this.btnSearchByID.Text = "Search by ID";
            this.btnSearchByID.UseVisualStyleBackColor = true;
            this.btnSearchByID.Click += new System.EventHandler(this.btnSearchByID_Click);
            // 
            // btnPassengerName
            // 
            this.btnPassengerName.Location = new System.Drawing.Point(213, 115);
            this.btnPassengerName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPassengerName.Name = "btnPassengerName";
            this.btnPassengerName.Size = new System.Drawing.Size(105, 24);
            this.btnPassengerName.TabIndex = 7;
            this.btnPassengerName.Text = "Search by Name";
            this.btnPassengerName.UseVisualStyleBackColor = true;
            this.btnPassengerName.Click += new System.EventHandler(this.btnPassengerName_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtSurname);
            this.groupBox2.Location = new System.Drawing.Point(194, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(150, 91);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(4, 17);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Name";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(4, 40);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(142, 20);
            this.txtSurname.TabIndex = 0;
            this.txtSurname.Text = "Surname";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.txtStartDate);
            this.groupBox3.Controls.Add(this.txtStop);
            this.groupBox3.Location = new System.Drawing.Point(366, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(150, 91);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // txtStop
            // 
            this.txtStop.Location = new System.Drawing.Point(4, 19);
            this.txtStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStop.Name = "txtStop";
            this.txtStop.Size = new System.Drawing.Size(142, 20);
            this.txtStop.TabIndex = 1;
            this.txtStop.Text = "Stops";
            // 
            // btnSearchByStops
            // 
            this.btnSearchByStops.Location = new System.Drawing.Point(213, 144);
            this.btnSearchByStops.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchByStops.Name = "btnSearchByStops";
            this.btnSearchByStops.Size = new System.Drawing.Size(105, 24);
            this.btnSearchByStops.TabIndex = 10;
            this.btnSearchByStops.Text = "Search by Stops";
            this.btnSearchByStops.UseVisualStyleBackColor = true;
            this.btnSearchByStops.Click += new System.EventHandler(this.btnSearchByStops_Click);
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.Location = new System.Drawing.Point(391, 115);
            this.btnSearchByDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(105, 24);
            this.btnSearchByDate.TabIndex = 11;
            this.btnSearchByDate.Text = "Search by Date";
            this.btnSearchByDate.UseVisualStyleBackColor = true;
            this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(4, 40);
            this.txtStartDate.Mask = "00/00/0000";
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(141, 20);
            this.txtStartDate.TabIndex = 2;
            this.txtStartDate.ValidatingType = typeof(System.DateTime);
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
            // flightDataGridViewTextBoxColumn
            // 
            this.flightDataGridViewTextBoxColumn.DataPropertyName = "Flight";
            this.flightDataGridViewTextBoxColumn.HeaderText = "Flight";
            this.flightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.flightDataGridViewTextBoxColumn.Name = "flightDataGridViewTextBoxColumn";
            this.flightDataGridViewTextBoxColumn.ReadOnly = true;
            this.flightDataGridViewTextBoxColumn.Width = 125;
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
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.bookingManagerBindingSource;
            // 
            // bookingManagerBindingSource
            // 
            this.bookingManagerBindingSource.DataSource = typeof(KURSOVA.BookingManager);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTicketID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFlightNumber);
            this.groupBox1.Location = new System.Drawing.Point(27, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(200, 113);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ticket ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Flight number:";
            // 
            // btnSearchByID
            // 
            this.btnSearchByID.Location = new System.Drawing.Point(52, 142);
            this.btnSearchByID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchByID.Name = "btnSearchByID";
            this.btnSearchByID.Size = new System.Drawing.Size(140, 30);
            this.btnSearchByID.TabIndex = 3;
            this.btnSearchByID.Text = "Search by ID";
            this.btnSearchByID.UseVisualStyleBackColor = true;
            this.btnSearchByID.Click += new System.EventHandler(this.btnSearchByID_Click);
            // 
            // btnPassengerName
            // 
            this.btnPassengerName.Location = new System.Drawing.Point(511, 142);
            this.btnPassengerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPassengerName.Name = "btnPassengerName";
            this.btnPassengerName.Size = new System.Drawing.Size(140, 30);
            this.btnPassengerName.TabIndex = 7;
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
            this.groupBox2.Location = new System.Drawing.Point(484, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(200, 113);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(5, 35);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(188, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(5, 86);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(188, 22);
            this.txtSurname.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtStartDate);
            this.groupBox3.Controls.Add(this.txtStop);
            this.groupBox3.Location = new System.Drawing.Point(255, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(200, 113);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date:";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(5, 87);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartDate.Mask = "00/00/0000";
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(187, 22);
            this.txtStartDate.TabIndex = 2;
            this.txtStartDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtStop
            // 
            this.txtStop.Location = new System.Drawing.Point(5, 35);
            this.txtStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStop.Name = "txtStop";
            this.txtStop.Size = new System.Drawing.Size(188, 22);
            this.txtStop.TabIndex = 1;
            // 
            // btnSearchByStops
            // 
            this.btnSearchByStops.Location = new System.Drawing.Point(289, 142);
            this.btnSearchByStops.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchByStops.Name = "btnSearchByStops";
            this.btnSearchByStops.Size = new System.Drawing.Size(140, 30);
            this.btnSearchByStops.TabIndex = 10;
            this.btnSearchByStops.Text = "Search by Stops";
            this.btnSearchByStops.UseVisualStyleBackColor = true;
            this.btnSearchByStops.Click += new System.EventHandler(this.btnSearchByStops_Click);
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.Location = new System.Drawing.Point(289, 176);
            this.btnSearchByDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(140, 30);
            this.btnSearchByDate.TabIndex = 11;
            this.btnSearchByDate.Text = "Search by Date";
            this.btnSearchByDate.UseVisualStyleBackColor = true;
            this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Surname:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Name:";
            // 
            // View_Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KURSOVA.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 366);
            this.Controls.Add(this.btnSearchByDate);
            this.Controls.Add(this.btnSearchByStops);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPassengerName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTickets);
            this.Controls.Add(this.btnSearchByID);
            this.Controls.Add(this.btnSearchByNum);

            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);

            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

            this.Name = "View_Ticket";
            this.ShowIcon = false;
            this.Text = "Your tickets";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingManagerBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.TextBox txtTicketID;
        private System.Windows.Forms.Button btnSearchByNum;
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isReturnTicketDataGridViewCheckBoxColumn;
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

    }
}