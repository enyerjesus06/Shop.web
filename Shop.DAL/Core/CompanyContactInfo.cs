

namespace Shop.DAL.Core
{
    public abstract class CompanyContactInfo : ContactDetails
    {
        public  string companyname { get; set; }
        public  string contactname { get; set; }
        public  string contacttitle { get; set;}
        public string? fax { get; set; }
    }
}
