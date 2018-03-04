namespace Lab_1
{
    partial class FProductsList
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
            this.DGWProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGWProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // DGWProducts
            // 
            this.DGWProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGWProducts.Location = new System.Drawing.Point(0, 0);
            this.DGWProducts.Name = "DGWProducts";
            this.DGWProducts.Size = new System.Drawing.Size(386, 376);
            this.DGWProducts.TabIndex = 0;
            // 
            // FProductsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 376);
            this.Controls.Add(this.DGWProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FProductsList";
            this.Text = "Lista Produktów";
            ((System.ComponentModel.ISupportInitialize)(this.DGWProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGWProducts;
    }
}