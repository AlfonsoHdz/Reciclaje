﻿using System;
using System.Collections.Generic;


namespace LVAReciclajeTPDA.Data
{
    public class Sale: IEntity
    {
        public int Id { get; set; }
        public string FullNameSeller { get; set; }
        public int SellerPhone { get; set; }
        public char SellerEmail { get; set; }
        public string BuyerName { get; set; }
        public string FullNameBuyer { get; set; }
        public int BuyerPhone { get; set; }
        public char BuyerEmail { get; set; }
        public string Product { get; set; }
        public string Billing { get; set; }
        public string SendTo { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public int CompanyPhone { get; set; }
        public string City { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
        public double SalePrice { get; set; }
        public double TotalCost { get; set; }
        

        public ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public ICollection<Employee> Employees { get; set; }
    

    }
}
