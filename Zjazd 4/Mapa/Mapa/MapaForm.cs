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
        private Droga droga;
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

            droga = new Droga();
            droga.Punkty.Add(new PointF(20, 20));
            droga.Punkty.Add(new PointF(200, 20));
            droga.Punkty.Add(new PointF(200, 120));
            droga.Punkty.Add(new PointF(250, 200));
            droga.Punkty.Add(new PointF(50, 120));
            droga.Punkty.Add(new PointF(20, 50));

            InitializeComponent();
        }

        private void MapaForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.ScaleTransform(3, 3);
            droga.Rysuj(e.Graphics);
            auto.Rysuj(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            auto.Dzialaj(0.02);
            Refresh();
        }

        private void MapaForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    auto.SkrecajLewo();
                    break;

                case Keys.Up:
                    auto.Gaz();
                    break;

                case Keys.Right:
                    auto.SkrecajPrawo();
                    break;

                case Keys.Down:
                    auto.Hamuj();
                    break;
            }
            
        }
    }
}
