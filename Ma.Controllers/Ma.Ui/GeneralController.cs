using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ma.Backend.Models.DataBase;
using Maui.Backend.Models.DataBase;
using Microsoft.EntityFrameworkCore;

// ReSharper disable ConvertToUsingDeclaration

namespace Ma.Controllers.Ma.Ui
{
    public class GeneralController
    {

        public void CreateDbIfNoExists()
        {
            using (var db = new SqLiteDbContext())
            {
                db.Database.EnsureCreated();
            }
        }

        public bool ExistsWorkers()
        {
            using (var db = new SqLiteDbContext())
            {
               return db.Workers
                   .Any();
            }
        }

        public Worker GetDefaultWorker()
        {
            using (var db = new SqLiteDbContext())
            {
                return db.Workers.First();
            }
        }

        public List<Worker> GetAllWorkers()
        {
            using (var db = new SqLiteDbContext())
            {
                return db.Workers.ToList();
            }
        }

        public async Task<List<Worker>> GetAllWorkersAsync()
        {
            await using (var db = new SqLiteDbContext())
            {
                return await Task.Run(db.Workers.ToList);
            }
        }


        public void AddWorker(Worker workerToAdd)
        {
             using (var db = new SqLiteDbContext())
             {
                 db.Workers.Add(workerToAdd);
                 db.SaveChanges();
             }
        }
    }
}