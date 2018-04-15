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
        private readonly Droga _droga;
        private readonly Pojazd _auto;
        public MapaForm()
        {
            _auto = new Pojazd()
            {
                X = 200,
                Y = 200,
                Kierunek = 120,
                V = 10
            };

            _droga = new Droga();
            _droga.Punkty.Add(new PointF(20, 20));
            _droga.Punkty.Add(new PointF(200, 20));
            _droga.Punkty.Add(new PointF(200, 120));
            _droga.Punkty.Add(new PointF(250, 200));
            _droga.Punkty.Add(new PointF(50, 120));
            _droga.Punkty.Add(new PointF(20, 50));

            InitializeComponent();
        }

        private void MapaForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.ScaleTransform(3, 3);
            _droga.Rysuj(e.Graphics);
            _auto.Rysuj(e.Graphics);

            Pozycja.Text = $@"Pozycja {_auto.X:0} x {_auto.Y:0} < {_auto.Kierunek%360:0}";
        }

        private readonly HashSet<Keys> _klawisze = new HashSet<Keys>();

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_klawisze.Contains(Keys.Left))
                _auto.SkrecajLewo();

            if (_klawisze.Contains(Keys.Right))
                _auto.SkrecajPrawo();

            if (_klawisze.Contains(Keys.Up))
                _auto.Gaz();

            if (_klawisze.Contains(Keys.Down))
                _auto.Hamuj();

            _auto.Dzialaj(0.02, Width/3, Height/3);
            Refresh();
        }



        private void MapaForm_KeyDown(object sender, KeyEventArgs e)
        {
            _klawisze.Add(e.KeyCode);
        }

        private void MapaForm_KeyUp(object sender, KeyEventArgs e)
        {
            _klawisze.Remove(e.KeyCode);
        }
    }
}
