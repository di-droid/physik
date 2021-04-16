using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hz
{
    public class BrokenLine : Figyru
    {

        public BrokenLine(float PenThickness, Color PenColor) : base(PenThickness, PenColor) { }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLines(pen, points);
        }
    }
}
