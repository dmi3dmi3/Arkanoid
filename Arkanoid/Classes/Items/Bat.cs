using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkanoid.Classes.Items
{
    class Bat:Item
    {
        public Bat():base(Constant.pnlW / 2, Constant.pnlH - 10, 100, 8){ shift = 0; }
        private const int v = 5;
        private double shift;
        
        public void MoveRight()
        {
            if (X < (Constant.pnlW - Width / 2))
            {
                X += v;
                shift += v;
                ShiftCheck();
            }
        }
        public void MoveLeft()
        {
            if (X > (Width / 2))
            {
                X -= v;
                shift -= v;
                ShiftCheck();
            }
        }

        public void ShiftCheck()
        {
            if (Math.Abs(shift) >= Physic.CellWidth)
            {
                Physic.CheckGridBat();
                shift = 0;
            }
        }
    }
}
