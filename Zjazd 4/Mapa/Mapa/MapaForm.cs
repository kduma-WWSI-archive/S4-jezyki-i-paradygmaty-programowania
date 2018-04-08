using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mapa
{
    public partial class MapaForm : Form
    {
        private Droga a1;
        private Pojazd auto;
        public MapaForm()
        {
            auto = new Pojazd()
            {
                X = 200,
                Y = 200,
                Kierunek = 120,
                V = 10
            };

            a1 = new Droga();
            a1.Punkty.Add(new PointF(20, 20));
            a1.Punkty.Add(new PointF(200, 20));
            a1.Punkty.Add(new PointF(200, 120));
            a1.Punkty.Add(new PointF(250, 200));
            a1.Punkty.Add(new PointF(50, 120));
            a1.Punkty.Add(new PointF(20, 50));

            InitializeComponent();
        }

        private void MapaForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.ScaleTransform(3, 3);
            a1.Rysuj(e.Graphics);
            auto.Rysuj(e.Graphics);
        }
    }
}
