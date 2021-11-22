using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ma.Backend.Models.DataBase;

// ReSharper disable UnusedAutoPropertyAccessor.Global
// ReSharper disable MemberCanBePrivate.Global

namespace Maui.Backend.Models.DataBase
{
    public class Transaction
    {
        /// <summary>
        /// Debe dejarse en blanco para que EF
        /// asgine su ID automáticamente.
        /// </summary>
        [Key] public uint TransactionId { get; set; }
        public uint QuantityOperated { get; set; }
        
        /// <summary>
        /// Los valores esperados son compra o venta
        /// </summary>
        public string PaymentMethod { get; set; }
        public DateTime ShellDateTime { get; set; }

        /// <summary>
        /// Definir si es una COMPRA (Purchase)
        /// o VENTA (Sale).
        /// Sin implementación.
        /// </summary>
        // public string TransactionType { get; set; }
        
        public double Amount { get; set; }


        // Foreign Key
        
        [ForeignKey("DocketId")]
        public uint WorkerId { get; set; }
        public Worker Worker { get; set; }
        
        [ForeignKey("ProductId")]
        public virtual uint ProductId { get; set; }
        public Product Product { get; set; }
    }
    
}