﻿using System;
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
        private readonly Image _obraz;

        public Pojazd()
        {
            _obraz = Image.FromFile("Images\\auto_czerwone.png");
        }

        public void Rysuj(Graphics g)
        {
            var m = g.Transform;

            g.TranslateTransform((float)X, (float)Y);
            g.RotateTransform((float)Kierunek+90);
            g.ScaleTransform(0.08f, 0.08f);
            // ReSharper disable once PossibleLossOfFraction
            g.DrawImage(_obraz, -_obraz.Width/2, -_obraz.Height/1.3f);

            g.Transform = m;
        }

        public void Gaz()
        {
            V += 0.5 + V * 0.01;
        }

        public void Hamuj()
        {
            V -= 0.5 + V * 0.1;
        }

        public void SkrecajLewo()
        {
            Kierunek -= 0.08 * V;
        }

        public void SkrecajPrawo()
        {
            Kierunek += 0.08 * V;
        }

        public void Dzialaj(double dt, int width, int height)
        {
            var dx = V * Math.Cos(Kierunek * Math.PI / 180) * dt;
            var dy = V * Math.Sin(Kierunek * Math.PI / 180) * dt;

            X += dx;
            Y += dy;

            if (X < 0)
                X = width;

            if (Y < 0)
                Y = height;

            if (X > width)
                X = 0;

            if (Y > height)
                Y = 0;
        }
    }
}
