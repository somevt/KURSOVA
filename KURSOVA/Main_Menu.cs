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

        string fileTicket = "Tickets.txt";
        string fileFlight = "Schedule.txt";

        public Main_Menu()
        {
            InitializeComponent();
            schedule = new Schedule();
            schedule.LoadFromFile(fileFlight);
            booking = new BookingManager(schedule);
            booking.LoadTicketsFromFile(fileTicket);
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            AddFlightForm addFlightForm = new AddFlightForm(schedule);
            addFlightForm.ShowDialog();
        }

        private void btnSearchFlights_Click(object sender, EventArgs e)
        {
            Search_Flight searchFlight = new Search_Flight(schedule);
            searchFlight.ShowDialog();
        }

        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            Book_Ticket book = new Book_Ticket(booking, "", "", d,false);
            book.ShowDialog();
        }

        private void btnViewTickets_Click(object sender, EventArgs e)
        {
            View_Ticket ticket = new View_Ticket(schedule, booking);
            ticket.ShowDialog();
        }

        private void btnFileManagement_Click(object sender, EventArgs e)
        {
            FileManagerForm fileManager = new FileManagerForm(schedule, booking);
            fileManager.ShowDialog();
        }
    }
}
