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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGreetingUser = new System.Windows.Forms.Label();
            this.picSmile = new FontAwesome.Sharp.IconPictureBox();
            this.lblGreetingDummy = new System.Windows.Forms.Label();
            this.pnlCcontainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSmile)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCcontainer
            // 
            this.pnlCcontainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCcontainer.BackgroundImage")));
            this.pnlCcontainer.Controls.Add(this.panel1);
            this.pnlCcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCcontainer.Font = new System.Drawing.Font("Simplifica", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlCcontainer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.pnlCcontainer.Location = new System.Drawing.Point(0, 55);
            this.pnlCcontainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCcontainer.Name = "pnlCcontainer";
            this.pnlCcontainer.Padding = new System.Windows.Forms.Padding(30, 30, 40, 30);
            this.pnlCcontainer.Size = new System.Drawing.Size(821, 543);
            this.pnlCcontainer.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblGreetingUser);
            this.panel1.Controls.Add(this.picSmile);
            this.panel1.Controls.Add(this.lblGreetingDummy);
            this.panel1.Location = new System.Drawing.Point(30, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 194);
            this.panel1.TabIndex = 2;
            // 
            // lblGreetingUser
            // 
            this.lblGreetingUser.AutoSize = true;
            this.lblGreetingUser.Location = new System.Drawing.Point(3, 95);
            this.lblGreetingUser.Name = "lblGreetingUser";
            this.lblGreetingUser.Size = new System.Drawing.Size(126, 79);
            this.lblGreetingUser.TabIndex = 1;
            this.lblGreetingUser.Text = "User";
            // 
            // picSmile
            // 
            this.picSmile.BackColor = System.Drawing.Color.Transparent;
            this.picSmile.Dock = System.Windows.Forms.DockStyle.Right;
            this.picSmile.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.picSmile.IconChar = FontAwesome.Sharp.IconChar.Gripfire;
            this.picSmile.IconColor = System.Drawing.Color.DarkSlateGray;
            this.picSmile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picSmile.IconSize = 169;
            this.picSmile.Location = new System.Drawing.Point(445, 0);
            this.picSmile.Name = "picSmile";
            this.picSmile.Size = new System.Drawing.Size(169, 194);
            this.picSmile.TabIndex = 1;
            this.picSmile.TabStop = false;
            // 
            // lblGreetingDummy
            // 
            this.lblGreetingDummy.AutoSize = true;
            this.lblGreetingDummy.Location = new System.Drawing.Point(0, 0);
            this.lblGreetingDummy.Name = "lblGreetingDummy";
            this.lblGreetingDummy.Size = new System.Drawing.Size(365, 79);
            this.lblGreetingDummy.TabIndex = 0;
            this.lblGreetingDummy.Text = "Que bueno verte,";
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCcontainer);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "HomeControl";
            this.Controls.SetChildIndex(this.pnlCcontainer, 0);
            this.pnlCcontainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSmile)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlCcontainer;
        #endregion
        private System.Windows.Forms.Label lblGreetingDummy;
        private FontAwesome.Sharp.IconPictureBox picSmile;
        public System.Windows.Forms.Label lblGreetingUser;
        private System.Windows.Forms.Panel panel1;
    }
}