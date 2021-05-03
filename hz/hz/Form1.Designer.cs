
namespace hz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnSimplePolygon = new System.Windows.Forms.Button();
            this.lblBrushColor = new System.Windows.Forms.Label();
            this.lblistFigureillColor = new System.Windows.Forms.Label();
            this.lblNumOfCorners = new System.Windows.Forms.Label();
            this.lblPenThick = new System.Windows.Forms.Label();
            this.butDeserializ = new System.Windows.Forms.Button();
            this.butSerializ = new System.Windows.Forms.Button();
            this.numNumOfCorners = new System.Windows.Forms.NumericUpDown();
            this.numPenThick = new System.Windows.Forms.NumericUpDown();
            this.btnBrushColor = new System.Windows.Forms.Button();
            this.btnFillColor = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btmEllipse = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnBrokenLine = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumOfCorners)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPenThick)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.Location = new System.Drawing.Point(12, 109);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(1234, 546);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Paint += new System.Windows.Forms.PaintEventHandler(this.picture_Paint);
            this.picture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picture_MouseClick);
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.btnRedo);
            this.panel1.Controls.Add(this.btnUndo);
            this.panel1.Controls.Add(this.btnSimplePolygon);
            this.panel1.Controls.Add(this.lblBrushColor);
            this.panel1.Controls.Add(this.lblistFigureillColor);
            this.panel1.Controls.Add(this.lblNumOfCorners);
            this.panel1.Controls.Add(this.lblPenThick);
            this.panel1.Controls.Add(this.butDeserializ);
            this.panel1.Controls.Add(this.butSerializ);
            this.panel1.Controls.Add(this.numNumOfCorners);
            this.panel1.Controls.Add(this.numPenThick);
            this.panel1.Controls.Add(this.btnBrushColor);
            this.panel1.Controls.Add(this.btnFillColor);
            this.panel1.Controls.Add(this.btnPolygon);
            this.panel1.Controls.Add(this.btmEllipse);
            this.panel1.Controls.Add(this.btnRectangle);
            this.panel1.Controls.Add(this.btnBrokenLine);
            this.panel1.Controls.Add(this.btnLine);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 100);
            this.panel1.TabIndex = 1;
            // 
            // btnRedo
            // 
            this.btnRedo.Location = new System.Drawing.Point(1141, 49);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(89, 31);
            this.btnRedo.TabIndex = 17;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(1141, 12);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(89, 31);
            this.btnUndo.TabIndex = 16;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnSimplePolygon
            // 
            this.btnSimplePolygon.Image = ((System.Drawing.Image)(resources.GetObject("btnSimplePolygon.Image")));
            this.btnSimplePolygon.Location = new System.Drawing.Point(297, 25);
            this.btnSimplePolygon.Name = "btnSimplePolygon";
            this.btnSimplePolygon.Size = new System.Drawing.Size(50, 50);
            this.btnSimplePolygon.TabIndex = 15;
            this.btnSimplePolygon.UseVisualStyleBackColor = true;
            this.btnSimplePolygon.Click += new System.EventHandler(this.btnSimplePolygon_Click);
            // 
            // lblBrushColor
            // 
            this.lblBrushColor.AutoSize = true;
            this.lblBrushColor.Location = new System.Drawing.Point(487, 65);
            this.lblBrushColor.Name = "lblBrushColor";
            this.lblBrushColor.Size = new System.Drawing.Size(101, 25);
            this.lblBrushColor.TabIndex = 14;
            this.lblBrushColor.Text = "Brush color";
            // 
            // lblistFigureillColor
            // 
            this.lblistFigureillColor.AutoSize = true;
            this.lblistFigureillColor.Location = new System.Drawing.Point(403, 65);
            this.lblistFigureillColor.Name = "lblistFigureillColor";
            this.lblistFigureillColor.Size = new System.Drawing.Size(78, 25);
            this.lblistFigureillColor.TabIndex = 13;
            this.lblistFigureillColor.Text = "Fill color";
            // 
            // lblNumOfCorners
            // 
            this.lblNumOfCorners.AutoSize = true;
            this.lblNumOfCorners.Location = new System.Drawing.Point(616, 55);
            this.lblNumOfCorners.Name = "lblNumOfCorners";
            this.lblNumOfCorners.Size = new System.Drawing.Size(162, 25);
            this.lblNumOfCorners.TabIndex = 12;
            this.lblNumOfCorners.Text = "Number of corners";
            // 
            // lblPenThick
            // 
            this.lblPenThick.AutoSize = true;
            this.lblPenThick.Location = new System.Drawing.Point(616, 14);
            this.lblPenThick.Name = "lblPenThick";
            this.lblPenThick.Size = new System.Drawing.Size(117, 25);
            this.lblPenThick.TabIndex = 11;
            this.lblPenThick.Text = "Pen thickness";
            // 
            // butDeserializ
            // 
            this.butDeserializ.Location = new System.Drawing.Point(941, 49);
            this.butDeserializ.Name = "butDeserializ";
            this.butDeserializ.Size = new System.Drawing.Size(143, 34);
            this.butDeserializ.TabIndex = 10;
            this.butDeserializ.Text = "Deserialization";
            this.butDeserializ.UseVisualStyleBackColor = true;
            // 
            // butSerializ
            // 
            this.butSerializ.Location = new System.Drawing.Point(941, 9);
            this.butSerializ.Name = "butSerializ";
            this.butSerializ.Size = new System.Drawing.Size(143, 34);
            this.butSerializ.TabIndex = 9;
            this.butSerializ.Text = "Serialization";
            this.butSerializ.UseVisualStyleBackColor = true;
            // 
            // numNumOfCorners
            // 
            this.numNumOfCorners.Location = new System.Drawing.Point(784, 49);
            this.numNumOfCorners.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numNumOfCorners.Name = "numNumOfCorners";
            this.numNumOfCorners.Size = new System.Drawing.Size(59, 31);
            this.numNumOfCorners.TabIndex = 8;
            this.numNumOfCorners.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numNumOfCorners.ValueChanged += new System.EventHandler(this.numNumOfCorners_ValueChanged);
            // 
            // numPenThick
            // 
            this.numPenThick.Location = new System.Drawing.Point(784, 9);
            this.numPenThick.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPenThick.Name = "numPenThick";
            this.numPenThick.Size = new System.Drawing.Size(59, 31);
            this.numPenThick.TabIndex = 7;
            this.numPenThick.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPenThick.ValueChanged += new System.EventHandler(this.numPenThick_ValueChanged);
            // 
            // btnBrushColor
            // 
            this.btnBrushColor.BackColor = System.Drawing.Color.Black;
            this.btnBrushColor.Location = new System.Drawing.Point(508, 12);
            this.btnBrushColor.Name = "btnBrushColor";
            this.btnBrushColor.Size = new System.Drawing.Size(50, 50);
            this.btnBrushColor.TabIndex = 6;
            this.btnBrushColor.UseVisualStyleBackColor = false;
            this.btnBrushColor.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnFillColor
            // 
            this.btnFillColor.BackColor = System.Drawing.Color.White;
            this.btnFillColor.Location = new System.Drawing.Point(418, 12);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(50, 50);
            this.btnFillColor.TabIndex = 5;
            this.btnFillColor.UseVisualStyleBackColor = false;
            this.btnFillColor.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnPolygon
            // 
            this.btnPolygon.Image = ((System.Drawing.Image)(resources.GetObject("btnPolygon.Image")));
            this.btnPolygon.Location = new System.Drawing.Point(241, 25);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(50, 50);
            this.btnPolygon.TabIndex = 4;
            this.btnPolygon.UseVisualStyleBackColor = true;
            this.btnPolygon.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // btmEllipse
            // 
            this.btmEllipse.Image = ((System.Drawing.Image)(resources.GetObject("btmEllipse.Image")));
            this.btmEllipse.Location = new System.Drawing.Point(185, 25);
            this.btmEllipse.Name = "btmEllipse";
            this.btmEllipse.Size = new System.Drawing.Size(50, 50);
            this.btmEllipse.TabIndex = 3;
            this.btmEllipse.UseVisualStyleBackColor = true;
            this.btmEllipse.Click += new System.EventHandler(this.btmEllipse_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Image = ((System.Drawing.Image)(resources.GetObject("btnRectangle.Image")));
            this.btnRectangle.Location = new System.Drawing.Point(129, 23);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(50, 50);
            this.btnRectangle.TabIndex = 2;
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnBrokenLine
            // 
            this.btnBrokenLine.Image = ((System.Drawing.Image)(resources.GetObject("btnBrokenLine.Image")));
            this.btnBrokenLine.Location = new System.Drawing.Point(73, 23);
            this.btnBrokenLine.Name = "btnBrokenLine";
            this.btnBrokenLine.Size = new System.Drawing.Size(50, 50);
            this.btnBrokenLine.TabIndex = 1;
            this.btnBrokenLine.UseVisualStyleBackColor = true;
            this.btnBrokenLine.Click += new System.EventHandler(this.btnBrokenLine_Click);
            // 
            // btnLine
            // 
            this.btnLine.Image = ((System.Drawing.Image)(resources.GetObject("btnLine.Image")));
            this.btnLine.Location = new System.Drawing.Point(17, 23);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(50, 50);
            this.btnLine.TabIndex = 0;
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(180)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumOfCorners)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPenThick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btmEllipse;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnBrokenLine;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnFillColor;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnBrushColor;
        private System.Windows.Forms.Label lblBrushColor;
        private System.Windows.Forms.Label lblistFigureillColor;
        private System.Windows.Forms.Label lblNumOfCorners;
        private System.Windows.Forms.Label lblPenThick;
        private System.Windows.Forms.Button butDeserializ;
        private System.Windows.Forms.Button butSerializ;
        private System.Windows.Forms.NumericUpDown numNumOfCorners;
        private System.Windows.Forms.NumericUpDown numPenThick;
        private System.Windows.Forms.Button btnSimplePolygon;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnUndo;
    }
}

