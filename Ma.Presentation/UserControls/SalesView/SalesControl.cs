using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ma.Controllers.Ma.Ui;
using Ma.Ui.UserControls.MainView;
using Ma.Ui.UserControls.SalesView;

namespace Ma.UI.UserControls.SalesView
{
    public partial class SalesControl : MainSectionTemplate
    {
        private SalesController _salesController = new SalesController();
        public SalesControl()
        {
            InitializeComponent();
            this.InicializeProductViews();
        }

        public async void InicializeProductViews()
        {
            await Task.Run(this.RestoreProductsFromDb);
            await this.RenderProductViewsAsync();
            await this.ShowProductsInPanelListAsync();
            ViewRepresentations.ShellSection = new ShellSectionControl() {Dock = DockStyle.Fill};

            pnlShellSection.Controls.Clear();
            pnlShellSection.Controls.Add(ViewRepresentations.ShellSection);
        }

        private void RestoreProductsFromDb()
        {
            GlobalAccess.SalesData.Products = _salesController.GetAllAvailableProducts();
        }

        private async Task RenderProductViewsAsync()
        {
            // expresar los productos como vistas.
            await Task.Run(() =>
            {
                // el for es dececiente para que el primer elemento sea el ultimo en añadirse
                // y quede arriba.
                for (int i = GlobalAccess.SalesData.Products.Count - 1; i > -1 ; i--)
                {
                    ViewRepresentations.ProductViews.Add(new ProductView()
                    {
                        CurrentProduct = GlobalAccess.SalesData.Products[i],
                        Dock = DockStyle.Top,
                        KeyInList = i
                    });
                }
            });
        }

        public async Task ShowProductsInPanelListAsync()
        {
            // renderizar las vistas.
            foreach (ProductView productView in ViewRepresentations.ProductViews)
            {
                await Task.Delay(10);

                pnlProductList.Controls.Add(productView);

                productView.SendToBack();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            GlobalAccess.SalesData.CurrentProductKey = 0;
            pnlShellSection.Controls.Clear();
            pnlProductList.Controls.Clear();
            ViewRepresentations.ProductViews.Clear();
            this.InicializeProductViews();
        }

        public void ReloadShellSection()
        {
            ViewRepresentations.ShellSection = new ShellSectionControl() { Dock = DockStyle.Fill };
            pnlShellSection.Controls.Clear();
            pnlShellSection.Controls.Add(ViewRepresentations.ShellSection);
        }
    }
}