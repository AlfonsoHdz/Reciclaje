using System.Collections.Generic;

namespace LVAReciclajeTPDA.Data
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surnames { get; set; }
        public string Rfc { get; set; }
        public string Curp { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string Contact { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public ICollection<Sale> Sales { get; set; }
    }
}
