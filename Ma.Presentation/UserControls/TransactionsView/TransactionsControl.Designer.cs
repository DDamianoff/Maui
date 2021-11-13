using System.ComponentModel;

namespace Ma.UI.UserControls.TransactionsView
{
    partial class TransactionsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.btnReload = new FontAwesome.Sharp.IconButton();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.IdTransaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityOperated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShelledDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.Controls.Add(this.btnReload);
            this.pnlMainContainer.Controls.Add(this.dgvTransactions);
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMainContainer.Size = new System.Drawing.Size(884, 585);
            this.pnlMainContainer.TabIndex = 0;
            // 
            // btnReload
            // 
            this.btnReload.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.btnReload.IconColor = System.Drawing.Color.Black;
            this.btnReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReload.Location = new System.Drawing.Point(732, 33);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(129, 49);
            this.btnReload.TabIndex = 1;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTransaction,
            this.Product,
            this.Worker,
            this.quantityOperated,
            this.ShelledDateTime,
            this.Amout,
            this.Type});
            this.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTransactions.Location = new System.Drawing.Point(20, 88);
            this.dgvTransactions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.Size = new System.Drawing.Size(844, 477);
            this.dgvTransactions.TabIndex = 0;
            // 
            // IdTransaction
            // 
            this.IdTransaction.HeaderText = "Código";
            this.IdTransaction.Name = "IdTransaction";
            this.IdTransaction.ReadOnly = true;
            // 
            // Product
            // 
            this.Product.HeaderText = "Producto";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Worker
            // 
            this.Worker.HeaderText = "Vendedor";
            this.Worker.Name = "Worker";
            this.Worker.ReadOnly = true;
            // 
            // quantityOperated
            // 
            this.quantityOperated.HeaderText = "Cantidad";
            this.quantityOperated.Name = "quantityOperated";
            this.quantityOperated.ReadOnly = true;
            // 
            // ShelledDateTime
            // 
            this.ShelledDateTime.HeaderText = "Fecha";
            this.ShelledDateTime.Name = "ShelledDateTime";
            this.ShelledDateTime.ReadOnly = true;
            // 
            // Amout
            // 
            this.Amout.HeaderText = "Monto";
            this.Amout.Name = "Amout";
            this.Amout.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Tipo";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // TransactionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMainContainer);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "TransactionsControl";
            this.Size = new System.Drawing.Size(884, 585);
            this.pnlMainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvTransactions;

        private System.Windows.Forms.Panel pnlMainContainer;

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn IdTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityOperated;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShelledDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private FontAwesome.Sharp.IconButton btnReload;
    }
}