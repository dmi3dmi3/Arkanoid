using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace Arkanoid.Classes
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
            vel = 4;
        }

        public void Move()
        {
            X += vel * velVec.X;
            Y += vel * velVec.Y;
        }

        private void CheckWalls()
        {
            if (X > Constant.pnlW - Width / 2 || X < Width / 2)
                velVec = velVec.Reflect(Ver);
            else if (Y < Height / 2)
                velVec = velVec.Reflect(Hor);
        }

        public void CheckBat(Bat bat)
        {
            if (X > bat.Left && X < bat.Right && Y >= bat.Top - Height / 2)
                velVec = velVec.Reflect(Hor);
            else if ((Y < bat.Top && Y > bat.Bottom) && (X >= bat.Left - Width / 2 || X <= bat.Right + Width / 2))
                velVec = velVec.Reflect(Ver);
            else if (new Vector(new PointD(X, Y), new PointD(bat.Left, bat.Top)).Length <= Width / 2 ||
                     new Vector(new PointD(X, Y), new PointD(bat.Right, bat.Top)).Length <= Width / 2)
                    velVec = velVec.Negate();
        }

        public void CheckBall(Bat bat)
        {
            CheckWalls();
            CheckBat(bat);
        }
    }
}
