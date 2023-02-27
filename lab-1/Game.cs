using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{

    public class Game
    {
        private GameBoard _gameBoard;
        private Player player1;
        private Player player2;
        private char? lastWinnerChar;
        private Player CurrentPlayer;
        private Player FirstMovePlayer;
        public Game()
        {
            _gameBoard = new GameBoard();
            player1 = new Player("Player 1", 'X', 0);
            player2 = new Player("Player 2", 'O', 0);
            CurrentPlayer = player1;
            FirstMovePlayer = player1;
        }
        private void SwitchCurrentPlayer()
        {
            CurrentPlayer = CurrentPlayer == player1 ? player2 : player1;
        }
        private void SwitchFirstMovePlayer()
        {
            FirstMovePlayer = FirstMovePlayer == player1 ? player2 : player1;
            CurrentPlayer = FirstMovePlayer;
        }
        public void Run()
        {
            while (true)
            {
                PrintGame();
                Console.WriteLine(FirstMovePlayer.GetHashCode().ToString());
                Console.WriteLine(CurrentPlayer.GetHashCode().ToString());
                if (CheckRoundEnd())
                {
                    if (PrintAskMessage("Do you want to play again? (y/n)") == "y")
                    {
                        continue;
                    }
                    EndGame();
                    break;
                }
                try
                {
                    Input();
                }
                catch (Exception e)
                {
                    PrintYellowMessage(e.Message + ". Press any key to continue...");
                }
            }
        }
        private void Input()
        {
            string input = Console.ReadLine();
            if (input == "u")
            {
                UndoMove();
            }
            else
            {
                MakeMove(int.Parse(input));
            }
        }
        private bool CheckRoundEnd()
        {
            if (IsWin())
            {
                Player winner = lastWinnerChar == player1.PlayerChar ? player1 : player2;
                winner.Score++;
                PrintGreenMessage($"{winner.Name} wins");
                SwitchFirstMovePlayer();
                _gameBoard = new GameBoard();
                return true;
            }
            else if (isDraw())
            {
                PrintGreenMessage("It's a draw");
                SwitchFirstMovePlayer();
                return true;
            }
            return false;
        }
        private bool isDraw()
        {
            for (int i = 0; i < _gameBoard.Board.GetLength(0); i++)
            {
                for (int j = 0; j < _gameBoard.Board.GetLength(1); j++)
                {
                    if (Char.IsDigit(_gameBoard.Board[i, j]))
                        return false;
                }
            }
            return true;
        }
        private bool IsWin()
        {
            char[,] board = _gameBoard.Board;
            int i = 1;
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                lastWinnerChar = board[0, 0];
                return true;
            }
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                lastWinnerChar = board[0, 2];
                return true;
            }
            for (i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    lastWinnerChar = board[i, 0];
                    return true;
                }
            }
            for (i = 0; i < board.GetLength(0); i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    lastWinnerChar = board[i, 0];
                    return true;
                }
            }
            return false;
        }
        private void UndoMove()
        {
            _gameBoard.UndoMove();
            SwitchCurrentPlayer();
        }
        private void MakeMove(int position)
        {

            if (position <= 9 && position >= 1)
            {
                _gameBoard.SetCharAt(position, CurrentPlayer.PlayerChar);
                SwitchCurrentPlayer();
            }
            else
            {
                throw new Exception($"There is no cell \"{position}\" on the field");
            }

        }
        private void PrintGame()
        {
            Console.Clear();
            PrintScore();
            Console.WriteLine($"\n{CurrentPlayer.Name} turn. Select from 1 to 9 from the game board.\n");
            _gameBoard.PrintBoard();
            Console.WriteLine("\n");
        }
        public void PrintScore()
        {
            Console.WriteLine($"{player1.Name}: {player1.PlayerChar} [{player1.Score}]");
            Console.WriteLine($"{player2.Name}: {player2.PlayerChar} [{player2.Score}]");
        }
        public void PrintGreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadLine();
        }

        public void PrintYellowMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadLine();
        }
        public string PrintAskMessage(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        public void EndGame()
        {
            Console.Clear();
            Console.WriteLine("Game over");
            PrintScore();
        }
    }
}
