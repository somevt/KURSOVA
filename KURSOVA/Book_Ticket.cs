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
    public partial class Book_Ticket : Form
    {
        private Schedule schedule;
        private BookingManager booking;
        public Book_Ticket(Schedule sh , BookingManager book)
        {
            InitializeComponent();
            schedule = sh;
            booking = book;
        }

        private void btnBookFlight_Click(object sender, EventArgs e)
        {
            try
            {
                string passengerName = txtPassengerName.Text;
                string passengerSurname = txtPassengerSurname.Text;
                string flightNumber = txtFlightNumber.Text;

                var ticket = booking.BookOneWayTicket(passengerName, passengerSurname, flightNumber );
                MessageBox.Show("Ticket booked successfully. Ticket ID: " + ticket.TicketID);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void txtFlightNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
