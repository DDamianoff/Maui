
namespace Ma.Ui.UserControls.UsView
{
    partial class WorkerView
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
            this.tlpMainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFirstMain = new System.Windows.Forms.Panel();
            this.picUserPicture = new System.Windows.Forms.PictureBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pnlSecondMain = new System.Windows.Forms.Panel();
            this.tlpMainContainer.SuspendLayout();
            this.pnlFirstMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMainContainer
            // 
            this.tlpMainContainer.ColumnCount = 1;
            this.tlpMainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMainContainer.Controls.Add(this.pnlSecondMain, 0, 1);
            this.tlpMainContainer.Controls.Add(this.pnlFirstMain, 0, 0);
            this.tlpMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainContainer.Font = new System.Drawing.Font("Prime", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tlpMainContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpMainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMainContainer.Name = "tlpMainContainer";
            this.tlpMainContainer.RowCount = 2;
            this.tlpMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainContainer.Size = new System.Drawing.Size(250, 500);
            this.tlpMainContainer.TabIndex = 0;
            this.tlpMainContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpMainContainer_Paint);
            // 
            // pnlFirstMain
            // 
            this.pnlFirstMain.Controls.Add(this.txtUserName);
            this.pnlFirstMain.Controls.Add(this.picUserPicture);
            this.pnlFirstMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFirstMain.Location = new System.Drawing.Point(3, 3);
            this.pnlFirstMain.Name = "pnlFirstMain";
            this.pnlFirstMain.Size = new System.Drawing.Size(244, 244);
            this.pnlFirstMain.TabIndex = 0;
            // 
            // picUserPicture
            // 
            this.picUserPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picUserPicture.Location = new System.Drawing.Point(0, 0);
            this.picUserPicture.Name = "picUserPicture";
            this.picUserPicture.Padding = new System.Windows.Forms.Padding(6);
            this.picUserPicture.Size = new System.Drawing.Size(244, 244);
            this.picUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserPicture.TabIndex = 0;
            this.picUserPicture.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtUserName.Location = new System.Drawing.Point(0, 224);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(244, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // pnlSecondMain
            // 
            this.pnlSecondMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSecondMain.Location = new System.Drawing.Point(3, 253);
            this.pnlSecondMain.Name = "pnlSecondMain";
            this.pnlSecondMain.Size = new System.Drawing.Size(244, 244);
            this.pnlSecondMain.TabIndex = 1;
            // 
            // WorkerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMainContainer);
            this.MaximumSize = new System.Drawing.Size(250, 500);
            this.MinimumSize = new System.Drawing.Size(100, 200);
            this.Name = "WorkerView";
            this.Size = new System.Drawing.Size(250, 500);
            this.tlpMainContainer.ResumeLayout(false);
            this.pnlFirstMain.ResumeLayout(false);
            this.pnlFirstMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMainContainer;
        private System.Windows.Forms.Panel pnlSecondMain;
        private System.Windows.Forms.Panel pnlFirstMain;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox picUserPicture;
    }
}
