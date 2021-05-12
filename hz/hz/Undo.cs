using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;

namespace hz
{
    [DataContract]
    public class Undo
    {
        [DataMember]
        private List<Figyru> figureList;
        public void Add(Figyru figyru)
        {
            figureList.Add(figyru);
        }

        public void Drawing(Graphics graphics)
        {
            foreach (var figyru in figureList)
            {
                figyru.Draw(graphics);
            }
        }

        public Undo()
        {
            figureList = new List<Figyru>();
        }

        public Figyru Remove()
        {
            Figyru temp = figureList.Last();
            figureList.Remove(figureList.Last());
            return temp;
        }

        public bool IsEmpty()
        {
            if (figureList.Count == 0)
                return false;

            return true;
        }
            
    }

}

