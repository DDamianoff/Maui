using System.Collections.Generic;
using System.Linq;
using Maui.Backend.Models.DataBase;
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
                    return Transactions.ToList();
                }
            }
        }
    }
}
