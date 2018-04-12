using SnakeGame.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    static class InputHandler
    {
        public static InputCommand ButtonUp;
        public static InputCommand ButtonDown;
        public static InputCommand ButtonLeft;
        public static InputCommand ButtonRight;
        public static InputCommand ButtonRestart;

        public static InputCommand HandleInput(Keys key)
        {
            if (key.Equals(Keys.W)) return ButtonUp;
            if (key.Equals(Keys.A)) return ButtonLeft;
            if (key.Equals(Keys.S)) return ButtonDown;
            if (key.Equals(Keys.D)) return ButtonRight;
            if (key.Equals(Keys.R)) return ButtonRestart;

            return null;
        }

    }
}
