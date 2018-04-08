using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Mapa
{
    public class Droga
    {
        public List<PointF> Punkty { get; set; }
        private readonly Pen _bialaLinia;
        private readonly Pen _asfalt;

        public Droga()
        {
            Punkty = new List<PointF>();

            _bialaLinia = new Pen(Color.White)
            {
                DashStyle = DashStyle.Dash
            };

            _asfalt = new Pen(Color.DarkGray, 20)
            {
                StartCap = LineCap.Round,
                EndCap = LineCap.Round,
                LineJoin = LineJoin.Round
            };
        }

        public void Rysuj(Graphics g)
        {
            g.DrawLines(_asfalt, Punkty.ToArray());
            g.DrawLines(_bialaLinia, Punkty.ToArray());
        } 

    }
}