using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace hz
{ 
    public interface ICreator
    {
        bool corners { get; }
        bool mouseClick { get; }
        Figyru GetFigyru(float PenThickness, Color PenColor, Color FillColor);
    }
}
