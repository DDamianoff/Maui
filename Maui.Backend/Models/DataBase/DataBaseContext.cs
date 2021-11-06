using System.Reflection;
using Maui.Backend.Models.General;
using Microsoft.EntityFrameworkCore;

namespace Maui.Backend.Models.DataBase
{
    /// <summary>
    /// Referencia:
    /// https://youtu.be/TyRrFt2fUJs
    /// </summary>
    public class DataBaseContext : DbContext
    {
        private static readonly string DataBase = "dataBase.sqlite";
        
        /*  Equivalen a tablas SQL. */

        /* getters - setters */
        public DbSet<OrmProduct> OrmProducts { get; set; }
        public DbSet<OrmWorker> OrmWorkers { get; set; }
        public DbSet<OrmTransaction> OrmTransactions { get; set; }


        /* Sobrecarga: Creará la DB solo si no existe. */
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
            modelBuilder.Entity<OrmProduct>().ToTable("Products");
            modelBuilder.Entity<OrmWorker>().ToTable("Workers");
            modelBuilder.Entity<OrmTransaction>().ToTable("Transtactions");

            // Definir las id como claves primarias.
            modelBuilder.Entity<OrmProduct>(entity => entity.HasKey(product => product.ProductId));
            modelBuilder.Entity<OrmWorker>(entity => entity.HasKey(worker => worker.DocketId));
            modelBuilder.Entity<OrmTransaction>(entity => entity.HasKey(transaction => transaction.TransactionId));
            
            base.OnModelCreating(modelBuilder);
        }
    }
}