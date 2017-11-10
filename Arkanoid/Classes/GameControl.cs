using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arkanoid.Classes
{
    static class GameControl
    {
        static public bool KeyDown { get; private set; }
        static public bool MoveRight { get; private set; }
        static public bool MoveLeft { get; private set; }
        static public bool PlayFlag { get; private set; }

        static public void SetLeft()
        {
            MoveLeft = true;
            MoveRight = false;
            KeyDown = true;
        }
        static public void SetRight()
        {
            MoveRight = true;
            MoveLeft = false;
            KeyDown = true;
        }
        static public void KeyUpLeft()
        {
            if (MoveLeft)
            {
                MoveRight = false;
                MoveLeft = false;
                KeyDown = false;
            }
        }
        static public void KeyUpRight()
        {
            if (MoveRight)
            {
                MoveRight = false;
                MoveLeft = false;
                KeyDown = false;
            }
        }
        static public void Start()
        {
            PlayFlag = true;
            MoveRight = false;
            MoveLeft = false;
            KeyDown = false;
        }
        static public void Stop()
        {
            PlayFlag = true;
            MoveRight = false;
            MoveLeft = false;
            KeyDown = false;
        }
    }
}
