using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maui.Backend.Models.DataBase;
// ReSharper disable ConvertToUsingDeclaration

namespace Ma.Controllers.Ma.Ui
{
    public class StockController : GeneralController
    {
        public async Task UpdateProductInDbAsync(Product product)
        {
            await using (var db = new SqLiteDbContext())
            {
                var productLinked = await db.Products.FindAsync(product.ProductId);

                productLinked.Title = product.Title;
                productLinked.Price = product.Price;
                productLinked.AvailableQuantity = product.AvailableQuantity;
                productLinked.ThumbnailUrl = product.ThumbnailUrl;

                await db.SaveChangesAsync();
            }
        }

        public void UpdateProductInDb(Product product)
        {
             using (var db = new SqLiteDbContext())
             {
                 var productLinked =  db.Products.Find(product.ProductId);

                 productLinked.Title = product.Title;
                 productLinked.Price = product.Price;
                 productLinked.AvailableQuantity = product.AvailableQuantity;
                 productLinked.ThumbnailUrl = productLinked.ThumbnailUrl;

                 db.SaveChanges();
             }
        }
        public List<Product> GetAllProducts()
        {
            using (var db = new SqLiteDbContext())
            {
                return db.Products.ToList();
            }
        }

        public Product GetProductById(uint id)
        {
            using (var db = new SqLiteDbContext())
            {
                return db.Products.Find(id);
            }
        }
    }
}