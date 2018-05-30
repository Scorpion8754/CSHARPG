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
            pots.Add(new HealthPotion());
        }
    }

    public class God : Monster
    {
        public God()
        {
            health = 666;
            name = "Punished Shane";
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
