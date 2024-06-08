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
        private BookingManager booking;

        public Search_Flight(BookingManager booking)
        {
            InitializeComponent();
            this.booking = booking;
            this.KeyPreview = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            Schedule sh = new Schedule();
            sh.Flights = this.booking.Schedule.Flights;
            
           
            
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
           

            dgwInfo.DataSource = sh.Flights;
           
          
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void dgwInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
             
                DataGridViewCell cell = dgwInfo.Rows[e.RowIndex].Cells[e.ColumnIndex];

         
                if (cell.Value != null)
                {
                 
                    string flightNum = cell.Value.ToString();
                    lstViewStops.Items.Clear();

                    
                    var flight = booking.Schedule.FindFlightByNumber(flightNum);
                    if (flight != null)
                    {
                      
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

           
            if (!string.IsNullOrEmpty(txtFlightNumber.Text))
            {
                string flightNumber = txtFlightNumber.Text;
                var flight = booking.Schedule.FindFlightByNumber(flightNumber);
                if (flight != null)
                {
                    results.Add(flight);
                }
            }

            else
            {
                foreach (var item in booking.Schedule.Flights)
                {
                    results.Add(item);
                }
            }
            
            dgwInfo.DataSource = results;
            
        }
        private void Search_Flight_KeyDown(object sender, KeyEventArgs e)
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

        private void ShowHelp()
        {

            MessageBox.Show("Book a flight");
        }
    }

}
