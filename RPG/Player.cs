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
            playerFighter = true;
            pots.Add(new HealthPotion());
    }
        public override void levelUp()
        {
            level++;
            LevelUp levelUp = new LevelUp();
        }
        public override void death()
        {
            
            
            
        }
    }
}
