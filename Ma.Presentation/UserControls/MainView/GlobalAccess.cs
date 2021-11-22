using Ma.Backend.Models.DataBase;
using Ma.Ui.UserControls.SalesView;
using Maui.Backend.Models.DataBase;

namespace Ma.Ui.UserControls.MainView
{
    public static class GlobalAccess
    {
        public static Worker CurrentWorker { get; set; }
        public static SalesData SalesData { get; } = new SalesData();
    }
}