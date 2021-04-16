using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hz
{
    public abstract class Figyru
    {
        public Point[] points;
        public Pen pen { get; set; }

        public Figyru(float PenThickness, Color PenColor)
        {
            pen = new Pen(PenColor, PenThickness);
        }

        public abstract void Draw(Graphics graphics);
    }
}
