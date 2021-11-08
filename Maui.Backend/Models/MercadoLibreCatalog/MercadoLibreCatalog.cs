#nullable enable
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;

/*
 * Al profesor: este wrapper fue creado para un proyecto
 * personal. Entiendo que hay muchas cosas en las que se puede mejorar.
 * 
 * Es necesario usar "MeLiCatalogGenerator.GetCatalogAsync(...)"
 * para crear el MeLiCataLog.
 */

namespace Maui.Backend.Models.MercadoLibreCatalog
{
    public class MercadoLibreCatalog
    {
        public List<Result> Results { get; set; }
        public Paging Paging { get; set; }
        
        [JsonConstructor] public MercadoLibreCatalog(List<Result> results, Paging paging, uint total, uint limit)
        {
            Results = results;
            Paging = paging;
        }
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