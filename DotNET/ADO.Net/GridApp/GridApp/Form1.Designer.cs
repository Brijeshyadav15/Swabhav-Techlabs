namespace GridApp
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
            this.components = new System.ComponentModel.Container();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.empGrid = new System.Windows.Forms.DataGridView();
            this.techlabsDataSet = new GridApp.TechlabsDataSet();
            this.techlabsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techlabsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techlabsDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPopulate
            // 
            this.btnPopulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopulate.Location = new System.Drawing.Point(310, 76);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(174, 54);
            this.btnPopulate.TabIndex = 0;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // empGrid
            // 
            this.empGrid.AutoGenerateColumns = false;
            this.empGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empGrid.DataSource = this.techlabsDataSetBindingSource;
            this.empGrid.Location = new System.Drawing.Point(160, 185);
            this.empGrid.Name = "empGrid";
            this.empGrid.Size = new System.Drawing.Size(494, 186);
            this.empGrid.TabIndex = 1;
            // 
            // techlabsDataSet
            // 
            this.techlabsDataSet.DataSetName = "TechlabsDataSet";
            this.techlabsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // techlabsDataSetBindingSource
            // 
            this.techlabsDataSetBindingSource.DataSource = this.techlabsDataSet;
            this.techlabsDataSetBindingSource.Position = 0;
            // 
            // frmGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 459);
            this.Controls.Add(this.empGrid);
            this.Controls.Add(this.btnPopulate);
            this.Name = "frmGrid";
            this.Text = "Grid App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techlabsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techlabsDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.DataGridView empGrid;
        private System.Windows.Forms.BindingSource techlabsDataSetBindingSource;
        private TechlabsDataSet techlabsDataSet;
    }
}

