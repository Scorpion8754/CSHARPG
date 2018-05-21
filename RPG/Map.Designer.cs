namespace RPG
{
    partial class Map
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
            this.startAreaButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startAreaButton
            // 
            this.startAreaButton.Location = new System.Drawing.Point(54, 336);
            this.startAreaButton.Name = "startAreaButton";
            this.startAreaButton.Size = new System.Drawing.Size(21, 23);
            this.startAreaButton.TabIndex = 0;
            this.startAreaButton.Text = "X";
            this.startAreaButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.startAreaButton);
            this.Name = "Map";
            this.Text = "Map";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startAreaButton;
        private System.Windows.Forms.Button button1;
    }
}