using System;
using System.Collections.Generic;
using System.Linq;

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

        public event EventHandler Death;
        public event EventHandler PlayerMove;

        public Character()
        {
            myID = Hub.monsterID;
            Hub.monsterID += 1;
        }
        public virtual string combatMove(Character enemy)
        {
            if (health < maxHealth / 2 && pots.Count > 0)
            {
                string healvalue = pots[0].healthValue.ToString();
                pots[0].Use(this);
                return (name + " uses a health potion, restoring " + healvalue + " health.");
            }
            else
            {
                attack(enemy);
                return (name + " attacks " + enemy.name + " for " + strength.ToString() + " damage.");
            }
        }


        public virtual void attack(Character enemy)
        {
            enemy.hurt(strength);
            level = 1;
            neededxp = 100 * (level * 1.33);
        }

        public virtual void hurt(int amount) //Each character has a hurt function instead of just subtracting health...
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

            if (Death != null) { Death(this, EventArgs.Empty); }
            if (playerFighter == true)
            {
                health = 0;
                if (Hub.pokedex.Count > 0)
                {
                    for (int i = 0; i < Hub.pokedex.Count(); i++)
                    {
                        if (Hub.pokedex[i].myID == myID)
                        {
                            Hub.pokedex.RemoveAt(i);
                        }

                    }
                    Hub.theHero = Hub.pokedex[0];
                    Hub.pokedex.RemoveAt(0);
                }
            }

        }


    }

}
