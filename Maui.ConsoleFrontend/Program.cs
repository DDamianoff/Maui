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
            Product product = await Product.ReadFromDbById(614485334);
            product.Title = "Remeras Lisas Algodón Mangas Largas S - Xxl";
            await product.UpdateChangesInDbAsync();
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