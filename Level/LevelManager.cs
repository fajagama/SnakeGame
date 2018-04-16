using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame.Level
{
    static class LevelManager
    {
        public static ILevel Level { get { return _Level; } }
        private static ILevel _Level = null;
        private static List<ILevel> _Levels = new List<ILevel>();

        public static void AddLevel(ILevel NewLevel)
        {
            if (_Level == null)
            {
                _Level = NewLevel;
                _Level.OnCreate();
            }

            _Levels.Add(NewLevel);
        }
        
        public static void LoadNewLevel(string LevelName)
        {
            InputHandler.ClearCommands();
            _Level = _Levels.Find(x => x.GetType().Name.Equals(LevelName));
            _Level.OnCreate();
        }
    }
}
