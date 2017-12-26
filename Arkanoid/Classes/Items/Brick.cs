using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkanoid.Classes.Items
{
    class Brick:Item
    {
        static public int count = 0;
        public int id;
        public new const double Width = (Constant.pnlW - 6)/ 10 - 2;
        public new const double Height = (Constant.pnlH - 200) / 10 - 2;
        public Brick(double a, double b) : base(a, b, Width, Height)
        {
            id = count;
            count++;
        }
    }
}
