using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSOVA
{
    public class Schedule
    {
        public List<Flight> Flights { get;  set; }

        public Schedule()
        {
            Flights = new List<Flight>();
        }

        public void AddFlight(Flight flight)
        {
            if (flight == null)
                throw new ArgumentNullException(nameof(flight), "Flight cannot be null.");
            Flights.Add(flight);
        }

        public Flight FindFlightByNumber(string flightNumber)
        {
            return Flights.FirstOrDefault(f => f.FlightNumber == flightNumber);
        }

        public List<Flight> FindFlightsByRoute(string departure, string destination)
        {
            return Flights.Where(f => f.DeparturePoint.Equals(departure, StringComparison.OrdinalIgnoreCase) &&
                                       f.DestinationPoint.Equals(destination, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Flight> FindFlightsByDuration(TimeSpan maxDuration)
        {
            return Flights.Where(f => f.Duration <= maxDuration).ToList();
        }

        public List<Flight> GetFlightsByStop(string stop)
        {
            return Flights.Where(f => f.Stops.Contains(stop, StringComparer.OrdinalIgnoreCase)).ToList();
        }
        public List<Flight> FindFlightsByCarrier(string carrier)
        {
            return Flights.Where(f => f.Carrier.Equals(carrier, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Flight> FindFlightsByPriceRange(double minPrice, double maxPrice)
        {
            return Flights.Where(f => f.TicketPrice >= minPrice && f.TicketPrice <= maxPrice).ToList();
        }

        public List<Flight> FindFlightsByDate(DateTime date)
        {
            return Flights.Where(f => f.DepartureDate.Date == date.Date).ToList();
        }

        public List<Flight> GetFlightsByDateRange(DateTime startDate, DateTime endDate)
        {
            return Flights.Where(f => f.DepartureDate >= startDate && f.DepartureDate <= endDate).ToList();
        }

        public List<Flight> GetWeeklySchedule()
        {
            var today = DateTime.Today;
            var endOfWeek = today.AddDays(7);
            return Flights.Where(f => f.DepartureDate.Date >= today && f.DepartureDate.Date <= endOfWeek).ToList();
        }

        public Flight GetNearestFlight(string destination)
        {
            var today = DateTime.Today;
            return Flights.Where(f => f.DestinationPoint.Equals(destination, StringComparison.OrdinalIgnoreCase) && f.DepartureDate.Date >= today)
                          .OrderBy(f => f.DepartureDate)
                          .FirstOrDefault(f => f.AvailableSeats > 0);
        }
    }
}
