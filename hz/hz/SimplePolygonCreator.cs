using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace hz
{
    public class SimplePolygonCreator : ICreator
    {
        public Figyru GetFigyru(float PenThickness, Color PenColor, Color FillColor)
        {
            return new SimplePolygon(PenThickness, PenColor, FillColor);
        }
        public bool corners { get { return false; } }
        public bool mouseClick { get { return true; } }
    }
}
