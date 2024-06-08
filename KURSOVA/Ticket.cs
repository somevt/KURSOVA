using System;

namespace KURSOVA
{
    public class Ticket
    {
        public string TicketID { get; private set; }
        public Flight Flight { get; private set; }
        public string PassengerName { get; private set; }
        public string PassengerSurname { get; private set; }
        public DateTime BookingDate { get; private set; }

        public Ticket(string ticketID, Flight flight, string passengerName, string passengerSurname)
        {
            if (flight == null)
                throw new ArgumentNullException(nameof(flight), "Flight cannot be null.");
            if (string.IsNullOrEmpty(passengerName))
                throw new ArgumentException("Passenger name cannot be null or empty.", nameof(passengerName));

            TicketID = ticketID;
            Flight = flight;
            PassengerName = passengerName;
            PassengerSurname = passengerSurname;
            BookingDate = DateTime.Now;

            
        }

        public DateTime GetArrivalDate()
        {
            return Flight.ArrivalDate;
        }

        public TimeSpan GetArrivalTime()
        {
            return Flight.ArrivalTime;
        }

        public TimeSpan GetDepartureTime()
        {
            return Flight.DepartureTime;
        }

        public DateTime GetDepartureDate()
        {
            return Flight.DepartureDate;
        }

        public void PrintTicket()
        {
            Console.WriteLine($"Ticket ID: {TicketID}");
            Console.WriteLine($"Passenger: {PassengerName} {PassengerSurname}");
            Console.WriteLine($"Booking Date: {BookingDate}");
            Console.WriteLine($"Flight: {Flight.FlightNumber} from {Flight.DeparturePoint} to {Flight.DestinationPoint}");
            Console.WriteLine($"Departure: {Flight.DepartureDate} at {Flight.DepartureTime}");
            Console.WriteLine($"Arrival: {GetArrivalDate()} at {GetArrivalTime()}");
            Console.WriteLine($"Carrier: {Flight.Carrier}");
            Console.WriteLine($"Price: {Flight.TicketPrice:C}");
        }

        public void CancelTicket()
        {
            Flight.AvailableSeats++;
            Console.WriteLine($"Ticket ID {TicketID} has been cancelled.");
        }


    }
}
