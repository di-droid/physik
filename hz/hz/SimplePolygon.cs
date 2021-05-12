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
    public class SimplePolygon : Figyru
    {
        [DataMember]
        private Brush brush { get; set; }

        public SimplePolygon(float PenThickness, Color PenColor, Color FillColor) : base(PenThickness, PenColor) 
        {
            brush = new SolidBrush(FillColor);
        }

        public override void Draw(Graphics graphics)
        {
            SetPen();

            graphics.FillPolygon(brush, points);
            graphics.DrawPolygon(pen, points);
        }
    }
}
