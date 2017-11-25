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
        public double X { get; set; }
        public double Y { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public PointD CornerLocation { get { return new PointD(X - Width / 2, Y - Height / 2); } }
        public PointD CenterLocation { get { return new PointD(X, Y); } }
        public SizeF Size { get { return new SizeF((float)Width, (float)Height); } }

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
