using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RPG
{
    public partial class Hub : Form
    {
        public static Character theHero;
        public static Character theEnemy;
        public static int monsterID;
        public static List<Character> pokedex = new List<Character>();
        public Boolean inCombat = false;
        public Boolean playerTurn = true;
        public Hub()
        {
            InitializeComponent();
        }

        public void Hub_Load(object sender, EventArgs e)
        {
            Test1.Show();
        }

        public void combat() //The first monster passed through combat attacks the second
        {
            if (inCombat == true)
            {
                update(theHero);
                update(theEnemy);
                if (playerTurn == false)
                {
                    string action = theEnemy.combatMove(theHero);
                    if (action == "attack") { printBox(theEnemy.name + " attacks " + theHero.name + " for " + theEnemy.strength.ToString() + " damage."); }
                    if (action == "heal") { printBox(theEnemy.name + " uses a potion and restores" + theEnemy.pots[0].healthValue.ToString() + " health."); update(theEnemy); }
                    playerTurn = true;
                    combat();
                }
                else
                {
                    attackButton.Show();
                    PotionButton.Show();
                }
                update(theHero);
            }
        }

        private void update(Character check)
        {   //All this does is figure out what kind of Character is being passed and passes it through its respective update function...
            //if ever in a scenario where youre not sure what kind of character you're updating you can just put it through this function.
            if (check.playerFighter == false) { updateEnemy(check); }
            else { updateHero(check); }
        }

        public void initHero(Character hero)
        {
            this.Show();
            hero.health = hero.maxHealth;
            hero.Death += playerDeath;
            theHero = hero;
            //testing stuff
            Monster HobreRat = new Rat();
            HobreRat.playerFighter = true;
            HobreRat.name = "Tony the Rat";
            pokedex.Add(HobreRat);
            pokedex.Add(new God());
            pokedex.Add(new Rat());
            updateHero(hero); //this should (probably) always be on the bottom
        }

        public void updateHero(Character hero) //HERO UPDATE FUNCTION
        {
            groupBox1.Text = hero.name;
            progressBar1.Maximum = hero.maxHealth;
            strLabel.Text = "Strength: " + hero.strength.ToString();
            healthLabel.Text = hero.health.ToString();
            PotionButton.Text = "Potion (" + theHero.pots.Count.ToString() + ")";
            if (hero.health > 0)
            {
                progressBar1.Value = hero.health;
            }
            else
            { //DEATH
                hero.health = 0;
                hero.Death += killFeed;
                hero.death();
                hero = null;
                progressBar1.Value = 0;
                pokeBox.Items.Clear();
                for (int i = 0; i < pokedex.Count(); i++)
                {
                    pokeBox.Items.Add(i + 1 + ") " + pokedex[i].name);
                    pokeBox.SelectedItem = pokeBox.Items[i];
                }
                updateHero(theHero);
            }
            groupBox1.Update();
            strLabel.Update();
            healthLabel.Update();
            pokeBox.Items.Clear();
            for (int i = 0; i < pokedex.Count(); i++)
            {
                pokedex[i].playerFighter = true; //Everything in the pokedex HAS to be playerfighter
                pokeBox.Items.Add(i + 1 + ") " + pokedex[i].name);
            }
        }


        public void updateEnemy(Character enemy) //ENEMY UPDATE FUNCTION
        {

            groupBox2.Text = enemy.name;
            enemyHealthBar.Maximum = enemy.maxHealth;
            enemyHealthLabel.Text = enemy.health.ToString();
            enemyStrLabel.Text = "Strength: " + enemy.strength.ToString();
            if (enemy.health <= 0)
            {
                enemy.Death += killFeed;
                enemy.death();
                enemy.health = 0;
                inCombat = false;
                enemyHealthBar.Value = enemy.health;
                enemy = null;
                groupBox2.Hide();
                groupBox2.Update();
            }
            else
            {
                enemyHealthBar.Value = enemy.health;
                groupBox2.Show(); groupBox2.Update();
                inCombat = true;
            }
            enemyHealthBar.Update();
            groupBox2.Update();
            enemyHealthLabel.Update();
            enemyStrLabel.Update();
        }


        public void printBox(string input)
        {
            listBox1.Items.Add(input);
            int visibleItems = listBox1.ClientSize.Height / listBox1.ItemHeight;
            listBox1.TopIndex = Math.Max(listBox1.Items.Count - visibleItems + 1, 0);
            listBox1.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        { //COMBAT TEST
            Rat ratboi = new Rat();
            theEnemy = ratboi;
            ratboi.health = 50;
            ratboi.maxHealth = 50;
            updateEnemy(theEnemy);
            combat();
        }
        private void button2_Click(object sender, EventArgs e)
        { //COMBAT TEST
            theEnemy = new God();
            updateEnemy(theEnemy);
            combat();
        }

        private void Hub_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void gameOver()
        {
            inCombat = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void selectHero_Click(object sender, EventArgs e)
        {

            if (pokeBox.SelectedItem != null && inCombat == false)
            {
                string valueString = pokeBox.SelectedItem.ToString();
                valueString = valueString[0].ToString();
                int value = int.Parse(valueString) - 1;
                pokedex.Add(theHero);
                theHero = pokedex[value];
                pokedex.RemoveAt(value);
                updateHero(theHero);
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (inCombat == true)
            {
                combat();
            }
        }
        public void killFeed(object sender, EventArgs e)
        {
            Character c = sender as Character;
            printBox(c.name + " died!");
        }

        public void playerDeath(object sender, EventArgs e)
        {
            this.Close();
        }


        private void attackButton_Click(object sender, EventArgs e)
        {
            if (inCombat == true && playerTurn == true)
            {
                theHero.attack(theEnemy);
                printBox(theHero.name + " attacks " + theEnemy.name + " for " + theHero.strength.ToString() + " damage.");
                updateEnemy(theEnemy);
                playerTurn = false;
                attackButton.Hide();
                PotionButton.Hide();
                System.Threading.Thread.Sleep(1000);
                combat();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Character user = theHero;
            if (user.pots.Count > 0 && playerTurn == true)
            {
                printBox(user.name + " uses a health potion and restores " + user.pots[0].healthValue.ToString() + " health.");
                user.pots[0].Use(user);
                updateHero(theHero);
                playerTurn = false;
                PotionButton.Hide();
                attackButton.Hide();
                System.Threading.Thread.Sleep(1000);
                combat();
            }
        }
    }
}
