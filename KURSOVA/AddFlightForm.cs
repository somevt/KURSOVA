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
    public partial class AddFlightForm : Form
    {
        private Schedule schedule;
        public AddFlightForm(Schedule schedule)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.schedule = schedule; 
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            
                string flightNumber = txtFlightNumber.Text;
                List<string> stops = txtStops.Text.Split(',').ToList();
                string carrier = txtCarrier.Text;

              
                if (!double.TryParse(txtTicketPrice.Text, out double ticketPrice) || ticketPrice <= 0)
                {
                    MessageBox.Show("Ticket price must be a positive number greater than 0.");
                    return;
                }

              
                if (!int.TryParse(txtAvailableSeats.Text, out int availableSeats) || availableSeats <= 0)
                {
                    MessageBox.Show("Available seats must be a positive integer greater than 0.");
                    return;
                }

                
                if (!DateTime.TryParse(txtDepartureDate.Text, out DateTime departureDate))
                {
                    MessageBox.Show("Invalid departure date format.");
                    return;
                }

               
                if (!DateTime.TryParse(txtArrivalDate.Text, out DateTime arrivalDate))
                {
                    MessageBox.Show("Invalid arrival date format.");
                    return;
                }

                
                if (departureDate < DateTime.Now || arrivalDate < DateTime.Now)
                {
                    MessageBox.Show("Date and time input error. Dates cannot be in the past.");
                    return;
                }

          
                if (departureDate == arrivalDate)
                {
                    MessageBox.Show("Date and time input error. Departure and arrival dates cannot be the same.");
                    return;
                }

               
                if (schedule.Flights.Any(f => f.FlightNumber == flightNumber))
                {
                    MessageBox.Show("A flight with this number already exists.");
                    return;
                }

               
                arrivalDate = arrivalDate.AddHours(1);

           
                var flight = new Flight(flightNumber, stops, carrier, ticketPrice, availableSeats, departureDate, arrivalDate);
                schedule.AddFlight(flight);

                MessageBox.Show("Flight added successfully.");
            }
        private void AddFlightForm_KeyDown(object sender, KeyEventArgs e)
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
                    else
                    {
                        btnAddFlight_Click(sender, e);
                    }
                    break;
                case Keys.Escape:
                 
                    this.Close();  
                    break;
                case Keys.Tab:
                   
                    this.SelectNextControl(this.ActiveControl, true, true, true, true);
                    break;
                case Keys.ShiftKey:

                    if (e.Shift)
                    {
                        this.SelectNextControl(this.ActiveControl, false, true, true, true);
                    }
                    break;
            }
        }

        private void ShowHelp()
        {
            
            MessageBox.Show("Flight form fo adding aa flight");
        }
    }
}
