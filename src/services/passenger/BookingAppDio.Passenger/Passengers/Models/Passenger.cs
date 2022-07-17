using BookingAppDio.Core.ModelsAggregate;

namespace BookingAppDio.Passenger.Passengers.Models
{
    public class Passenger : Aggregate<long>
    {
        public string PassportNumber { get; private set; }
        public string Name { get; private set; }
        public PassengerType PassengerType { get; private set; }
        public int Age { get; private set; }

        public Passenger CompleteRegistrationPassenger(long id, string name, string passportNumber, PassengerType passengerType, int age)
        {
            return new Passenger
            {
                Name = name,
                PassportNumber = passportNumber,
                PassengerType = passengerType,
                Age = age,
                Id = id
            };
        }

        public static Passenger Create(long id, string name, string passportNumber, bool isDeleted = false )
        {
            return new Passenger
            {
                Id = id,
                Name = name,
                PassportNumber = passportNumber,
                IsDeleted = isDeleted
            };
        }

    }   
}
