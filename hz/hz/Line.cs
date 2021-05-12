using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace hz
{
    [DataContract]
    public class Line : Figyru
    {
        public Line(float PenThickness, Color PenColor) : base(PenThickness, PenColor) { }

        public override void Draw(Graphics graphics) 
        {
            SetPen();

            graphics.DrawLine(pen, points[0], points[1]);
        }  
    }
}
