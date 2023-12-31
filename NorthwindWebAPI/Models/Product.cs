﻿using System.ComponentModel.DataAnnotations;

namespace NorthwindWebAPI.Models
{
    public class Product
    {
        [Key] 
        public int ProductId { get; set; }
        public string ProductName { get; set; } = "";
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public bool Discontinued { get; set; }

    }
}
