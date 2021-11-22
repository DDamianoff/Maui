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
            this.pnlHeaderReservedSpace = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlHeaderReservedSpace
            // 
            this.pnlHeaderReservedSpace.BackColor = System.Drawing.Color.Silver;
            this.pnlHeaderReservedSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderReservedSpace.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderReservedSpace.Name = "pnlHeaderReservedSpace";
            this.pnlHeaderReservedSpace.Size = new System.Drawing.Size(821, 55);
            this.pnlHeaderReservedSpace.TabIndex = 0;
            // 
            // MainSectionTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.pnlHeaderReservedSpace);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainSectionTemplate";
            this.Size = new System.Drawing.Size(821, 598);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeaderReservedSpace;
    }
}