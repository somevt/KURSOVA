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
    public partial class User_Menu : Form
    {
        public Schedule schedule;
        public BookingManager booking;
        public BookingManager userBooking ;
        public User user;


        string fileTicket = "Tickets.txt";
        string fileFlight = "Schedule.txt";

        public User_Menu(User user)
        {
            InitializeComponent();
            this.user = user;
            this.KeyPreview = true;
            schedule = new Schedule();
            schedule.LoadFromFile(fileFlight);
            booking = new BookingManager(schedule);
            booking.LoadTicketsFromFile(fileTicket);
            userBooking = new BookingManager(schedule);
            if (booking.isPassenger(user.Name, user.Surname))
            {
                userBooking.Tickets = booking.GetTicketsByPassenger(user.Name, user.Surname);
            }


        }


        private void btnSearchFlights_Click(object sender, EventArgs e)
        {
            Search_Flight searchFlight = new Search_Flight(booking);
            searchFlight.ShowDialog();
        }

        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            Book_Ticket book = new Book_Ticket(booking, "", "", d, false,user);
            book.ShowDialog();
        }

        private void btnViewTickets_Click(object sender, EventArgs e)
        {
            if (booking.isPassenger(user.Name, user.Surname))
            {
                userBooking.Tickets = booking.GetTicketsByPassenger(user.Name, user.Surname);
            }
            View_Ticket ticket = new View_Ticket(userBooking);
            ticket.ShowDialog();
        }

      
        private void ShowHelp()
        {

            MessageBox.Show("Menu with main functionality");
        }

        private void User_Menu_KeyDown(object sender, KeyEventArgs e)
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DeleteForm delete = new DeleteForm(booking,user);
            this.Hide();
            delete.ShowDialog();
            this.Show();
        }
    }
}
