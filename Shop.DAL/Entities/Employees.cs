

using Shop.DAL.Core;

namespace Shop.DAL.Entities
{
    internal class Employees : Adresses
    {
        public int? EmpId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public string? Title { get; set; }
        public string? TitleofCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public int Mgrid { get; set; }

    }
}
