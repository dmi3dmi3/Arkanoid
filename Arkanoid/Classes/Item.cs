using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkanoid.Classes
{
    abstract class Item
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Point CornerLocation { get { return new Point(X - Width / 2, Y - Height / 2); } }
        public Point CenterLocation { get { return new Point(X, Y); } }
        public Size Size { get { return new Size(Width, Height); } }

        public Item(int a, int b, int c, int d)
        {
            X = a;
            Y = b;
            Width = c;
            Height = d;
        }

        public Item(Point p, Size s)
        {
            X = p.X;
            Y = p.Y;
            Width = s.Width;
            Height = s.Height;
        }
    }
}
