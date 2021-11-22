using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ma.Presentation;
using Ma.Ui.UserControls.MainView;
using Maui.Backend.Models.DataBase;

namespace Ma.Ui.UserControls.SalesView
{
    public partial class ProductView : UserControl
    {
        private Product _currentProduct;

        public int KeyInList;

        public Product CurrentProduct
        {
            get => this._currentProduct;
            set
            {
                _currentProduct = value;
                this.LoadPicture(CurrentProduct.ThumbnailUrl);
            }
        }


        public ProductView()
        {
            InitializeComponent();
        }

        private void LinkLblMercadoLibre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                this.OpenLink(CurrentProduct.PermalinkToProduct);
            }
            catch (Exception error)
            {
                MessageBox.Show($"No se pudo abrir el link: {CurrentProduct.PermalinkToProduct} \n {error}");
            }
        }

        private void OpenLink(string link)
        {
            System.Diagnostics.Process.Start("cmd", $"/c start {link}");
        }

        private async void LoadPicture(String url)
        {
            // TODO - mejora del comportamiento al cargar de forma errónea una imagen.
            await Task.Run(() =>
            {
                try
                {
                    this.picProduct.Load(url);
                }
                catch (Exception e)
                {
                    try
                    {
                        this.picProduct.Load(url);
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                    }
                    Console.WriteLine(e);
                }
            });
        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            GlobalAccess.SalesData.CurrentProductKey = KeyInList;
            Program.MainFormWindowForm.MainControl.SalesControl.ReloadShellSection();
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $@"{CurrentProduct.Title}";
            lblPrice.Text = $@"{CurrentProduct.Price}";
            lblQuantity.Text = $@"{CurrentProduct.AvailableQuantity}";
        }
    }
}