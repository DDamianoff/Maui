using System;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ma.Controllers.Ma.Ui;
using Maui.Backend.Models.DataBase;

namespace Ma.Ui.UserControls.StockView
{
    public partial class StockProductView : UserControl
    {
        private Product _productIRepresent;

        private StockController controller = new StockController();

        public Product ProductIRepresent
        {
            get => this._productIRepresent;
            set
            {
                _productIRepresent = value;
                this.LoadPicture(ProductIRepresent.ThumbnailUrl);
            }
        }


        public StockProductView()
        {
            InitializeComponent();
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
        private void ProductView_Load(object sender, EventArgs e)
        {
            //lblTitle.Text = $@"{ProductIRepresent.Title}";
            //lblPrice.Text = $@"{ProductIRepresent.Price}";
            //lblQuantity.Text = $@"{ProductIRepresent.AvailableQuantity}";

            this.SetAll();
        }

        private async void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.IsEveryThingOkay())
            {
                _productIRepresent.Title = txtTitle.Text;
                _productIRepresent.ThumbnailUrl = txtImgLink.Text;
                _productIRepresent.Price = (double) numPrice.Value;
                _productIRepresent.AvailableQuantity = (int) numQuantity.Value;

                await controller.UpdateProductInDbAsync(_productIRepresent);

                this.LoadPicture(ProductIRepresent.ThumbnailUrl);

                if (_productIRepresent.AvailableQuantity != 0)
                    pnlImgContainer.BackColor = Color.DarkSlateGray;
                else
                    pnlImgContainer.BackColor = Color.MediumVioletRed;

                await Task.Run(() => this.NotifyToUser("Operación realizada con éxito!", false));
            }
        }

        private bool IsEveryThingOkay()
        {
            if (!string.IsNullOrEmpty(txtTitle.Text) && !string.IsNullOrEmpty(txtImgLink.Text))
            {
                return true;
            }
            this.NotifyToUser(@"Asegúrese de no dejar algún campo vacío");
            return false;
        }

        private void NotifyToUser(string message, bool isError = true)
        {
            if (isError)
                new SoundPlayer(@"C:\Windows\Media\Windows Error.wav").Play();
            else new SoundPlayer(@"C:\Windows\Media\Windows Balloon.wav").Play();
            
  
            MessageBox.Show(message);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ProductIRepresent = controller.GetProductById(ProductIRepresent.ProductId);
            this.SetAll();
            this.LoadPicture(ProductIRepresent.ThumbnailUrl);
            new SoundPlayer(@"C:\Windows\Media\Windows Balloon.wav").Play();
        }


        private void SetAll()
        {
            txtTitle.Text = $@"{ProductIRepresent.Title}";
            numPrice.Value = (decimal)ProductIRepresent.Price;
            numQuantity.Value = ProductIRepresent.AvailableQuantity;
            txtImgLink.Text = $@"{ProductIRepresent.ThumbnailUrl}";
            if (ProductIRepresent.AvailableQuantity == 0) pnlImgContainer.BackColor = Color.MediumVioletRed;
        }
    }
}
