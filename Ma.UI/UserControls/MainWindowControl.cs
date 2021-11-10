using System;
using System.Windows.Forms;
using Ma.UI.UserControls.AccountsView;
using Ma.UI.UserControls.HomeView;
using Ma.UI.UserControls.SalesView;
using Ma.UI.UserControls.StockView;
using Ma.UI.UserControls.UsView;

// ReSharper disable ArrangeThisQualifier
// ReSharper disable MemberCanBePrivate.Global

namespace Ma.UI.UserControls
{
    public partial class MainWindowControl : UserControl
    {
        private HomeControl _homeControl;
        private AccountsControl _accountsControl;
        private SalesControl _salesControl;
        private StockControl _stockControl;
        private UsControl _usControl;
        
        // Consultar si el elemento fue o no instanciado (??)
        // Para hacerlo y retornarlo.
        public AccountsView.AccountsControl AccountsControl =>
            _accountsControl ?? 
            (_accountsControl = new AccountsView.AccountsControl()
            {
                Dock = DockStyle.Fill
            });
        public SalesView.SalesControl SalesControl =>
            _salesControl ??
            (_salesControl = new SalesView.SalesControl()
            {
                Dock = DockStyle.Fill
            });
        public StockView.StockControl StockControl =>
            _stockControl ??
            (_stockControl = new StockView.StockControl()
            {
                Dock = DockStyle.Fill
            });
        public UsView.UsControl UsControl => 
            _usControl ?? 
            (_usControl = new UsView.UsControl()
            {
                Dock = DockStyle.Fill
            });
        public HomeControl HomeView => 
            _homeControl ?? 
            (_homeControl = new HomeControl()
            {
                Dock = DockStyle.Fill
            });
        
        public MainWindowControl()
        {
            InitializeComponent();
            
            // añadir el Home como de arranque.
            pnlMainView.Controls.Add(HomeView);
            btnHome.Enabled = false;
        }


        private void EnableAllbuttons()
        {
            btnHome.Enabled = true;
            btnUs.Enabled = true;
            btnAccounts.Enabled = true;
            btnSales.Enabled = true;
            btnStock.Enabled = true;
            btnHome.Enabled = true;
        }
        
        // TODO: Set colors on disabled button.
        // TODO: simplify the code of all section buttons: "setCurrentView" Method.
        
        
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //throw new System.NotImplementedException();
        }

        private void btnUs_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            pnlMainView.Controls.Add(UsControl);
            this.EnableAllbuttons();
            btnUs.Enabled = false;
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            pnlMainView.Controls.Add(AccountsControl);
            this.EnableAllbuttons();
            btnAccounts.Enabled = false;
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            pnlMainView.Controls.Add(SalesControl);
            this.EnableAllbuttons();
            btnSales.Enabled = false;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            pnlMainView.Controls.Add(StockControl);
            this.EnableAllbuttons();
            btnStock.Enabled = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            pnlMainView.Controls.Add(HomeView);
            this.EnableAllbuttons();
            btnHome.Enabled = false;
        }
    }
}