using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hz
{
    class Pollygon : Figyru
    {
        private Brush brush { get; set; }
        
        private PointF[] corners { get; set; } 

        private Pollygon(float PenThickness, Color PenColor, Color FillColor, int numbersOfCorners, Point center, float radius) : base(PenThickness, PenColor)
        {
            brush = new SolidBrush(FillColor);
         //   this.corners = corners;

            double angle = Math.PI * 2 / numbersOfCorners;
            corners = Enumerable.Range(0, numbersOfCorners).Select(i => PointF.Add(center, new SizeF((float)Math.Sin(i * angle) * radius, (float)Math.Cos(i * angle) * radius))).ToArray();
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawPolygon(pen, corners);
            graphics.FillPolygon(brush, corners);
        }
    }
}
