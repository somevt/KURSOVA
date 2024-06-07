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
            this.KeyPreview = true;

        }


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
            List<Ticket> tickets = bookingManager.GetTicketsByDate(DateTime.Parse(txtStartDate.Text));
            dgvTickets.DataSource = tickets;
        }
        private void ShowHelp()
        {

            MessageBox.Show("Search a ticket form");
        }
        private void View_Ticket_KeyDown(object sender, KeyEventArgs e)
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
    }
}

