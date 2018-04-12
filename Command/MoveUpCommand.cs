using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Command
{
    class MoveUpCommand : MoveCommand
    {
        public MoveUpCommand(ref Snake Snake) : base(ref Snake)
        {

        }

        public override void Execute()
        {
            _Snake.MoveUp();
        }
    }
}
