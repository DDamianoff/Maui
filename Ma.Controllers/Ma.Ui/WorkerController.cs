using System.Collections.Generic;
using System.Linq;
using Ma.Backend.Models.DataBase;
using Maui.Backend.Models.DataBase;

namespace Ma.Controllers.Ma.Ui
{
    public class WorkerController : GeneralController
    {
        public List<Worker> GetActiveWorkers()
        {
            using (var db = new SqLiteDbContext())
            {
                return db.Workers.Where(w => w.IsActive == true).ToList();
            }
        }
    }
}
