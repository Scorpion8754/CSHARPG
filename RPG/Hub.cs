using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public Hub()
        {
            InitializeComponent();
            
        }

        public void Hub_Load(object sender, EventArgs e)
        {
            Test1.Show();            
        }

        public void combat(Character first, Character second) //The first monster passed through combat gets the first attack
        {            
            update(second);
            update(first);
            first.attack(second);
            Console.Write("YEET");
            printBox(first.name + " attacks " + second.name + " for " + first.strength + " damage.");
            update(second);
            System.Threading.Thread.Sleep(500);
            if (second.health > 0)
            {
                combat(second, first);
            }          

        }
        private void update(Character check)
        { //All this does is figure out what kind of Character is being passed and passes it through its respective update function...
            //Type checkClass = check.GetType(); //if ever in a scenario where youre not sure what kind of character you're updating...
            //if (checkClass.Equals(typeof(Player))) { updateHero(check); } //you can just put it through this function.
            //else { updateEnemy(check); }
            if(check.playerFighter == false) { updateEnemy(check); }
            else { updateHero(check); }
        }

        public void initHero(Character hero)
        {
            this.Show();
            theHero = hero;
            


            //testing shit
            Monster HobreRat = new Rat();
            HobreRat.playerFighter = true;
            HobreRat.name = "Tony the Rat";
            pokedex.Add(HobreRat);

            updateHero(hero); //this should (probably) always be on the bottom


        }
        public void updateHero(Character hero) //HERO UPDATE FUNCTION
        {
            
            groupBox1.Text = hero.name;
            progressBar1.Maximum = hero.maxHealth;
            strLabel.Text = "Strength: " + hero.strength.ToString();
            healthLabel.Text = hero.health.ToString();
            if(hero.health > 0)
            { 
                progressBar1.Value = hero.health;

            }
            else
            { //DEATH
                if(hero.myID == 0) { Application.Exit(); }
                inCombat = false;
                hero.health = 0;
                hero.death();
                hero = null;
                progressBar1.Value = 0;
                Application.Exit();
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
        {
            Rat ratboi = new Rat();
            theEnemy = ratboi;
            updateEnemy(theEnemy);
            
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            theEnemy = new God();
            updateEnemy(theEnemy);
            
        }

        private void Hub_FormClosed(object sender, FormClosedEventArgs e)
        {
            nuke();
        }
        public static void nuke()
        {
            Application.Exit();
        }
        
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void selectHero_Click(object sender, EventArgs e)
        {
            if (pokeBox.SelectedItem != null)
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
                combat(theEnemy, theHero);
            }
        }
    }
}
