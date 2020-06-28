using System;

namespace Crossxox
{
    public class Game
    {
        private int _moveCount;

        private string[] _moves;

        public event Action GameOver = delegate { };

        public string Winner { get; private set; } = string.Empty;

        public Game()
        {
            _moveCount = 0;

            _moves = new string[9];

            for (int i = 0; i < 9; i++)
            {
                _moves[i] = string.Empty;
            }
        }

        public void Move(string move, int position)
        {
            if (_moveCount > 9)
            {
                return;
            }

            _moveCount++;

            _moves[position] = move;

            CheckResult();
        }

        public int RandomMove(string move)
        {
            _moveCount++;

            if (_moveCount > 9)
            {
                return -1;
            }

            int index = -1;

            while (true)
            {
                index = new Random().Next(0, 9);

                if (_moves[index] == string.Empty)
                {
                    _moves[index] = move;

                    break;
                }
            }

            CheckResult();

            return index;
        }

        private void CheckResult()
        {
            if ((_moves[0] == _moves[1] && _moves[0] == _moves[2] && _moves[0] != string.Empty) ||
                (_moves[3] == _moves[4] && _moves[3] == _moves[5] && _moves[3] != string.Empty) ||
                (_moves[6] == _moves[7] && _moves[6] == _moves[8] && _moves[6] != string.Empty))
            {
                //Row
                Winner = _moves[0];

                GameOver();
            }

            if ((_moves[0] == _moves[3] && _moves[0] == _moves[6] && _moves[0] != string.Empty) ||
                (_moves[1] == _moves[4] && _moves[4] == _moves[7] && _moves[1] != string.Empty) ||
                (_moves[2] == _moves[5] && _moves[5] == _moves[8] && _moves[2] != string.Empty))
            {
                //Column
                Winner = _moves[0];

                GameOver();
            }

            if ((_moves[0] == _moves[4] && _moves[4] == _moves[8] && _moves[0] != string.Empty) ||
                (_moves[2] == _moves[4] && _moves[4] == _moves[6]) && _moves[2] != string.Empty)
            {
                //Diagonal
                Winner = _moves[0];

                GameOver();
            }
        }

    }
}
