using System.ComponentModel;

namespace Ma.UI.UserControls
{
    partial class MainSectionTemplate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlVoid = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (81)))), ((int) (((byte) (81)))), ((int) (((byte) (81)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.pnlVoid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Lavender;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 54);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Logger", 27.75F);
            this.lblTitle.Location = new System.Drawing.Point(20, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 54);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Kakuy";
            // 
            // pnlVoid
            // 
            this.pnlVoid.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlVoid.Location = new System.Drawing.Point(0, 0);
            this.pnlVoid.Name = "pnlVoid";
            this.pnlVoid.Size = new System.Drawing.Size(20, 54);
            this.pnlVoid.TabIndex = 1;
            // 
            // MainSectionTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.panel1);
            this.Name = "MainSectionTemplate";
            this.Size = new System.Drawing.Size(704, 518);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel pnlVoid;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}