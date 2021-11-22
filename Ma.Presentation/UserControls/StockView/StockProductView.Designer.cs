
namespace Ma.Ui.UserControls.StockView
{
    partial class StockProductView
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
            this.pnlImgContainer = new System.Windows.Forms.Panel();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.picDefault = new FontAwesome.Sharp.IconPictureBox();
            this.lblDummy2 = new System.Windows.Forms.Label();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.tlpDummy = new System.Windows.Forms.TableLayoutPanel();
            this.txtDummyImgLink = new System.Windows.Forms.TextBox();
            this.txtDummyStock = new System.Windows.Forms.TextBox();
            this.txtDummyPrice = new System.Windows.Forms.TextBox();
            this.txtDummytTitle = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtImgLink = new System.Windows.Forms.TextBox();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.pnlText = new System.Windows.Forms.Panel();
            this.tlpButtonSection = new System.Windows.Forms.TableLayoutPanel();
            this.btnReload = new FontAwesome.Sharp.IconButton();
            this.pnlImgContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDefault)).BeginInit();
            this.tlpDummy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.pnlText.SuspendLayout();
            this.tlpButtonSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlImgContainer
            // 
            this.pnlImgContainer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlImgContainer.Controls.Add(this.picProduct);
            this.pnlImgContainer.Controls.Add(this.picDefault);
            this.pnlImgContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlImgContainer.Location = new System.Drawing.Point(2, 1);
            this.pnlImgContainer.Name = "pnlImgContainer";
            this.pnlImgContainer.Padding = new System.Windows.Forms.Padding(10);
            this.pnlImgContainer.Size = new System.Drawing.Size(149, 149);
            this.pnlImgContainer.TabIndex = 0;
            // 
            // picProduct
            // 
            this.picProduct.BackColor = System.Drawing.Color.Transparent;
            this.picProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picProduct.Location = new System.Drawing.Point(10, 10);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(129, 129);
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
            this.picDefault.IconSize = 129;
            this.picDefault.Location = new System.Drawing.Point(10, 10);
            this.picDefault.Name = "picDefault";
            this.picDefault.Size = new System.Drawing.Size(129, 129);
            this.picDefault.TabIndex = 1;
            this.picDefault.TabStop = false;
            // 
            // lblDummy2
            // 
            this.lblDummy2.AutoSize = true;
            this.lblDummy2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDummy2.Font = new System.Drawing.Font("Simplifica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDummy2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDummy2.Location = new System.Drawing.Point(347, 71);
            this.lblDummy2.Name = "lblDummy2";
            this.lblDummy2.Size = new System.Drawing.Size(69, 18);
            this.lblDummy2.TabIndex = 4;
            this.lblDummy2.Text = "Disponible:";
            this.lblDummy2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MintCream;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnEdit.IconColor = System.Drawing.Color.DarkSlateGray;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 38;
            this.btnEdit.Location = new System.Drawing.Point(0, 74);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(69, 75);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tlpDummy
            // 
            this.tlpDummy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tlpDummy.ColumnCount = 2;
            this.tlpDummy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.67384F));
            this.tlpDummy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.32616F));
            this.tlpDummy.Controls.Add(this.txtDummyImgLink, 0, 3);
            this.tlpDummy.Controls.Add(this.txtDummyStock, 0, 2);
            this.tlpDummy.Controls.Add(this.txtDummyPrice, 0, 1);
            this.tlpDummy.Controls.Add(this.txtDummytTitle, 0, 0);
            this.tlpDummy.Controls.Add(this.txtTitle, 1, 0);
            this.tlpDummy.Controls.Add(this.txtImgLink, 1, 3);
            this.tlpDummy.Controls.Add(this.numPrice, 1, 1);
            this.tlpDummy.Controls.Add(this.numQuantity, 1, 2);
            this.tlpDummy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDummy.Font = new System.Drawing.Font("Prime", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tlpDummy.Location = new System.Drawing.Point(10, 10);
            this.tlpDummy.Name = "tlpDummy";
            this.tlpDummy.RowCount = 4;
            this.tlpDummy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDummy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDummy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDummy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpDummy.Size = new System.Drawing.Size(290, 129);
            this.tlpDummy.TabIndex = 0;
            // 
            // txtDummyImgLink
            // 
            this.txtDummyImgLink.BackColor = System.Drawing.Color.AliceBlue;
            this.txtDummyImgLink.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDummyImgLink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDummyImgLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDummyImgLink.Font = new System.Drawing.Font("Prime", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDummyImgLink.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtDummyImgLink.Location = new System.Drawing.Point(3, 99);
            this.txtDummyImgLink.Name = "txtDummyImgLink";
            this.txtDummyImgLink.ReadOnly = true;
            this.txtDummyImgLink.Size = new System.Drawing.Size(77, 26);
            this.txtDummyImgLink.TabIndex = 9;
            this.txtDummyImgLink.Text = "Img:";
            // 
            // txtDummyStock
            // 
            this.txtDummyStock.BackColor = System.Drawing.Color.AliceBlue;
            this.txtDummyStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDummyStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDummyStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDummyStock.Font = new System.Drawing.Font("Prime", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDummyStock.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtDummyStock.Location = new System.Drawing.Point(3, 67);
            this.txtDummyStock.Name = "txtDummyStock";
            this.txtDummyStock.ReadOnly = true;
            this.txtDummyStock.Size = new System.Drawing.Size(77, 26);
            this.txtDummyStock.TabIndex = 8;
            this.txtDummyStock.Text = "Stock:";
            // 
            // txtDummyPrice
            // 
            this.txtDummyPrice.BackColor = System.Drawing.Color.AliceBlue;
            this.txtDummyPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDummyPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDummyPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDummyPrice.Font = new System.Drawing.Font("Prime", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDummyPrice.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtDummyPrice.Location = new System.Drawing.Point(3, 35);
            this.txtDummyPrice.Name = "txtDummyPrice";
            this.txtDummyPrice.ReadOnly = true;
            this.txtDummyPrice.Size = new System.Drawing.Size(77, 26);
            this.txtDummyPrice.TabIndex = 7;
            this.txtDummyPrice.Text = "Precio:";
            // 
            // txtDummytTitle
            // 
            this.txtDummytTitle.BackColor = System.Drawing.Color.AliceBlue;
            this.txtDummytTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDummytTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDummytTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDummytTitle.Font = new System.Drawing.Font("Prime", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDummytTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtDummytTitle.Location = new System.Drawing.Point(3, 3);
            this.txtDummytTitle.Name = "txtDummytTitle";
            this.txtDummytTitle.ReadOnly = true;
            this.txtDummytTitle.Size = new System.Drawing.Size(77, 26);
            this.txtDummytTitle.TabIndex = 6;
            this.txtDummytTitle.Text = "Título:";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.AliceBlue;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Font = new System.Drawing.Font("Simplifica", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtTitle.Location = new System.Drawing.Point(86, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(201, 26);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Título";
            // 
            // txtImgLink
            // 
            this.txtImgLink.BackColor = System.Drawing.Color.AliceBlue;
            this.txtImgLink.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImgLink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImgLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtImgLink.Font = new System.Drawing.Font("Simplifica", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtImgLink.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtImgLink.Location = new System.Drawing.Point(86, 99);
            this.txtImgLink.Name = "txtImgLink";
            this.txtImgLink.Size = new System.Drawing.Size(201, 30);
            this.txtImgLink.TabIndex = 3;
            this.txtImgLink.Text = "www.link.com";
            // 
            // numPrice
            // 
            this.numPrice.BackColor = System.Drawing.Color.AliceBlue;
            this.numPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numPrice.Font = new System.Drawing.Font("Prime", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numPrice.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.numPrice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numPrice.Location = new System.Drawing.Point(86, 35);
            this.numPrice.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.numPrice.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(201, 22);
            this.numPrice.TabIndex = 4;
            this.numPrice.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // numQuantity
            // 
            this.numQuantity.BackColor = System.Drawing.Color.AliceBlue;
            this.numQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numQuantity.Font = new System.Drawing.Font("Prime", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numQuantity.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.numQuantity.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numQuantity.Location = new System.Drawing.Point(86, 67);
            this.numQuantity.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(201, 23);
            this.numQuantity.TabIndex = 5;
            // 
            // pnlText
            // 
            this.pnlText.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlText.Controls.Add(this.tlpDummy);
            this.pnlText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlText.Location = new System.Drawing.Point(151, 1);
            this.pnlText.Name = "pnlText";
            this.pnlText.Padding = new System.Windows.Forms.Padding(10);
            this.pnlText.Size = new System.Drawing.Size(310, 149);
            this.pnlText.TabIndex = 1;
            // 
            // tlpButtonSection
            // 
            this.tlpButtonSection.ColumnCount = 1;
            this.tlpButtonSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonSection.Controls.Add(this.btnReload, 0, 0);
            this.tlpButtonSection.Controls.Add(this.btnEdit, 0, 1);
            this.tlpButtonSection.Dock = System.Windows.Forms.DockStyle.Right;
            this.tlpButtonSection.Location = new System.Drawing.Point(461, 1);
            this.tlpButtonSection.Name = "tlpButtonSection";
            this.tlpButtonSection.RowCount = 2;
            this.tlpButtonSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonSection.Size = new System.Drawing.Size(69, 149);
            this.tlpButtonSection.TabIndex = 5;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.MintCream;
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.btnReload.IconColor = System.Drawing.Color.DarkSlateGray;
            this.btnReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReload.IconSize = 38;
            this.btnReload.Location = new System.Drawing.Point(0, 0);
            this.btnReload.Margin = new System.Windows.Forms.Padding(0);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(69, 74);
            this.btnReload.TabIndex = 3;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // StockProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.pnlText);
            this.Controls.Add(this.tlpButtonSection);
            this.Controls.Add(this.pnlImgContainer);
            this.Controls.Add(this.lblDummy2);
            this.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.Name = "StockProductView";
            this.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Size = new System.Drawing.Size(532, 151);
            this.Load += new System.EventHandler(this.ProductView_Load);
            this.pnlImgContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDefault)).EndInit();
            this.tlpDummy.ResumeLayout(false);
            this.tlpDummy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.pnlText.ResumeLayout(false);
            this.tlpButtonSection.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlImgContainer;
        private System.Windows.Forms.PictureBox picProduct;
        private FontAwesome.Sharp.IconPictureBox picDefault;
        private System.Windows.Forms.Label lblDummy2;
        private FontAwesome.Sharp.IconButton btnEdit;
        private System.Windows.Forms.TableLayoutPanel tlpDummy;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.TextBox txtDummyImgLink;
        private System.Windows.Forms.TextBox txtDummyStock;
        private System.Windows.Forms.TextBox txtDummyPrice;
        private System.Windows.Forms.TextBox txtDummytTitle;
        private System.Windows.Forms.TextBox txtImgLink;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.TableLayoutPanel tlpButtonSection;
        private FontAwesome.Sharp.IconButton btnReload;
    }
}
