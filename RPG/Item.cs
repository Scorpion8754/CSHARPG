using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Item
    {
        public int value;
        public string description;
    }
    class HealthPotion : Item
    {
        public int healthValue;
        public HealthPotion()
        {
            value = 10;
            healthValue = 10;
            description = "Doesn't taste good, but drinking it will restore 10 health points.";

        }
        public void Use(Character user)
        {
            user.health += 10;
        }
    }
}
