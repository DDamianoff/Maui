using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maui.Backend.Models.MercadoLibreCatalog;
using Microsoft.EntityFrameworkCore;

// ReSharper disable UnusedAutoPropertyAccessor.Global

// ReSharper disable ConvertToUsingDeclaration

namespace Maui.Backend.Models.DataBase
{
    public class Product
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public int AvailableQuantity { get; set; }
        public string PermalinkToProduct { get; set; }
        public string ThumbnailUrl { get; set; }
        public uint ProductId { get; set; }

        public static async Task<bool> ExistsInDbAsync(uint id)
        {
            await using (var dataBase = new SqLiteDbContext())
            {
                return dataBase.Products.Any(p => p.ProductId == id);
            }
        } 
        
        public static async Task CreateInDbAsync(Product product)
        {
            await using (var dataBase = new SqLiteDbContext())
            {
                dataBase.Products.Add(product);
                await dataBase.SaveChangesAsync();
            }
        }
        /// <summary>
        /// Confirmar si el registro existe (ExistsInDbAsync)
        /// antes de consultarlo.
        /// </summary>
        public static async Task<Product> ReadFromDbById(uint targetId)
        {
            await using (var dataBase = new SqLiteDbContext())
            {
               if (await ExistsInDbAsync(targetId)) return dataBase.Products.First(p => p.ProductId == targetId);
                
                // TODO: fix this - var db = dataBase.Products.FromSqlRaw("SELECT * FROM Products WHERE ProductID = {0} LIMIT 1", targetId).First();
                
            }
            return new Product()
            {
                Title = null,
                Price = 0,
                AvailableQuantity = 0,
                PermalinkToProduct = null,
                ProductId = 0,
                ThumbnailUrl = null
            };
        }
        
        public static async Task<List<Product>> ReadAllFromDbAsync()
        {
            await using (var dataBase = new SqLiteDbContext())
            {
               return dataBase.Products.ToList();
            }
        }
        
        public async Task UpdateChangesInDbAsync()
        {
            await using (var dataBase = new SqLiteDbContext())
            {
               
                var inDbProduct = dataBase.Products.First(p => p.ProductId == ProductId);

                inDbProduct.Title = Title;
                inDbProduct.Price = Price;
                inDbProduct.AvailableQuantity = AvailableQuantity;
                inDbProduct.ThumbnailUrl = ThumbnailUrl;
                inDbProduct.PermalinkToProduct = PermalinkToProduct;

                await dataBase.SaveChangesAsync();
            }
        }

        public async Task RemoveOfDbAsync()
        {
            await using (var dataBase = new SqLiteDbContext())
            {
                dataBase.Remove(this);
                
                await dataBase.SaveChangesAsync();
            }
        }

        public static Product CastFromResult(Result result)
        {
            return new Product()
            {
                Title = result.Title,
                AvailableQuantity = result.AvailableQuantity,
                PermalinkToProduct = result.PermalinkToProduct,
                Price = result.Price,
                ProductId = result.ProductId,
                ThumbnailUrl = result.ThumbnailUrl
            };
        }
    }
}