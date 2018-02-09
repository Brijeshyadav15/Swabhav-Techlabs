namespace GridDataApp
{
    partial class frmGrid
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
            this.btn_Populate = new System.Windows.Forms.Button();
            this.empGrid = new System.Windows.Forms.DataGridView();
            this.deptGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Populate
            // 
            this.btn_Populate.Location = new System.Drawing.Point(269, 66);
            this.btn_Populate.Name = "btn_Populate";
            this.btn_Populate.Size = new System.Drawing.Size(75, 23);
            this.btn_Populate.TabIndex = 0;
            this.btn_Populate.Text = "Populate";
            this.btn_Populate.UseVisualStyleBackColor = true;
            this.btn_Populate.Click += new System.EventHandler(this.btn_Populate_Click);
            // 
            // empGrid
            // 
            this.empGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empGrid.Location = new System.Drawing.Point(12, 121);
            this.empGrid.Name = "empGrid";
            this.empGrid.Size = new System.Drawing.Size(695, 206);
            this.empGrid.TabIndex = 1;
            // 
            // deptGrid
            // 
            this.deptGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deptGrid.Location = new System.Drawing.Point(12, 333);
            this.deptGrid.Name = "deptGrid";
            this.deptGrid.Size = new System.Drawing.Size(377, 179);
            this.deptGrid.TabIndex = 2;
            // 
            // frmGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 535);
            this.Controls.Add(this.deptGrid);
            this.Controls.Add(this.empGrid);
            this.Controls.Add(this.btn_Populate);
            this.Name = "frmGrid";
            this.Text = "Grid App";
            this.Load += new System.EventHandler(this.frmGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deptGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Populate;
        private System.Windows.Forms.DataGridView empGrid;
        private System.Windows.Forms.DataGridView deptGrid;
    }
}

