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
            pots.Add(new HealthPotion());
        }
        public override void combatMove(Character enemy)
        {
            attack(enemy);
        }
        public override void levelUp()
        {
            level++;
            LevelUp levelUp = new LevelUp();
        }

    }
}
