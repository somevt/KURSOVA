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
       
        private BookingManager booking;
        public string departure;
        public DateTime date;
        public string arrival;
        public bool isReturn ;
        public User user = null;
        public Book_Ticket( BookingManager book, string departure, string arrival, DateTime date, bool isReturn)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.booking = book;
            this.departure = departure;
            this.arrival = arrival;
            
            txtArrival.Text= arrival;
            txtDeparure.Text = departure;
            dtpDate.Value = date;
            this.isReturn = isReturn;
        }
        public Book_Ticket(BookingManager book, string departure, string arrival, DateTime date, bool isReturn,User user)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.booking = book;
            this.departure = departure;
            this.arrival = arrival;
            this.user = user;
            txtArrival.Text = arrival;
            txtDeparure.Text = departure;
            dtpDate.Value = date;
            this.isReturn = isReturn;
        }

        private void btnBookFlight_Click(object sender, EventArgs e)
        {
            if (user!=null)
            {
                txtPassengerName.Text = user.Name;
                txtPassengerSurname.Text = user.Surname;
            }
           
            string passengerName = txtPassengerName.Text;
            string passengerSurname = txtPassengerSurname.Text;
            if (string.IsNullOrWhiteSpace(passengerName) || string.IsNullOrWhiteSpace(passengerSurname))
            {
                MessageBox.Show("Please enter both passenger name and surname.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtFlightNumber.Text))
            {
                string flightNumber = txtFlightNumber.Text;

                var flight = booking.Schedule.FindFlightByNumber(flightNumber);
                if (flight == null)
                {
                    MessageBox.Show($"Flight with number {flightNumber} does not exist.", "Flight Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (flight.AvailableSeats <= 0)
                {
                    MessageBox.Show("No available seats on this flight.", "No Seats Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                var ticket = booking.BookOneWayTicket(passengerName, passengerSurname, flightNumber);
                MessageBox.Show("Ticket booked successfully. Ticket ID: " + ticket.TicketID);
            }

            
            else if (!string.IsNullOrWhiteSpace(txtDeparure.Text) && !string.IsNullOrWhiteSpace(txtArrival.Text))
            {
                BookingManager manager = new BookingManager(booking.Schedule);
                manager.Schedule = manager.Schedule.SearchOneWay(booking.Schedule, txtDeparure.Text, txtArrival.Text, dtpDate.Value);
                dgvFlights.DataSource = manager.Schedule.Flights;
            }
        }  
          
       


        private void txtFlightNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvFlights_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string passengerName = txtPassengerName.Text;
                string passengerSurname = txtPassengerSurname.Text;
                DataGridViewRow selectedRow = dgvFlights.Rows[e.RowIndex];
                string flightNumber = selectedRow.Cells["FlightNumber"].Value.ToString();

                try
                {
                    BookFlightAndAskReturn(passengerName, passengerSurname, flightNumber);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void BookFlightAndAskReturn(string passengerName, string passengerSurname, string flightNumber)
        {
           

           var ticket = booking.BookOneWayTicket(passengerName, passengerSurname, flightNumber);
            MessageBox.Show($"Ticket booked successfully. Ticket ID: {ticket.TicketID}");
            Flight flight = booking.Schedule.FindFlightByNumber(flightNumber);
            if (isReturn)
            {
                this.Close();
            }
            if (!isReturn)
            {
                DialogResult result = MessageBox.Show($"Do you want to buy a return ticket?", "Return Ticket", MessageBoxButtons.YesNo);
                this.Hide();
                if (result == DialogResult.Yes)
                {
                    isReturn = true;
                    Book_Ticket book = new Book_Ticket(booking, flight.DestinationPoint, flight.DeparturePoint, dtpDate.Value.AddDays(1), true);
                    book.ShowDialog();
                    

                }
                if (result == DialogResult.No )
                {
                    this.Close();
                }
            }
           
            
           
        }


        private void Book_Ticket_Load(object sender, EventArgs e)
        {
             
        }

        private void Book_Ticket_KeyDown(object sender, KeyEventArgs e)
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
                        btnBookFlight_Click(sender, e); 
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
