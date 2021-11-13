using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maui.Backend.Models.DataBase;

namespace Ma.Controllers.Ma.Ui
{
    /// <summary>
    /// Clase destinada a ser heredada por todos los
    /// controladores.
    /// El objetivo es tener un código más limpio
    /// agrupoando los métodos más comunes en todos
    /// los controladores.
    /// </summary>
    public class GeneralController
    {

        public async Task CreateDbIfNoExistsAsync()
        {
            await using (var db = new SqLiteDbContext())
            {
                await Task.Run(() => db.Database.EnsureCreatedAsync());
            }
        }
    }
}
