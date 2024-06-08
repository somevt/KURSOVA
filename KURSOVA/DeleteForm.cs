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
    public partial class DeleteForm : Form
    {
       
        public BookingManager booking;
        public User user;
       
        public DeleteForm(BookingManager booking, User user)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.user = user;
            this.booking = booking;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFlightNumber.Text))
            {
                
                List<Flight> flightsToRemove = new List<Flight>();
                foreach (Flight flight in booking.Schedule.Flights)
                {
                    if (flight.FlightNumber == txtFlightNumber.Text)
                    {
                        flightsToRemove.Add(flight);
                    }
                }

              
                foreach (Flight flight in flightsToRemove)
                {
                    booking.Schedule.Flights.Remove(flight);
                }

               
                List<Ticket> ticketsToRemove = new List<Ticket>();
                foreach (Ticket ticket in booking.Tickets)
                {
                    if (ticket.Flight.FlightNumber == txtFlightNumber.Text)
                    {
                        ticketsToRemove.Add(ticket);
                    }
                }

                
                foreach (Ticket ticket in ticketsToRemove)
                {
                    booking.Tickets.Remove(ticket);
                }

                if (flightsToRemove.Count > 0 || ticketsToRemove.Count > 0)
                {
                    MessageBox.Show("Done");
                }
            }

            if (!string.IsNullOrEmpty(txtTicketNumber.Text))
            {
              
                List<Ticket> ticketsToRemove = new List<Ticket>();
                foreach (Ticket ticket in booking.Tickets)
                {
                    if (ticket.TicketID == txtTicketNumber.Text)
                    {
                        ticketsToRemove.Add(ticket);
                    }
                }

                
                foreach (Ticket ticket in ticketsToRemove)
                {
                    booking.Tickets.Remove(ticket);
                }

                if (ticketsToRemove.Count>0)
                {
                    MessageBox.Show("Ticket deleted sucessfully!");
                }
                else
                {
                    MessageBox.Show("No tickets to delete");
                }


            }
        }

        private void ShowHelp()
        {

            MessageBox.Show("Menu with functionality for deleting");
        }
        private void DeleteForm_KeyDown(object sender, KeyEventArgs e)
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
                        btnDelete_Click(sender, e);
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

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            if (user.IsAdmin==false)
            {
                txtFlightNumber.Hide();
                lblFlight.Hide();
                btnDelete.Hide();
                btnUserDelete.Show();
                
            }
            else
            {
                txtFlightNumber.Show();
                lblFlight.Show();
                btnUserDelete.Hide();
                btnDelete.Show();
            }
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTicketNumber.Text))
            {

                List<Ticket> ticketsToRemove = new List<Ticket>();
                foreach (Ticket ticket in booking.Tickets)
                {
                    if (ticket.TicketID == txtTicketNumber.Text && ticket.PassengerSurname == user.Surname&&ticket.PassengerName==user.Name)
                    {
                        ticketsToRemove.Add(ticket);
                    }
                }


                foreach (Ticket ticket in ticketsToRemove)
                {
                    booking.GetTicketById(ticket.TicketID).Flight.AvailableSeats++;
                    booking.Tickets.Remove(ticket);
                }


                MessageBox.Show("Done");

            }
        }
    }
}
