using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeGame.Command;

namespace SnakeGame.Level
{
    class NormalGameLevel : ILevel
    {
        private Snake _Snake;
        private int _Score;
        private Point _Fruid;
        private Random _Rnd;
        private int _CellSize;

        public NormalGameLevel()
        {

            _Snake = new Snake();
            _Score = 0;
            _Rnd = new Random();
            _CellSize = 10;
            
            InputHandler.ButtonUp = new MoveUpCommand(ref _Snake);
            InputHandler.ButtonDown = new MoveDownCommand(ref _Snake);
            InputHandler.ButtonLeft = new MoveLeftCommand(ref _Snake);
            InputHandler.ButtonRight = new MoveRightCommand(ref _Snake);

            GerateNewFruid();
        }

        private void AddScore()
        {
            _Score++;
        }

        private void GerateNewFruid()
        {
            do
                _Fruid = new Point(_Rnd.Next(1, 50), _Rnd.Next(1, 50));
            while (_Snake.Body.Exists(x => x.Equals(_Fruid)));
        }
        
        public void Draw(Graphics g)
        {
            for (int i = 0; i <= 50; i++)
            {
                g.FillRectangle(new SolidBrush(Color.Blue), 0, i * _CellSize, _CellSize, _CellSize);
                g.FillRectangle(new SolidBrush(Color.Blue), 50 * _CellSize, i * _CellSize, _CellSize, _CellSize);
                g.FillRectangle(new SolidBrush(Color.Blue), i * _CellSize, 0, _CellSize, _CellSize);
                g.FillRectangle(new SolidBrush(Color.Blue), i * _CellSize, _CellSize * 50, _CellSize, _CellSize);
            }

            foreach (var item in _Snake.Body)
            {
                g.FillRectangle(new SolidBrush(Color.Orange), item.X * _CellSize + 1, item.Y * _CellSize + 1, _CellSize - 2, _CellSize - 2);
            }
            g.FillRectangle(new SolidBrush(Color.Red), _Snake.Body.Last().X * _CellSize + 1, _Snake.Body.Last().Y * _CellSize + 1, _CellSize - 2, _CellSize - 2);
            g.FillRectangle(new SolidBrush(Color.Green), _Fruid.X * _CellSize + 1, _Fruid.Y * _CellSize + 1, _CellSize - 2, _CellSize - 2);
        }

        public void Update()
        {
            _Snake.MakeMove();

            if (_Snake.Body.Last().X == 0 || _Snake.Body.Last().Y == 0 || _Snake.Body.Last().X == 50 || _Snake.Body.Last().Y == 50 || _Snake.Body.GroupBy(n => n).Any(c => c.Count() > 1))
            {
                _Snake.Body.Clear();
                ShareMemory.Add("score", _Score);
                LevelManager.LoadNewLevel(new GameOverLevel());
            }
            else
            {
                if (!_Fruid.Equals(_Snake.Body.Last()))
                    _Snake.RemoveTail();
                else
                {
                    AddScore();
                    GerateNewFruid();
                }
            }
        }
    }
}
