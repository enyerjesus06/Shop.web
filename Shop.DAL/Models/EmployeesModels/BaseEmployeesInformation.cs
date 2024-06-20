


namespace Shop.DAL.Models.EmployeesModels
{
    public abstract class BaseEmployeesInformation
    {
        public  string title { get; set; }
        public  string titleofcourtesy { get; set; }
        public DateTime birthdate { get; set; }
        public  string address { get; set; }
        public  string city { get; set; }
        public string? region { get; set; }
        public string? postalcode { get; set; }
        public  string country { get; set; }
        public int? mgrid { get; set; }
        public int creation_user { get; set; }
        public DateTime creation_date { get; set; }
    }
}
