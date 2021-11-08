// ReSharper disable ClassNeverInstantiated.Global
// La clase SI es instanciada por el deseralizador.
namespace Maui.Backend.Models.MercadoLibreCatalog
{
    public class Result
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public int AvailableQuantity { get; set; }
        public string PermalinkToProduct { get; set; }
        public string ThumbnailUrl { get; set; }
        public uint ProductId { get; set; }
        
        public Result(string title,
            double price,
            // ReSharper disable once InconsistentNaming
            int available_quantity,
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