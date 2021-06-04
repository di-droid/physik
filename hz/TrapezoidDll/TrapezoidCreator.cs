using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using hz;

namespace TrapezoidDll
{
    [Factory("Trapezoid")]
    public class TrapezoidCreator : ICreator
    {
        public Figyru GetFigyru(float PenThickness, Color PenColor, Color FillColor)
        {
            return new Trapezoid(PenThickness, PenColor, FillColor);
        }
        public bool corners { get { return false; } }
        public bool mouseClick { get { return false; } }
    }
}
