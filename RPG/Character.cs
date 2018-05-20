using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Character
    {
        public string name;
        public int health;
        public int maxHealth;
        public int strength = 1;
        public int armor = 1;
        public void attack(Character enemy)
        {
            enemy.hurt(strength);
        }
        public void hurt(int amount)
        {
            health -= amount / armor;
        }
    }
    
}
