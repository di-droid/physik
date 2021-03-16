using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hz
{
    class Circle : Figyru
    {
        private Brush brush { get; set; }
        private Point startpoint { get; set; }
        private Point finishpoint { get; set; }


        private Circle(float PenThickness, Color PenColor, Color FillColor, Point startpoint, Point finishpoint) : base(PenThickness, PenColor)
        {
            brush = new SolidBrush(FillColor);
            this.startpoint = startpoint;
            this.finishpoint = finishpoint;
        }

        public override void Draw(Graphics graphics)
        {
            int width = Math.Abs(startpoint.X - finishpoint.X);
            int height = Math.Abs(startpoint.Y - finishpoint.Y);

            graphics.DrawEllipse(pen, startpoint.X, startpoint.Y, width, height);
            graphics.FillEllipse(brush, startpoint.X, startpoint.Y, width, height);
        }
    }
}
