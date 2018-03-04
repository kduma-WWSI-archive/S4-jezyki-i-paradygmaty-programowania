/*
    ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓
    ┃                                                                          ┃
    ┃                           [2018] Krystian Duma                           ┃░░
    ┃                           All Rights Reserved.                           ┃░░
    ┃                                                                          ┃░░
    ┃  NOTICE: All information contained herein is, and remains the property   ┃░░
    ┃   of Krystian Duma. The intellectual and technical concepts contained    ┃░░
    ┃  herein are proprietary to Krystian Duma and may be covered by U.S. and  ┃░░
    ┃  Foreign Patents, patents in process, and are protected by trade secret  ┃░░
    ┃  or copyright law. Dissemination of this information or reproduction of  ┃░░
    ┃  this material is strictly forbidden unless prior written permission is  ┃░░
    ┃                       obtained from Krystian Duma.                       ┃░░
    ┃                                                                          ┃░░
    ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛░░
        ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
        ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
*/

namespace Zadanie1
{
    partial class MainWindow
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
            this.LBPracownicy = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBPracownicy
            // 
            this.LBPracownicy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBPracownicy.FormattingEnabled = true;
            this.LBPracownicy.Location = new System.Drawing.Point(12, 12);
            this.LBPracownicy.Name = "LBPracownicy";
            this.LBPracownicy.Size = new System.Drawing.Size(297, 316);
            this.LBPracownicy.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(325, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(485, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LBPracownicy);
            this.Name = "MainWindow";
            this.Text = "Pracownik.NET Krystian Duma 7763";
            this.Load += new System.EventHandler(this.MWLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LBPracownicy;
        private System.Windows.Forms.Button button1;
    }
}

