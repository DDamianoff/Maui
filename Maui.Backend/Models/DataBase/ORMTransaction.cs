using System;

namespace Maui.Backend.Models.DataBase
{
    public class OrmTransaction
    {
        public uint TransactionId { get; init; }
        public string Product { get; init; }

        public uint QuantityShelled { get; init; }
        
        public string PaymentMethod { get; init; }

        public DateTime ShellDateTime { get; init; }

        public string LinkToProduct { get; init; }

        public string ThumbnailUrl { get; init; }
        
        public string TransactionType { get; init; }
    }
}