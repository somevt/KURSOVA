using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KURSOVA
{
    public class BookingManager
    {
        public Schedule Schedule { get; set; }
        public List<Ticket> Tickets { get; set; }

        public BookingManager(Schedule schedule)
        {
            Schedule = schedule ;
            Tickets = new List<Ticket>();
        }

        public Ticket BookOneWayTicket(string passengerName, string passengerSurname, string flightNumber)
        {
            var flight = Schedule.FindFlightByNumber(flightNumber);
            if (flight == null)
                throw new ArgumentException($"Flight with number {flightNumber} does not exist.");
            if (flight.AvailableSeats <= 0)
                throw new InvalidOperationException("No available seats on this flight.");

            
            var ticket = new Ticket(Guid.NewGuid().ToString(), flight, passengerName , passengerSurname);
            Tickets.Add(ticket);
            return ticket;
        }

        

        public void PrintTicket(string ticketID)
        {
            var ticket = Tickets.FirstOrDefault(t => t.TicketID == ticketID);
            if (ticket == null)
                throw new ArgumentException($"Ticket with ID {ticketID} does not exist.");

            ticket.PrintTicket();
        }

        public void CancelTicket(string ticketID)
        {
            var ticket = Tickets.FirstOrDefault(t => t.TicketID == ticketID);
            if (ticket == null)
                throw new ArgumentException($"Ticket with ID {ticketID} does not exist.");

            ticket.CancelTicket();
            Tickets.Remove(ticket);
        }


        public List<Ticket> GetTicketsByPassenger(string name, string surname)
        {
            
            List<Ticket> tic = Tickets.Where(t => t.PassengerName == name).ToList();
            return tic.Where(t => t.PassengerSurname == surname).ToList();
        }
        public bool isPassenger(string name, string surname)
        {
            foreach (var item in Tickets)
            {
                if (item.PassengerName==name&&item.PassengerSurname==surname)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Ticket> GetTicketsByStop(string stop)
        {
            return Tickets.Where(t => t.Flight.Stops.Contains(stop)).ToList();
        }

        public List<Ticket> GetTicketsByDate(DateTime date)
        {
            return Tickets.Where(t => t.Flight.DepartureDate.Date == date.Date).ToList();
        }
        public Ticket GetTicketById(string ticketId)
        {
            return Tickets.FirstOrDefault(t => t.TicketID == ticketId);
        }

       public Ticket GetTicketByFlightNum(string ticketFlightNum)
        {
            return Tickets.FirstOrDefault(t => t.Flight.FlightNumber == ticketFlightNum);
        }
        public void SaveTicketsToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var ticket in Tickets)
                {
                    writer.WriteLine($"{ticket.TicketID},{ticket.PassengerName},{ticket.PassengerSurname},{ticket.Flight.FlightNumber}");
                }
            }
        }

        public void LoadTicketsFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("File not found", filePath);

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 4)
                    {
                        var ticketID = parts[0];
                        var passengerName = parts[1];
                        var passengerSurname = parts[2];
                        var flightNumber = parts[3];

                        var flight = Schedule.FindFlightByNumber(flightNumber);
                        if (flight != null)
                        {
                            var ticket = new Ticket(ticketID, flight, passengerName, passengerSurname);
                            Tickets.Add(ticket);
                        }
                    }
                }
            }
        }
    }
}
