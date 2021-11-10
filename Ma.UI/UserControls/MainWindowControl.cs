using System;
using System.Windows.Forms;

namespace Ma.UI.UserControls
{
    public partial class MainWindowControl : UserControl
    {
        public MainWindowControl()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //throw new System.NotImplementedException();
        }
    }
}