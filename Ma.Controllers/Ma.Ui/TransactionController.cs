using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Threading.Tasks;
using Maui.Backend.Models.DataBase;
using Maui.Backend.Models.MercadoLibreCatalog;
using Microsoft.EntityFrameworkCore;

namespace Ma.Controllers.Ma.Ui
{
    public class TransactionController : GeneralController
    {
        public List<Transaction> GetAllTransactions()
        {
            List<Transaction> transactions = new List<Transaction>();

            using (var db = new SqLiteDbContext())
            {
                {
                    var Transactions = db.Transactions.Include("Worker").Include("Product");
                    var queryAll = Transactions.All(t => t.Worker != null);
                    return Transactions.ToList();
                }
            }
        }
    }
}
