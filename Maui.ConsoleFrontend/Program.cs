using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Maui.Backend.Models;
using Maui.Backend.Models.DataBase;
using Maui.Backend.Models.MercadoLibreCatalog;
using Microsoft.EntityFrameworkCore;
using Product = Maui.Backend.Models.DataBase.Product;

namespace Maui.ConsoleFrontend
{
    public static class Program
    {
        static async Task Main()
        {
            await using (var db = new SqLiteDbContext()) { await db.Database.EnsureCreatedAsync(); }
            
            Transaction transaction1 = new Transaction()
            {
                DoerId = 12234,
                LinkToProduct = "",
                PaymentMethod = "Banco galicia debito",
                Product = "Cassette rojo divino",
                QuantityOperated = 10,
                ShellDateTime = DateTime.Now,
                ThumbnailUrl = "www.meli.com",
                TransactionType = "COMPRA",
            };
            
            Transaction transaction2 = new Transaction()
            {
                DoerId = 12234,
                LinkToProduct = "",
                PaymentMethod = "Banco galicia debito",
                Product = "Cassette rojo divino",
                QuantityOperated = 10,
                ShellDateTime = DateTime.Now,
                ThumbnailUrl = "www.meli.com",
                TransactionType = "COMPRA",
            };

            await Transaction.CreateInDbAsync(transaction1);
            await Transaction.CreateInDbAsync(transaction2);
        }
    }
}

/*
var catalogo = await MercadoLibreCatalog.GetCatalogAsync("remera roja");

if (catalogo != null)
    foreach (Result result in catalogo.Results)
    {
        await Product.CreateInDbAsync(Product.CastFromResult(result));
    }
else Console.WriteLine("sin conexión a internet");
*/