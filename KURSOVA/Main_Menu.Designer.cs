namespace KURSOVA
{
    partial class Main_Menu
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
            this.btnSearchFlights = new System.Windows.Forms.Button();
            this.btnBookTicket = new System.Windows.Forms.Button();
            this.btnViewTickets = new System.Windows.Forms.Button();
            this.btnFileManagement = new System.Windows.Forms.Button();
            this.btnDelFlight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnAddFlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddFlight.Location = new System.Drawing.Point(39, 367);
            this.btnAddFlight.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(111, 28);
            this.btnAddFlight.TabIndex = 5;
            this.btnAddFlight.Text = "Add flight";
            this.btnAddFlight.UseVisualStyleBackColor = true;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // btnSearchFlights
            // 
            this.btnSearchFlights.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnSearchFlights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearchFlights.Location = new System.Drawing.Point(202, 116);
            this.btnSearchFlights.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchFlights.Name = "btnSearchFlights";
            this.btnSearchFlights.Size = new System.Drawing.Size(111, 30);
            this.btnSearchFlights.TabIndex = 1;
            this.btnSearchFlights.Text = "Search flights";
            this.btnSearchFlights.UseVisualStyleBackColor = true;
            this.btnSearchFlights.Click += new System.EventHandler(this.btnSearchFlights_Click);
            // 
            // btnBookTicket
            // 
            this.btnBookTicket.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnBookTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBookTicket.Location = new System.Drawing.Point(336, 117);
            this.btnBookTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookTicket.Name = "btnBookTicket";
            this.btnBookTicket.Size = new System.Drawing.Size(111, 28);
            this.btnBookTicket.TabIndex = 2;
            this.btnBookTicket.Text = "Book ticket";
            this.btnBookTicket.UseVisualStyleBackColor = true;
            this.btnBookTicket.Click += new System.EventHandler(this.btnBookTicket_Click);
            // 
            // btnViewTickets
            // 
            this.btnViewTickets.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnViewTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnViewTickets.Location = new System.Drawing.Point(336, 165);
            this.btnViewTickets.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewTickets.Name = "btnViewTickets";
            this.btnViewTickets.Size = new System.Drawing.Size(111, 30);
            this.btnViewTickets.TabIndex = 3;
            this.btnViewTickets.Text = "View tickets";
            this.btnViewTickets.UseVisualStyleBackColor = true;
            this.btnViewTickets.Click += new System.EventHandler(this.btnViewTickets_Click);
            // 
            // btnFileManagement
            // 
            this.btnFileManagement.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnFileManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnFileManagement.Location = new System.Drawing.Point(202, 165);
            this.btnFileManagement.Margin = new System.Windows.Forms.Padding(2);
            this.btnFileManagement.Name = "btnFileManagement";
            this.btnFileManagement.Size = new System.Drawing.Size(111, 30);
            this.btnFileManagement.TabIndex = 4;
            this.btnFileManagement.Text = "File management";
            this.btnFileManagement.UseVisualStyleBackColor = true;
            this.btnFileManagement.Click += new System.EventHandler(this.btnFileManagement_Click);
            // 
            // btnDelFlight
            // 
            this.btnDelFlight.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnDelFlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDelFlight.Location = new System.Drawing.Point(496, 367);
            this.btnDelFlight.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelFlight.Name = "btnDelFlight";
            this.btnDelFlight.Size = new System.Drawing.Size(111, 28);
            this.btnDelFlight.TabIndex = 6;
            this.btnDelFlight.Text = "Delete Flight";
            this.btnDelFlight.UseVisualStyleBackColor = true;
            this.btnDelFlight.Click += new System.EventHandler(this.btnDelFlight_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KURSOVA.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 425);
            this.Controls.Add(this.btnDelFlight);
            this.Controls.Add(this.btnFileManagement);
            this.Controls.Add(this.btnViewTickets);
            this.Controls.Add(this.btnBookTicket);
            this.Controls.Add(this.btnSearchFlights);
            this.Controls.Add(this.btnAddFlight);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main_Menu";
            this.ShowIcon = false;
            this.Text = "Main_Menu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_Menu_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.Button btnSearchFlights;
        private System.Windows.Forms.Button btnBookTicket;
        private System.Windows.Forms.Button btnViewTickets;
        private System.Windows.Forms.Button btnFileManagement;
        private System.Windows.Forms.Button btnDelFlight;
    }
}