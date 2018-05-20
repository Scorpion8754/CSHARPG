using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Monster: Character
    {
    }
    public class Rat: Monster
    {
        public Rat()
        {
            health = 30;
            name = "Giant Rat";
            strength = 3;
            maxHealth = health;
        }
    }
}
