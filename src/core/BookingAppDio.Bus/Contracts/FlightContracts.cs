using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppDio.Bus.Contracts
{
    public record GetFlightById
    {
        public long FlightId { get; init; }
    }

    public record GetAvailableSeatsById
    {
        public long FlightId { get; init; }
    }

    public record FlightResponse
    {
        public long Id { get; private set; }
        public string FlightNumber { get; private set; }
        public string Description { get; private set; }
        public long AircraftId { get; private set; }
        public DateTime DepartureDate { get; private set; }
        public long DepartureAirportId { get; private set; }
        public DateTime ArriveDate { get; private set; }
        public long ArriveAirportId { get; private set; }
        public decimal DurationMinutes { get; private set; }
        public DateTime FlightDate { get; private set; }
        public FlightStatus Status { get; private set; }
        public decimal Price { get; private set; }
    }

    public enum FlightStatus
    {
        Flying = 1,
        Delay = 2,
        Canceled = 3,
        Completed = 4
    }

    public record SeatResponse
    {
        public long Id { get; private set; }

        public string SeatNumber { get; private set; }
        public SeatType Type { get; private set; }
        public SeatClass Class { get; private set; }
        public long FlightId { get; private set; }
    }

    public enum SeatClass
    {
        FirstClass,
        Business,
        Economy
    }

    public enum SeatType
    {
        Window,
        Middle,
        Aisle
    }

    public record ReserveSeatRequestDto
    {
        public long Id { get; init; }
        public string SeatNumber { get; init; }
        public SeatType Type { get; init; }
        public SeatClass Class { get; init; }
        public long FlightId { get; init; }
        
    }
}
