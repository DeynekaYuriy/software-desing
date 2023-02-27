using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Player
    {
        public string Name { get; set; }
        public char PlayerChar;
        public int Score;
        public Player(string name, char playerChar, int score)
        {
            Name = name;
            PlayerChar = playerChar;
            Score = score;
        }
    }
}
