using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_creator
{
    class Highscore
    {
        public string name;
        public int score; 
        public Highscore(int _score, string _name)
        {
            score = _score;
            name = _name;
        }
    }
}
