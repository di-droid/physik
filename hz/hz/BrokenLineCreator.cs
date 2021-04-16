using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace hz
{
    public class BrokenLineCreator : ICreator
    {
        public Figyru GetFigyru(float PenThickness, Color PenColor, Color FillColor)
        {
            return new BrokenLine(PenThickness, PenColor);
        }
        public bool corners { get { return false;  } }
        public bool mouseClick { get { return true;  } }
    }
}
