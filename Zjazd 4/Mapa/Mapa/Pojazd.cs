using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapa
{
    class Pojazd
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double V { get; set; }
        public double Kierunek { get; set; }
        private readonly Image obraz;

        public Pojazd()
        {
            obraz = Image.FromFile("Images\\auto_czerwone.png");
        }

        public void Rysuj(Graphics g)
        {
            var m = g.Transform;

            g.TranslateTransform((float)X, (float)Y);
            g.RotateTransform((float)Kierunek+90);
            g.ScaleTransform(0.08f, 0.08f);
            // ReSharper disable once PossibleLossOfFraction
            g.DrawImage(obraz, -obraz.Width/2, y: -obraz.Height/1.1f);

            g.Transform = m;
        }
    }
}
