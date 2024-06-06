using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSOVA
{
    public class Flight
    {
        public string flightNumber;
        public List<string> Stops; // Список зупинок, включаючи пункт відправлення, проміжні пункти та пункт призначення
        
        public DateTime departureDate;
        public DateTime arrivalDate;
        public string carrier;
        public double ticketPrice;
        public int availableSeats;

        public  TimeSpan departureTime;
        private TimeSpan arrivalTime;
        private TimeSpan duration;

        public string FlightNumber
        {
            get { return flightNumber; }
            set { flightNumber = value; }
        }
        public int AvailableSeats
        {
            get { return availableSeats; }
            set { availableSeats = value; }
        }
        public double TicketPrice
        {
            get { return ticketPrice; }
            set { ticketPrice = value; }
        }
        public string Carrier
        {
            get { return carrier; }
            set { carrier = value; }
        }
        public DateTime DepartureDate
        {
            get { return departureDate; }
            set { departureDate = value; }
        }
        public DateTime ArrivalDate
        {
            get { return arrivalDate; }
            set { arrivalDate = value; }
        }
        public TimeSpan DepartureTime 
        { 
            get { return departureTime; } 
            set { departureTime =value; } 
        }
        public TimeSpan ArrivalTime
        {
            get { return arrivalTime; }
            set { arrivalTime = value; }
        }
        
        public TimeSpan Duration 
        {
            get
            {
                return duration;
            }
            set
            {
                duration =  ArrivalDate-DepartureDate;
            } 
        }
        
        
        public string DeparturePoint => Stops.FirstOrDefault(); // Пункт відправлення - перший елемент у списку
        public string DestinationPoint => Stops.LastOrDefault(); // Пункт призначення - останній елемент у списку
        

        public Flight(string flightNumber, List<string> stops, string carrier, double ticketPrice, int availableSeats, DateTime departureDate, DateTime arrivalDate)
        {
            if (stops == null || stops.Count < 2)
                throw new ArgumentException("Stops list must contain at least two locations (departure and destination).");

            FlightNumber = flightNumber;
            Stops = stops;
            Carrier = carrier;
            TicketPrice = ticketPrice;
            AvailableSeats = availableSeats;
            DepartureDate = departureDate;
            ArrivalDate = arrivalDate;
            departureTime = (TimeSpan)DepartureDate.TimeOfDay;
            arrivalTime = (TimeSpan)ArrivalDate.TimeOfDay;
            duration = arrivalDate-departureDate  ;

        }

        public void UpdateFlightDetails(TimeSpan newDepartureTime, TimeSpan newDuration, double newTicketPrice, int newAvailableSeats, DateTime newDepartureDate, DateTime arrivalDate)
        {
            DepartureTime = newDepartureTime;
            Duration = newDuration;
            TicketPrice = newTicketPrice;
            AvailableSeats = newAvailableSeats;
            DepartureDate = newDepartureDate;
            ArrivalDate = arrivalDate;
        }

        public void AddStop(string stop)
        {
            if (!string.IsNullOrEmpty(stop) && !Stops.Contains(stop))
            {
                Stops.Insert(Stops.Count - 1, stop); // Add the stop before the last destination
            }
        }

        public void RemoveStop(string stop)
        {
            if (!string.IsNullOrEmpty(stop) && Stops.Contains(stop) && Stops.Count > 2)
            {
                Stops.Remove(stop);
            }
        }

        
     
         
        public override string ToString()
        {
            return $"Flight {FlightNumber} from {DeparturePoint} to {DestinationPoint}," +
                $" Carrier: {Carrier}, Departure: {DepartureTime}, Duration: {Duration}, " +
                $"Price: {TicketPrice:C}, Available Seats: {AvailableSeats}," +
                $" Departure Date: {DepartureDate.ToShortDateString()}, " +
                $" Arrival Date: {ArrivalDate.ToShortDateString()}, " ;
        }
    }
}
