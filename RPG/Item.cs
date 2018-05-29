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
            user.health += healthValue;
            user.pots.Remove(this);
            if (user.health > user.maxHealth) { user.health = user.maxHealth; }
        }
    }
}
