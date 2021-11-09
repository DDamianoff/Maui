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
        
        public static async Task<bool> ExitsInDbAsync(uint id)
        {
            await using (var dataBase = new SqLiteDbContext())
            {
                return dataBase.Accounts.Any(p => p.AccountId == id);
            }
        }
        
        public static async Task CreateInDbAsync(Account account)
        {
            await using (var dataBase = new SqLiteDbContext())
            {
                dataBase.Accounts.Add(account);
                await dataBase.SaveChangesAsync();
            }
        }
        
        public static async Task<Account> ReadFromDbById(uint targetId)
        {
            await using (var dataBase = new SqLiteDbContext())
            {
                if (await ExitsInDbAsync(targetId)) return dataBase.Accounts.First(p => p.AccountId == targetId);
                // TODO: fix this - var db = dataBase.Products.FromSqlRaw("SELECT * FROM Accounts WHERE ProductID = {0} LIMIT 1", targetId).First();
                
            }
            
            return new Account()
            {
                AccountId = 0,
                Description = null,
                Name = null
            };
        }
        
        public async Task UpdateChangesInDbAsync()
        {
            await using (var dataBase = new SqLiteDbContext())
            {
                
                var inDbAccount = dataBase.Accounts.First(account => account.AccountId == AccountId);

                 inDbAccount.Name = Name;
                 inDbAccount.Description = Description;
                 inDbAccount.Total = Total;
                 inDbAccount.Debit = Debit;
                 inDbAccount.Credit = Credit;
                
                await dataBase.SaveChangesAsync();
            }
            
        }
        /// <summary>
        /// Sobreescribir los valores existentes
        /// sin necesidad de hacerlo antes en el objeto
        /// y luego el Update.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="debit"></param>
        /// <param name="credit"></param>
        public async Task SetNewValueAsync(double total = 0, double debit = 0, double credit = 0)
        {
            await using (var dataBase = new SqLiteDbContext())
            {
                
                var inDbAccount = dataBase.Accounts.First(account => account.AccountId == AccountId);
                
                if (!inDbAccount.Total.Equals(total)) inDbAccount.Total = total;
                if (!inDbAccount.Debit.Equals(debit)) inDbAccount.Debit = debit;
                if (!inDbAccount.Credit.Equals(credit)) inDbAccount.Credit = credit;
                
                await dataBase.SaveChangesAsync();
            }
        }
        // un método "RemoveOfDbAsync" en este modelo sería peligroso.
    }
}