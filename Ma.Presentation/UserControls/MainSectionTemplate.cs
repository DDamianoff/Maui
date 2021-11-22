using System.Windows.Forms;


namespace Ma.UI.UserControls
{
    /// <summary>
    /// Clase de la cual heredan todos los
    /// Controles de usuario (forms) que se ven.
    ///
    /// Mas que nada para definir el tamaño y un espacio
    /// reservado para el header.
    /// </summary>
    public partial class MainSectionTemplate : UserControl
    {
        public MainSectionTemplate()
        {
            InitializeComponent();
        }
    }
}