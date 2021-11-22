using System.Collections.Generic;
using System.Windows.Forms;
using Ma.Controllers.Ma.Ui;

namespace Ma.Ui.UserControls.SalesView
{
    public static class ViewRepresentations
    {
        private static SalesController _salesController = new SalesController();

        private static ShellSectionControl _shellSection;

        public static ShellSectionControl ShellSection
        {
            get
            {
                _shellSection ??= new ShellSectionControl() { Dock = DockStyle.Fill };
                return _shellSection;
            }
            set
            {
                _shellSection = value;
                
            }
        }

        public static List<ProductView> ProductViews { get; } = new List<ProductView>();

    }
}
