
namespace KURSOVA
{
    partial class User_Menu
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
            this.btnViewTickets = new System.Windows.Forms.Button();
            this.btnBookTicket = new System.Windows.Forms.Button();
            this.btnSearchFlights = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnViewTickets
            // 
            this.btnViewTickets.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnViewTickets.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnViewTickets.Location = new System.Drawing.Point(208, 203);
            this.btnViewTickets.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewTickets.Name = "btnViewTickets";
            this.btnViewTickets.Size = new System.Drawing.Size(111, 30);
            this.btnViewTickets.TabIndex = 4;
            this.btnViewTickets.Text = "View tickets";
            this.btnViewTickets.UseVisualStyleBackColor = true;
            this.btnViewTickets.Click += new System.EventHandler(this.btnViewTickets_Click);
            // 
            // btnBookTicket
            // 
            this.btnBookTicket.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnBookTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBookTicket.Location = new System.Drawing.Point(114, 145);
            this.btnBookTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnBookTicket.Name = "btnBookTicket";
            this.btnBookTicket.Size = new System.Drawing.Size(111, 28);
            this.btnBookTicket.TabIndex = 1;
            this.btnBookTicket.Text = "Book ticket";
            this.btnBookTicket.UseVisualStyleBackColor = true;
            this.btnBookTicket.Click += new System.EventHandler(this.btnBookTicket_Click);
            // 
            // btnSearchFlights
            // 
            this.btnSearchFlights.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnSearchFlights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearchFlights.Location = new System.Drawing.Point(208, 75);
            this.btnSearchFlights.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchFlights.Name = "btnSearchFlights";
            this.btnSearchFlights.Size = new System.Drawing.Size(111, 30);
            this.btnSearchFlights.TabIndex = 2;
            this.btnSearchFlights.Text = "Search flights";
            this.btnSearchFlights.UseVisualStyleBackColor = true;
            this.btnSearchFlights.Click += new System.EventHandler(this.btnSearchFlights_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnReturn.Location = new System.Drawing.Point(301, 143);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(111, 30);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return Ticket";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // User_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KURSOVA.Properties.Resources.main;
            this.ClientSize = new System.Drawing.Size(553, 298);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnViewTickets);
            this.Controls.Add(this.btnBookTicket);
            this.Controls.Add(this.btnSearchFlights);
            this.Name = "User_Menu";
            this.Text = "User_Menu";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.User_Menu_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnViewTickets;
        private System.Windows.Forms.Button btnBookTicket;
        private System.Windows.Forms.Button btnSearchFlights;
        private System.Windows.Forms.Button btnReturn;
    }
}