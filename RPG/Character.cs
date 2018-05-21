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
        public int level;
        public int currentXP = 0;
        public double neededxp;
        public int health;
        public int maxHealth;
        public int strength = 1;
        public int armor = 1;
        public Boolean playerFighter = false;
        public void attack(Character enemy)
        {
            enemy.hurt(strength);
            level = 1;
            neededxp = 100 * (level * 1.33); 
        }
        public void hurt(int amount) //Each character has a hurt function instead of just subtracting health...
        { //in the attack function because it leaves it open to add armor modifiers
            health -= amount / armor;
        }
        public void levelUp()
        {
            level++;
            neededxp = 100 * (level * 1.33);
            maxHealth += 10;
            health = maxHealth;
        }
    }
    
}
