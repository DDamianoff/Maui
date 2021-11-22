using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Maui.Backend.Models.MercadoLibreCatalog;

// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable ConvertToUsingDeclaration

namespace Maui.Backend.Models.DataBase
{
    public class Product
    {
        [Key] public uint ProductId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int AvailableQuantity { get; set; }
        public string PermalinkToProduct { get; set; }
        public string ThumbnailUrl { get; set; }
        
        public bool IsActive { get; set; }
        
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
                ThumbnailUrl = result.ThumbnailUrl,
                IsActive = true
            };
        }
    }
}