
namespace Ma.Ui.UserControls.StockView
{
    partial class MeLiUserControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMainSectionContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlMainSectionContainer
            // 
            this.pnlMainSectionContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainSectionContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlMainSectionContainer.Name = "pnlMainSectionContainer";
            this.pnlMainSectionContainer.Size = new System.Drawing.Size(930, 583);
            this.pnlMainSectionContainer.TabIndex = 6;
            // 
            // MeLiUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMainSectionContainer);
            this.Name = "MeLiUserControl";
            this.Size = new System.Drawing.Size(930, 583);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMainSectionContainer;
    }
}
