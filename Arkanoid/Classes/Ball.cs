using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkanoid.Classes
{
    class Ball : Item
    {
        private float _angel;
        public float Angle {private set {
                if (value < 0)
                    _angel = value + 360;
                else
                    _angel = value;
            }
            get { return _angel; } }

        public Ball() : base(Constant.pnlW / 2, Constant.pnlH - 24, 20,20)
        {
            Angle = 300;
        }

        public void Move()
        {
            X = X + (float)(4 * Math.Cos(Angle * Math.PI / 180));
            Y = Y + (float)(4 * Math.Sin(Angle * Math.PI / 180));
        }

        private void CheckWalls()
        {
       /*     float tang;
            tang = 90 - Angle % 90;
            if (X > Constant.pnlW - Width / 2)
                if (Angle % 180 == 0)
                    Angle -= 180;
                else
                    Angle += Angle < 180 ? tang : -tang;
            else if (X < Width / 2)
                if (Angle % 180 == 0)
                    Angle -= 180;
                else
                    Angle += Angle < 180 ? -tang : tang;
            else if (Y < Height / 2)
                if (Angle % 180 == 90)
                    Angle -= 180;
                else
                    Angle += -tang;
            else if (Y > Constant.pnlH + Height/2)
            { }*/
        }

        public void CheckBat(Bat bat)
        {
       /*     float tang;
            tang = 90 - Angle % 90;
            if (bat.X - bat.Width / 2 < X && X < bat.X + bat.Width / 2 && Y > bat.Y - bat.Height / 2 - Height / 2)
                if (Angle % 180 == 90)
                    Angle -= 180;
                else
                    Angle += -tang;*/
        }

        public void CheckBall(Bat bat)
        {
            CheckWalls();
            CheckBat(bat);
        }
    }
}
