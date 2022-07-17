
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext : DbContext
    {
        
        public StoreContext(DbStoreContextOptions options) : base (options)
        {
        } 

        public DbSet<Product> Products { get; set }
    }
}