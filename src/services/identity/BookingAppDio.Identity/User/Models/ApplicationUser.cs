using BookingAppDio.Core.ModelsAggregate;

namespace BookingAppDio.Identity.User.Models
{
    public class ApplicationUser : Aggregate<long>
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string? PassPortNumber { get; set; }

    }
}
