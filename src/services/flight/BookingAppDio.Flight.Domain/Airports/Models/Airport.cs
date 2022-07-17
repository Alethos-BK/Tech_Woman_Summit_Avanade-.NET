using BookingAppDio.Core.ModelsAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppDio.Flight.Domain.Airports.Models
{
    public class Airport : Aggregate<long>
    {
        public string Name { get; private set; }
        public string Adress { get; private set; }

        public string Code { get; private set; }

        public static Airport Create(long id, string adress, string code, string v)
        {
            return new Airport
            {
                Id = id,
                Adress = adress,
                Code = code
            };

        }
    }
}
