using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Ma.Backend.Models.DataBase;
using Ma.Controllers.Ma.Ui;
using Ma.Presentation;
using Ma.UI.UserControls.HomeView;
using Ma.UI.UserControls.SalesView;
using Ma.UI.UserControls.StockView;
using Ma.UI.UserControls.TransactionsView;
using Ma.UI.UserControls.UsView;
using Maui.Backend.Models.DataBase;

// ReSharper disable ArrangeThisQualifier
// ReSharper disable MemberCanBePrivate.Global

namespace Ma.Ui.UserControls.MainView
{
    public partial class MainWindowControl : UserControl
    {
        public GeneralController Controller = new GeneralController();

        private HomeControl _homeControl;
        private TransactionsControl _transactionsControl;
        private SalesControl _salesControl;
        private StockControl _stockControl;
        private UsControl _usControl;

        public MainWindowControl()
        {
            InitializeComponent();

        }


        private void MainWindowControl_Load(object sender, EventArgs e)
        {
            if (!Controller.ExistsWorkers())
            {
                Controller.AddWorker(new Worker()
                {
                    Age = 50,
                    BirthDate = new DateTime(2005,11,7),
                    Dni = 2073067970,
                    DocketId = 1,
                    FavoriteBackColor = 0xFF5f433c,
                    FavoriteForeColor = 0xFFe5d7b9,
                    FirstName = "Alpine",
                    IsActive = true,
                    LastName = "Ropa Deportiva",
                    ProfilePicturePermalink = "https://bl6pap003files.storage.live.com/y4mzA5sxiVDEe_lg5TB1rvIsh66m3TBNoMF__BK6V0IZBZrRu2d2yTF1886FngvcwBkQWIVf93TeT5Bdbj0wuC2Vnlyq-RxLL24IFhIKkMVLuDe99nlxL71h63auRBbVFlWKTy-4Fxt8zzlWoR9bLwSXKoakM-d_0hqBo0ivWvMN-Td-Fbo83p7d-uApnGQvgVE?width=400&height=400&cropmode=none",
                    Title = "Cuenta Administrativa"
                });

            }

            GlobalAccess.CurrentWorker = Controller.GetDefaultWorker();
            SetUpWorkerSection();

            // setear el Home como de arranque.
            pnlMainView.Controls.Add(HomeView);
            setCurrentButton(btnHome);
            lblTitle.Text = @"Inicio";
        }



        // 

        /// <summary>
        /// Realiza lo necesario para
        /// dejar lista la "WorkerSection"
        /// del Header.
        /// </summary>
        public async void SetUpWorkerSection()
        {                           // mostrar solo el primer nombre y el primer apellido.
            lblUserFullName.Text = $@"{GlobalAccess.CurrentWorker.FirstName.Split(' ')[0]} " + 
                                   $@"{GlobalAccess.CurrentWorker.LastName.Split(' ')[0]}";
            List<Worker> workers = await Controller.GetAllWorkersAsync();
            List<WorkerItem> workerItemList = new List<WorkerItem>();

            cboUserSelector.Items.Clear();

            foreach (var worker in workers)
            {
                workerItemList.Add(new WorkerItem(worker));
            }


            foreach (var workerItem in workerItemList)
            {
                if (workerItem.ThisWorker.DocketId != GlobalAccess.CurrentWorker.DocketId)
                    cboUserSelector.Items.Add(workerItem);
            }

            Program.MainFormWindowForm.MainControl.HomeView.lblGreetingUser.Text = $@"{GlobalAccess.CurrentWorker.FirstName.Split(" ")[0]}";
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (cboUserSelector.SelectedIndex != -1) this.SetCurrentWorker(((WorkerItem)cboUserSelector.SelectedItem).ThisWorker);
        }
        public void SetCurrentWorker(Worker thisWorker)
        {
            GlobalAccess.CurrentWorker = thisWorker;
            Program.MainFormWindowForm.MainControl.HomeView.lblGreetingUser.Text = $@"{thisWorker.FirstName.Split(" ")[0]}";
            this.SetUpWorkerSection();
        }




        // 
        // 

        //
        // SUBCONTROLES
        //
        public TransactionsControl TransactionsControl =>
            _transactionsControl ??= new TransactionsControl()
            {
                Dock = DockStyle.Fill
            };

        public SalesControl SalesControl =>
            _salesControl ??= new SalesControl()
            {
                Dock = DockStyle.Fill
            };

        public StockControl StockControl =>
            _stockControl ??= new StockControl()
            {
                Dock = DockStyle.Fill
            };

        public UsControl UsControl =>
            _usControl ??= new UsControl()
            {
                Dock = DockStyle.Fill
            };

        public HomeControl HomeView =>
            _homeControl ??= new HomeControl()
            {
                Dock = DockStyle.Fill
            };





        //
        // BOTONES
        //
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void setAllForCurrentView(String title, IconButton btn)
        {
            lblTitle.Text = title;
            pnlMainView.Controls.Clear();
            this.RestartAllButtons();
            this.setCurrentButton(btn);
        }

        private void btnUs_Click(object sender, EventArgs e)
        {
            this.setAllForCurrentView(@"Nosotros", btnUs);

            pnlMainView.Controls.Add(UsControl);
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            this.setAllForCurrentView(@"Cuentas", btnAccounts);
            pnlMainView.Controls.Add(TransactionsControl);

            // aquí y no en el trans.Control.constructor() porque
            // no se recargaría al re-ingresar.
            TransactionsControl.LoadDataGridViewData();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            this.setAllForCurrentView(@"Ventas", btnSales);
            pnlMainView.Controls.Add(SalesControl);
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            this.setAllForCurrentView(@"Stock", btnStock);
            pnlMainView.Controls.Add(StockControl);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.setAllForCurrentView(@"Inicio", btnHome);
            pnlMainView.Controls.Add(HomeView);
        }

        private void setCurrentButton(IconButton btn)
        {
            btn.Enabled = false;
            btn.BackColor = System.Drawing.Color.AliceBlue;
        }

        private void setDefaultButtonState(IconButton btn)
        {
            btn.Enabled = true;
            btn.BackColor = Color.FromArgb(33, 31, 30);
        }

        private void RestartAllButtons()
        {
            this.setDefaultButtonState(btnHome);
            this.setDefaultButtonState(btnUs);
            this.setDefaultButtonState(btnAccounts);
            this.setDefaultButtonState(btnSales);
            this.setDefaultButtonState(btnStock);
            this.setDefaultButtonState(btnHome);
        }
    }
}