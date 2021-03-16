using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hz
{
    class Line : Figyru
    {
        public Line(float PenThickness, Color PenColor, Point startpoint, Point finishpoint) : base(PenThickness, PenColor)
        {
            this.startpoint = startpoint;
            this.finishpoint = finishpoint;
        }

        public override void Draw(Graphics graphics) 
        {
            graphics.DrawLine(pen, startpoint, finishpoint);
        }
    }
}
