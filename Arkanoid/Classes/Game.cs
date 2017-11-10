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

        public Game(){}

        public void Start()
        {
            bat = new Bat();
            Render.items.Add(bat);
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
        }

        public void Stop()
        { }

    }
}

