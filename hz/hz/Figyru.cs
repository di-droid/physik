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
    public abstract class Figyru
    {
        [DataMember]
        public Point[] points;
        [DataMember]
        public Color penColor;
        [DataMember]
        public float penThickness;

        protected Pen pen { get; set; }

        protected void SetPen ()
        {
            pen = new Pen(penColor, penThickness);
        }

        public Figyru(float PenThickness, Color PenColor)
        {
            this.penColor = PenColor;
            this.penThickness = PenThickness;
            pen = new Pen(PenColor, PenThickness);
        }

        public abstract void Draw(Graphics graphics);
    }
}
