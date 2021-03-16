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
        public Brush brush { get; set; }
        
        public PointF[] corners { get; set; } 

        public Pollygon(float PenThickness, Color PenColor, Color FillColor, int numbersOfCorners, Point startpoint, float radius) : base(PenThickness, PenColor)
        {
            brush = new SolidBrush(FillColor);
            this.startpoint = startpoint;

            double angle = Math.PI * 2 / numbersOfCorners;
            corners = Enumerable.Range(0, numbersOfCorners).Select(i => PointF.Add(startpoint, new SizeF((float)Math.Sin(i * angle) * radius, (float)Math.Cos(i * angle) * radius))).ToArray();
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawPolygon(pen, corners);
            graphics.FillPolygon(brush, corners);
        }
    }
}
