using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeGame.Level;

namespace SnakeGame.Command
{
    class RestartCommand : InputCommand
    {
        public override void Execute()
        {
            LevelManager.LoadNewLevel("NormalGameLevel");
        }
    }
}
