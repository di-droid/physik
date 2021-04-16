using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace hz
{
    public class PolygonCreator : ICreator
    {
        public Figyru GetFigyru(float PenThickness, Color PenColor, Color FillColor)
        {
            return new Polygon(PenThickness, PenColor, FillColor);
        }
        public bool corners { get { return true; } }
        public bool mouseClick { get { return false; } }
    }
}
