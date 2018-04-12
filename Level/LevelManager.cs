using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Level
{
    static class LevelManager
    {
        public static ILevel Level;
        
        public static void LoadNewLevel(ILevel NewLevel)
        {
            Level = NewLevel;
        }
    }
}
