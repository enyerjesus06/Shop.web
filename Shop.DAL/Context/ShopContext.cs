
using Microsoft.EntityFrameworkCore;
using Shop.DAL.Entities;

namespace Shop.DAL.Context
{
    public partial class ShopContext : DbContext
    {
        #region "Constructor"
        public ShopContext(DbContextOptions<ShopContext> options) : base(options) 
        {
        
        }
        #endregion
        #region "Dbsets"
        public DbSet<Categories> Categories  { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
                .HasKey(c => c.categoryid); 
        }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Shippers> Shippers { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        

        #endregion
    }
}
