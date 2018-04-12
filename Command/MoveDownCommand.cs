using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Command
{
    class MoveDownCommand : MoveCommand
    {
        public MoveDownCommand(ref Snake Snake) : base(ref Snake)
        {
        }

        public override void Execute()
        {
            _Snake.MoveDown();
        }
    }
}
