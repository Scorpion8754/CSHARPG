namespace RPG
{
    public class Player : Character
    {

        public Player()
        {
            health = 100;
            maxHealth = health;
            strength = 10;
            playerFighter = true;
            for (int i = 0; i < 5; i++)
            {
                pots.Add(new HealthPotion());
            }
        }

        public override void levelUp()
        {
            level++;
            LevelUp levelUp = new LevelUp();
        }

    }
}
