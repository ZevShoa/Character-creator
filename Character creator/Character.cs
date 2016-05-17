using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_creator
{
    class Character
    {
        public string name, clothes, weapon, gender, color;
        public int healthStat, energyStat;

        public Character(string _name, string _clothes, string _weapon, string _gender, string _color, int _healthstat, int _energyStat)
        {
            name = _name;
            clothes = _clothes;
            weapon = _weapon;
            gender = _gender;
            color = _color;
            healthStat = _healthstat;
            energyStat = _energyStat;
        }

    }
}
