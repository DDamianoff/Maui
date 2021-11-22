using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ma.Controllers.Ma.Ui;
using Ma.Ui.UserControls.SalesView;
using Ma.Ui.UserControls.StockView;
using Maui.Backend.Models.DataBase;

namespace Ma.UI.UserControls.StockView
{
    public partial class StockControl : MainSectionTemplate
    {
        private StockController controller = new StockController();

        public List<Product> Products = new List<Product>();

        public List<StockProductView> ProductViews = new List<StockProductView>();

        public StockControl()
        {
            InitializeComponent();
        }


        private async void StockControl_Load(object sender, System.EventArgs e)
        {
            this.RestoreProductList();

            await this.LoadViewsIntoViewList();

            this.RenderViews();
            this.btnEditSection.Enabled = false;
        }

        public async void RenderViews()
        {
            pnlContentSection.Controls.Clear();
            foreach (var view in ProductViews)
            {
                pnlContentSection.Controls.Add(view);
                await Task.Delay(10);
            }
        }

        public async Task LoadViewsIntoViewList()
        {
            await Task.Run(() =>
            {
                foreach (Product product in Products)
                {
                    ProductViews.Add(new StockProductView()
                    {
                        ProductIRepresent = product,
                        Dock = DockStyle.Top
                    });
                }
            });
        }
        public void RestoreProductList()
        {
            Products = controller.GetAllProducts();
        }

        private void btnEditSection_Click(object sender, EventArgs e)
        {
            this.SetStockAsCurrentView();
        }


        private void btnMercadoLibre_Click(object sender, System.EventArgs e)
        {
            this.SetMeLiAsCurrentView();
        }

        private void SetMeLiAsCurrentView()
        {
            pnlMeLiSection.BringToFront();
            btnEditSection.Enabled = true;
            btnMeliSection.Enabled = false;
        }

        private void SetStockAsCurrentView()
        {
            pnlContentSection.BringToFront();
            btnEditSection.Enabled = false;
            btnMeliSection.Enabled = true;
        }

        private async void btnReload_Click_1(object sender, EventArgs e)
        { 
            this.SetStockAsCurrentView();
            ProductViews.Clear();

            this.RestoreProductList();
            await this.LoadViewsIntoViewList();
            this.RenderViews();
        }
    }
}