using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SnakeGame.Level
{
    interface ILevel
    {
        void OnCreate();
        void Draw(Graphics g);
        void Update();
    }
}
