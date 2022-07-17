using BookingAppDio.Core.ModelsAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppDio.Flight.Domain.Aircrafts.Models
{
    public class Aircraft : Aggregate<long>
    {
        public string Name { get; private set; }
        public string Model { get; private set; }

        public static Aircraft Create(long id, string name, string model)
        {
            return new Aircraft
            {
                Id = id,
                Name = name,
                Model = model
            };

        }
    }
}
