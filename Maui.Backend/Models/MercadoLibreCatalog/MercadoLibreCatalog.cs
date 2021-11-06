#nullable enable
using System.Collections.Generic;
using Maui.Backend.Models.General;
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
        [JsonConstructor] 
        public MercadoLibreCatalog(List<Product> results, Paging paging, uint total, uint limit)
        {
            Results = results;
            Paging = paging;
        }
        
        public List<Product> Results { get; set; }

        public Paging Paging { get; set; }
    }
}