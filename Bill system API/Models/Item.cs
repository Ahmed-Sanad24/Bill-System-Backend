﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Bill_system_API.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double SellingPrice { get; set; }
        public double BuyingPrice { get; set; }
        public int AvailableAmount {  get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public int TypeId { get; set; }
        public Type Type { get; set; }
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
        //public ICollection<invoiceItem> invoices { get; set; }

    }
}
