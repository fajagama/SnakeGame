using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeGame.Command;

namespace SnakeGame.Level
{
    class GameOverLevel : ILevel
    {
        private int _score;

        public void OnCreate()
        {
            _score = ShareMemory.Read("score");
            InputHandler.ButtonRestart = new RestartCommand();
        }

        public void Draw(Graphics g)
        {
            g.DrawString("Game Over", new Font("Arial", 16), new SolidBrush(Color.Black), 150, 150);
            g.DrawString("Score: " + (_score * 10), new Font("Arial", 16), new SolidBrush(Color.Black), 150, 200);
            g.DrawString("Press R to restart level", new Font("Arial", 16), new SolidBrush(Color.Black), 150, 250);
        }

        public void Update()
        {
            
        }
    }
}
