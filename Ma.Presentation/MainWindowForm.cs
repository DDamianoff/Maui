using System.Windows.Forms;
using Ma.Ui.UserControls.MainView;

namespace Ma.Ui
{
    public partial class frmMainWindowForm : Form
    {
        private MainWindowControl _mainControl;
        public MainWindowControl MainControl => _mainControl ??= new MainWindowControl() { Dock = DockStyle.Fill };

        public frmMainWindowForm()
        {
            InitializeComponent();
            Controls.Add(MainControl);
        }
    }
}
