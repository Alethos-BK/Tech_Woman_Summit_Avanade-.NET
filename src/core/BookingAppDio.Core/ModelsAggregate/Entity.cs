using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingAppDio.Core.ModelsAggregate
{
    public abstract class Entity
    {
        public DateTime? CreateAt { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        public bool IsDeleted { get; set; }

    }
}
