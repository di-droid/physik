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
        private ICreator creator;
        private Figyru figyru;
        private List<Point> points;
        private Undo listFigure;
        private Redo figureStack;
        private bool drawing;
        private Point startPoint;
        private Point finishPoint;

        private Color penColor;
        private float penThickness;
        private Color fillColor;

        private int numOfCorners;

        public Form1()
        {
            listFigure = new Undo();
            figureStack = new Redo();
            drawing = false;
            points = new List<Point>();
           
            penColor = Color.Black;
            fillColor = Color.White;

            penThickness = 1;
            numOfCorners = 3;

            InitializeComponent();
        }
      
        private void button6_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnFillColor.BackColor = colorDialog1.Color;
                fillColor = btnFillColor.BackColor;
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btnBrushColor.BackColor = colorDialog1.Color;
                penColor = btnBrushColor.BackColor;
            }

        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            creator = new LineCreator();
        }

        private void btnBrokenLine_Click(object sender, EventArgs e)
        {
            creator = new BrokenLineCreator();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            creator = new RectangleCreator();
        }

        private void btmEllipse_Click(object sender, EventArgs e)
        {
            creator = new CircleCreator();
        }

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            creator = new PolygonCreator();
        }

        private void btnSimplePolygon_Click(object sender, EventArgs e)
        {
            creator = new SimplePolygonCreator();
        }

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            if (creator != null)
            {
                if (!drawing && !creator.mouseClick)
                {
                    figyru = creator.GetFigyru(penThickness, penColor, fillColor);

                    if (creator.corners)
                    {
                        (figyru as Polygon).numOfCorners = numOfCorners;
                    }

                    drawing = !drawing;
                    startPoint.X = e.X;
                    startPoint.Y = e.Y;
                    points.Clear();
                    points.Add(startPoint);
                    points.Add(startPoint);
                }
            }    
        }

        private void picture_Paint(object sender, PaintEventArgs e)
        {       
            listFigure.Drawing(e.Graphics);
            if (drawing)
            {
                figyru.Draw(e.Graphics);
            }
            
        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                finishPoint.X = e.X;
                finishPoint.Y = e.Y;
                points[points.Count - 1] = finishPoint;

                figyru.points = points.ToArray();
                picture.Refresh();
            }
        }

        private void numPenThick_ValueChanged(object sender, EventArgs e)
        {
            penThickness = (float)numPenThick.Value;
            if (figyru != null)
            {
                figyru.pen = new Pen(penColor, penThickness);
            }
        }

        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawing && !creator.mouseClick)
            {
                finishPoint.X = e.X;
                finishPoint.Y = e.Y;

                drawing = !drawing;

                if (startPoint != finishPoint)
                {
                    points[1] = finishPoint;
                    listFigure.Add(figyru);
                    figureStack.CleanStack();
                }
            }
        }

        private void numNumOfCorners_ValueChanged(object sender, EventArgs e)
        {
            numOfCorners = (int)numNumOfCorners.Value;
        }

        private void picture_MouseClick(object sender, MouseEventArgs e)
        {
            if (creator != null)
            {
                if (creator.mouseClick)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        startPoint.X = e.X;
                        startPoint.Y = e.Y;

                        if (!drawing)
                        {
                            figyru = creator.GetFigyru(penThickness, penColor, fillColor);

                            points.Clear();
                            points.Add(startPoint);
                            points.Add(startPoint);
                            drawing = !drawing;

                        }
                        else
                        {
                            points.Add(startPoint);
                        }
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        drawing = !drawing;
                        listFigure.Add(figyru);
                        figureStack.CleanStack();
                    }

                }
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (listFigure.IsEmpty())
            {
                figureStack.Push(listFigure.Remove());
                picture.Refresh();

            }       
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            if (figureStack.IsEmpty())
            {
                listFigure.Add(figureStack.Pop());
                picture.Refresh();
            }
        }
    }
}