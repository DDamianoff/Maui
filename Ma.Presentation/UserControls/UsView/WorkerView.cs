using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ma.Backend.Models.DataBase;
using Maui.Backend.Models.DataBase;

namespace Ma.Ui.UserControls.UsView
{
    public partial class WorkerView : UserControl
    {
        public Worker WorkerIRepresent { get; set; }

        public WorkerView()
        {
            InitializeComponent();
        }

        private void tlpMainContainer_Paint(object sender, PaintEventArgs e)
        {
            tlpMainContainer.BackColor = Color.FromArgb((int)WorkerIRepresent.FavoriteBackColor);
            tlpMainContainer.ForeColor = Color.FromArgb((int)WorkerIRepresent.FavoriteForeColor);

            picUserPicture.Load(WorkerIRepresent.ProfilePicturePermalink);

            txtUserName.Text = $@"{WorkerIRepresent.FirstName.Split(' ')[0]} {WorkerIRepresent.LastName.Split(' ')[0]}";
        }
    }
}
