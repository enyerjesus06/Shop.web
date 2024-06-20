﻿
namespace Shop.DAL.Models.ProductsModels
{
    public class ProductsModel
    {
        public int productid { get; set; }
        public string productname { get; set; }
        public int supplierid { get; set; }
        public int categoryid { get; set; }
        public decimal unitprice { get; set; }
        public bool discontinued { get; set; }
        public DateTime creation_date { get; set; }
        public int creation_user { get; set; }
    }
}
