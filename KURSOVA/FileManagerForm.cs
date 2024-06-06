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
        private Schedule schedule;
        private BookingManager bookingManager;
        public FileManagerForm(Schedule sh, BookingManager book)
        {
            InitializeComponent();
            schedule = sh;
            bookingManager = book;

        }


        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                string fileTicket = "Tickets.txt";
                string fileFlight = "Schedule.txt";

                if (bookingManager.Tickets.Count == 0||schedule.Flights.Count==0)
                {
                    MessageBox.Show("No tickets or flights to save.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bookingManager.SaveTicketsToFile(fileTicket);
                schedule.SaveToFile(fileFlight);
                MessageBox.Show("Tickets and Flights saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving tickets and flights: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                string fileTicket = "Tickets.txt";
                string fileFlight = "Schedule.txt";

                if (!File.Exists(fileTicket)||!File.Exists(fileFlight))
                {
                    MessageBox.Show("Tickets file does not exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bookingManager.LoadTicketsFromFile(fileTicket);
                schedule.LoadFromFile(fileFlight);
                MessageBox.Show("Tickets and Flights loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading tickets and flights: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
