

namespace Shop.DAL.Core
{
    public abstract class Identity : Adresses
    {
        public string? CompanyName { get; set; }
        public string? ContactName { get; set; }
        public string? ContactTitle { get; set;}
        public string? Fax { get; set; }
    }
}
