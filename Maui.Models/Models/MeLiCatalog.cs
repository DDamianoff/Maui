using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

// ReSharper disable ConvertToAutoProperty
// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable InconsistentNaming


namespace Maui.Frontend.Models
{ 
    public class Result
    {
        //[field: JsonPropertyName("title")]
        private string _title;

        //[field: JsonPropertyName("price")]
        private double? _price;

        //[field: JsonPropertyName("avaliable_quantity")]
        private int? _availableQuantity;

        //[field: JsonPropertyName("permalink")] 
        private string _permalinkToProduct ;

        //[field: JsonPropertyName("thumbnail")] 
        private string _thumbnail ;

        //[field: JsonPropertyName("id")] 
        private uint _id ;

        public Result(
                        string title,  double? price, 
                        int? available_quantity, string permalink,
                        string thumbnail, string id
                        )

        {
            _title = title;
            _price = price;
            _availableQuantity = available_quantity;
            _permalinkToProduct = permalink;
            _thumbnail = thumbnail;
            _id = uint.Parse(id.Replace("MLA",""));
        }

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public double? Price
        {
            get => _price;
            set => _price = value;
        }

        public int? AvailableQuantity
        {
            get => _availableQuantity;
            set => _availableQuantity = value;
        }

        public string PermalinkToProduct
        {
            get => _permalinkToProduct;
            set => _permalinkToProduct = value;
        }

        public string ThumbnailUrl
        {
            get => _thumbnail;
            set => _thumbnail = value;
        }

        public uint Id
        {
            get => _id;
            set => _id = value;
        }
    }
    
    public class MercadoLibreCatalog
    {
        //[field: JsonPropertyName("results")]
        private List<Result> _results;

        //[field: JsonPropertyName("paging")]
        private Paging _paging;

        public List<Result> Results
        {
            get => _results;
            set => _results = value;
        }

        public Paging Paging
        {
            get => _paging;
            set => _paging = value;
        }

        [JsonConstructor] public MercadoLibreCatalog(List<Result> results, Paging paging, uint total, uint limit)
        {
            _results = results;
            _paging = paging;
        }
        
    }


    public class Paging
    {
        public uint Limit
        {
            get => _limit;
            set => _limit = value;
        }

        public uint Total
        {
            get => _total;
            set => _total = value;
        }

        public uint Count
        {
            get => _count;
            set => _count = value;
        }

        //[field: JsonPropertyName("limit")] 
        private uint _limit;

        //[field: JsonPropertyName("total")] 
        private uint _total;

        // Cantidad real de elementos en Results.
        private uint _count;

        public Paging(uint limit, uint total)
        {
            _limit = limit;
            _total = total;
            _count = total > limit ? limit : total;
        }
    }

    public class MeLiCatalogGenerator
    {
        public async Task<MercadoLibreCatalog?> GetCatalogAsync(string searchTerm, uint limit = 20, string category = "%22MLA1430%22")
        {
            var webclient = new WebClient();
            var downloadedString = await Task.Run(() => webclient.DownloadString(
                $"https://api.mercadolibre.com/sites/MLA/search?q={searchTerm}&limit={limit}&category={category}"));
            return JsonConvert.DeserializeObject<MercadoLibreCatalog>(downloadedString);
            // TODO: async task correctly.
        }
    }
}