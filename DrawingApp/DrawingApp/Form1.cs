using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class Form1 : Form
    {
        bool paint = false;
        int index = 1;
        int x, y, sX, sY, cX, cY;
        Color colorP;
        //Color newColor;
        Point pointX, pointY;
        Bitmap newBitmap;
        Graphics graphics;
        Pen pen = new Pen(Color.Black, 2);
        Pen eraser = new Pen(Color.White, 4);
        ColorDialog colorDialog = new ColorDialog();
        

        static Point SetPoint(PictureBox pictureBox, Point point)
        {
            float pX = 1f * pictureBox.Image.Width / pictureBox.Width;
            float pY = 1f * pictureBox.Image.Height / pictureBox.Height;

            return new Point((int)(point.X * pX), (int)(point.Y * pY));
        }

        private void Validate(Bitmap bitmap, Stack<Point> pointStack, int x, int y, Color newColor, Color oldColor)
        {
            Color pixelColor = bitmap.GetPixel(x, y);
            if(pixelColor == oldColor)
            {
                pointStack.Push(new Point(x, y));
                bitmap.SetPixel(x, y, newColor);
            }
        }

        public void FillUp(Bitmap bitmap, int x, int y, Color newColor)
        {
            Color oldColor = bitmap.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bitmap.SetPixel(x, y, newColor);
            if (oldColor == newColor) return;

            while(pixel.Count > 0)
            {
                Point point = (Point)pixel.Pop();
                if (point.X > 0 && point.Y > 0 && point.X < bitmap.Width - 1 && point.Y < bitmap.Height - 1)
                {
                    Validate(bitmap, pixel, point.X - 1, point.Y, oldColor, newColor);
                    Validate(bitmap, pixel, point.X, point.Y - 1, oldColor, newColor);
                    Validate(bitmap, pixel, point.X + 1, point.Y, oldColor, newColor);
                    Validate(bitmap, pixel, point.X, point.Y + 1, oldColor, newColor);
                }
            }
        }


        public Form1()
        {
            InitializeComponent();
            newBitmap = new Bitmap(DrawPanel.Width, DrawPanel.Height);
            graphics = Graphics.FromImage(newBitmap);
            graphics.Clear(Color.White);
            DrawPanel.Image = newBitmap;
            BtnDraw.BackColor = BtnLine1.BackColor = Color.LightBlue;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Palette_MouseClick(object sender, MouseEventArgs e)
        {
            Point pointColor = SetPoint(Palette, e.Location);
            MainColor.BackColor = ((Bitmap)Palette.Image).GetPixel(pointColor.X, pointColor.Y);
            colorP = MainColor.BackColor;
            pen.Color = MainColor.BackColor;
        }

        private void BtnSetColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            colorP = MainColor.BackColor = pen.Color = colorDialog.Color;
        }

        private void BtnPenWidth_Click(object sender, EventArgs e)
        {
            foreach(var penWidth in WidthPenPanel.Controls.OfType<Button>())
            {
                penWidth.BackColor = Color.WhiteSmoke;
                Button button = (Button)sender;
                button.BackColor = Color.LightBlue;
                pen.Width = eraser.Width = Convert.ToInt32(button.Tag);
            }
        }

        private void ActionBtn_Click(object sender, EventArgs e)
        {
            foreach(var btn in MainPanel.Controls.OfType<Button>())
            {
                btn.BackColor = Color.WhiteSmoke;
                Button button = (Button)sender;
                button.BackColor = Color.LightBlue;
                index = Convert.ToInt32(button.Tag);
            }
        }

        private void DrawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            pointY = e.Location;

            cX = e.X;
            cY = e.Y;

        }

        private void DrawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sX = x - cX;
            sY = y - cY;

            if(index == 5)
            {
                graphics.DrawLine(pen, cX, cY, x, y);
            }
            if(index == 6)
            {
                graphics.DrawRectangle(pen, cX, cY, sX, sY);
            }
            if(index == 7)
            {
                graphics.DrawEllipse(pen, cX, cY, sX, sY);
            }
        }

        private void DrawPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = SetPoint(DrawPanel, e.Location);
            if(index == 3)
            {
                colorP = pen.Color = MainColor.BackColor = ((Bitmap)DrawPanel.Image).GetPixel(point.X, point.Y);
            }
            if(index == 4)
            {
                FillUp(newBitmap, point.X, point.Y, colorP);
            }
        }

        private void DrawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(paint)
            {
                if(index == 1)
                {
                    pointX = e.Location;
                    graphics.DrawLine(pen, pointX, pointY);
                    pointY = pointX;
                }
                if(index == 2)
                {
                    pointX = e.Location;
                    graphics.DrawLine(eraser, pointX, pointY);
                    pointY = pointX;
                }
            }

            DrawPanel.Refresh();
            x = e.X;
            y = e.Y;
            sX = e.X;
            sY = e.Y;
        }

        private void DrawPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphicsPaint = e.Graphics;
            if(paint)
            {
                if (index == 5)
                {
                    graphicsPaint.DrawLine(pen, cX, cY, x, y);
                }
                if (index == 6)
                {
                    graphicsPaint.DrawRectangle(pen, cX, cY, sX, sY);
                }
                if (index == 7)
                {
                    graphicsPaint.DrawEllipse(pen, cX, cY, sX, sY);
                }
            }
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void BtnSize_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void BtnMini_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void DrawPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
