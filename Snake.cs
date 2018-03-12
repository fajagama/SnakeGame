using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Snake
    {
        public List<Point> Body { get { return _Snake; } }

        private List<Point> _Snake = new List<Point>();
        private ISnakeMove _SnakeMove;

        private bool _CanChangeMove;

        public Snake()
        {
            _SnakeMove = new SnakeMoveRight();
            _Snake.Add(new Point(1, 1));
            _Snake.Add(new Point(1, 2));
            _Snake.Add(new Point(1, 3));

            _CanChangeMove = true;
        }

        public void MakeMove()
        {
            _CanChangeMove = true;
            _Snake.Add(_SnakeMove.Move(_Snake.Last()));            
        }

        public void RemoveTail()
        {
            _Snake.Remove(_Snake.First());
        }

        private void SetNewMove(ISnakeMove snakeMove)
        {
            _SnakeMove = snakeMove;
            _CanChangeMove = false;
        }

        public void MoveUp()
        {
            if (_SnakeMove.GetType() != typeof(SnakeMoveDown) && _CanChangeMove)
                SetNewMove(new SnakeMoveUp());
        }
        public void MoveDown()
        {
            if (_SnakeMove.GetType() != typeof(SnakeMoveUp) && _CanChangeMove)
                SetNewMove(new SnakeMoveDown());
        }
        public void MoveLeft()
        {
            if (_SnakeMove.GetType() != typeof(SnakeMoveRight) && _CanChangeMove)
                SetNewMove(new SnakeMoveLeft());
        }
        public void MoveRight()
        {
            if (_SnakeMove.GetType() != typeof(SnakeMoveLeft) && _CanChangeMove)
                SetNewMove(new SnakeMoveRight());
        }
    }
}
