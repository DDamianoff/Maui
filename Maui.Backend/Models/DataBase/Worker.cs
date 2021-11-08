using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maui.Backend.Models.DataBase
{
    public class Worker
    {
        /// <summary>
        /// Número de legajo.
        /// </summary>
        public uint DocketId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public uint Dni { get; set;}
        public uint Age { get; set;}
        public DateTime BirthDate { get; set; }
        public string ProfilePictureId { get; set;}
        
        public static async Task<bool> ExistsInDbAsync(uint id)
        {
            await using (var dataBase = new SqLiteDbContext())
            {
                await dataBase.Database.EnsureCreatedAsync();
                
                return dataBase.Workers.Any(w => w.DocketId == id);
            }
        }
        
        public static async Task CreateInDbAsync(Worker worker)
        {
            await using (var dataBase = new SqLiteDbContext())
            {
                await dataBase.Database.EnsureCreatedAsync();
                dataBase.Workers.Add(worker);
                await dataBase.SaveChangesAsync();
            }
        }
        public static async Task<Worker> ReadFromDbById(uint targetId)
        {
            await using (var dataBase = new SqLiteDbContext())
            {
                await dataBase.Database.EnsureCreatedAsync();
                if (await ExistsInDbAsync(targetId)) return dataBase.Workers.First(w => w.DocketId == targetId);
                
                // TODO: fix this - var db = dataBase.Products.FromSqlRaw("SELECT * FROM Products WHERE ProductID = {0} LIMIT 1", targetId).First();
                
            }
            return new Worker()
            {
                Dni = 0,
                FirstName = null,
                LastName = null,
                Age = 0,
                BirthDate = DateTime.Now,
                ProfilePictureId = null,
                DocketId = 0,
            };
        }
        public static async Task<List<Worker>> ReadAllFromDbAsync()
        {
            await using (var dataBase = new SqLiteDbContext())
            {
                await dataBase.Database.EnsureCreatedAsync();
                return dataBase.Workers.ToList();
            }
        }
        public async Task UpdateChangesInDbAsync()
        {
            await using (var dataBase = new SqLiteDbContext())
            {
                await dataBase.Database.EnsureCreatedAsync();
                

                var inDbWorker = dataBase.Workers.First(w => w.DocketId == DocketId);
 
                inDbWorker.Age = Age;
                inDbWorker.Dni = Dni;
                inDbWorker.BirthDate = BirthDate;
                inDbWorker.DocketId = DocketId;
                inDbWorker.FirstName = FirstName;
                inDbWorker.LastName = LastName;
                inDbWorker.ProfilePictureId = ProfilePictureId;
                
                await dataBase.SaveChangesAsync();
            }
        }
        public async Task RemoveOfDbAsync()
        {
            await using (var dataBase = new SqLiteDbContext())
            {
                await dataBase.Database.EnsureCreatedAsync();

                dataBase.Remove(this);
                
                await dataBase.SaveChangesAsync();
            }
        }
    }
}