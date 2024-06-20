using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Models.SuppliersModels
{
    public abstract class BaseSuppliersModel  
    {
        public  string companyname { get; set; }
        public  string contactname { get; set; }
        public  string contacttitle { get; set; }
        public string? fax { get; set; }
        public  string address { get; set; }
        public string city { get; set; }
        public string? region { get; set; }
        public string? postalcode { get; set; }
        public  string country { get; set; }
        public  string phone { get; set; }
    }
}
