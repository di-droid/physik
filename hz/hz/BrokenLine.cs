using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hz
{
    class BrokenLine : Figyru
    {
        private Point[] points { get; set; }

        private BrokenLine(float PenThickness, Color PenColor, Point[] points) : base(PenThickness, PenColor)
        {
            this.points = points;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawPolygon(pen, points);
        }
    }
}
