using System.ComponentModel;

namespace Ma.UI.UserControls.HomeView
{
    partial class HomeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControl));
            this.pnlCcontainer = new System.Windows.Forms.Panel();
            this.picKakuy = new System.Windows.Forms.PictureBox();
            this.pnlImageContainer = new System.Windows.Forms.Panel();
            this.pnlCcontainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picKakuy)).BeginInit();
            this.pnlImageContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCcontainer
            // 
            this.pnlCcontainer.Controls.Add(this.pnlImageContainer);
            this.pnlCcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCcontainer.Location = new System.Drawing.Point(0, 54);
            this.pnlCcontainer.Name = "pnlCcontainer";
            this.pnlCcontainer.Size = new System.Drawing.Size(704, 464);
            this.pnlCcontainer.TabIndex = 2;
            // 
            // picKakuy
            // 
            this.picKakuy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picKakuy.Image = ((System.Drawing.Image) (resources.GetObject("picKakuy.Image")));
            this.picKakuy.Location = new System.Drawing.Point(0, 113);
            this.picKakuy.Name = "picKakuy";
            this.picKakuy.Size = new System.Drawing.Size(258, 351);
            this.picKakuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKakuy.TabIndex = 0;
            this.picKakuy.TabStop = false;
            // 
            // pnlImageContainer
            // 
            this.pnlImageContainer.Controls.Add(this.picKakuy);
            this.pnlImageContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlImageContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlImageContainer.Name = "pnlImageContainer";
            this.pnlImageContainer.Size = new System.Drawing.Size(258, 464);
            this.pnlImageContainer.TabIndex = 1;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCcontainer);
            this.Name = "HomeControl";
            this.Controls.SetChildIndex(this.pnlCcontainer, 0);
            this.pnlCcontainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picKakuy)).EndInit();
            this.pnlImageContainer.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlImageContainer;

        private System.Windows.Forms.PictureBox picKakuy;

        private System.Windows.Forms.Panel pnlCcontainer;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}