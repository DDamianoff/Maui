using System.ComponentModel;

namespace Ma.UI.UserControls
{
    partial class MainWindowControl
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
            this.pnlNavigator = new System.Windows.Forms.Panel();
            this.btnWorkers = new FontAwesome.Sharp.IconButton();
            this.btnAccounts = new FontAwesome.Sharp.IconButton();
            this.btnSales = new FontAwesome.Sharp.IconButton();
            this.btnStock = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlMainView = new System.Windows.Forms.Panel();
            this.pnlNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavigator
            // 
            this.pnlNavigator.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.pnlNavigator.Controls.Add(this.btnWorkers);
            this.pnlNavigator.Controls.Add(this.btnAccounts);
            this.pnlNavigator.Controls.Add(this.btnSales);
            this.pnlNavigator.Controls.Add(this.btnStock);
            this.pnlNavigator.Controls.Add(this.btnExit);
            this.pnlNavigator.Controls.Add(this.btnHome);
            this.pnlNavigator.Controls.Add(this.pnlLogo);
            this.pnlNavigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigator.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.pnlNavigator.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigator.Name = "pnlNavigator";
            this.pnlNavigator.Size = new System.Drawing.Size(50, 400);
            this.pnlNavigator.TabIndex = 0;
            // 
            // btnWorkers
            // 
            this.btnWorkers.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.btnWorkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWorkers.FlatAppearance.BorderSize = 0;
            this.btnWorkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkers.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnWorkers.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (224)))), ((int) (((byte) (192)))));
            this.btnWorkers.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.btnWorkers.IconColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (224)))), ((int) (((byte) (192)))));
            this.btnWorkers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWorkers.IconSize = 28;
            this.btnWorkers.Location = new System.Drawing.Point(0, 250);
            this.btnWorkers.Name = "btnWorkers";
            this.btnWorkers.Size = new System.Drawing.Size(50, 60);
            this.btnWorkers.TabIndex = 4;
            this.btnWorkers.Text = "Nosotros";
            this.btnWorkers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWorkers.UseVisualStyleBackColor = false;
            // 
            // btnAccounts
            // 
            this.btnAccounts.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.btnAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccounts.FlatAppearance.BorderSize = 0;
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAccounts.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (224)))), ((int) (((byte) (192)))));
            this.btnAccounts.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnAccounts.IconColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (224)))), ((int) (((byte) (192)))));
            this.btnAccounts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccounts.IconSize = 28;
            this.btnAccounts.Location = new System.Drawing.Point(0, 190);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(50, 60);
            this.btnAccounts.TabIndex = 3;
            this.btnAccounts.Text = "Cuentas";
            this.btnAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAccounts.UseVisualStyleBackColor = false;
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSales.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (224)))), ((int) (((byte) (192)))));
            this.btnSales.IconChar = FontAwesome.Sharp.IconChar.StoreAlt;
            this.btnSales.IconColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (224)))), ((int) (((byte) (192)))));
            this.btnSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSales.IconSize = 28;
            this.btnSales.Location = new System.Drawing.Point(0, 130);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(50, 60);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "Ventas";
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSales.UseVisualStyleBackColor = false;
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnStock.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (224)))), ((int) (((byte) (192)))));
            this.btnStock.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnStock.IconColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (224)))), ((int) (((byte) (192)))));
            this.btnStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStock.IconSize = 28;
            this.btnStock.Location = new System.Drawing.Point(0, 70);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(50, 60);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "Stock";
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStock.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (224)))), ((int) (((byte) (192)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (224)))), ((int) (((byte) (192)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 28;
            this.btnExit.Location = new System.Drawing.Point(0, 353);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 47);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "salir";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (224)))), ((int) (((byte) (192)))));
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (224)))), ((int) (((byte) (192)))));
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnHome.IconSize = 28;
            this.btnHome.Location = new System.Drawing.Point(0, 10);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 60);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Inicio";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(50, 10);
            this.pnlLogo.TabIndex = 6;
            // 
            // pnlMainView
            // 
            this.pnlMainView.BackColor = System.Drawing.Color.DimGray;
            this.pnlMainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainView.Location = new System.Drawing.Point(50, 0);
            this.pnlMainView.Name = "pnlMainView";
            this.pnlMainView.Size = new System.Drawing.Size(550, 400);
            this.pnlMainView.TabIndex = 1;
            // 
            // MainWindowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMainView);
            this.Controls.Add(this.pnlNavigator);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainWindowControl";
            this.Size = new System.Drawing.Size(600, 400);
            this.pnlNavigator.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlLogo;

        private System.Windows.Forms.Panel panel1;

        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnStock;
        private FontAwesome.Sharp.IconButton btnSales;
        private FontAwesome.Sharp.IconButton btnAccounts;
        private FontAwesome.Sharp.IconButton btnWorkers;
        private FontAwesome.Sharp.IconButton btnExit;
        
        private System.Windows.Forms.Panel pnlMainView;
        private System.Windows.Forms.Panel pnlNavigator;

        #endregion
    }
}