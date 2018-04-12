using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Command
{
    abstract class MoveCommand : InputCommand
    {
        protected Snake _Snake;
        public MoveCommand(ref Snake Snake)
        {
            _Snake = Snake;
        }
    }
}
