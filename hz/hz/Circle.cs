using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hz
{
    public class Circle : Figyru
    {
        private Brush brush { get; set; }

        public Circle(float PenThickness, Color PenColor, Color FillColor) : base(PenThickness, PenColor) 
        {
            brush = new SolidBrush(FillColor); 
        }

        public override void Draw(Graphics graphics)
        {
            int width = points[1].X - points[0].X;
            int height = points[1].Y - points[0].Y;

            graphics.FillEllipse(brush, points[0].X, points[0].Y, width, height);
            graphics.DrawEllipse(pen, points[0].X, points[0].Y, width, height);
        }
    }
}
