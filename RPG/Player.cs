using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Player: Character
    {
        public Player()
            {
            health = 100;
            maxHealth = health;
            strength = 10;
            }
    }
}
