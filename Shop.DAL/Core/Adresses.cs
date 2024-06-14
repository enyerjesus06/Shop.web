

namespace Shop.DAL.Core
{
    public abstract class Adresses : BaseEntity
    {
        public string? Adress  { get; set; }
        public string? City { get; set; }
        public string? Region { get; set; }
        public string? PostalCode { get; set;}
        public string? Country { get; set; }
        public string? Phone { get; set; }

    }
}
