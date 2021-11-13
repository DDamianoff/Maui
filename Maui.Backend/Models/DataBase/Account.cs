using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
// ReSharper disable RedundantDefaultMemberInitializer

// ReSharper disable ConvertToUsingDeclaration
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace Maui.Backend.Models.DataBase
{
    
    /// <summary>
    /// Modelo para las cuentas de registros.
    /// </summary>
    public class Account
    {
        [Key]
        public uint AccountId
        {
            get;
            set;
        }

        public string Name
        {
            get; 
            set;
        }
        
        public string Description
        {
            get; 
            set;
        }

        /*
         Ando un poco flojo de contalidad.
         No sé si el total es necesario
         cuando se trabaja con debe y haber.
         
         Por las dudas, inizalizado en 0.
         */
        public double Total { get; set; } = 0;
        /*
         Valor por defecto a estas cuentas
         ya que no espero que sean utilizadas
         en esta aplicación.
         */
        public double Debit { get; set; }  = 0;
        public double Credit { get; set; } = 0;
        
    }
}