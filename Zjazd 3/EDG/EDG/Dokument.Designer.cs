﻿namespace EDG
{
    partial class Dokument
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LFont = new System.Windows.Forms.Label();
            this.BFont = new System.Windows.Forms.Button();
            this.BColor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.LMousePosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.LSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.DocumentPictureBox = new System.Windows.Forms.PictureBox();
            this.CD = new System.Windows.Forms.ColorDialog();
            this.FD = new System.Windows.Forms.FontDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chartreuse;
            this.panel1.Controls.Add(this.LFont);
            this.panel1.Controls.Add(this.BFont);
            this.panel1.Controls.Add(this.BColor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(119, 566);
            this.panel1.TabIndex = 0;
            // 
            // LFont
            // 
            this.LFont.AutoSize = true;
            this.LFont.Dock = System.Windows.Forms.DockStyle.Top;
            this.LFont.Location = new System.Drawing.Point(5, 122);
            this.LFont.Name = "LFont";
            this.LFont.Size = new System.Drawing.Size(51, 13);
            this.LFont.TabIndex = 2;
            this.LFont.Text = "Czcionka";
            // 
            // BFont
            // 
            this.BFont.Dock = System.Windows.Forms.DockStyle.Top;
            this.BFont.Location = new System.Drawing.Point(5, 65);
            this.BFont.Name = "BFont";
            this.BFont.Size = new System.Drawing.Size(109, 57);
            this.BFont.TabIndex = 1;
            this.BFont.Text = "Czcionka";
            this.BFont.UseVisualStyleBackColor = true;
            this.BFont.Click += new System.EventHandler(this.BFont_Click);
            // 
            // BColor
            // 
            this.BColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.BColor.Location = new System.Drawing.Point(5, 5);
            this.BColor.Name = "BColor";
            this.BColor.Size = new System.Drawing.Size(109, 60);
            this.BColor.TabIndex = 0;
            this.BColor.Text = "Kolor";
            this.BColor.UseVisualStyleBackColor = true;
            this.BColor.Click += new System.EventHandler(this.BColor_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(119, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 49);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Narzędzia";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel2,
            this.LUserName,
            this.LMousePosition,
            this.LSize});
            this.statusStrip1.Location = new System.Drawing.Point(119, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(724, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatusLabel1.Text = "Zapisywanie";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(72, 17);
            this.toolStripStatusLabel2.Text = "Zalogowany";
            // 
            // LUserName
            // 
            this.LUserName.Name = "LUserName";
            this.LUserName.Size = new System.Drawing.Size(304, 17);
            this.LUserName.Spring = true;
            this.LUserName.Text = "%USERNAME%";
            this.LUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LMousePosition
            // 
            this.LMousePosition.Name = "LMousePosition";
            this.LMousePosition.Size = new System.Drawing.Size(75, 17);
            this.LMousePosition.Text = "Kursor (0 x 0)";
            // 
            // LSize
            // 
            this.LSize.Name = "LSize";
            this.LSize.Size = new System.Drawing.Size(84, 17);
            this.LSize.Text = "Rozmiar (0 x 0)";
            // 
            // DocumentPictureBox
            // 
            this.DocumentPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentPictureBox.Location = new System.Drawing.Point(119, 49);
            this.DocumentPictureBox.Name = "DocumentPictureBox";
            this.DocumentPictureBox.Size = new System.Drawing.Size(724, 495);
            this.DocumentPictureBox.TabIndex = 3;
            this.DocumentPictureBox.TabStop = false;
            this.DocumentPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_MouseMove);
            this.DocumentPictureBox.Resize += new System.EventHandler(this.PB_Resize);
            // 
            // Dokument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 566);
            this.Controls.Add(this.DocumentPictureBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dokument";
            this.Text = "Dokument";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BColor;
        private System.Windows.Forms.Button BFont;
        private System.Windows.Forms.Label LFont;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel LUserName;
        private System.Windows.Forms.ToolStripStatusLabel LMousePosition;
        private System.Windows.Forms.ToolStripStatusLabel LSize;
        private System.Windows.Forms.PictureBox DocumentPictureBox;
        private System.Windows.Forms.ColorDialog CD;
        private System.Windows.Forms.FontDialog FD;
    }
}