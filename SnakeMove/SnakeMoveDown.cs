using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class SnakeMoveDown : ISnakeMove
    {
        public Point Move(Point lastPosition)
        {
            Point newPoint = lastPosition;
            newPoint.Y++;
            return newPoint;
        }
    }
}
