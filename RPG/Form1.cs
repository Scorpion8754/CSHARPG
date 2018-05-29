using System;
using System.Windows.Forms;

namespace RPG
{
    public partial class Form1 : Form
    {
        Player hero = new Player();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length > 0) && (textBox1.Text != "What is your name?"))
            {
                this.Hide();
                Hub hub = new Hub();
                hero.name = textBox1.Text.ToString();
                hero.Death += kill;
                hub.initHero(hero);
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void kill(object sender, EventArgs e)
        {

            this.Close();

        }

    }
}

