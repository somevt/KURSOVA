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
    public partial class View_Ticket : Form
    {
        private Schedule schedule;
        private BookingManager bookingManager;
        public View_Ticket(Schedule sh, BookingManager book)
        {
            InitializeComponent();
            schedule = sh;
            bookingManager = book;

        }


        /* private void btnSearchByFlightNumber_Click(object sender, EventArgs e)
         {
             List<Ticket> list = new List<Ticket>();

             var ticket = bookingManager.GetTicketById(txtTicketID.Text);
             if (ticket != null)
             {
                 DisplayTicket(ticket);
             }
             else
             {
                 MessageBox.Show("Ticket not found.");

             }
         }*/

        

        private void btnSearchByID_Click(object sender, EventArgs e)
        {
            List<Ticket> tickets = new List<Ticket>();
            var ticket = bookingManager.GetTicketById(txtTicketID.Text);
            if (ticket != null)
            {
                tickets.Add(ticket);
            }
            else
            {
                MessageBox.Show("Ticket not found.");
                foreach (var item in bookingManager.Tickets)
                {
                    tickets.Add(item);
                }

            }

           
            dgvTickets.DataSource = tickets;
        }

        private void btnSearchByNum_Click(object sender, EventArgs e)
        {
            
            List<Ticket> tickets = new List<Ticket>();
            var ticket = bookingManager.GetTicketByFlightNum(txtFlightNumber.Text);
            if (ticket != null)
            {
                tickets.Add(ticket);
            }
            else
            {
                MessageBox.Show("Ticket not found.");
                foreach (var item in bookingManager.Tickets)
                {
                    tickets.Add(item);
                }

            }

            dgvTickets.DataSource = tickets;
        }

        private void btnPassengerName_Click(object sender, EventArgs e)
        {
            List<Ticket> tickets = bookingManager.GetTicketsByPassenger(txtName.Text, txtSurname.Text);
            if (tickets == null)
            {
                MessageBox.Show("Ticket not found.");
            }

            dgvTickets.DataSource = tickets;
        }

        private void btnSearchByStops_Click(object sender, EventArgs e)
        {
            
            List<Ticket> tickets = bookingManager.GetTicketsByStop(txtStop.Text);


            if (tickets.Count > 0)
            {
               
                dgvTickets.DataSource = tickets;
            }
            else
            {
                MessageBox.Show("No flights found with the specified stop.");
            }
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            List<Ticket> tickets = bookingManager.GetTicketsByDate(  DateTime.Parse(txtStartDate.Text));
            dgvTickets.DataSource = tickets;
        }


        /*private void DisplayTickets(List<Ticket> tickets)
        {
            lstTickets.Items.Clear();
            foreach (var ticket in tickets)
            {
                lstTickets.Items.Add(ticket.ToString());
            }
        }*/

        /*  private void DisplayTicket(Ticket ticket)
          {
              lstTickets.Items.Clear();
              lstTickets.Items.Add(ticket.ToString());
          }*/
    }
}

