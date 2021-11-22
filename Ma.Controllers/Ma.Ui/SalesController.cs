using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Maui.Backend.Models.DataBase;

// ReSharper disable ConvertToUsingDeclaration

namespace Ma.Controllers.Ma.Ui
{
    public class SalesController : GeneralController
    {
        /// <summary>
        /// Retornará todos los valores diferentes de 0.
        /// Se da por hecho que en la base de datos no existen valores
        /// negativos (clase representativa de tipo uint).
        /// </summary>
        /// <returns>
        /// Todos los productos con stock diferente de 0.
        /// </returns>
        public List<Product> GetAllAvailableProducts()
        {
            using (var db = new SqLiteDbContext())
            {
                return QueryableExtensions.Include(db.Products, "Products").Where(product => product.AvailableQuantity != 0).ToList();
            }
        }

        public void NotifyTransactionToDb(Transaction transaction)
        {
           // this.UpdateQuantityOperated(transaction.ProductId, transaction.Product.AvailableQuantity);

            using (var db = new SqLiteDbContext())
            {
                // es necesario indicarle a la DB que estamos usando
                // entidades (worker y product) ya existentes, porque de lo contrario
                // intenta crear nuevas identicas.
                Transaction transactionToPush = new Transaction()
                {
                    Amount = transaction.Amount,
                    PaymentMethod = transaction.PaymentMethod,
                    Product = db.Products.Find(transaction.ProductId),
                    ProductId = db.Products.First(p => p.ProductId == transaction.ProductId).ProductId,
                    QuantityOperated = transaction.QuantityOperated,
                    ShellDateTime = transaction.ShellDateTime,
                    Worker = db.Workers.Find(transaction.Worker.DocketId),
                    WorkerId = db.Workers.First(w => w.DocketId == transaction.Worker.DocketId).DocketId
                };
                // registrar transacción
                db.Transactions.Add(transactionToPush);
                db.SaveChanges();

                Product currentProduct = db.Products.First(p => p.ProductId == transaction.ProductId);
                currentProduct.AvailableQuantity -= Convert.ToInt32(transaction.QuantityOperated);
                db.SaveChanges();
            }

        }

        public int GetCurrentStock(uint productId)
        {
            using (var db = new SqLiteDbContext())
            {
                return db.Products.Find(productId).AvailableQuantity;
            }
        }

        public double GetCurrentPrice(uint productId)
        {
            using (var db = new SqLiteDbContext())
            {
                //return db.Products.Where(p => p.ProductId == productId).First();
                return db.Products.Find(productId).Price;
            }
        }
    }
}