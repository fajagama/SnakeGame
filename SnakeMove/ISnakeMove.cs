using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    interface ISnakeMove
    {
        Point Move(Point lastPosition);
    }
}
