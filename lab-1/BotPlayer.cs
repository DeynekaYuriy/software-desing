using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class BotPlayer : Player
    {
        public BotPlayer(string name, char playerChar, int score) : base(name, playerChar, score)
        {
        }
        public override string Input(char[,] board)
        {
            char[] board1 = board.Cast<char>().ToArray();
            int move = MakeMove(board1) + 1;
            return move.ToString();
        }
        public int MakeMove(char[] boardPositions)
        {
            int winMove = FindWinningMove(boardPositions, 'O');
            if (winMove != -1)
                return winMove;

            int preventLossMove = FindWinningMove(boardPositions, 'X');
            if (preventLossMove != -1)
                return preventLossMove;

            Random random = new Random();
            int position;
            do
            {
                position = random.Next(0, 8);
            } while (boardPositions[position] == 'X' || boardPositions[position] == 'O');

            return position;
        }

        private int FindWinningMove(char[] boardPositions, char player)
        {
            for (int i = 0; i < boardPositions.Length; i++)
            {
                if (boardPositions[i] != 'X' && boardPositions[i] != 'O')
                {
                    char[] boardCopy = (char[])boardPositions.Clone();
                    boardCopy[i] = player;
                    if (CheckWin(boardCopy))
                        return i;
                }
            }
            return -1;
        }

        private bool CheckWin(char[] boardPositions)
        {
            // check horizontals
            for (int i = 0; i <= 6; i += 3)
                if (boardPositions[i] == boardPositions[i + 1] && boardPositions[i] == boardPositions[i + 2])
                    return true;

            // check verticals
            for (int i = 0; i <= 2; i++)
                if (boardPositions[i] == boardPositions[i + 3] && boardPositions[i] == boardPositions[i + 6])
                    return true;

            // check diagonals
            if (boardPositions[0] == boardPositions[4] && boardPositions[0] == boardPositions[8])
                return true;
            if (boardPositions[2] == boardPositions[4] && boardPositions[2] == boardPositions[6])
                return true;

            return false;
        }
    }
}
