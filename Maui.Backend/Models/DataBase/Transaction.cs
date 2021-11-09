using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace Maui.Backend.Models.DataBase
{
    public class Transaction
    {
        /// <summary>
        /// Debe dejarse en blanco para que EF
        /// asgine su ID automáticamente.
        /// </summary>
        public uint TransactionId { get; set; }
        public string Product { get; set; }
        public uint QuantityOperated { get; set; }
        
        /// <summary>
        /// Los valores esperados son ...
        /// </summary>
        // TODO: Definir valores esperados.
        public string PaymentMethod { get; set; }
        public DateTime ShellDateTime { get; set; }
        public string LinkToProduct { get; set; }
        public string ThumbnailUrl { get; set; }
        public uint DoerId { get; set; }
        
        /// <summary>
        /// Definir si es una COMPRA (Purchase)
        /// o VENTA (Sale).
        /// </summary>
        public string TransactionType { get; set; }
        
        public static async Task<bool> ExistsInDbAsync(uint id)
        {
            await using (var dataBase = new SqLiteDbContext())
            {
                return dataBase.Transactions.Any(t => t.TransactionId == id);
            }
        } 
        
        public static async Task CreateInDbAsync(Transaction transaction)
        {
            await using (var dataBase = new SqLiteDbContext())
            {
                dataBase.Transactions.Add(transaction);
                await dataBase.SaveChangesAsync();
            }
        }
        
        public static async Task<Transaction> ReadFromDbById(uint targetId)
        {
            await using (var dataBase = new SqLiteDbContext())
            {
                if (await ExistsInDbAsync(targetId)) return dataBase.Transactions.First(t => t.TransactionId == targetId);
            }
            return new Transaction()
            {
                TransactionId = 0,
                Product = null,
                QuantityOperated = 0,
                PaymentMethod = "",
                ShellDateTime = DateTime.Now,
                LinkToProduct = null,
                ThumbnailUrl = null,
                TransactionType = null,
                DoerId = 0
            };
        }
        
        public static async Task<List<Transaction>> ReadAllFromDbAsync()
        {
            await using (var dataBase = new SqLiteDbContext())
            {
                return dataBase.Transactions.ToList();
            }
        }
        
    }
    
}