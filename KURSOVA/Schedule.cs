using System;
using System.Collections.Generic;
using System.IO;
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

       
        public Schedule SearchOneWay(Schedule schedule, string departure, string arrival, DateTime date)
        {
            var filteredFlights = schedule.Flights
                                          .Where(f => f.DeparturePoint == departure &&
                                                      f.DestinationPoint == arrival &&
                                                      f.DepartureDate.Date == date.Date &&
                                                      f.AvailableSeats > 0)
                                          .ToList();

            if (!filteredFlights.Any())
            {
                throw new ArgumentException($"There are no flights from {departure} to {arrival} on {date.ToShortDateString()}.");
            }

            var resultSchedule = new Schedule();
            resultSchedule.Flights = filteredFlights;
            return resultSchedule;
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
        public List<Flight> FindFlightsByDeparture(string stop)
        {
            return Flights.Where(f => f.DeparturePoint==stop).ToList();
        }
        public List<Flight> FindFlightsByArrival(string stop)
        {
            List < Flight > flights = new List<Flight>();
            
            foreach (var item in Flights)
            {
                if (item.DestinationPoint==stop)
                {
                    flights.Add(item);
                }
                
            }
            return flights;
        }
        public List<Flight> FindFlightsByCarrier(string carrier)
        {
            return Flights.Where(f => f.Carrier.Equals(carrier, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Flight> FindFlightsByPriceRange(double minPrice, double maxPrice)
        {
            return Flights.Where(f => f.TicketPrice >= minPrice && f.TicketPrice <= maxPrice).ToList();
        }

        public List<Flight> FindFlightsByDepartureDate(DateTime date)
        {
            return Flights.Where(f => (f.DepartureDate.Day == date.Day&& f.DepartureDate.Month == date.Month&& f.DepartureDate.Year == date.Year)).ToList();
        }
        public List<Flight> FindFlightsByArrivalDate(DateTime date)
        {
            return Flights.Where(f => f.ArrivalDate.Date == date.Date).ToList();
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
        public void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var flight in Flights)
                {
                    writer.WriteLine($"{flight.FlightNumber};{string.Join(",", flight.Stops)};{flight.Carrier};{flight.TicketPrice};{flight.AvailableSeats};{flight.DepartureDate};{flight.ArrivalDate}");
                }
            }
        }

        public void LoadFromFile(string filePath)
        {
            Flights.Clear();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(';');

                    string flightNumber = parts[0];
                    List<string> stops = parts[1].Split(',').ToList();
                    string carrier = parts[2];
                    double ticketPrice = double.Parse(parts[3]);
                    int availableSeats = int.Parse(parts[4]);
                    DateTime departureDate = DateTime.Parse(parts[5]);
                    DateTime arrivalDate = DateTime.Parse(parts[6]);

                    var flight = new Flight(flightNumber, stops, carrier, ticketPrice, availableSeats, departureDate, arrivalDate);
                    
                    Flights.Add(flight);
                }
            }
        }
    }
}
