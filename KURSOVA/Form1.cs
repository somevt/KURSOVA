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
    public partial class Form1 : Form
    {

        private Schedule schedule;
        public Form1(Schedule schedule)
        {
            InitializeComponent();
            this.schedule = schedule; // Store Schedule object passed from Main_Menu
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            try
            {
                string flightNumber = txtFlightNumber.Text;
                List<string> stops = txtStops.Text.Split(',').ToList();
                string carrier = txtCarrier.Text;
                double ticketPrice = double.Parse(txtTicketPrice.Text);
                int availableSeats = int.Parse(txtAvailableSeats.Text);
                DateTime departureDate = DateTime.Parse(txtDepartureDate.Text);
                DateTime arrivalDate = DateTime.Parse(txtArrivalDate.Text);

                if (ticketPrice <= 0)
                {
                    MessageBox.Show("Ticket price must be greater than 0.");
                    return;
                }

                if (availableSeats <= 0)
                {
                    MessageBox.Show("Available seats must be greater than 0.");
                    return;
                }

                if (departureDate < DateTime.Now && arrivalDate < DateTime.Now)
                {
                    MessageBox.Show("Date and time input error");
                    return;
                }

                if (departureDate == arrivalDate)
                {
                    MessageBox.Show("Date and time input error");
                    return;
                }

                if (schedule.Flights.Any(f => f.FlightNumber == flightNumber))
                {
                    MessageBox.Show("A flight with this number already exists.");
                    return;
                }


                arrivalDate.AddHours(1);

                var flight = new Flight(flightNumber, stops, carrier, ticketPrice, availableSeats, departureDate, arrivalDate);
                schedule.AddFlight(flight);

                MessageBox.Show("Flight added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void txtArrivalDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtAvailableSeats_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
