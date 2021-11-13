using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Key] public string Title { get; set; }
        public double Price { get; set; }
        public int AvailableQuantity { get; set; }
        public string PermalinkToProduct { get; set; }
        public string ThumbnailUrl { get; set; }
        public uint ProductId { get; set; }
        
        public ICollection<Transaction> Transactions { get; set; }

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