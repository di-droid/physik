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

    public class FactoryAttribute : Attribute
    {
        private string toolName;
        public string ToolName { get => toolName; set => toolName = value; }

        public FactoryAttribute() { }
        public FactoryAttribute(string toolName)
        {
            this.toolName = toolName;
        }
    }
}
