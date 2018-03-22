namespace EDG
{
    partial class EDGForm
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
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MNowy = new System.Windows.Forms.ToolStripMenuItem();
            this.MOtworz = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MZamknij = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopiujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wytnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wklejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MKaskadowo = new System.Windows.Forms.ToolStripMenuItem();
            this.MPionowo = new System.Windows.Forms.ToolStripMenuItem();
            this.MPoziomio = new System.Windows.Forms.ToolStripMenuItem();
            this.oknaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MZamknijWszystkie = new System.Windows.Forms.ToolStripMenuItem();
            this.MWyodrebnijAktywne = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.edytujToolStripMenuItem,
            this.widokToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNowy,
            this.MOtworz,
            this.zapiszToolStripMenuItem,
            this.zapiszJakoToolStripMenuItem,
            this.MZamknij});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // MNowy
            // 
            this.MNowy.Name = "MNowy";
            this.MNowy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.MNowy.Size = new System.Drawing.Size(209, 22);
            this.MNowy.Text = "Nowy";
            this.MNowy.Click += new System.EventHandler(this.MNowy_Click);
            // 
            // MOtworz
            // 
            this.MOtworz.Name = "MOtworz";
            this.MOtworz.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MOtworz.Size = new System.Drawing.Size(209, 22);
            this.MOtworz.Text = "Otwórz";
            this.MOtworz.Click += new System.EventHandler(this.MOtworz_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Enabled = false;
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            // 
            // zapiszJakoToolStripMenuItem
            // 
            this.zapiszJakoToolStripMenuItem.Enabled = false;
            this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
            this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako...";
            // 
            // MZamknij
            // 
            this.MZamknij.Name = "MZamknij";
            this.MZamknij.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.MZamknij.Size = new System.Drawing.Size(209, 22);
            this.MZamknij.Text = "Zamknij Program";
            this.MZamknij.Click += new System.EventHandler(this.MZamknij_Click);
            // 
            // edytujToolStripMenuItem
            // 
            this.edytujToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kopiujToolStripMenuItem,
            this.wytnijToolStripMenuItem,
            this.wklejToolStripMenuItem,
            this.usuńToolStripMenuItem});
            this.edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            this.edytujToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.edytujToolStripMenuItem.Text = "Edytuj";
            // 
            // kopiujToolStripMenuItem
            // 
            this.kopiujToolStripMenuItem.Enabled = false;
            this.kopiujToolStripMenuItem.Name = "kopiujToolStripMenuItem";
            this.kopiujToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopiujToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.kopiujToolStripMenuItem.Text = "Kopiuj";
            // 
            // wytnijToolStripMenuItem
            // 
            this.wytnijToolStripMenuItem.Enabled = false;
            this.wytnijToolStripMenuItem.Name = "wytnijToolStripMenuItem";
            this.wytnijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.wytnijToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.wytnijToolStripMenuItem.Text = "Wytnij";
            // 
            // wklejToolStripMenuItem
            // 
            this.wklejToolStripMenuItem.Enabled = false;
            this.wklejToolStripMenuItem.Name = "wklejToolStripMenuItem";
            this.wklejToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.wklejToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.wklejToolStripMenuItem.Text = "Wklej";
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Enabled = false;
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.usuńToolStripMenuItem.Text = "Usuń";
            // 
            // widokToolStripMenuItem
            // 
            this.widokToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MKaskadowo,
            this.MPionowo,
            this.MPoziomio,
            this.oknaToolStripMenuItem});
            this.widokToolStripMenuItem.Name = "widokToolStripMenuItem";
            this.widokToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.widokToolStripMenuItem.Text = "Widok";
            // 
            // MKaskadowo
            // 
            this.MKaskadowo.Name = "MKaskadowo";
            this.MKaskadowo.Size = new System.Drawing.Size(187, 22);
            this.MKaskadowo.Text = "Rozmieść Kaskadowo";
            this.MKaskadowo.Click += new System.EventHandler(this.MKaskadowo_Click);
            // 
            // MPionowo
            // 
            this.MPionowo.Name = "MPionowo";
            this.MPionowo.Size = new System.Drawing.Size(187, 22);
            this.MPionowo.Text = "Rozmieść Pionowo";
            this.MPionowo.Click += new System.EventHandler(this.MPionowo_Click);
            // 
            // MPoziomio
            // 
            this.MPoziomio.Name = "MPoziomio";
            this.MPoziomio.Size = new System.Drawing.Size(187, 22);
            this.MPoziomio.Text = "Rozmieść Poziomo";
            this.MPoziomio.Click += new System.EventHandler(this.MPoziomio_Click);
            // 
            // oknaToolStripMenuItem
            // 
            this.oknaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MZamknijWszystkie,
            this.MWyodrebnijAktywne});
            this.oknaToolStripMenuItem.Name = "oknaToolStripMenuItem";
            this.oknaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.oknaToolStripMenuItem.Text = "Okna";
            // 
            // MZamknijWszystkie
            // 
            this.MZamknijWszystkie.Name = "MZamknijWszystkie";
            this.MZamknijWszystkie.Size = new System.Drawing.Size(184, 22);
            this.MZamknijWszystkie.Text = "Zamknij Wszystkie";
            this.MZamknijWszystkie.Click += new System.EventHandler(this.MZamknijWszystkie_Click);
            // 
            // MWyodrebnijAktywne
            // 
            this.MWyodrebnijAktywne.Name = "MWyodrebnijAktywne";
            this.MWyodrebnijAktywne.Size = new System.Drawing.Size(184, 22);
            this.MWyodrebnijAktywne.Text = "Wyodrębnij Aktywne";
            this.MWyodrebnijAktywne.Click += new System.EventHandler(this.MWyodrebnijAktywne_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.oProgramieToolStripMenuItem.Text = "O Programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // OFD
            // 
            this.OFD.Filter = "GIF|*.gif|JPG|*.jpg|PNG|*.png";
            // 
            // EDGForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 561);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EDGForm";
            this.Text = "EDG v.1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EDGForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MNowy;
        private System.Windows.Forms.ToolStripMenuItem MOtworz;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MZamknij;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem widokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MKaskadowo;
        private System.Windows.Forms.ToolStripMenuItem MPionowo;
        private System.Windows.Forms.ToolStripMenuItem MPoziomio;
        private System.Windows.Forms.ToolStripMenuItem oknaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MZamknijWszystkie;
        private System.Windows.Forms.ToolStripMenuItem MWyodrebnijAktywne;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.SaveFileDialog SFD;
    }
}

