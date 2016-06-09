using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Character_creator
{
    class Monsters
    {
        public int x, y, size, speed;
        public string type;
        public Monsters(int _x, int _y, int _size, int _speed, string _type)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            type = _type;
        }
    }
}
