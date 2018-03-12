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
        public Snake Snake;
        private int _Score;
        private Point _Fruid;
        private Random _Rnd;
        private int _CellSize;

        public SnakeGame()
        {
            Snake = new Snake();
            _Score = -1;
            _Rnd = new Random();
            _CellSize = 10;

            GerateNewFruid();
        }

        private void GerateNewFruid()
        {
            _Score++;

            do
                _Fruid = new Point(_Rnd.Next(1, 50), _Rnd.Next(1, 50));
            while (Snake.Body.Exists(x => x.Equals(_Fruid)));
        }

        public bool GameOver()
        {
            return Snake.Body.Count == 0;
        }

        public void Update()
        {
            if (GameOver()) return;

            Snake.MakeMove();

            if (Snake.Body.Last().X == 0 || Snake.Body.Last().Y == 0 || Snake.Body.Last().X == 50 || Snake.Body.Last().Y == 50 || Snake.Body.GroupBy(n => n).Any(c => c.Count() > 1))
            {
                Snake.Body.Clear();
            }
            else
            {
                if (!_Fruid.Equals(Snake.Body.Last()))
                    Snake.RemoveTail();
                else
                    GerateNewFruid();
            }

            GC.Collect();
        }

        public void Draw(Graphics g)
        {
            if (GameOver())
            {
                g.DrawString("Game Over", new Font("Arial", 16), new SolidBrush(Color.Black), 150, 150);
                g.DrawString("Score: " + _Score, new Font("Arial", 16), new SolidBrush(Color.Black), 150, 200);
                g.DrawString("Press R to restart level", new Font("Arial", 16), new SolidBrush(Color.Black), 150, 250);

                return;
            }            

            for (int i = 0; i <= 50; i++)
            {
                g.FillRectangle(new SolidBrush(Color.Blue), 0, i * _CellSize, _CellSize, _CellSize);
                g.FillRectangle(new SolidBrush(Color.Blue), 50 * _CellSize, i * _CellSize, _CellSize, _CellSize);
                g.FillRectangle(new SolidBrush(Color.Blue), i * _CellSize, 0, _CellSize, _CellSize);
                g.FillRectangle(new SolidBrush(Color.Blue), i * _CellSize, _CellSize * 50, _CellSize, _CellSize);
            }

            foreach (var item in Snake.Body)
            {
                g.FillRectangle(new SolidBrush(Color.Orange), item.X * _CellSize + 1, item.Y * _CellSize + 1, _CellSize - 2, _CellSize - 2);
            }
            g.FillRectangle(new SolidBrush(Color.Red), Snake.Body.Last().X * _CellSize + 1, Snake.Body.Last().Y * _CellSize + 1, _CellSize - 2, _CellSize - 2);
            g.FillRectangle(new SolidBrush(Color.Green), _Fruid.X * _CellSize + 1, _Fruid.Y * _CellSize + 1, _CellSize - 2, _CellSize - 2);
        }
    }
}
