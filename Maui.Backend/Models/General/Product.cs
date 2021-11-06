// ReSharper disable InconsistentNaming
namespace Maui.Backend.Models.General
{
    
    
    public class Product
    {
        public string Title { get; set; }
        public double? Price { get; set; }
        public int? AvailableQuantity { get; set; }
        public string PermalinkToProduct { get; set; }
        public string ThumbnailUrl { get; set; }
        public uint ProductId { get; }
        
        public Product(  string title,
            double? price,
            int? available_quantity,
            string permalink,
            string thumbnail,
            string id)
        {
            Title = title;
            Price = price;
            AvailableQuantity = available_quantity;
            PermalinkToProduct = permalink;
            ThumbnailUrl = thumbnail;
            ProductId = uint.Parse(id.Replace("MLA",""));
        }
    }
}