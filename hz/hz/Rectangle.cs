using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hz
{
    class Rectangle : Figyru
    {
        private Brush brush { get; set; }
        private Point startpoint { get; set; }
        private Point finishpoint { get; set; }


        private Rectangle (float PenThickness, Color PenColor, Color FillColor, Point startpoint, Point finishpoint) : base(PenThickness, PenColor)
        {
            brush = new SolidBrush(FillColor);
            this.startpoint = startpoint;
            this.finishpoint = finishpoint;
               
        }

        public override void Draw(Graphics graphics)
        {
            Point LeftPoint = new Point(Math.Min(startpoint.X, finishpoint.X), Math.Min(startpoint.Y, finishpoint.Y));
            Point RightPoint = new Point(Math.Max(startpoint.X, finishpoint.X), Math.Max(startpoint.Y, finishpoint.Y));

            graphics.DrawRectangle(pen, LeftPoint.X, LeftPoint.Y, RightPoint.X - LeftPoint.X, RightPoint.Y - LeftPoint.Y);
            graphics.FillRectangle(brush, LeftPoint.X, LeftPoint.Y, RightPoint.X - LeftPoint.X, RightPoint.Y - LeftPoint.Y);
        }
    }
}
