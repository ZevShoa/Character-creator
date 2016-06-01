using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_creator
{
    class User
    {
        public string username, password, score, character1, character2, character3;
        public User(string _username, string _password, string _score, string _character1, string _character2, string _character3)
        {
            username = _username;
            password = _password;
            score = _score;
            character1 = _character1;
            character2 = _character2;
            character3 = _character3;
        }
    }
}
