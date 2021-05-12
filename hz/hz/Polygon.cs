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
    public class Polygon : Figyru
    {
        [DataMember]
        private Brush brush { get; set; }
        [DataMember]
        private PointF[] corners;
        [DataMember]
        public int numOfCorners;


        public Polygon(float PenThickness, Color PenColor, Color FillColor) : base(PenThickness, PenColor) 
        {
            brush = new SolidBrush(FillColor);
        }

        public override void Draw(Graphics graphics)
        {
            SetPen();

            corners = new PointF[numOfCorners];
            corners[0] = points[1];
            PointF o = points[0];
            PointF polar = new PointF(1 * (float)Math.Cos(Math.Acos(-1.0) * 2 / numOfCorners), 1 * (float)Math.Sin(Math.Acos(-1.0) * 2 / numOfCorners));
            PointF radNext = new PointF(points[1].X - o.X, points[1].Y - o.Y);
            PointF temp = new PointF();

            for (int i = 1; i < numOfCorners; i++)
            {
                temp.X = radNext.X * polar.X - radNext.Y * polar.Y;
                temp.Y = radNext.X * polar.Y + radNext.Y * polar.X;

                radNext.X = temp.X;
                radNext.Y = temp.Y;

                corners[i].X = o.X + radNext.X;
                corners[i].Y = o.Y + radNext.Y;
            }

            graphics.FillPolygon(brush, corners);
            graphics.DrawPolygon(pen, corners);
        }
    }
}
