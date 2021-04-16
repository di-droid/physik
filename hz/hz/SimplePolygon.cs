using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hz
{
    public class SimplePolygon : Figyru
    {
        private Brush brush { get; set; }

        public SimplePolygon(float PenThickness, Color PenColor, Color FillColor) : base(PenThickness, PenColor) 
        {
            brush = new SolidBrush(FillColor);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillPolygon(brush, points);
            graphics.DrawPolygon(pen, points);
        }
    }
}
