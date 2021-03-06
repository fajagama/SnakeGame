﻿using SnakeGame.Level;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class SnakeGame
    {
        public SnakeGame()
        {
            LevelManager.AddLevel(new NormalGameLevel());
            LevelManager.AddLevel(new GameOverLevel());
        }
        
        public void Update()
        {
            LevelManager.Level.Update();
            GC.Collect();
        }

        public void Draw(Graphics g)
        {
            LevelManager.Level.Draw(g);
        }
    }
}
