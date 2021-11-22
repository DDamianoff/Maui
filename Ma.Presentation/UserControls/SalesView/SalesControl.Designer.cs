using System.ComponentModel;

namespace Ma.UI.UserControls.SalesView
{
    partial class SalesControl
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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.spcProducts = new System.Windows.Forms.SplitContainer();
            this.pnlDummy2 = new System.Windows.Forms.Panel();
            this.pnlProductList = new System.Windows.Forms.Panel();
            this.pnlDummy = new System.Windows.Forms.Panel();
            this.btnReload = new FontAwesome.Sharp.IconButton();
            this.pnlShellSection = new System.Windows.Forms.Panel();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcProducts)).BeginInit();
            this.spcProducts.Panel1.SuspendLayout();
            this.spcProducts.Panel2.SuspendLayout();
            this.spcProducts.SuspendLayout();
            this.pnlDummy2.SuspendLayout();
            this.pnlDummy.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(32)))), ((int)(((byte)(28)))));
            this.pnlContainer.Controls.Add(this.spcProducts);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 55);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.pnlContainer.Size = new System.Drawing.Size(821, 543);
            this.pnlContainer.TabIndex = 1;
            // 
            // spcProducts
            // 
            this.spcProducts.Cursor = System.Windows.Forms.Cursors.Default;
            this.spcProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcProducts.Location = new System.Drawing.Point(20, 30);
            this.spcProducts.Name = "spcProducts";
            // 
            // spcProducts.Panel1
            // 
            this.spcProducts.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(251)))));
            this.spcProducts.Panel1.Controls.Add(this.pnlDummy2);
            // 
            // spcProducts.Panel2
            // 
            this.spcProducts.Panel2.Controls.Add(this.pnlShellSection);
            this.spcProducts.Size = new System.Drawing.Size(781, 493);
            this.spcProducts.SplitterDistance = 336;
            this.spcProducts.SplitterIncrement = 10;
            this.spcProducts.SplitterWidth = 10;
            this.spcProducts.TabIndex = 0;
            // 
            // pnlDummy2
            // 
            this.pnlDummy2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(251)))));
            this.pnlDummy2.Controls.Add(this.pnlProductList);
            this.pnlDummy2.Controls.Add(this.pnlDummy);
            this.pnlDummy2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDummy2.Location = new System.Drawing.Point(0, 0);
            this.pnlDummy2.Name = "pnlDummy2";
            this.pnlDummy2.Size = new System.Drawing.Size(336, 493);
            this.pnlDummy2.TabIndex = 1;
            // 
            // pnlProductList
            // 
            this.pnlProductList.AutoScroll = true;
            this.pnlProductList.AutoSize = true;
            this.pnlProductList.BackColor = System.Drawing.Color.Transparent;
            this.pnlProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductList.Location = new System.Drawing.Point(0, 100);
            this.pnlProductList.Name = "pnlProductList";
            this.pnlProductList.Size = new System.Drawing.Size(336, 393);
            this.pnlProductList.TabIndex = 1;
            // 
            // pnlDummy
            // 
            this.pnlDummy.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlDummy.Controls.Add(this.btnReload);
            this.pnlDummy.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDummy.Location = new System.Drawing.Point(0, 0);
            this.pnlDummy.Name = "pnlDummy";
            this.pnlDummy.Size = new System.Drawing.Size(336, 100);
            this.pnlDummy.TabIndex = 1;
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
            this.btnReload.Location = new System.Drawing.Point(0, 0);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(336, 100);
            this.btnReload.TabIndex = 2;
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // pnlShellSection
            // 
            this.pnlShellSection.BackColor = System.Drawing.Color.Transparent;
            this.pnlShellSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShellSection.Location = new System.Drawing.Point(0, 0);
            this.pnlShellSection.Name = "pnlShellSection";
            this.pnlShellSection.Size = new System.Drawing.Size(435, 493);
            this.pnlShellSection.TabIndex = 0;
            // 
            // SalesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContainer);
            this.Name = "SalesControl";
            this.Controls.SetChildIndex(this.pnlContainer, 0);
            this.pnlContainer.ResumeLayout(false);
            this.spcProducts.Panel1.ResumeLayout(false);
            this.spcProducts.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcProducts)).EndInit();
            this.spcProducts.ResumeLayout(false);
            this.pnlDummy2.ResumeLayout(false);
            this.pnlDummy2.PerformLayout();
            this.pnlDummy.ResumeLayout(false);
            this.pnlDummy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.SplitContainer spcProducts;
        private System.Windows.Forms.Panel pnlProductList;
        private FontAwesome.Sharp.IconButton btnReload;
        private System.Windows.Forms.Panel pnlDummy;
        private System.Windows.Forms.Panel pnlDummy2;
        private System.Windows.Forms.Panel pnlShellSection;
    }
}