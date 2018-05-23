using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Character
    {
        internal List<HealthPotion> pots = new List<HealthPotion>();
        public string name;
        public int level;
        public int currentXP = 0;
        public double neededxp;
        public int health;
        public int maxHealth;
        public int strength = 1;
        public int armor = 1;
        public int myID;
        public Boolean playerFighter = false;
        public Character()
        {
            myID = Hub.monsterID;
            Hub.monsterID += 1;
        }
        public virtual void combatMove(Character enemy)
        {
            attack(enemy);
        }
        public virtual void attack(Character enemy)
        {
            enemy.hurt(strength);
            level = 1;
            neededxp = 100 * (level * 1.33); 
        }
        public  void hurt(int amount) //Each character has a hurt function instead of just subtracting health...
        { //in the attack function because it leaves it open to add armor modifiers
            health -= amount / armor;
        }
        public virtual void levelUp()
        {
            level++;
            neededxp = 100 * (level * 1.33);
            maxHealth += 10;
            health = maxHealth;
        }
        public virtual void death()
        {
            System.Windows.Forms.MessageBox.Show(name + " died!");
            health = 0;
            Hub.theHero = Hub.pokedex[0];
            
            //if(playerFighter == true)
           // {
            //    for (int i = 0; i < Hub.pokedex.Count(); i++)           
            //    {
            //        if (Hub.pokedex[i].myID == myID)
            //        {
            //            Hub.pokedex.RemoveAt(i);
            //           for(int z = 0; z < Hub.pokedex.Count(); z++)
            //            {
            //                Hub.theHero = Hub.pokedex[z];
            //                
            //            }
            //    }
                    
            //    }
            //}


        }

    }
    
}
