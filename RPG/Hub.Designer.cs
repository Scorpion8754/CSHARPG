namespace RPG
{
    partial class Hub
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.strLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Test1 = new System.Windows.Forms.Button();
            this.enemyStrLabel = new System.Windows.Forms.Label();
            this.enemyHealthLabel = new System.Windows.Forms.Label();
            this.enemyHealthBar = new System.Windows.Forms.ProgressBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pokeBox = new System.Windows.Forms.ComboBox();
            this.selectHero = new System.Windows.Forms.Button();
            this.FightButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.attackButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.strLabel);
            this.groupBox1.Controls.Add(this.healthLabel);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // strLabel
            // 
            this.strLabel.AutoSize = true;
            this.strLabel.Location = new System.Drawing.Point(5, 71);
            this.strLabel.Name = "strLabel";
            this.strLabel.Size = new System.Drawing.Size(65, 13);
            this.strLabel.TabIndex = 3;
            this.strLabel.Text = "Strength: 69";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Location = new System.Drawing.Point(48, 45);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(25, 13);
            this.healthLabel.TabIndex = 2;
            this.healthLabel.Text = "999";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(119, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // Test1
            // 
            this.Test1.Location = new System.Drawing.Point(185, 25);
            this.Test1.Name = "Test1";
            this.Test1.Size = new System.Drawing.Size(75, 23);
            this.Test1.TabIndex = 1;
            this.Test1.Text = "Spawn Rat";
            this.Test1.UseVisualStyleBackColor = true;
            this.Test1.Visible = false;
            this.Test1.Click += new System.EventHandler(this.button1_Click);
            // 
            // enemyStrLabel
            // 
            this.enemyStrLabel.AutoSize = true;
            this.enemyStrLabel.Location = new System.Drawing.Point(5, 71);
            this.enemyStrLabel.Name = "enemyStrLabel";
            this.enemyStrLabel.Size = new System.Drawing.Size(65, 13);
            this.enemyStrLabel.TabIndex = 3;
            this.enemyStrLabel.Text = "Strength: 69";
            // 
            // enemyHealthLabel
            // 
            this.enemyHealthLabel.AutoSize = true;
            this.enemyHealthLabel.Location = new System.Drawing.Point(48, 45);
            this.enemyHealthLabel.Name = "enemyHealthLabel";
            this.enemyHealthLabel.Size = new System.Drawing.Size(25, 13);
            this.enemyHealthLabel.TabIndex = 2;
            this.enemyHealthLabel.Text = "999";
            // 
            // enemyHealthBar
            // 
            this.enemyHealthBar.Location = new System.Drawing.Point(6, 19);
            this.enemyHealthBar.Name = "enemyHealthBar";
            this.enemyHealthBar.Size = new System.Drawing.Size(119, 23);
            this.enemyHealthBar.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(47, 232);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(350, 95);
            this.listBox1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.enemyHealthBar);
            this.groupBox2.Controls.Add(this.enemyHealthLabel);
            this.groupBox2.Controls.Add(this.enemyStrLabel);
            this.groupBox2.Location = new System.Drawing.Point(302, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 90);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Visible = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pokeBox
            // 
            this.pokeBox.FormattingEnabled = true;
            this.pokeBox.Location = new System.Drawing.Point(12, 108);
            this.pokeBox.Name = "pokeBox";
            this.pokeBox.Size = new System.Drawing.Size(82, 21);
            this.pokeBox.TabIndex = 6;
            // 
            // selectHero
            // 
            this.selectHero.Location = new System.Drawing.Point(95, 108);
            this.selectHero.Name = "selectHero";
            this.selectHero.Size = new System.Drawing.Size(52, 21);
            this.selectHero.TabIndex = 7;
            this.selectHero.Text = "Select";
            this.selectHero.UseVisualStyleBackColor = true;
            this.selectHero.Click += new System.EventHandler(this.selectHero_Click);
            // 
            // FightButton
            // 
            this.FightButton.Location = new System.Drawing.Point(185, 69);
            this.FightButton.Name = "FightButton";
            this.FightButton.Size = new System.Drawing.Size(75, 23);
            this.FightButton.TabIndex = 8;
            this.FightButton.Text = "Fight";
            this.FightButton.UseVisualStyleBackColor = true;
            this.FightButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Kill me";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // attackButton
            // 
            this.attackButton.Location = new System.Drawing.Point(7, 148);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(75, 23);
            this.attackButton.TabIndex = 10;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            // 
            // Hub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 348);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FightButton);
            this.Controls.Add(this.selectHero);
            this.Controls.Add(this.pokeBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Test1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Hub";
            this.Text = "Hub";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Hub_FormClosed);
            this.Load += new System.EventHandler(this.Hub_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Test1;
        private System.Windows.Forms.Label strLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label enemyStrLabel;
        private System.Windows.Forms.Label enemyHealthLabel;
        private System.Windows.Forms.ProgressBar enemyHealthBar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox pokeBox;
        private System.Windows.Forms.Button selectHero;
        private System.Windows.Forms.Button FightButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button attackButton;
    }
}