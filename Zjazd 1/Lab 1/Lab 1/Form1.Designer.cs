namespace Lab_1
{
    partial class Form1
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
            this.TBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBQuanity = new System.Windows.Forms.TextBox();
            this.CBSupplier = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BAdd = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSLQuanity = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMIProductsList = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(91, 35);
            this.TBName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(154, 22);
            this.TBName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ilość";
            // 
            // TBQuanity
            // 
            this.TBQuanity.Location = new System.Drawing.Point(91, 72);
            this.TBQuanity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TBQuanity.Name = "TBQuanity";
            this.TBQuanity.Size = new System.Drawing.Size(154, 22);
            this.TBQuanity.TabIndex = 3;
            this.TBQuanity.TextChanged += new System.EventHandler(this.TBQuanity_TextChanged);
            // 
            // CBSupplier
            // 
            this.CBSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBSupplier.FormattingEnabled = true;
            this.CBSupplier.Items.AddRange(new object[] {
            "Producent 1",
            "Producent 2",
            "Producent 3",
            "Producent 4",
            "Producent 5",
            "Producent 6",
            "Producent 7",
            "Producent 8",
            "Producent 9"});
            this.CBSupplier.Location = new System.Drawing.Point(91, 109);
            this.CBSupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBSupplier.Name = "CBSupplier";
            this.CBSupplier.Size = new System.Drawing.Size(154, 21);
            this.CBSupplier.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Producent";
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(91, 145);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(154, 23);
            this.BAdd.TabIndex = 6;
            this.BAdd.Text = "Dodaj";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Peru;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.TSSLQuanity});
            this.statusStrip1.Location = new System.Drawing.Point(0, 181);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(262, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Peru;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(104, 17);
            this.toolStripStatusLabel1.Text = "Liczba Produktów:";
            // 
            // TSSLQuanity
            // 
            this.TSSLQuanity.BackColor = System.Drawing.Color.Crimson;
            this.TSSLQuanity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TSSLQuanity.Name = "TSSLQuanity";
            this.TSSLQuanity.Size = new System.Drawing.Size(13, 17);
            this.TSSLQuanity.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIProductsList});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(262, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMIProductsList
            // 
            this.TSMIProductsList.Name = "TSMIProductsList";
            this.TSMIProductsList.Size = new System.Drawing.Size(104, 20);
            this.TSMIProductsList.Text = "Lista Produktów";
            this.TSMIProductsList.Click += new System.EventHandler(this.TSMIProductsList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(262, 203);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBSupplier);
            this.Controls.Add(this.TBQuanity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBName);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Magazyn v0.9.1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBQuanity;
        private System.Windows.Forms.ComboBox CBSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel TSSLQuanity;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMIProductsList;
    }
}

