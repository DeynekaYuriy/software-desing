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
        private readonly Player _player1;
        private readonly Player _player2;
        private char? _lastWinnerChar;
        private Player _currentPlayer;
        private Player _firstMovePlayer;
        public Game()
        {
            _gameBoard = new GameBoard();
            _player1 = new Player("Player 1", 'X', 0);
            _player2 = new Player("Player 2", 'O', 0);
            _currentPlayer = _player1;
            _firstMovePlayer = _player1;
        }
        private void SwitchCurrentPlayer()
        {
            _currentPlayer = _currentPlayer == _player1 ? _player2 : _player1;
        }
        private void SwitchFirstMovePlayer()
        {
            _firstMovePlayer = _firstMovePlayer == _player1 ? _player2 : _player1;
            _currentPlayer = _firstMovePlayer;
        }
        public void Run()
        {
            while (true)
            {
                PrintGame();
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
                Player winner = _lastWinnerChar == _player1.PlayerChar ? _player1 : _player2;
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
                _lastWinnerChar = board[0, 0];
                return true;
            }
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                _lastWinnerChar = board[0, 2];
                return true;
            }
            for (i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    _lastWinnerChar = board[i, 0];
                    return true;
                }
            }
            for (i = 0; i < board.GetLength(0); i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    _lastWinnerChar = board[0, i];
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
                _gameBoard.SetCharAt(position, _currentPlayer.PlayerChar);
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
            Console.WriteLine($"\n{_currentPlayer.Name} turn. Select from 1 to 9 from the game board.\n");
            _gameBoard.PrintBoard();
            Console.WriteLine("\n");
        }
        public void PrintScore()
        {
            Console.WriteLine($"{_player1.Name}: {_player1.PlayerChar} [{_player1.Score}]");
            Console.WriteLine($"{_player2.Name}: {_player2.PlayerChar} [{_player2.Score}]");
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
