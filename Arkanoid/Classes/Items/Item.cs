using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkanoid.Classes.Items
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
        public double Left { get { return X - Width / 2; } }
        public double Right { get { return X + Width / 2; } }
        public double Top { get { return Y - Height / 2; } }
        public double Bottom { get { return Y + Height / 2; } }

        public Item(double a, double b, double c, double d)
        {
            X = a;
            Y = b;
            Width = c;
            Height = d;
            Add();
        }
        public Item(Point p, Size s)
        {
            X = p.X;
            Y = p.Y;
            Width = s.Width;
            Height = s.Height;
            Add();
        }
        public void Add()
        {
            GameControl.render.Add(this);
            if (this is Ball)
                Physic.ball = this as Ball;
            else
            Physic.itemList.Add(this);
            
        }
        public void Remove()
        {
            if (Physic.itemList.IndexOf(this) != -1)
                Physic.itemList.Remove(this);
            if (GameControl.render.IndexOf(this) != -1)
                GameControl.render.Remove(this);
        }
    }
}
