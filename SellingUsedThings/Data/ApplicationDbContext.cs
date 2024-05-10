
using Microsoft.EntityFrameworkCore;
using SellingUsedThings.Models;


namespace SellingUsedThings.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> users { get; set; }  
        public DbSet<Product> products { get; set; }
        public DbSet<Chat> chats { get; set; }
        


    }
}
