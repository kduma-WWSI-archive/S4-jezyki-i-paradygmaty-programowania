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

            Pozycja.Text = $@"Pozycja {auto.X:0} x {auto.Y:0} < {auto.Kierunek%360:0}";
        }

        private readonly StanyKlawiszy _klawisze = new StanyKlawiszy();

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_klawisze.Left)
                auto.SkrecajLewo();

            if (_klawisze.Right)
                auto.SkrecajPrawo();

            if (_klawisze.Up)
                auto.Gaz();

            if (_klawisze.Down)
                auto.Hamuj();

            auto.Dzialaj(0.02);
            Refresh();
        }



        private void MapaForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    _klawisze.Left = true;
                    break;

                case Keys.Up:
                    _klawisze.Up = true;
                    break;

                case Keys.Right:
                    _klawisze.Right = true;
                    break;

                case Keys.Down:
                    _klawisze.Down = true;
                    break;
            }
            
        }

        private void MapaForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    _klawisze.Left = false;
                    break;

                case Keys.Up:
                    _klawisze.Up = false;
                    break;

                case Keys.Right:
                    _klawisze.Right = false;
                    break;

                case Keys.Down:
                    _klawisze.Down = false;
                    break;
            }
        }
    }
}
