namespace BookmarksApp
{
    partial class ShowBookmark
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
            this.lblHello = new System.Windows.Forms.Label();
            this.gridBookmarks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridBookmarks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHello.Location = new System.Drawing.Point(274, 51);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(71, 24);
            this.lblHello.TabIndex = 0;
            this.lblHello.Text = "Hello, ";
            // 
            // gridBookmarks
            // 
            this.gridBookmarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBookmarks.Location = new System.Drawing.Point(104, 110);
            this.gridBookmarks.Name = "gridBookmarks";
            this.gridBookmarks.Size = new System.Drawing.Size(552, 289);
            this.gridBookmarks.TabIndex = 1;
            // 
            // ShowBookmark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 514);
            this.Controls.Add(this.gridBookmarks);
            this.Controls.Add(this.lblHello);
            this.Name = "ShowBookmark";
            this.Text = "ShowBookmark";
            this.Load += new System.EventHandler(this.ShowBookmark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBookmarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.DataGridView gridBookmarks;
    }
}