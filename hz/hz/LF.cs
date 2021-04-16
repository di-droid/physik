using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace hz
{
    public class LF
    {
        private List<Figyru> figyrusList;
        public void Dobavit(Figyru figyru) 
        {
            figyrusList.Add(figyru);
        }

        public void Drawing(Graphics graphics) 
        {
            foreach (var figyru in figyrusList)
            {
                figyru.Draw(graphics);
            }
        }

        public LF() 
        {
            figyrusList = new List<Figyru>();
        }
    }
}
