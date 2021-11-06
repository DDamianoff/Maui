// ReSharper disable UnusedAutoPropertyAccessor.Local

using System;

namespace Maui.Backend.Models.General
{
    /// <summary>
    /// Registro de las transacciones realizadas.
    /// Similar a un libro contable.
    /// Razón por la que todas las propiedades son
    /// readOnly.
    /// </summary>
    public class Transaction
    {
        public uint TransactionId { get; }

        public string Product { get; }

        public uint QuantityShelled { get; }

        /// <summary>
        /// Los valores esperados son ...
        /// </summary>
        // TODO: Definir valores esperados.
        public string PaymentMethod { get; }

        public DateTime shellDateTime { get; }

        public string LinkToProduct { get; }

        public string ThumbnailUrl { get; }

        /// <summary>
        /// Los valores esperados son "venta"
        /// y "compra".
        /// </summary>
        public string TransactionType { get; }

        public Transaction(uint transactionId,
            string product,
            uint quantityShelled,
            string paymentMethod,
            DateTime shellDateTime,
            string linkToProduct,
            string thumbnailUrl, 
            string transactionType)
        {
            TransactionId = transactionId;
            Product = product;
            QuantityShelled = quantityShelled;
            PaymentMethod = paymentMethod;
            this.shellDateTime = shellDateTime;
            LinkToProduct = linkToProduct;
            ThumbnailUrl = thumbnailUrl;
            TransactionType = transactionType;
        }
    }
}