
namespace Ma.Ui.UserControls.SalesView
{
    partial class ProductView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.picDefault = new FontAwesome.Sharp.IconPictureBox();
            this.pnlText = new System.Windows.Forms.Panel();
            this.pnlDummy3 = new System.Windows.Forms.Panel();
            this.LinkLblMercadoLibre = new System.Windows.Forms.LinkLabel();
            this.pnlDummy2 = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDemo1 = new System.Windows.Forms.Label();
            this.pnlDummy1 = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDummy2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSelectProduct = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDefault)).BeginInit();
            this.pnlText.SuspendLayout();
            this.pnlDummy3.SuspendLayout();
            this.pnlDummy2.SuspendLayout();
            this.pnlDummy1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.picProduct);
            this.panel1.Controls.Add(this.picDefault);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(100, 98);
            this.panel1.TabIndex = 0;
            // 
            // picProduct
            // 
            this.picProduct.BackColor = System.Drawing.Color.Transparent;
            this.picProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picProduct.Location = new System.Drawing.Point(10, 10);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(80, 78);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduct.TabIndex = 1;
            this.picProduct.TabStop = false;
            // 
            // picDefault
            // 
            this.picDefault.BackColor = System.Drawing.Color.MidnightBlue;
            this.picDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDefault.ForeColor = System.Drawing.Color.AliceBlue;
            this.picDefault.IconChar = FontAwesome.Sharp.IconChar.FileImage;
            this.picDefault.IconColor = System.Drawing.Color.AliceBlue;
            this.picDefault.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picDefault.IconSize = 78;
            this.picDefault.Location = new System.Drawing.Point(10, 10);
            this.picDefault.Name = "picDefault";
            this.picDefault.Size = new System.Drawing.Size(80, 78);
            this.picDefault.TabIndex = 1;
            this.picDefault.TabStop = false;
            // 
            // pnlText
            // 
            this.pnlText.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlText.Controls.Add(this.pnlDummy3);
            this.pnlText.Controls.Add(this.pnlDummy2);
            this.pnlText.Controls.Add(this.pnlDummy1);
            this.pnlText.Controls.Add(this.lblTitle);
            this.pnlText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlText.Location = new System.Drawing.Point(102, 1);
            this.pnlText.Name = "pnlText";
            this.pnlText.Padding = new System.Windows.Forms.Padding(10);
            this.pnlText.Size = new System.Drawing.Size(235, 98);
            this.pnlText.TabIndex = 1;
            // 
            // pnlDummy3
            // 
            this.pnlDummy3.Controls.Add(this.LinkLblMercadoLibre);
            this.pnlDummy3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDummy3.Location = new System.Drawing.Point(10, 70);
            this.pnlDummy3.Name = "pnlDummy3";
            this.pnlDummy3.Size = new System.Drawing.Size(215, 18);
            this.pnlDummy3.TabIndex = 6;
            // 
            // LinkLblMercadoLibre
            // 
            this.LinkLblMercadoLibre.AutoSize = true;
            this.LinkLblMercadoLibre.DisabledLinkColor = System.Drawing.Color.PaleTurquoise;
            this.LinkLblMercadoLibre.Dock = System.Windows.Forms.DockStyle.Right;
            this.LinkLblMercadoLibre.Font = new System.Drawing.Font("Simplifica", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LinkLblMercadoLibre.LinkColor = System.Drawing.Color.CadetBlue;
            this.LinkLblMercadoLibre.Location = new System.Drawing.Point(105, 0);
            this.LinkLblMercadoLibre.Name = "LinkLblMercadoLibre";
            this.LinkLblMercadoLibre.Size = new System.Drawing.Size(110, 16);
            this.LinkLblMercadoLibre.TabIndex = 2;
            this.LinkLblMercadoLibre.TabStop = true;
            this.LinkLblMercadoLibre.Text = "Ver en MercadoLibre";
            this.LinkLblMercadoLibre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LinkLblMercadoLibre.VisitedLinkColor = System.Drawing.Color.Honeydew;
            this.LinkLblMercadoLibre.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLblMercadoLibre_LinkClicked);
            // 
            // pnlDummy2
            // 
            this.pnlDummy2.Controls.Add(this.lblPrice);
            this.pnlDummy2.Controls.Add(this.lblDemo1);
            this.pnlDummy2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDummy2.Location = new System.Drawing.Point(10, 50);
            this.pnlDummy2.Name = "pnlDummy2";
            this.pnlDummy2.Size = new System.Drawing.Size(215, 20);
            this.pnlDummy2.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrice.Font = new System.Drawing.Font("Simplifica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblPrice.Location = new System.Drawing.Point(47, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(28, 18);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "92.5";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDemo1
            // 
            this.lblDemo1.AutoSize = true;
            this.lblDemo1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDemo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDemo1.Font = new System.Drawing.Font("Simplifica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDemo1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDemo1.Location = new System.Drawing.Point(0, 0);
            this.lblDemo1.Name = "lblDemo1";
            this.lblDemo1.Size = new System.Drawing.Size(47, 18);
            this.lblDemo1.TabIndex = 3;
            this.lblDemo1.Text = "Precio:";
            this.lblDemo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDummy1
            // 
            this.pnlDummy1.Controls.Add(this.lblQuantity);
            this.pnlDummy1.Controls.Add(this.lblDummy2);
            this.pnlDummy1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDummy1.Location = new System.Drawing.Point(10, 30);
            this.pnlDummy1.Name = "pnlDummy1";
            this.pnlDummy1.Size = new System.Drawing.Size(215, 20);
            this.pnlDummy1.TabIndex = 4;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuantity.Font = new System.Drawing.Font("Simplifica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantity.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblQuantity.Location = new System.Drawing.Point(69, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(25, 18);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "456";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDummy2
            // 
            this.lblDummy2.AutoSize = true;
            this.lblDummy2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDummy2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDummy2.Font = new System.Drawing.Font("Simplifica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDummy2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDummy2.Location = new System.Drawing.Point(0, 0);
            this.lblDummy2.Name = "lblDummy2";
            this.lblDummy2.Size = new System.Drawing.Size(69, 18);
            this.lblDummy2.TabIndex = 4;
            this.lblDummy2.Text = "Disponible:";
            this.lblDummy2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Prime", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblTitle.Location = new System.Drawing.Point(10, 10);
            this.lblTitle.MaximumSize = new System.Drawing.Size(0, 200);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(98, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Product Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelectProduct
            // 
            this.btnSelectProduct.BackColor = System.Drawing.Color.MintCream;
            this.btnSelectProduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectProduct.FlatAppearance.BorderSize = 0;
            this.btnSelectProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectProduct.IconChar = FontAwesome.Sharp.IconChar.Shopify;
            this.btnSelectProduct.IconColor = System.Drawing.Color.DarkSlateGray;
            this.btnSelectProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectProduct.IconSize = 38;
            this.btnSelectProduct.Location = new System.Drawing.Point(337, 1);
            this.btnSelectProduct.Name = "btnSelectProduct";
            this.btnSelectProduct.Size = new System.Drawing.Size(65, 98);
            this.btnSelectProduct.TabIndex = 2;
            this.btnSelectProduct.UseVisualStyleBackColor = false;
            this.btnSelectProduct.Click += new System.EventHandler(this.btnSelectProduct_Click);
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.pnlText);
            this.Controls.Add(this.btnSelectProduct);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.Name = "ProductView";
            this.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Size = new System.Drawing.Size(404, 100);
            this.Load += new System.EventHandler(this.ProductView_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDefault)).EndInit();
            this.pnlText.ResumeLayout(false);
            this.pnlText.PerformLayout();
            this.pnlDummy3.ResumeLayout(false);
            this.pnlDummy3.PerformLayout();
            this.pnlDummy2.ResumeLayout(false);
            this.pnlDummy2.PerformLayout();
            this.pnlDummy1.ResumeLayout(false);
            this.pnlDummy1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picProduct;
        private FontAwesome.Sharp.IconPictureBox picDefault;
        private System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.Label lblDemo1;
        private System.Windows.Forms.LinkLabel LinkLblMercadoLibre;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlDummy3;
        private System.Windows.Forms.Panel pnlDummy2;
        private System.Windows.Forms.Panel pnlDummy1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDummy2;
        private FontAwesome.Sharp.IconButton btnSelectProduct;
    }
}
