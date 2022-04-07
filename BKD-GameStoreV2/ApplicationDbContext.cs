using BKD_GameStoreV2.Models;
using Microsoft.EntityFrameworkCore;

namespace BKD_GameStoreV2
{
    public class ApplicationDbContext: DbContext
    {   
        public DbSet<Products> Products { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}
    }
}
