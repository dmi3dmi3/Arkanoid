using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Arkanoid.Classes.Items;

namespace Arkanoid.Classes
{
    class Game
    {
        private Bat bat;
        private Ball ball;
        private Wall leftWall;
        private Wall topWall;
        private Wall rightWall;
        private List<Brick> bricks = new List<Brick>();
        public Game(){}

        public void Start()
        {
            leftWall = new Wall(1, Constant.pnlH / 2, 2, Constant.pnlH - 4);
            topWall = new Wall(Constant.pnlW / 2, 1, Constant.pnlW - 4, 2);
            rightWall = new Wall(Constant.pnlW - 1, Constant.pnlH / 2, 2, Constant.pnlH - 4);
            bat = new Bat();
            ball = new Ball();
            {
                double i = 4, j = 4;
                while (true)
                {
                    bricks.Add(new Brick(i + Brick.Width / 2, j + Brick.Height / 2));
                    i += Brick.Width + 2;
                    if (i >= Constant.pnlW)
                    {
                        i = 4;
                        j += Brick.Height + 2;
                        if (j >= Constant.pnlH - 200) break;
                    }
                }
            }
            Physic.Init();

            GameControl.Start();
        }
        public void Play()
        {
            if (GameControl.KeyDown)
            {
                if (GameControl.MoveLeft)
                    bat.MoveLeft();
                else if (GameControl.MoveRight)
                    bat.MoveRight();
            }

            ball.Move();
            ball.CheckBall(bat);
        }

        public void Stop()
        { }

    }
}

