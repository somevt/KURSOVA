using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSOVA
{
    public partial class Search_Flight : Form
    {
        private Schedule schedule = new Schedule();

        public Search_Flight(Schedule schedule)
        {
            InitializeComponent();
            this.schedule = schedule; // Store Schedule object passed from Main_Menu
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Flight> results = new List<Flight>();

            // Приклад пошуку за номером рейсу
            if (!string.IsNullOrEmpty(txtFlightNumber.Text))
            {
                string flightNumber = txtFlightNumber.Text;
                var flight = schedule.FindFlightByNumber(flightNumber);
                if (flight != null)
                {
                    results.Add(flight);
                }
            }

            else
            {
                foreach (var item in schedule.Flights)
                {
                    results.Add(item);
                }
            }
            // Інші критерії пошуку можна додати аналогічним чином

            // Виведення результатів пошуку
            dgwInfo.DataSource = results;
            /*foreach (var flight in results)
            {
                lstResults.Items.Add(flight.ToString());
            }*/
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void dgwInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on a valid cell (not on header or out of bounds)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the clicked cell
                DataGridViewCell cell = dgwInfo.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Ensure the cell value is not null
                if (cell.Value != null)
                {
                    // Get the cell value as a string
                    string flightNum = cell.Value.ToString();

                    // Clear the list view
                    lstViewStops.Items.Clear();

                    // Find the flight by its number
                    var flight = schedule.FindFlightByNumber(flightNum);
                    if (flight != null)
                    {
                        // Add each stop to the list view
                        foreach (var item in flight.Stops)
                        {
                            lstViewStops.Items.Add(item);
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("The selected cell is empty.");
                }
            }
        }

        private void txtFlightNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
