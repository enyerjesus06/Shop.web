﻿using System.ComponentModel.DataAnnotations;

using Shop.DAL.Core;

namespace Shop.DAL.Entities
{
    public class Employees : ContactDetails
    {
        [Key]
        public int empid { get; set; }
        public string firstname { get; set; }
        public  string lastname { get; set;}
        public  string title { get; set; }
        public  string titleofcourtesy { get; set; }
        public DateTime birthdate { get; set; }
        public DateTime hiredate { get; set; }
        public int? mgrid { get; set; }

    }
}
