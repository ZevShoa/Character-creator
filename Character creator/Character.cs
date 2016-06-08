using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Character_creator
{
   public class Character
    {
        public string name, clothes, weapon, gender, color;
        public int healthStat, energyStat, x, y, speed;
        public Image picture;

        public Character(string _name, string _clothes, string _weapon, string _gender, string _color, int _healthstat, int _energyStat, Image _picture, int _x, int _y, int  _speed)
        {
            name = _name;
            clothes = _clothes;
            weapon = _weapon;
            gender = _gender;
            color = _color;
            healthStat = _healthstat;
            energyStat = _energyStat;
            picture = _picture;
            x = _x;
            y = _y;
            speed = _speed;
        }

        public void move(Character ch, string direction)
        {
            if (direction == "Left")
            {
                ch.x -= ch.speed;
            }

            else
            {
                ch.x += ch.speed;
            }
        }
    }
}
