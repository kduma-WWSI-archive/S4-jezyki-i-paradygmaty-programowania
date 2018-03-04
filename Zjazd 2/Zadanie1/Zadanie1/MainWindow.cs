using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
      
        private void MWLoad(object sender, EventArgs e)
        {
            // TODO: Directory.GetFiles(".", "*.txt");
            var p = Pracownik.Otworz("12345678901");
            LBPracownicy.Items.Add(p);

            p = Pracownik.Otworz("12345678902");
            p.Imie = "Ignacy";
            p.Nazwisko = "Krasicki";
            LBPracownicy.Items.Add(p);

            p = Pracownik.Otworz("12345678903");
            p.Imie = "Ewa";
            p.Nazwisko = "Nowak";
            LBPracownicy.Items.Add(p);
        }
    }
}
