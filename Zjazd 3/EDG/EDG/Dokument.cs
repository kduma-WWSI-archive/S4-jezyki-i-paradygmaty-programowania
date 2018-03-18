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
    public partial class Dokument : Form
    {
        public Dokument()
        {
            InitializeComponent();

            LUserName.Text = System.Environment.UserName;
        }

        public void UstawZdjecie(string nazwaPliku)
        {
            DocumentPictureBox.Image = Image.FromFile(nazwaPliku);
        }

        private void BColor_Click(object sender, EventArgs e)
        {
            // TODO: 2.a.i.1.a - Color Dialog
        }

        private void BFont_Click(object sender, EventArgs e)
        {
            // TODO: 2.a.i.2.a - Font Dialog
        }

        private void PB_Resize(object sender, EventArgs e)
        {
            LSize.Text = $"Rozmiar ({DocumentPictureBox.Width} x {DocumentPictureBox.Height})";
        }

        private void PB_MouseMove(object sender, MouseEventArgs e)
        {
            LMousePosition.Text = $"Kursor ({e.X} x {e.Y})";
        }
    }
}
