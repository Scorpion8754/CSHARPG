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
        public Character theHero;
        public Boolean inCombat = false;
        public Hub()
        {
            InitializeComponent();
        }

        public void Hub_Load(object sender, EventArgs e)
        {
            Test1.Show();
        }
        public void combat(Character first, Character second) 
        {
            inCombat = true;
            while (inCombat == true)
            {
                update(second);
                update(first);
                first.attack(second);
                listBox1.Update();
                printBox(first.name + " attacks " + second.name + " for " + first.strength + " damage.");
                listBox1.Update();
                update(second);
                System.Threading.Thread.Sleep(1000);
                second.attack(first);
                printBox(second.name + " attacks " + first.name + " for " + second.strength + " damage.");
                listBox1.Update();
                update(first);
                System.Threading.Thread.Sleep(1000);
            }

        }
        private void update(Character check)
        { //All this does is figure out what kind of Character is being passed and passes it through its respective update function...
            Type checkClass = check.GetType(); //if ever in a scenario where youre not sure what kind of character you're updating...
            if (checkClass.Equals(typeof(Player))) { updateHero(check); } //you can just put it through this function.
            else { updateEnemy(check); }
        }


        public void updateHero(Character hero) //updates all the player labels
        {
            this.Show();
            theHero = hero;
            groupBox1.Text = hero.name;
            progressBar1.Maximum = hero.maxHealth;
            strLabel.Text = "Strength: " + hero.strength.ToString();
            healthLabel.Text = hero.health.ToString();
            if(hero.health > 0)
            { 
                progressBar1.Value = hero.health;

            }
            else
            {
                progressBar1.Value = 0;
                System.Windows.Forms.MessageBox.Show("You dead");
                Application.Exit();
            }
            groupBox1.Update();
            strLabel.Update();
            healthLabel.Update();
        }

        public void updateEnemy(Character enemy)
        {
            groupBox2.Text = enemy.name;
            enemyHealthBar.Maximum = enemy.maxHealth;
            enemyHealthBar.Value = enemy.health;
            enemyHealthLabel.Text = enemy.health.ToString();
            enemyStrLabel.Text = "Strength: " + enemy.strength.ToString();
            if(enemy.health <= 0)
            {
                enemy.health = 0;
                inCombat = false;
                enemyHealthBar.Value = enemy.health;
                groupBox2.Hide();
                groupBox2.Update();
                
            }
            else { groupBox2.Show(); groupBox2.Update(); }
            enemyHealthBar.Update();
            groupBox2.Update();
            enemyHealthLabel.Update();
            enemyStrLabel.Update();
        }
        private void printBox(string input)
        {
            listBox1.Items.Add(input);
            int visibleItems = listBox1.ClientSize.Height / listBox1.ItemHeight;
            listBox1.TopIndex = Math.Max(listBox1.Items.Count - visibleItems + 1, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rat ratboi = new Rat();
            updateEnemy(ratboi);
            combat(ratboi, theHero);
            update(theHero);
            update(ratboi);
        }

        private void Hub_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
