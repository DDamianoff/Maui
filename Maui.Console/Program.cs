using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maui.Backend.Models.DataBase;
using Maui.Backend.Models.MercadoLibreCatalog;
using Microsoft.EntityFrameworkCore;

namespace Maui.ConsoleFrontend
{
    /// <summary>
    /// Este proyecto es un sandbox para hacer operaciones
    /// rápidas.
    /// Principalmente añadir grandes lotes de registros a la
    /// base de datos para su prueba.
    /// </summary>
    public static class Program
    {
        static async Task Main()
        {
            using (var db = new SqLiteDbContext())
            {
                var transactions = db.Transactions;
                foreach (Transaction transaction in db.Transactions
                    .Include(t => t.Worker)
                    .Include(t => t.Product))
                {
                    Console.WriteLine($"Vendedor: {transaction.Worker.FirstName} Cantidad: {transaction.QuantityOperated} Producto: {transaction.Product.ProductId}");
                }
            }
        }
    }
}

/*
             await db.Database.EnsureCreatedAsync();

                Worker pepeWorker = new Worker()
                {
                    Age = 12,
                    BirthDate = DateTime.Now,
                    Dni = 1,
                    DocketId = 234455,
                    FirstName = "peep",
                    IsAdmin = false,
                    LastName = "Herald",
                    Password = "pepe123",
                    ProfilePictureId = "1234"
                };

                db.Workers.Add(pepeWorker);

                await db.SaveChangesAsync();

                var catalogo = await MercadoLibreCatalog.GetCatalogAsync("invierno");

                if (catalogo != null)
                    foreach (Result result in catalogo.Results)
                    {
                        db.Products.Add( Product.CastFromResult(result));
                    }
                else Console.WriteLine("sin conexión a internet");




                await db.SaveChangesAsync();



                foreach (Product product in db.Products)
                {
                    Transaction currentTransaction = new Transaction()
                    {
                        PaymentMethod = "tarjeta",
                        Product = product,
                        ProductId = product.ProductId,
                        Worker = db.Workers.First(),
                        WorkerId = db.Workers.First().DocketId,
                        QuantityOperated = 12,
                        ShellDateTime = DateTime.Now,
                        TransactionType = "venta"
                    };

                    await db.Transactions.AddAsync(currentTransaction);
                }
                await db.SaveChangesAsync();

                foreach (Transaction transaction in db.Transactions)
                {
                    Console.WriteLine($"Vendedor: {transaction.Worker.FirstName} Cantidad: {transaction.QuantityOperated} Producto: {transaction.Product.ProductId}");
                }

*/