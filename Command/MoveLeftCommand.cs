using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Command
{
    class MoveLeftCommand : MoveCommand
    {
        public MoveLeftCommand(ref Snake Snake) : base(ref Snake)
        {

        }

        public override void Execute()
        {
            _Snake.MoveLeft();
        }
    }
}
