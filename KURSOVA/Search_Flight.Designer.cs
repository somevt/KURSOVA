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
            this.Carrier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TicketPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lstViewStops = new System.Windows.Forms.ListView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departurePointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Location = new System.Drawing.Point(430, 227);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(144, 22);
            this.txtFlightNumber.TabIndex = 0;
            this.txtFlightNumber.Text = "Flight number";
            this.txtFlightNumber.TextChanged += new System.EventHandler(this.txtFlightNumber_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(902, 405);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(172, 23);
            this.btnSearch.TabIndex = 1;
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
            this.Carrier,
            this.departureTimeDataGridViewTextBoxColumn,
            this.arrivalTimeDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.departurePointDataGridViewTextBoxColumn,
            this.destinationPointDataGridViewTextBoxColumn,
            this.TicketPrice,
            this.AvailableSeats});
            this.dgwInfo.DataSource = this.flightsBindingSource;
            this.dgwInfo.Location = new System.Drawing.Point(12, 12);
            this.dgwInfo.Name = "dgwInfo";
            this.dgwInfo.RowHeadersWidth = 51;
            this.dgwInfo.RowTemplate.Height = 24;
            this.dgwInfo.Size = new System.Drawing.Size(1187, 198);
            this.dgwInfo.TabIndex = 2;
            this.dgwInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwInfo_CellContentClick);
            // 
            // Carrier
            // 
            this.Carrier.DataPropertyName = "Carrier";
            this.Carrier.HeaderText = "Carrier";
            this.Carrier.MinimumWidth = 6;
            this.Carrier.Name = "Carrier";
            this.Carrier.Width = 125;
            // 
            // TicketPrice
            // 
            this.TicketPrice.DataPropertyName = "TicketPrice";
            this.TicketPrice.HeaderText = "TicketPrice";
            this.TicketPrice.MinimumWidth = 6;
            this.TicketPrice.Name = "TicketPrice";
            this.TicketPrice.Width = 125;
            // 
            // AvailableSeats
            // 
            this.AvailableSeats.DataPropertyName = "AvailableSeats";
            this.AvailableSeats.HeaderText = "AvailableSeats";
            this.AvailableSeats.MinimumWidth = 6;
            this.AvailableSeats.Name = "AvailableSeats";
            this.AvailableSeats.Width = 125;
            // 
            // flightsBindingSource
            // 
            this.flightsBindingSource.DataMember = "Flights";
            this.flightsBindingSource.DataSource = this.scheduleBindingSource;
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
            this.lstViewStops.Location = new System.Drawing.Point(12, 227);
            this.lstViewStops.Name = "lstViewStops";
            this.lstViewStops.Size = new System.Drawing.Size(389, 90);
            this.lstViewStops.TabIndex = 3;
            this.lstViewStops.UseCompatibleStateImageBehavior = false;
            this.lstViewStops.View = System.Windows.Forms.View.List;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FlightNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "FlightNumber";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
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
            // scheduleBindingSource
            // 
            this.scheduleBindingSource.DataSource = typeof(KURSOVA.Schedule);
            // 
            // Search_Flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KURSOVA.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1205, 450);
            this.Controls.Add(this.lstViewStops);
            this.Controls.Add(this.dgwInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFlightNumber);
            this.Name = "Search_Flight";
            this.Text = "Search_Flight";
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
        private System.Windows.Forms.BindingSource flightsBindingSource;
        private System.Windows.Forms.BindingSource scheduleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrier;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departurePointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableSeats;
    }
}