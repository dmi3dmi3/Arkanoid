using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Arkanoid.Classes
{
    class Game
    {
        private Bat bat;
        private Ball ball;

        public Game(){}

        public void Start()
        {
            bat = new Bat();
            Render.items.Add(bat);
            ball = new Ball();
            Render.items.Add(ball);
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

