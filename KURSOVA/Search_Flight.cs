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
           
            Schedule sh = new Schedule();
            sh.Flights = this.schedule.Flights;
            
            // Приклад пошуку за номером рейсу
            
             if (!string.IsNullOrEmpty(txtDepartureCity.Text))
            {
                string departure = txtDepartureCity.Text;
                 sh.Flights = sh.FindFlightsByDeparture(departure);
                
               
            }
             if (!string.IsNullOrEmpty(txtArrivalCity.Text))
            {
                string arrival = txtArrivalCity.Text;
                sh.Flights = sh.FindFlightsByArrival(arrival);

            }
             if (!string.IsNullOrEmpty(txtPriceMax.Text)&& !string.IsNullOrEmpty(txtPriceMax.Text))
            {

               
                double min = double.Parse(txtPriceMin.Text);
                double max = double.Parse(txtPriceMax.Text);
                if (max>min)
                {

                    sh.Flights = sh.FindFlightsByPriceRange(min,max);
                }
               

            }
           //sgvdiyhuaqeoueahgouagoahegouaeoguiahuioghuioahgouahguoiaeghuoh
            DateTime? departureDate = null;
            if (!string.IsNullOrWhiteSpace(txtDepartureDate.Text))
            {
                if (DateTime.TryParse(txtDepartureDate.Text, out DateTime parsedDate))
                {
                    departureDate = parsedDate;
                }

            }
            DateTime? arrivalDate = null;
            if (!string.IsNullOrWhiteSpace(txtArrivalDate.Text))
            {
                if (DateTime.TryParse(txtArrivalDate.Text, out DateTime parsedDate))
                {
                    arrivalDate = parsedDate;
                }

            }
            if (departureDate!=null)
            {
                sh.Flights = sh.FindFlightsByDepartureDate((DateTime)departureDate);
            }
            if (arrivalDate!=null)
            {
                
                sh.Flights = sh.FindFlightsByArrivalDate((DateTime)arrivalDate);
            }
            /* if (!string.IsNullOrEmpty(txtFlightNumber.Text))
             {
                 string flightNumber = txtFlightNumber.Text;
                 var flight = schedule.FindFlightByNumber(flightNumber);
                 if (flight != null)
                 {
                     sh.Flights.Clear();
                      sh.Flights.Add(flight);
                 }
             }*/

            dgwInfo.DataSource = sh.Flights;
           
          
            
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

        private void btnFlightNum_Click(object sender, EventArgs e)
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
            
            dgwInfo.DataSource = results;
            
        }


    }

}
