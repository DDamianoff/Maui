using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ma.UI.UserControls;

namespace Ma.Presentation
{
    public partial class MainWindow : Form
    {
        private MainWindowControl _mainControl;
        public MainWindowControl MainControl => _mainControl ?? (_mainControl = new MainWindowControl() { Dock = DockStyle.Fill });

        public MainWindow()
        {
            InitializeComponent();
            Controls.Add(MainControl);
        }
    }
}
