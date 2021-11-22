using System.ComponentModel;

namespace Ma.UI.UserControls.StockView
{
    partial class StockControl
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
            this.tlpContentAsideDiv = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDummyMain = new System.Windows.Forms.Panel();
            this.pnlContentSection = new System.Windows.Forms.Panel();
            this.pnlMeLiSection = new System.Windows.Forms.Panel();
            this.btnMeliSection = new FontAwesome.Sharp.IconButton();
            this.btnEditSection = new FontAwesome.Sharp.IconButton();
            this.picWallpaper = new System.Windows.Forms.PictureBox();
            this.ltpButtonSection = new System.Windows.Forms.TableLayoutPanel();
            this.btnReload = new FontAwesome.Sharp.IconButton();
            this.pnlMainContainer.SuspendLayout();
            this.tlpContentAsideDiv.SuspendLayout();
            this.pnlDummyMain.SuspendLayout();
            this.pnlMeLiSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWallpaper)).BeginInit();
            this.ltpButtonSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.Controls.Add(this.tlpContentAsideDiv);
            this.pnlMainContainer.Controls.Add(this.ltpButtonSection);
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContainer.Location = new System.Drawing.Point(0, 55);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.pnlMainContainer.Size = new System.Drawing.Size(821, 543);
            this.pnlMainContainer.TabIndex = 1;
            // 
            // tlpContentAsideDiv
            // 
            this.tlpContentAsideDiv.ColumnCount = 2;
            this.tlpContentAsideDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66667F));
            this.tlpContentAsideDiv.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tlpContentAsideDiv.Controls.Add(this.pnlDummyMain, 0, 0);
            this.tlpContentAsideDiv.Controls.Add(this.picWallpaper, 1, 0);
            this.tlpContentAsideDiv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContentAsideDiv.Location = new System.Drawing.Point(20, 101);
            this.tlpContentAsideDiv.Name = "tlpContentAsideDiv";
            this.tlpContentAsideDiv.RowCount = 1;
            this.tlpContentAsideDiv.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContentAsideDiv.Size = new System.Drawing.Size(781, 422);
            this.tlpContentAsideDiv.TabIndex = 0;
            // 
            // pnlDummyMain
            // 
            this.pnlDummyMain.Controls.Add(this.pnlContentSection);
            this.pnlDummyMain.Controls.Add(this.pnlMeLiSection);
            this.pnlDummyMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDummyMain.Location = new System.Drawing.Point(3, 3);
            this.pnlDummyMain.Name = "pnlDummyMain";
            this.pnlDummyMain.Size = new System.Drawing.Size(514, 416);
            this.pnlDummyMain.TabIndex = 6;
            // 
            // pnlContentSection
            // 
            this.pnlContentSection.AutoScroll = true;
            this.pnlContentSection.BackColor = System.Drawing.Color.MintCream;
            this.pnlContentSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentSection.Location = new System.Drawing.Point(0, 0);
            this.pnlContentSection.Name = "pnlContentSection";
            this.pnlContentSection.Size = new System.Drawing.Size(514, 416);
            this.pnlContentSection.TabIndex = 1;
            // 
            // pnlMeLiSection
            // 
            this.pnlMeLiSection.BackColor = System.Drawing.Color.LightGreen;
            this.pnlMeLiSection.Controls.Add(this.btnMeliSection);
            this.pnlMeLiSection.Controls.Add(this.btnEditSection);
            this.pnlMeLiSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMeLiSection.Location = new System.Drawing.Point(0, 0);
            this.pnlMeLiSection.Name = "pnlMeLiSection";
            this.pnlMeLiSection.Size = new System.Drawing.Size(514, 416);
            this.pnlMeLiSection.TabIndex = 6;
            // 
            // btnMeliSection
            // 
            this.btnMeliSection.AutoSize = true;
            this.btnMeliSection.BackColor = System.Drawing.Color.Teal;
            this.btnMeliSection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMeliSection.Enabled = false;
            this.btnMeliSection.FlatAppearance.BorderSize = 0;
            this.btnMeliSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeliSection.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.btnMeliSection.IconColor = System.Drawing.Color.MintCream;
            this.btnMeliSection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMeliSection.IconSize = 40;
            this.btnMeliSection.Location = new System.Drawing.Point(0, 286);
            this.btnMeliSection.Name = "btnMeliSection";
            this.btnMeliSection.Size = new System.Drawing.Size(514, 65);
            this.btnMeliSection.TabIndex = 4;
            this.btnMeliSection.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMeliSection.UseVisualStyleBackColor = false;
            this.btnMeliSection.Visible = false;
            this.btnMeliSection.Click += new System.EventHandler(this.btnMercadoLibre_Click);
            // 
            // btnEditSection
            // 
            this.btnEditSection.AutoSize = true;
            this.btnEditSection.BackColor = System.Drawing.Color.Teal;
            this.btnEditSection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEditSection.Enabled = false;
            this.btnEditSection.FlatAppearance.BorderSize = 0;
            this.btnEditSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSection.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditSection.IconColor = System.Drawing.Color.MintCream;
            this.btnEditSection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditSection.IconSize = 40;
            this.btnEditSection.Location = new System.Drawing.Point(0, 351);
            this.btnEditSection.Name = "btnEditSection";
            this.btnEditSection.Size = new System.Drawing.Size(514, 65);
            this.btnEditSection.TabIndex = 5;
            this.btnEditSection.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEditSection.UseVisualStyleBackColor = false;
            this.btnEditSection.Click += new System.EventHandler(this.btnEditSection_Click);
            // 
            // picWallpaper
            // 
            this.picWallpaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picWallpaper.Image = global::Ma.Ui.Properties.Resources.wp7528754_minimalist_forest_wallpapers;
            this.picWallpaper.Location = new System.Drawing.Point(523, 3);
            this.picWallpaper.Name = "picWallpaper";
            this.picWallpaper.Size = new System.Drawing.Size(255, 416);
            this.picWallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWallpaper.TabIndex = 2;
            this.picWallpaper.TabStop = false;
            // 
            // ltpButtonSection
            // 
            this.ltpButtonSection.ColumnCount = 1;
            this.ltpButtonSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ltpButtonSection.Controls.Add(this.btnReload, 0, 0);
            this.ltpButtonSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.ltpButtonSection.Location = new System.Drawing.Point(20, 30);
            this.ltpButtonSection.Name = "ltpButtonSection";
            this.ltpButtonSection.RowCount = 1;
            this.ltpButtonSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ltpButtonSection.Size = new System.Drawing.Size(781, 71);
            this.ltpButtonSection.TabIndex = 5;
            // 
            // btnReload
            // 
            this.btnReload.AutoSize = true;
            this.btnReload.BackColor = System.Drawing.Color.Teal;
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.btnReload.IconColor = System.Drawing.Color.MintCream;
            this.btnReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReload.IconSize = 40;
            this.btnReload.Location = new System.Drawing.Point(3, 3);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(775, 65);
            this.btnReload.TabIndex = 4;
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click_1);
            // 
            // StockControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMainContainer);
            this.Name = "StockControl";
            this.Load += new System.EventHandler(this.StockControl_Load);
            this.Controls.SetChildIndex(this.pnlMainContainer, 0);
            this.pnlMainContainer.ResumeLayout(false);
            this.tlpContentAsideDiv.ResumeLayout(false);
            this.pnlDummyMain.ResumeLayout(false);
            this.pnlMeLiSection.ResumeLayout(false);
            this.pnlMeLiSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWallpaper)).EndInit();
            this.ltpButtonSection.ResumeLayout(false);
            this.ltpButtonSection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainContainer;
        private FontAwesome.Sharp.IconButton btnMeliSection;
        private System.Windows.Forms.Panel pnlContentSection;
        private System.Windows.Forms.TableLayoutPanel ltpButtonSection;
        private FontAwesome.Sharp.IconButton btnEditSection;
        private System.Windows.Forms.TableLayoutPanel tlpContentAsideDiv;
        private System.Windows.Forms.PictureBox picWallpaper;
        private System.Windows.Forms.Panel pnlDummyMain;
        private System.Windows.Forms.Panel pnlMeLiSection;
        private FontAwesome.Sharp.IconButton btnReload;
    }
}