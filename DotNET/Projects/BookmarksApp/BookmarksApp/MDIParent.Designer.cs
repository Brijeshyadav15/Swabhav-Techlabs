namespace BookmarksApp
{
    partial class MDIParent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.registerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.showMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginMenu,
            this.registerMenu,
            this.addMenu,
            this.showMenu,
            this.exitMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginMenu
            // 
            this.loginMenu.Name = "loginMenu";
            this.loginMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loginMenu.Size = new System.Drawing.Size(49, 20);
            this.loginMenu.Text = "Login";
            this.loginMenu.Click += new System.EventHandler(this.loginMenu_Click);
            // 
            // registerMenu
            // 
            this.registerMenu.Name = "registerMenu";
            this.registerMenu.Size = new System.Drawing.Size(61, 20);
            this.registerMenu.Text = "Register";
            this.registerMenu.Click += new System.EventHandler(this.registerMenu_Click);
            // 
            // addMenu
            // 
            this.addMenu.Name = "addMenu";
            this.addMenu.Size = new System.Drawing.Size(98, 20);
            this.addMenu.Text = "Add Bookmark";
            this.addMenu.Click += new System.EventHandler(this.addMenu_Click);
            // 
            // showMenu
            // 
            this.showMenu.Name = "showMenu";
            this.showMenu.Size = new System.Drawing.Size(105, 20);
            this.showMenu.Text = "Show Bookmark";
            this.showMenu.Click += new System.EventHandler(this.showMenu_Click);
            // 
            // exitMenu
            // 
            this.exitMenu.Name = "exitMenu";
            this.exitMenu.Size = new System.Drawing.Size(37, 20);
            this.exitMenu.Text = "Exit";
            // 
            // MDIParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 474);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIParent";
            this.Text = "MDIParent";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginMenu;
        private System.Windows.Forms.ToolStripMenuItem registerMenu;
        private System.Windows.Forms.ToolStripMenuItem addMenu;
        private System.Windows.Forms.ToolStripMenuItem showMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenu;
    }
}