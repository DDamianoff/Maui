#nullable enable
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Maui.Backend.Models.MercadoLibreCatalog
{
    public static class MeLiCatalogGenerator
    {
        public static async Task<MercadoLibreCatalog?> GetCatalogAsync(
            string searchTerm,
            uint limit = 20, 
            string category = "%22MLA1430%22"
        )
        {
            var webclient = new WebClient();
            string downloadedString = await Task.Run(() => webclient.DownloadString(
                $"https://api.mercadolibre.com/sites/MLA/search?q={searchTerm}&limit={limit}&category={category}"));
            return JsonConvert.DeserializeObject<MercadoLibreCatalog>(downloadedString);
        }
    }
}