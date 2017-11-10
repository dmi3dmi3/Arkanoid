using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkanoid.Classes
{
    class Bat:Item
    {
        public Bat():base(Constant.pnlW / 2, Constant.pnlH - 10, 50, 8){}
        private const int v = 3;
        public void MoveRight()
        {
            if (X < (Constant.pnlW - Width / 2))
            {
                X = X + v;
            }
        }

        public void MoveLeft()
        {
            if (X > (Width / 2))
            {
                X = X - v;
            }
        }
    }
}
