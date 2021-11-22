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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.IdTransaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityOperated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShelledDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReload = new FontAwesome.Sharp.IconButton();
            this.pnlMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.Controls.Add(this.dgvTransactions);
            this.pnlMainContainer.Controls.Add(this.btnReload);
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContainer.Location = new System.Drawing.Point(0, 55);
            this.pnlMainContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.pnlMainContainer.Size = new System.Drawing.Size(884, 530);
            this.pnlMainContainer.TabIndex = 0;
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            this.dgvTransactions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(251)))));
            this.dgvTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Prime", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTransaction,
            this.Product,
            this.Worker,
            this.quantityOperated,
            this.ShelledDateTime,
            this.Amout,
            this.Type});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Simplifica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactions.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransactions.EnableHeadersVisualStyles = false;
            this.dgvTransactions.GridColor = System.Drawing.Color.ForestGreen;
            this.dgvTransactions.Location = new System.Drawing.Point(20, 30);
            this.dgvTransactions.Margin = new System.Windows.Forms.Padding(0);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTransactions.RowHeadersVisible = false;
            this.dgvTransactions.Size = new System.Drawing.Size(844, 434);
            this.dgvTransactions.TabIndex = 0;
            // 
            // IdTransaction
            // 
            this.IdTransaction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdTransaction.HeaderText = "Código";
            this.IdTransaction.Name = "IdTransaction";
            this.IdTransaction.ReadOnly = true;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.HeaderText = "Producto";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // Worker
            // 
            this.Worker.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Worker.HeaderText = "Vendedor";
            this.Worker.Name = "Worker";
            this.Worker.ReadOnly = true;
            // 
            // quantityOperated
            // 
            this.quantityOperated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityOperated.HeaderText = "Cantidad";
            this.quantityOperated.Name = "quantityOperated";
            this.quantityOperated.ReadOnly = true;
            // 
            // ShelledDateTime
            // 
            this.ShelledDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ShelledDateTime.HeaderText = "Fecha";
            this.ShelledDateTime.Name = "ShelledDateTime";
            this.ShelledDateTime.ReadOnly = true;
            // 
            // Amout
            // 
            this.Amout.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amout.HeaderText = "Monto";
            this.Amout.Name = "Amout";
            this.Amout.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Type.HeaderText = "Tipo";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // btnReload
            // 
            this.btnReload.AutoSize = true;
            this.btnReload.BackColor = System.Drawing.Color.Teal;
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.btnReload.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(251)))));
            this.btnReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReload.IconSize = 40;
            this.btnReload.Location = new System.Drawing.Point(20, 464);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(844, 46);
            this.btnReload.TabIndex = 1;
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // TransactionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMainContainer);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "TransactionsControl";
            this.Size = new System.Drawing.Size(884, 585);
            this.Controls.SetChildIndex(this.pnlMainContainer, 0);
            this.pnlMainContainer.ResumeLayout(false);
            this.pnlMainContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvTransactions;

        private System.Windows.Forms.Panel pnlMainContainer;

        #endregion
        private FontAwesome.Sharp.IconButton btnReload;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityOperated;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShelledDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
    }
}