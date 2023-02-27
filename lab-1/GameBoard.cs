using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class GameBoard
    {
        public char[,] Board { get; private set; }
        private Stack<int> movesStack;
        public GameBoard()
        {
            Board = new char[,] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
            movesStack = new Stack<int>();
        }
        public void SetCharAt(int position, char c)
        {
            movesStack.Push(position);
            position--;
            int row = position / 3;
            int column = position % 3;
            if (Char.IsDigit(Board[row, column]))
            {
                Board[row, column] = c;
            }
            else
            {
                throw new Exception("Cell is already occupied");
            }
        }
        public void PrintBoard()
        {
            for (int i = 0; i < Board.GetLength(0); i++)
            {
                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    Console.Write($" {Board[i, j]} ");
                    if (j < 2)
                    {
                        Console.Write('|');
                    }
                }
                if (i < 2)
                {
                    Console.WriteLine("\n---+---+---");
                }
            }
        }
        public void UndoMove()
        {
            if(movesStack.Count == 0)
            {
                throw new Exception("The moves list is empty");
            }
            int movePosition = movesStack.Pop();
            movePosition--;
            int row = movePosition / 3;
            int column = movePosition % 3;
            Board[row, column] = (++movePosition).ToString()[0];
        }
    }
}
