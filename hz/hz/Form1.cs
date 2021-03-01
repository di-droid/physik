using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Draw();
        }
        private void Draw ()
        {
            Bitmap bmp = new Bitmap(picture.Width, picture.Height);
            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Blue);
            graph.DrawRectangle(pen, 100, 200, 300, 200);
            graph.DrawLine(pen, 100, 200, 250, 10);
            graph.DrawLine(pen, 500, 500, 450, 100);
            graph.DrawLine(pen, 250, 10, 400, 200);
            Rectangle rect = new Rectangle(100, 200, 300, 200);
            graph.DrawEllipse(pen, rect);
            Point point1 = new Point(250, 200);
            Point point2 = new Point(150, 300);
            Point point3 = new Point(200, 400);
            Point point4 = new Point(300, 400);
            Point point5 = new Point(350, 300);
            Point[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5
             };
            graph.DrawPolygon(pen, curvePoints);
            picture.Image = bmp;
        }
    }
}