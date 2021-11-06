using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maui.Backend.Models.General;
using Maui.Backend.Models.MercadoLibreCatalog;

namespace Maui.Backend.Models.DataBase
{
    public class OrmProduct
    {
        public string Title { get; init; }

        public double? Price { get; init; }

        public int? AvailableQuantity { get; init; }

        public string PermalinkToProduct { get; init; }

        public string ThumbnailUrl { get; init; }
        public uint ProductId { get; init; }
    }

    public static class ProductOperations
    {
        public static async Task PushToDataBaseAsync(Product product)
        {
            OrmProduct ormProduct = new OrmProduct()
            {
                Title = product.Title,
                Price = product.Price,
                AvailableQuantity = product.AvailableQuantity,
                PermalinkToProduct = product.PermalinkToProduct,
                ThumbnailUrl = product.ThumbnailUrl,
                ProductId = product.ProductId
            };
            
            await using (var dataBase = new DataBaseContext())
            {
                await dataBase.Database.EnsureCreatedAsync();
                dataBase.OrmProducts.Add(ormProduct);
                await dataBase.SaveChangesAsync();
            }
        }
        
        public static async Task<List<OrmProduct>> ReadAllFromDataBaseAsync()
        {
            List<OrmProduct> queryResult;
            
            await using (var dataBase = new DataBaseContext())
            {
                await dataBase.Database.EnsureCreatedAsync();
                queryResult = dataBase.OrmProducts.ToList();
                await dataBase.SaveChangesAsync();
            }
            return queryResult;
        }
    }
}