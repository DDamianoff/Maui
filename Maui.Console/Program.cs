using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

            await using (var sqLiteDataDase = new SqLiteDbContext())
            {
                Console.WriteLine("Esperando que DB este creada");
                await sqLiteDataDase.Database.EnsureCreatedAsync();
                Console.WriteLine("Done :)");

                Console.WriteLine($"el trabajador {sqLiteDataDase.Transactions.First().Worker.FirstName} vendió {sqLiteDataDase.Transactions.First().Product.Title}");
            }
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