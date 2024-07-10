using InsanmarTec.Domain.Auth.Roles;
using InsanmarTec.Domain.Auth.Users;
using InsanmarTec.Domain.Brands;
using InsanmarTec.Domain.Customers;
using InsanmarTec.Domain.Models;
using InsanmarTec.Domain.Notes.EntryNotes;
using InsanmarTec.Domain.Notes.ExitNotes;
using InsanmarTec.Domain.PaymentMethods;
using InsanmarTec.Domain.Products;
using InsanmarTec.Domain.Purchases;
using InsanmarTec.Domain.Purchases.PurchaseOrders;
using InsanmarTec.Domain.Qualities;
using InsanmarTec.Domain.Sales;
using InsanmarTec.Domain.StockMovements;
using InsanmarTec.Domain.Suppliers;
using Microsoft.EntityFrameworkCore;

namespace InsanmarTec.Infrastructure.Shared.Persistence
{
    public class InsanmarTecDbContext : DbContext
    {
        public InsanmarTecDbContext(DbContextOptions<InsanmarTecDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(InfrastructureModule).Assembly);
            //modelBuilder.ApplyFilterByIsDeleted();
            InitialSeed.Seed(modelBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
            configurationBuilder.Properties<string>().HaveColumnType("varchar");
        }

        // Define a DbSet for each entity of the application
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<User> Users => Set<User>();
        public DbSet<PaymentMethod> PaymentMethods => Set<PaymentMethod>();
        public DbSet<StockMovement> StockMovements => Set<StockMovement>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Quality> Qualities => Set<Quality>();
        public DbSet<Brand> Brands => Set<Brand>();
        public DbSet<Model> Models => Set<Model>();
        public DbSet<Supplier> Suppliers => Set<Supplier>();
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<PurchaseOrder> PurchaseOrders => Set<PurchaseOrder>();
        public DbSet<PurchaseOrderDetail> PurchaseOrderDetails => Set<PurchaseOrderDetail>();
        public DbSet<Purchase> Purchases => Set<Purchase>();
        public DbSet<EntryNote> EntryNotes => Set<EntryNote>();
        public DbSet<Sale> Sales => Set<Sale>();
        public DbSet<SaleDetail> SaleDetails => Set<SaleDetail>();
        public DbSet<ExitNote> ExitNotes => Set<ExitNote>();
    }
}
