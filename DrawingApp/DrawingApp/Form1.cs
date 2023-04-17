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
        Point pointX, pointY;
        Bitmap bitmap;
        Graphics graphics;
        Pen pen = new Pen(Color.Black, 2);
        Pen earse = new Pen(Color.White, 4);
        

        static Point SetPoint(PictureBox pictureBox, Point point)
        {
            float pX = 1f * pictureBox.Image.Width / pictureBox.Width;
            float pY = 1f * pictureBox.Image.Height / pictureBox.Height;

            return new Point((int)(point.X * pX), (int)(point.Y * pY));
        }

        private void Validate(Bitmap bitmap, Stack<Point> pointStack, int x, int y, Color newColor, Color oldColor)
        {
            Color cx = bitmap.GetPixel(x, y);
            if(cx == oldColor)
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
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
