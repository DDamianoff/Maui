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
            this.btnUs = new FontAwesome.Sharp.IconButton();
            this.btnAccounts = new FontAwesome.Sharp.IconButton();
            this.btnSales = new FontAwesome.Sharp.IconButton();
            this.btnStock = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlUserSectionContainer = new System.Windows.Forms.Panel();
            this.pnlUserSelector = new System.Windows.Forms.Panel();
            this.btnLogIn = new FontAwesome.Sharp.IconButton();
            this.cboUserSelector = new System.Windows.Forms.ComboBox();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.lblUserFullName = new System.Windows.Forms.Label();
            this.picUserIcon = new FontAwesome.Sharp.IconPictureBox();
            this.lblAppName = new System.Windows.Forms.Label();
            this.pnlVoid = new System.Windows.Forms.Panel();
            this.pnlMainView = new System.Windows.Forms.Panel();
            this.pnlNavigator.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlUserSectionContainer.SuspendLayout();
            this.pnlUserSelector.SuspendLayout();
            this.pnlUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picUserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavigator
            // 
            this.pnlNavigator.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.pnlNavigator.Controls.Add(this.btnUs);
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
            // btnUs
            // 
            this.btnUs.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.btnUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUs.FlatAppearance.BorderSize = 0;
            this.btnUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUs.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnUs.ForeColor = System.Drawing.Color.Lavender;
            this.btnUs.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.btnUs.IconColor = System.Drawing.Color.Lavender;
            this.btnUs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUs.IconSize = 28;
            this.btnUs.Location = new System.Drawing.Point(0, 250);
            this.btnUs.Name = "btnUs";
            this.btnUs.Size = new System.Drawing.Size(50, 60);
            this.btnUs.TabIndex = 4;
            this.btnUs.Text = "Nosotros";
            this.btnUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUs.UseVisualStyleBackColor = false;
            this.btnUs.Click += new System.EventHandler(this.btnUs_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.btnAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccounts.FlatAppearance.BorderSize = 0;
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAccounts.ForeColor = System.Drawing.Color.Lavender;
            this.btnAccounts.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnAccounts.IconColor = System.Drawing.Color.Lavender;
            this.btnAccounts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccounts.IconSize = 28;
            this.btnAccounts.Location = new System.Drawing.Point(0, 190);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(50, 60);
            this.btnAccounts.TabIndex = 3;
            this.btnAccounts.Text = "Cuentas";
            this.btnAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAccounts.UseVisualStyleBackColor = false;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSales.ForeColor = System.Drawing.Color.Lavender;
            this.btnSales.IconChar = FontAwesome.Sharp.IconChar.StoreAlt;
            this.btnSales.IconColor = System.Drawing.Color.Lavender;
            this.btnSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSales.IconSize = 28;
            this.btnSales.Location = new System.Drawing.Point(0, 130);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(50, 60);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "Ventas";
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.btnStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnStock.ForeColor = System.Drawing.Color.Lavender;
            this.btnStock.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnStock.IconColor = System.Drawing.Color.Lavender;
            this.btnStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStock.IconSize = 28;
            this.btnStock.Location = new System.Drawing.Point(0, 70);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(50, 60);
            this.btnStock.TabIndex = 1;
            this.btnStock.Text = "Stock";
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnExit.ForeColor = System.Drawing.Color.Lavender;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnExit.IconColor = System.Drawing.Color.Lavender;
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
            this.btnHome.ForeColor = System.Drawing.Color.Lavender;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.Lavender;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnHome.IconSize = 28;
            this.btnHome.Location = new System.Drawing.Point(0, 10);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 60);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Inicio";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(50, 10);
            this.pnlLogo.TabIndex = 6;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (81)))), ((int) (((byte) (81)))), ((int) (((byte) (81)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.pnlUserSectionContainer);
            this.pnlHeader.Controls.Add(this.lblAppName);
            this.pnlHeader.Controls.Add(this.pnlVoid);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.Lavender;
            this.pnlHeader.Location = new System.Drawing.Point(50, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(550, 55);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Simplifica", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTitle.Location = new System.Drawing.Point(192, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 55);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Título";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlUserSectionContainer
            // 
            this.pnlUserSectionContainer.Controls.Add(this.pnlUserSelector);
            this.pnlUserSectionContainer.Controls.Add(this.pnlUserInfo);
            this.pnlUserSectionContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUserSectionContainer.Location = new System.Drawing.Point(350, 0);
            this.pnlUserSectionContainer.Name = "pnlUserSectionContainer";
            this.pnlUserSectionContainer.Size = new System.Drawing.Size(200, 55);
            this.pnlUserSectionContainer.TabIndex = 3;
            // 
            // pnlUserSelector
            // 
            this.pnlUserSelector.Controls.Add(this.btnLogIn);
            this.pnlUserSelector.Controls.Add(this.cboUserSelector);
            this.pnlUserSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserSelector.Location = new System.Drawing.Point(0, 32);
            this.pnlUserSelector.Name = "pnlUserSelector";
            this.pnlUserSelector.Size = new System.Drawing.Size(200, 23);
            this.pnlUserSelector.TabIndex = 1;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnLogIn.IconColor = System.Drawing.Color.GhostWhite;
            this.btnLogIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogIn.IconSize = 20;
            this.btnLogIn.Location = new System.Drawing.Point(156, 0);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(44, 23);
            this.btnLogIn.TabIndex = 1;
            this.btnLogIn.UseVisualStyleBackColor = true;
            // 
            // cboUserSelector
            // 
            this.cboUserSelector.BackColor = System.Drawing.Color.Silver;
            this.cboUserSelector.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboUserSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboUserSelector.Font = new System.Drawing.Font("Prime", 9.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cboUserSelector.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (81)))), ((int) (((byte) (81)))), ((int) (((byte) (81)))));
            this.cboUserSelector.FormattingEnabled = true;
            this.cboUserSelector.Items.AddRange(new object[] {"Juan Quiroga", "Andrés Ceballos", "Reinoso Mayra"});
            this.cboUserSelector.Location = new System.Drawing.Point(0, 0);
            this.cboUserSelector.Name = "cboUserSelector";
            this.cboUserSelector.Size = new System.Drawing.Size(156, 23);
            this.cboUserSelector.TabIndex = 0;
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (81)))), ((int) (((byte) (81)))), ((int) (((byte) (81)))));
            this.pnlUserInfo.Controls.Add(this.lblUserFullName);
            this.pnlUserInfo.Controls.Add(this.picUserIcon);
            this.pnlUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(200, 32);
            this.pnlUserInfo.TabIndex = 0;
            // 
            // lblUserFullName
            // 
            this.lblUserFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserFullName.Font = new System.Drawing.Font("Simplifica", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUserFullName.Location = new System.Drawing.Point(32, 0);
            this.lblUserFullName.Name = "lblUserFullName";
            this.lblUserFullName.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblUserFullName.Size = new System.Drawing.Size(168, 32);
            this.lblUserFullName.TabIndex = 1;
            this.lblUserFullName.Text = "Pepe Almeja";
            this.lblUserFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picUserIcon
            // 
            this.picUserIcon.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (81)))), ((int) (((byte) (81)))), ((int) (((byte) (81)))));
            this.picUserIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.picUserIcon.ForeColor = System.Drawing.Color.Lavender;
            this.picUserIcon.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.picUserIcon.IconColor = System.Drawing.Color.Lavender;
            this.picUserIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picUserIcon.Location = new System.Drawing.Point(0, 0);
            this.picUserIcon.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.picUserIcon.Name = "picUserIcon";
            this.picUserIcon.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.picUserIcon.Size = new System.Drawing.Size(32, 32);
            this.picUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUserIcon.TabIndex = 0;
            this.picUserIcon.TabStop = false;
            // 
            // lblAppName
            // 
            this.lblAppName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAppName.Font = new System.Drawing.Font("Logger", 27.75F);
            this.lblAppName.Location = new System.Drawing.Point(20, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(172, 55);
            this.lblAppName.TabIndex = 2;
            this.lblAppName.Text = "Kakuy";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlVoid
            // 
            this.pnlVoid.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlVoid.Location = new System.Drawing.Point(0, 0);
            this.pnlVoid.Name = "pnlVoid";
            this.pnlVoid.Size = new System.Drawing.Size(20, 55);
            this.pnlVoid.TabIndex = 1;
            // 
            // pnlMainView
            // 
            this.pnlMainView.BackColor = System.Drawing.Color.Transparent;
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
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMainView);
            this.Controls.Add(this.pnlNavigator);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainWindowControl";
            this.Size = new System.Drawing.Size(600, 400);
            this.pnlNavigator.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlUserSectionContainer.ResumeLayout(false);
            this.pnlUserSelector.ResumeLayout(false);
            this.pnlUserInfo.ResumeLayout(false);
            this.pnlUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picUserIcon)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.ComboBox cboUserSelector;

        private System.Windows.Forms.Label lblUserFullName;

        private FontAwesome.Sharp.IconButton btnLogIn;

        private FontAwesome.Sharp.IconPictureBox picUserIcon;
        

        private System.Windows.Forms.Panel pnlUserSelector;

        private System.Windows.Forms.Panel pnlUserInfo;

        private System.Windows.Forms.Panel pnlHeader;

        private System.Windows.Forms.Panel pnlUserSectionContainer;
        
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Panel pnlVoid;

        private System.Windows.Forms.Panel pnlLogo;
        
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnStock;
        private FontAwesome.Sharp.IconButton btnSales;
        private FontAwesome.Sharp.IconButton btnAccounts;
        private FontAwesome.Sharp.IconButton btnUs;
        private FontAwesome.Sharp.IconButton btnExit;
        
        private System.Windows.Forms.Panel pnlMainView;
        private System.Windows.Forms.Panel pnlNavigator;

        #endregion
    }
}