using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Maui.Backend.Models;
using Maui.Backend.Models.DataBase;
using Maui.Backend.Models.General;
using Maui.Backend.Models.MercadoLibreCatalog;
using Microsoft.EntityFrameworkCore;

namespace Maui.ConsoleFrontend
{
    public static class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static async Task Main(string[] args)
        {
            // var catalogo = await MeLiCatalogGenerator.GetCatalogAsync("remera");

            // foreach (Product result in catalogo.Results)
            // {
            //     await ProductOperations.PushToDataBaseAsync(result);
            // }

            var catalogFromDb = await ProductOperations.ReadAllFromDataBaseAsync();

            foreach (var product in catalogFromDb)
            {
                Console.WriteLine(product.Title);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.AvailableQuantity);
                
                Console.WriteLine("\n");
            }
        }
    }
}

