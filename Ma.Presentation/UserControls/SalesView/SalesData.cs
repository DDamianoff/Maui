using System.Collections.Generic;
using System.ComponentModel;
using Maui.Backend.Models.DataBase;

namespace Ma.Ui.UserControls.SalesView
{
    /// <summary>
    /// Clase intermediaria para hacer posible el DataBinding
    /// entre componentes diferentes.
    /// </summary>
    public class SalesData
    {
        public int CurrentProductKey { get; set; } = 0;

        public List<Product> Products { get; set; }
    }
}