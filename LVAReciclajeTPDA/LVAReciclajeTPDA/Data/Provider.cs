using System.Collections.Generic;

namespace LVAReciclajeTPDA.Data
{
    public class Provider
    {
        public int Id { get; set; }

        public string EnterpriseName { get; set; }
        public string Brand { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }

        public ICollection<Purchase> Purchases { get; set; }
        public ICollection<PurchaseDetail> PurchaseDetails { get; set; }

    }
}
