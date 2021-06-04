using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using hz;
using System.Drawing;

namespace TrapezoidDll
{
    [DataContract]
    public class Trapezoid : Figyru
    {
        [DataMember]
        private Brush brush { get; set; }

        [DataMember]
        private Point[] vertices;

        public Trapezoid(float PenThickness, Color PenColor, Color FillColor) : base(PenThickness, PenColor)
        {
            brush = new SolidBrush(FillColor);
        }

        public override void Draw(Graphics graphics)
        {
            int width = Math.Abs(points[1].X - points[0].X) / 3;
            vertices = new Point[4] { new Point(points[0].X + width, points[0].Y), new Point(points[1].X - width, points[0].Y),
                                    points[1], new Point(points[0].X, points[1].Y) };
            
            SetPen();

            graphics.FillPolygon(brush, vertices);
            graphics.DrawPolygon(pen, vertices);
        }
    }
}
