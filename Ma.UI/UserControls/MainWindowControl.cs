using System;
using System.Windows.Forms;
using Ma.UI.UserControls.HomeView;
using Ma.UI.UserControls.SalesView;
using Ma.UI.UserControls.StockView;
using Ma.UI.UserControls.UsView;
using Ma.UI.UserControls.TransactionsView;

// ReSharper disable ArrangeThisQualifier
// ReSharper disable MemberCanBePrivate.Global

namespace Ma.UI.UserControls
{
    public partial class MainWindowControl : UserControl
    {
        private HomeControl _homeControl;
        private TransactionsControl _transactionsControl;
        private SalesControl _salesControl;
        private StockControl _stockControl;
        private UsControl _usControl;
        
        // Consultar si el elemento fue o no instanciado (??)
        // Para crearlo y retornarlo.
        public TransactionsControl TransactionsControl =>
            _transactionsControl ?? 
            (_transactionsControl = new TransactionsControl()
            {
                Dock = DockStyle.Fill
            });
        public SalesControl SalesControl =>
            _salesControl ??
            (_salesControl = new SalesControl()
            {
                Dock = DockStyle.Fill
            });
        public StockControl StockControl =>
            _stockControl ??
            (_stockControl = new StockControl()
            {
                Dock = DockStyle.Fill
            });
        public UsControl UsControl => 
            _usControl ?? 
            (_usControl = new UsControl()
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
            lblTitle.Text = @"Inicio";
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
            lblTitle.Text = @"Nosotros";
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            pnlMainView.Controls.Add(TransactionsControl);
            this.EnableAllbuttons();
            btnAccounts.Enabled = false;
            lblTitle.Text = @"Cuentas";
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            pnlMainView.Controls.Add(SalesControl);
            this.EnableAllbuttons();
            btnSales.Enabled = false;
            lblTitle.Text = @"Ventas";
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            pnlMainView.Controls.Add(StockControl);
            this.EnableAllbuttons();
            btnStock.Enabled = false;
            lblTitle.Text = @"Stock";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlMainView.Controls.Clear();
            pnlMainView.Controls.Add(HomeView);
            this.EnableAllbuttons();
            btnHome.Enabled = false;
            lblTitle.Text = @"Inicio";
        }
        
    }
}