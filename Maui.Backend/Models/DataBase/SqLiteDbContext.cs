using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Maui.Backend.Models.DataBase
{
    /// <summary>
    /// Referencia:
    /// https://youtu.be/TyRrFt2fUJs
    /// </summary>
    public class SqLiteDbContext : DbContext
    {
        private static readonly string DataBase = "dataBase.sqlite";
        
        /*  Equivalen a tablas SQL. */
        public DbSet<Product> Products { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Account> Accounts { get; set; }


        /* Creará la DB solo si no existe. */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString: $"Filename={DataBase}",
            sqliteOptionsAction: sqliteDbContextOptionsBuilder =>
            {
                sqliteDbContextOptionsBuilder.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Worker>().ToTable("Workers");
            modelBuilder.Entity<Transaction>().ToTable("Transtactions");
            modelBuilder.Entity<Account>().ToTable("Accounts");

            // Definir las id como claves primarias.
            modelBuilder.Entity<Product>(entity => entity.HasKey(product => product.ProductId));
            modelBuilder.Entity<Worker>(entity => entity.HasKey(worker => worker.DocketId));
            modelBuilder.Entity<Transaction>(entity => entity.HasKey(transaction => transaction.TransactionId));
            modelBuilder.Entity<Account>(entity => entity.HasKey(account => account.AccountId));
            
            base.OnModelCreating(modelBuilder); 
        }
    }
}