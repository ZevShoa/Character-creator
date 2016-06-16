using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Character_creator
{
   public class Monsters
    {
        public Image[] monsterImages;
        public int x, y, size, speed, type;
        public Monsters(int _x, int _y, int _size, int _speed, int _type)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            type = _type;
        }
        public void move(Monsters m, string direction)
        {
            if (direction == "left")
            {
                m.x -= m.speed;
            }
            else if (direction == "right")
            {
                m.x += m.speed;
            }

            else if (direction == "up")
            {
                m.y -= m.speed;
            }
            else if (direction == "down")
            {
                m.y += m.speed;
            }
        }

        public bool monsterCollision(Monsters m, Character ch)
        {
            Rectangle pRec = new Rectangle(m.x, m.y, m.size, m.size);
            Rectangle bRec = new Rectangle(ch.x, ch.y, 300, 400);
            if (pRec.IntersectsWith(bRec))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
