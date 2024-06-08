namespace KURSOVA
{
    partial class Search_Flight
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgwInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableSeatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departurePointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lstViewStops = new System.Windows.Forms.ListView();
            this.txtDepartureCity = new System.Windows.Forms.TextBox();
            this.txtArrivalCity = new System.Windows.Forms.TextBox();
            this.txtDepartureDate = new System.Windows.Forms.MaskedTextBox();
            this.txtArrivalDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPriceMin = new System.Windows.Forms.MaskedTextBox();
            this.txtPriceMax = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFlightNum = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Location = new System.Drawing.Point(22, 301);
            this.txtFlightNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(109, 20);
            this.txtFlightNumber.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearch.Location = new System.Drawing.Point(804, 315);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 38);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgwInfo
            // 
            this.dgwInfo.AutoGenerateColumns = false;
            this.dgwInfo.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgwInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.availableSeatsDataGridViewTextBoxColumn,
            this.ticketPriceDataGridViewTextBoxColumn,
            this.carrierDataGridViewTextBoxColumn,
            this.departureDateDataGridViewTextBoxColumn,
            this.arrivalDateDataGridViewTextBoxColumn,
            this.departureTimeDataGridViewTextBoxColumn,
            this.arrivalTimeDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.departurePointDataGridViewTextBoxColumn,
            this.destinationPointDataGridViewTextBoxColumn});
            this.dgwInfo.DataSource = this.flightsBindingSource;
            this.dgwInfo.Location = new System.Drawing.Point(11, 11);
            this.dgwInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgwInfo.Name = "dgwInfo";
            this.dgwInfo.RowHeadersWidth = 51;
            this.dgwInfo.RowTemplate.Height = 24;
            this.dgwInfo.Size = new System.Drawing.Size(930, 161);
            this.dgwInfo.TabIndex = 1;
            this.dgwInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwInfo_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FlightNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "FlightNumber";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // availableSeatsDataGridViewTextBoxColumn
            // 
            this.availableSeatsDataGridViewTextBoxColumn.DataPropertyName = "AvailableSeats";
            this.availableSeatsDataGridViewTextBoxColumn.HeaderText = "AvailableSeats";
            this.availableSeatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.availableSeatsDataGridViewTextBoxColumn.Name = "availableSeatsDataGridViewTextBoxColumn";
            this.availableSeatsDataGridViewTextBoxColumn.Width = 125;
            // 
            // ticketPriceDataGridViewTextBoxColumn
            // 
            this.ticketPriceDataGridViewTextBoxColumn.DataPropertyName = "TicketPrice";
            this.ticketPriceDataGridViewTextBoxColumn.HeaderText = "TicketPrice";
            this.ticketPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ticketPriceDataGridViewTextBoxColumn.Name = "ticketPriceDataGridViewTextBoxColumn";
            this.ticketPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // carrierDataGridViewTextBoxColumn
            // 
            this.carrierDataGridViewTextBoxColumn.DataPropertyName = "Carrier";
            this.carrierDataGridViewTextBoxColumn.HeaderText = "Carrier";
            this.carrierDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.carrierDataGridViewTextBoxColumn.Name = "carrierDataGridViewTextBoxColumn";
            this.carrierDataGridViewTextBoxColumn.Width = 125;
            // 
            // departureDateDataGridViewTextBoxColumn
            // 
            this.departureDateDataGridViewTextBoxColumn.DataPropertyName = "DepartureDate";
            this.departureDateDataGridViewTextBoxColumn.HeaderText = "DepartureDate";
            this.departureDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departureDateDataGridViewTextBoxColumn.Name = "departureDateDataGridViewTextBoxColumn";
            this.departureDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // arrivalDateDataGridViewTextBoxColumn
            // 
            this.arrivalDateDataGridViewTextBoxColumn.DataPropertyName = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.HeaderText = "ArrivalDate";
            this.arrivalDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.arrivalDateDataGridViewTextBoxColumn.Name = "arrivalDateDataGridViewTextBoxColumn";
            this.arrivalDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // departureTimeDataGridViewTextBoxColumn
            // 
            this.departureTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.HeaderText = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
            this.departureTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // arrivalTimeDataGridViewTextBoxColumn
            // 
            this.arrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.HeaderText = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.arrivalTimeDataGridViewTextBoxColumn.Name = "arrivalTimeDataGridViewTextBoxColumn";
            this.arrivalTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.Width = 125;
            // 
            // departurePointDataGridViewTextBoxColumn
            // 
            this.departurePointDataGridViewTextBoxColumn.DataPropertyName = "DeparturePoint";
            this.departurePointDataGridViewTextBoxColumn.HeaderText = "DeparturePoint";
            this.departurePointDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departurePointDataGridViewTextBoxColumn.Name = "departurePointDataGridViewTextBoxColumn";
            this.departurePointDataGridViewTextBoxColumn.ReadOnly = true;
            this.departurePointDataGridViewTextBoxColumn.Width = 125;
            // 
            // destinationPointDataGridViewTextBoxColumn
            // 
            this.destinationPointDataGridViewTextBoxColumn.DataPropertyName = "DestinationPoint";
            this.destinationPointDataGridViewTextBoxColumn.HeaderText = "DestinationPoint";
            this.destinationPointDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.destinationPointDataGridViewTextBoxColumn.Name = "destinationPointDataGridViewTextBoxColumn";
            this.destinationPointDataGridViewTextBoxColumn.ReadOnly = true;
            this.destinationPointDataGridViewTextBoxColumn.Width = 125;
            // 
            // flightsBindingSource
            // 
            this.flightsBindingSource.DataMember = "Flights";
            this.flightsBindingSource.DataSource = this.scheduleBindingSource;
            // 
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataSource = typeof(KURSOVA.Schedule);
            // 
            // lstViewStops
            // 
            this.lstViewStops.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lstViewStops.AllowDrop = true;
            this.lstViewStops.AutoArrange = false;
            this.lstViewStops.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lstViewStops.HideSelection = false;
            this.lstViewStops.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lstViewStops.Location = new System.Drawing.Point(9, 184);
            this.lstViewStops.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstViewStops.Name = "lstViewStops";
            this.lstViewStops.Size = new System.Drawing.Size(293, 74);
            this.lstViewStops.TabIndex = 2;
            this.lstViewStops.UseCompatibleStateImageBehavior = false;
            this.lstViewStops.View = System.Windows.Forms.View.List;
            // 
            // txtDepartureCity
            // 
            this.txtDepartureCity.Location = new System.Drawing.Point(384, 214);
            this.txtDepartureCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDepartureCity.Name = "txtDepartureCity";
            this.txtDepartureCity.Size = new System.Drawing.Size(109, 20);
            this.txtDepartureCity.TabIndex = 4;
            // 
            // txtArrivalCity
            // 
            this.txtArrivalCity.Location = new System.Drawing.Point(384, 241);
            this.txtArrivalCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArrivalCity.Name = "txtArrivalCity";
            this.txtArrivalCity.Size = new System.Drawing.Size(109, 20);
            this.txtArrivalCity.TabIndex = 5;
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.Location = new System.Drawing.Point(607, 214);
            this.txtDepartureDate.Mask = "00/00/0000";
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(100, 20);
            this.txtDepartureDate.TabIndex = 6;
            this.txtDepartureDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtArrivalDate
            // 
            this.txtArrivalDate.Location = new System.Drawing.Point(607, 241);
            this.txtArrivalDate.Mask = "00/00/0000";
            this.txtArrivalDate.Name = "txtArrivalDate";
            this.txtArrivalDate.Size = new System.Drawing.Size(100, 20);
            this.txtArrivalDate.TabIndex = 7;
            this.txtArrivalDate.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(538, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Departure:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(538, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Arrival:       ";
            // 
            // txtPriceMin
            // 
            this.txtPriceMin.Location = new System.Drawing.Point(798, 211);
            this.txtPriceMin.Mask = "0000000";
            this.txtPriceMin.Name = "txtPriceMin";
            this.txtPriceMin.Size = new System.Drawing.Size(100, 20);
            this.txtPriceMin.TabIndex = 8;
            this.txtPriceMin.ValidatingType = typeof(int);
            // 
            // txtPriceMax
            // 
            this.txtPriceMax.Location = new System.Drawing.Point(798, 241);
            this.txtPriceMax.Mask = "0000000";
            this.txtPriceMax.Name = "txtPriceMax";
            this.txtPriceMax.Size = new System.Drawing.Size(100, 20);
            this.txtPriceMax.TabIndex = 9;
            this.txtPriceMax.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(20, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Flight num ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label4.Location = new System.Drawing.Point(316, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Departure:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Location = new System.Drawing.Point(316, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Arrival:       ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Location = new System.Drawing.Point(756, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label7.Location = new System.Drawing.Point(756, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "max";
            // 
            // btnFlightNum
            // 
            this.btnFlightNum.Location = new System.Drawing.Point(22, 331);
            this.btnFlightNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFlightNum.Name = "btnFlightNum";
            this.btnFlightNum.Size = new System.Drawing.Size(86, 23);
            this.btnFlightNum.TabIndex = 10;
            this.btnFlightNum.Text = "Search by num";
            this.btnFlightNum.UseVisualStyleBackColor = true;
            this.btnFlightNum.Click += new System.EventHandler(this.btnFlightNum_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(538, 185);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(755, 185);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Price:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(316, 185);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "City:";
            // 
            // Search_Flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KURSOVA.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 390);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnFlightNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPriceMax);
            this.Controls.Add(this.txtPriceMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArrivalDate);
            this.Controls.Add(this.txtDepartureDate);
            this.Controls.Add(this.txtArrivalCity);
            this.Controls.Add(this.txtDepartureCity);
            this.Controls.Add(this.lstViewStops);
            this.Controls.Add(this.dgwInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFlightNumber);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Search_Flight";
            this.ShowIcon = false;
            this.Text = "Search_Flight";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_Flight_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgwInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgwInfo;
        private System.Windows.Forms.ListView lstViewStops;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtDepartureCity;
        private System.Windows.Forms.TextBox txtArrivalCity;
        private System.Windows.Forms.MaskedTextBox txtDepartureDate;
        private System.Windows.Forms.MaskedTextBox txtArrivalDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtPriceMin;
        private System.Windows.Forms.MaskedTextBox txtPriceMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableSeatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departurePointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource flightsBindingSource;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private System.Windows.Forms.Button btnFlightNum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}