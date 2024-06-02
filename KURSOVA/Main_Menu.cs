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
    public partial class Main_Menu : Form
    {
        public Schedule schedule;
        public BookingManager booking;

        public Main_Menu()
        {
            InitializeComponent();
            schedule = new Schedule();
            booking = new BookingManager(schedule);

            var flights = new List<Flight>
    {
        new Flight("101", new List<string> { "New York", "London" }, "British Airways", 850.00, 100, new DateTime(2024, 6, 10, 8, 30, 0), new DateTime(2024, 6, 10, 20, 30, 0)),
        new Flight("202", new List<string> { "Los Angeles", "Tokyo" }, "Japan Airlines", 1200.00, 150, new DateTime(2024, 6, 11, 10, 0, 0), new DateTime(2024, 6, 12, 14, 0, 0)),
        new Flight("303", new List<string> { "Sydney", "Singapore", "Dubai" }, "Emirates", 1400.00, 200, new DateTime(2024, 6, 12, 12, 0, 0), new DateTime(2024, 6, 13, 18, 0, 0)),
        new Flight("404", new List<string> { "Paris", "Rome" }, "Air France", 400.00, 80, new DateTime(2024, 6, 14, 9, 0, 0), new DateTime(2024, 6, 14, 11, 30, 0)),
        new Flight("505", new List<string> { "Toronto", "New York", "Miami" }, "Air Canada", 500.00, 120, new DateTime(2024, 6, 15, 13, 0, 0), new DateTime(2024, 6, 15, 20, 0, 0))
    };

            foreach (var flight in flights)
            {
                schedule.AddFlight(flight);
            }

            MessageBox.Show("Example flights added successfully.");
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(schedule);
            form1.ShowDialog();
        }

        private void btnSearchFlights_Click(object sender, EventArgs e)
        {
            Search_Flight searchFlight = new Search_Flight(schedule);
            searchFlight.ShowDialog();
        }

        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            Book_Ticket book = new Book_Ticket(schedule,booking);
            book.ShowDialog();
        }

        private void btnViewTickets_Click(object sender, EventArgs e)
        {
            View_Ticket ticket = new View_Ticket(schedule, booking);
            ticket.ShowDialog();
        }
    }
}
