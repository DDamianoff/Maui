// ReSharper disable ClassNeverInstantiated.Global
// La clase SI es instanciada por el deseralizador.
namespace Maui.Backend.Models.MercadoLibreCatalog
{
    /// <summary>
    /// subclase de MercadoLibreCatalog.
    /// Datos sobre la cantidad de resultados.
    /// </summary>
    public class Paging
    {
        /// <summary>
        /// Límite de elementos que retorna la API de MeLi.
        /// Creo que la API no permite retornar mas de 50
        /// por cada solicitud.
        /// </summary>
        public uint Limit { get; set; }

        /// <summary>
        /// Total de resultados sin tener en cuenta el límite.
        /// Recomendado usar _count si se quiere referir
        /// a la cantidad existente de productos.
        /// </summary>
        public uint Total { get; set; }

        /// <summary>
        /// Cantidad de elementos en Results.
        /// </summary>
        public uint Count { get; set; }
        public Paging(uint limit, uint total)
        {
            Limit = limit;
            Total = total;
            Count = total > limit ? limit : total;
        }
    }
}