using SnakeGame.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        SnakeGame _SnakeGame;

        public Form1()
        {
            _SnakeGame = new SnakeGame();
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            _SnakeGame.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _SnakeGame.Update();
            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            InputCommand command = InputHandler.HandleInput(e.KeyCode);
            if (command != null)
                command.Execute();
        }
    }
}
