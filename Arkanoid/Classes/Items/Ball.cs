using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace Arkanoid.Classes.Items
{
    class Ball : Item
    {
        private Vector velVec;
        private double vel;
        private Vector Hor = new Vector(1, 0);
        private Vector Ver = new Vector(0, 1);

        public Ball() : base(Constant.pnlW / 2, Constant.pnlH - 24, 20,20)
        {
            velVec = new Vector(-10, -5).Normalize();
            vel = 5;
        }
        public void Move()
        {
            X += vel * velVec.X;
            Y += vel * velVec.Y;
        }
        private void CheckWalls()
        {
            if (Y < Height / 2)
            { velVec = velVec.Reflect(Hor); Move(); }
            else if (X > Constant.pnlW - Width / 2 || X < Width / 2)
            { velVec = velVec.Reflect(Ver); Move(); }
        }

        private void CheckBat(Bat bat)
        {
            if (X > bat.Left - Width / 2 && X < bat.Right + Width / 2 && Y >= bat.Top - Height / 2)
            {
                if (X > bat.Left && X < bat.Right && Y >= bat.Top - Height / 2)
                {
                    velVec.Set(-4 + (8 / bat.Width) * (X - bat.Left), -1);
                    velVec = velVec.Normalize();
                }
                else if ((X - bat.Left) * (X - bat.Left) + (Y - bat.Top) * (Y - bat.Top) < Width / 2 * Width / 2 ||
                         (X - bat.Right) * (X - bat.Right) + (Y - bat.Top) * (Y - bat.Top) < Width / 2 * Width / 2)
                {
                    velVec.Set(-3 + (6 / bat.Width) * (X - bat.Left), -1);
                    velVec = velVec.Normalize();
                }
            }
        }

        public void CheckBall(Bat bat)
        {
            CheckWalls();
            CheckBat(bat);
        }
    }
}
