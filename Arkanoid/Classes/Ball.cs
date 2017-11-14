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
                else if (value >= 360)
                    _angel = value % 360;
                else
                    _angel = value;
            }
            get { return _angel; } }

        public Ball() : base(Constant.pnlW / 2, Constant.pnlH - 24, 20,20)
        {
            Angle = 360-46;
        }

        public void Move()
        {
            X = X + (float)(4 * Math.Cos(Angle * Math.PI / 180));
            Y = Y + (float)(4 * Math.Sin(Angle * Math.PI / 180));
        }

        private void CheckWalls()
        {
            if (X > Constant.pnlW - Width / 2)
                if (Angle == 0)
                    Angle = 179;
            else
            {
                if (Angle > 180)
                    Angle = 270 - Angle % 270;
                else
                    Angle = 180 - Angle % 90;
            }
            else if (X<Width/2)
            {
                if (Angle == 180)
                    Angle = -1;
                else
                {
                    if (Angle > 180)
                        Angle = 360 - Angle % 180;
                    else
                        Angle = 90 - Angle % 90;
                }
            }
            else if(Y < Height / 2)
            {
                if (Angle == 270)
                    Angle = 90;
                else
                {
                  //  if (Angle > 180)
                    //    Angle = 180 - Angle % 180;
                   // else
                        Angle = 360 - Angle;
                }
            }
        }

        public void CheckBat(Bat bat)
        {
            if (bat.X - bat.Width / 2 < X && X < bat.X + bat.Width / 2 && Y > bat.Y - bat.Height / 2 - Height / 2)
            {
                if (Angle == 90)
                    Angle = 271;
                else
                {
                    if (Angle < 270)
                        Angle = 360 - Angle % 180;
                    else
                        Angle = 270 - Angle % 90;
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
