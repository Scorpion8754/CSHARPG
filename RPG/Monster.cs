﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Monster : Character
    {
    }
    public class Rat : Monster
    {
        public Rat()
        {
            health = 30;
            name = "Giant Rat";
            strength = 3;
            maxHealth = health;
        }

    }

    public class God : Monster
    {
        public God()
        {
            health = 666;
            name = "Shrek";
            strength = 666;
            maxHealth = health;
        }
        public override void hurt(int amount)
        {
            if (playerFighter == true) { health -= amount / armor; }
            else { health += amount / armor; maxHealth = health; }
        }
    }
}
