using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hz
{
    public class Rectangle : Figyru
    {
        private Brush brush { get; set; }

        public Rectangle(float PenThickness, Color PenColor, Color FillColor) : base(PenThickness, PenColor) 
        {
            brush = new SolidBrush(FillColor);
        }

        public override void Draw(Graphics graphics)
        {
            Point LeftPoint = new Point(Math.Min(points[0].X, points[1].X), Math.Min(points[0].Y, points[1].Y));
            Point RightPoint = new Point(Math.Max(points[0].X, points[1].X), Math.Max(points[0].Y, points[1].Y));

            graphics.FillRectangle(brush, LeftPoint.X, LeftPoint.Y, RightPoint.X - LeftPoint.X, RightPoint.Y - LeftPoint.Y);
            graphics.DrawRectangle(pen, LeftPoint.X, LeftPoint.Y, RightPoint.X - LeftPoint.X, RightPoint.Y - LeftPoint.Y);
        }
    }
}
