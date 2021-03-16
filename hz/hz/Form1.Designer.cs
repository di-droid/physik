
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
            this.lblBrushColor = new System.Windows.Forms.Label();
            this.lblFillColor = new System.Windows.Forms.Label();
            this.lblNumOfCorners = new System.Windows.Forms.Label();
            this.lblPenThick = new System.Windows.Forms.Label();
            this.butDeserializ = new System.Windows.Forms.Button();
            this.butSerializ = new System.Windows.Forms.Button();
            this.numNumOfCorners = new System.Windows.Forms.NumericUpDown();
            this.numPenThick = new System.Windows.Forms.NumericUpDown();
            this.button7 = new System.Windows.Forms.Button();
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(204)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.lblBrushColor);
            this.panel1.Controls.Add(this.lblFillColor);
            this.panel1.Controls.Add(this.lblNumOfCorners);
            this.panel1.Controls.Add(this.lblPenThick);
            this.panel1.Controls.Add(this.butDeserializ);
            this.panel1.Controls.Add(this.butSerializ);
            this.panel1.Controls.Add(this.numNumOfCorners);
            this.panel1.Controls.Add(this.numPenThick);
            this.panel1.Controls.Add(this.button7);
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
            // lblBrushColor
            // 
            this.lblBrushColor.AutoSize = true;
            this.lblBrushColor.Location = new System.Drawing.Point(415, 65);
            this.lblBrushColor.Name = "lblBrushColor";
            this.lblBrushColor.Size = new System.Drawing.Size(101, 25);
            this.lblBrushColor.TabIndex = 14;
            this.lblBrushColor.Text = "Brush color";
            // 
            // lblFillColor
            // 
            this.lblFillColor.AutoSize = true;
            this.lblFillColor.Location = new System.Drawing.Point(331, 65);
            this.lblFillColor.Name = "lblFillColor";
            this.lblFillColor.Size = new System.Drawing.Size(78, 25);
            this.lblFillColor.TabIndex = 13;
            this.lblFillColor.Text = "Fill color";
            // 
            // lblNumOfCorners
            // 
            this.lblNumOfCorners.AutoSize = true;
            this.lblNumOfCorners.Location = new System.Drawing.Point(544, 50);
            this.lblNumOfCorners.Name = "lblNumOfCorners";
            this.lblNumOfCorners.Size = new System.Drawing.Size(162, 25);
            this.lblNumOfCorners.TabIndex = 12;
            this.lblNumOfCorners.Text = "Number of corners";
            // 
            // lblPenThick
            // 
            this.lblPenThick.AutoSize = true;
            this.lblPenThick.Location = new System.Drawing.Point(544, 18);
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
            this.numNumOfCorners.Location = new System.Drawing.Point(712, 49);
            this.numNumOfCorners.Name = "numNumOfCorners";
            this.numNumOfCorners.Size = new System.Drawing.Size(59, 31);
            this.numNumOfCorners.TabIndex = 8;
            // 
            // numPenThick
            // 
            this.numPenThick.Location = new System.Drawing.Point(712, 12);
            this.numPenThick.Name = "numPenThick";
            this.numPenThick.Size = new System.Drawing.Size(59, 31);
            this.numPenThick.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(436, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnFillColor
            // 
            this.btnFillColor.Location = new System.Drawing.Point(339, 12);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(50, 50);
            this.btnFillColor.TabIndex = 5;
            this.btnFillColor.UseVisualStyleBackColor = true;
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
            // 
            // btmEllipse
            // 
            this.btmEllipse.Image = ((System.Drawing.Image)(resources.GetObject("btmEllipse.Image")));
            this.btmEllipse.Location = new System.Drawing.Point(185, 25);
            this.btmEllipse.Name = "btmEllipse";
            this.btmEllipse.Size = new System.Drawing.Size(50, 50);
            this.btmEllipse.TabIndex = 3;
            this.btmEllipse.UseVisualStyleBackColor = true;
            // 
            // btnRectangle
            // 
            this.btnRectangle.Image = ((System.Drawing.Image)(resources.GetObject("btnRectangle.Image")));
            this.btnRectangle.Location = new System.Drawing.Point(129, 23);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(50, 50);
            this.btnRectangle.TabIndex = 2;
            this.btnRectangle.UseVisualStyleBackColor = true;
            // 
            // btnBrokenLine
            // 
            this.btnBrokenLine.Image = ((System.Drawing.Image)(resources.GetObject("btnBrokenLine.Image")));
            this.btnBrokenLine.Location = new System.Drawing.Point(73, 23);
            this.btnBrokenLine.Name = "btnBrokenLine";
            this.btnBrokenLine.Size = new System.Drawing.Size(50, 50);
            this.btnBrokenLine.TabIndex = 1;
            this.btnBrokenLine.UseVisualStyleBackColor = true;
            // 
            // btnLine
            // 
            this.btnLine.Image = ((System.Drawing.Image)(resources.GetObject("btnLine.Image")));
            this.btnLine.Location = new System.Drawing.Point(17, 23);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(50, 50);
            this.btnLine.TabIndex = 0;
            this.btnLine.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label lblBrushColor;
        private System.Windows.Forms.Label lblFillColor;
        private System.Windows.Forms.Label lblNumOfCorners;
        private System.Windows.Forms.Label lblPenThick;
        private System.Windows.Forms.Button butDeserializ;
        private System.Windows.Forms.Button butSerializ;
        private System.Windows.Forms.NumericUpDown numNumOfCorners;
        private System.Windows.Forms.NumericUpDown numPenThick;
    }
}

