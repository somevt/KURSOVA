using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSOVA
{
    public partial class FileManagerForm : Form
    {
        
        private BookingManager bookingManager;
        public FileManagerForm(BookingManager book)
        {
            InitializeComponent();
            this.KeyPreview = true;
            bookingManager = book;

        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            string fileTicket = "Tickets.txt";
            string fileFlight = "Schedule.txt";

            if (bookingManager.Tickets.Count == 0 || bookingManager.Schedule.Flights.Count == 0)
            {
                MessageBox.Show("No tickets or flights to save.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bookingManager.SaveTicketsToFile(fileTicket);
            bookingManager.Schedule.SaveToFile(fileFlight);
            MessageBox.Show("Tickets and Flights saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            string fileTicket = "Tickets.txt";
            string fileFlight = "Schedule.txt";

            if (!File.Exists(fileTicket))
            {
                MessageBox.Show("Tickets file does not exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!File.Exists(fileFlight))
            {
                MessageBox.Show("Schedule file does not exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bookingManager.LoadTicketsFromFile(fileTicket);
            bookingManager.Schedule.LoadFromFile(fileFlight);
            MessageBox.Show("Tickets and Flights loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ShowHelp()
        {

            MessageBox.Show("Menu with functionality for saving to file and load from file");
        }
        private void FileManagerForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:

                    ShowHelp();
                    break;
                case Keys.Enter:
                    if (ActiveControl is TextBox || ActiveControl is ComboBox || ActiveControl is DateTimePicker)
                    {
                        SelectNextControl(ActiveControl, true, true, true, true);
                    }
                    
                    break;
                case Keys.Escape:

                    this.Close();
                    break;
                case Keys.Tab:
                    if (e.Shift)
                    {

                        this.SelectNextControl(this.ActiveControl, false, true, true, true);
                    }
                    else
                    {

                        this.SelectNextControl(this.ActiveControl, true, true, true, true);
                    }
                    e.Handled = true;
                    break;
            }
        }
    }
}
