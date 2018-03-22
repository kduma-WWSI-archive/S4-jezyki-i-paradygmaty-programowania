using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDG
{
    public partial class EDGForm : Form
    {
        public EDGForm()
        {
            InitializeComponent();
        }

        private void MKaskadowo_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MPionowo_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void MPoziomio_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void MZamknijWszystkie_Click(object sender, EventArgs e)
        {
            foreach (var window in MdiChildren)
            {
                window.Close();
            }
        }

        private void MWyodrebnijAktywne_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild == null)
                return;

            var form = ActiveMdiChild;
            form.MdiParent = null;
            form.Show();
        }

        private void MNowy_Click(object sender, EventArgs e)
        {
            var form = new Dokument
            {
                MdiParent = this,
                Text = "Plik " + MdiChildren.Count()
            };
            form.Show();
        }

        private void MZamknij_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MOtworz_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() != DialogResult.OK) return;

            var dok = new Dokument
            {
                MdiParent = this,
                Text = OFD.FileName
            };

            dok.UstawZdjecie(OFD.FileName);
            dok.Show();
        }

        private void EDGForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!MdiChildren.Any()) return;

            switch (MessageBox.Show("Nie zamknięto wszystkich okien programu, czy aby napewno chcesz kontynuowac?", "Zamykanie Programu.", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1))
            {
                case DialogResult.Yes:
                    break;

                case DialogResult.No:
                    e.Cancel = true;
                    break;
            }
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dialog = new AboutBox1();
            dialog.ShowDialog();
        }
    }
}
