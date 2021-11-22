using System;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ma.Controllers.Ma.Ui;
using Ma.Ui.UserControls.MainView;
using Maui.Backend.Models.DataBase;

namespace Ma.Ui.UserControls.SalesView
{
    public partial class ShellSectionControl : UserControl
    {
        private SalesController controller = new SalesController();

        private double _total;
        public double Total
        {
            get
            {
                _total = GlobalAccess.SalesData.Products[GlobalAccess.SalesData.CurrentProductKey].Price * decimal.ToDouble(numQuantityToShell.Value);
                return _total;
            }
            set => _total = value;
        }

        public ShellSectionControl()
        {
            InitializeComponent();
        }

        private void ShellSectionControl_Load(object sender, EventArgs e)
        {
            if (GlobalAccess.SalesData.Products.Any())
            {
                this.LoadPicture(GlobalAccess.SalesData.Products[GlobalAccess.SalesData.CurrentProductKey].ThumbnailUrl);

                cboPaymentMethod.Items.Add(@"tarjeta");
                cboPaymentMethod.Items.Add(@"efectivo");

                txtTitle.Text =
                    $@"{GlobalAccess.SalesData.Products[GlobalAccess.SalesData.CurrentProductKey].Title}";
                lblAvailibleCuantity.Text =
                    $@"{GlobalAccess.SalesData.Products[GlobalAccess.SalesData.CurrentProductKey].AvailableQuantity}";
                lblPrice.Text =
                    $@"{GlobalAccess.SalesData.Products[GlobalAccess.SalesData.CurrentProductKey].Price}";
                numQuantityToShell.Maximum =
                    GlobalAccess.SalesData.Products[GlobalAccess.SalesData.CurrentProductKey].AvailableQuantity;
                pnlMainContainer.Enabled = true;
            }
            else
            {
                MessageBox.Show("No hay productos disponibles, puedes añadirlos desde la sección de stock");
                pnlMainContainer.Enabled = false;
            }
        }

        public void numQuantityToShell_ValueChanged(object sender, EventArgs e)
        {
            lblTotal.Text = $@"{Total}";
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

        private void btnSales_Click(object sender, EventArgs e)
        {
            var stockInDb = controller.GetCurrentStock(GlobalAccess.SalesData
                .Products[GlobalAccess.SalesData.CurrentProductKey].ProductId);

            var priceInDb = controller.GetCurrentPrice(GlobalAccess.SalesData
                .Products[GlobalAccess.SalesData.CurrentProductKey].ProductId);

            if ((int)numQuantityToShell.Value > stockInDb)
            {
                this.ShowMessage("La cantidad es mayor al stock existente.");

                GlobalAccess.SalesData
                    .Products[GlobalAccess.SalesData.CurrentProductKey].AvailableQuantity = stockInDb;

                numQuantityToShell.Maximum = stockInDb;

                lblAvailibleCuantity.Text = $@"{stockInDb}";

                return;
            }


                if ((int) priceInDb != (int) GlobalAccess.SalesData
                    .Products[GlobalAccess.SalesData.CurrentProductKey].Price)
                {
                    this.ShowMessage("Se actualizó el precio actual");

                    GlobalAccess.SalesData
                        .Products[GlobalAccess.SalesData.CurrentProductKey].Price = priceInDb;

                    lblTotal.Text = @$"{(decimal)GlobalAccess.SalesData
                        .Products[GlobalAccess.SalesData.CurrentProductKey].Price * numQuantityToShell.Value}";

                    lblPrice.Text = $@"{(decimal)GlobalAccess.SalesData
                        .Products[GlobalAccess.SalesData.CurrentProductKey].Price}";

                    return;
                }


                if (GlobalAccess.SalesData.Products[GlobalAccess.SalesData.CurrentProductKey].AvailableQuantity == 0)
                {
                    new SoundPlayer(@"c:\Windows\Media\Windows Foreground.wav").Play();
                    MessageBox.Show(@"El producto se quedó sin stock, recargue la lista para dejar de verlo");
                    return;
                }

                if (!string.IsNullOrEmpty(cboPaymentMethod.Text))
                {
                    if (numQuantityToShell.Value != 0)
                    {
                        GlobalAccess.SalesData.Products[GlobalAccess.SalesData.CurrentProductKey].AvailableQuantity -= 
                            decimal.ToInt32(numQuantityToShell.Value);

                        controller.NotifyTransactionToDb(new Transaction()
                            {
                                Amount = (double) numQuantityToShell.Value * GlobalAccess.SalesData.Products[GlobalAccess.SalesData.CurrentProductKey].Price,
                                PaymentMethod = cboPaymentMethod.Text,
                                Product = GlobalAccess.SalesData.Products[GlobalAccess.SalesData.CurrentProductKey],
                                ProductId = GlobalAccess.SalesData.Products[GlobalAccess.SalesData.CurrentProductKey].ProductId,
                                QuantityOperated = decimal.ToUInt32(numQuantityToShell.Value),
                                ShellDateTime = DateTime.Now,
                                Worker = GlobalAccess.CurrentWorker,
                                WorkerId = GlobalAccess.CurrentWorker.DocketId
                            });
                        this.ShowMessage(@"Operación realizada con éxito!",false);
                    }
                    else
                    {
                        this.ShowMessage("Seleccione una cantidad");
                    }
                }
                else
                {
                    this.ShowMessage("Seleccione método de pago");
                }

                // Actualizar valores en la GUI.
                numQuantityToShell.Maximum =
                    GlobalAccess.SalesData.Products[GlobalAccess.SalesData.CurrentProductKey].AvailableQuantity;
                lblAvailibleCuantity.Text = $@"{
                    numQuantityToShell.Maximum =
                        GlobalAccess.SalesData.Products[GlobalAccess.SalesData.CurrentProductKey].AvailableQuantity}";
            }

            private void ShowMessage(string message, bool isError = true)
            {
                lblOutput.Text = $@"{message}";

                if (isError)
                {
                    lblOutput.ForeColor = Color.LightCoral;
                    new SoundPlayer(@"c:\Windows\Media\Windows Foreground.wav").Play();
                    
                }
                else
                {
                    lblOutput.ForeColor = Color.MintCream;
                    new SoundPlayer(@"c:\Windows\Media\Windows Balloon.wav").Play();
                }
            }
        }
    }

