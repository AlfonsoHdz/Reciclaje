namespace LVAReciclajeTPDA.Data
{
    public class DataContext : DbContext
    {
        public DataContext() : base ("name = con")
        {

        }

        DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        DbSet<Provider> Providers { get; set; }
        DbSet<Client> Clients { get; set; }



    }
}
