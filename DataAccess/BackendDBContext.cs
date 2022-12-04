using Microsoft.EntityFrameworkCore;
using webClientsApi.Entity;


namespace webClientsApi.DataAccess
{
    public class BacKendDBContext : DbContext
    {

        public BacKendDBContext(DbContextOptions<BacKendDBContext> options) :
           base(options)
                  { }

        //Todo: add DbSets (tables of our Data base)
        public DbSet<Client>? client { get; set; }
        public DbSet<Vehicle>? vehicle { get; set; }
        
    }
}

