namespace Test_1
{
    partial class New_Game
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
            this.exit = new System.Windows.Forms.Button();
            this.Seed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CivName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(289, 312);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(82, 44);
            this.exit.TabIndex = 0;
            this.exit.Text = "Return to Menu";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Seed
            // 
            this.Seed.Location = new System.Drawing.Point(271, 35);
            this.Seed.Name = "Seed";
            this.Seed.Size = new System.Drawing.Size(100, 20);
            this.Seed.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Seed:";
            // 
            // CivName
            // 
            this.CivName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.CivName.Location = new System.Drawing.Point(271, 85);
            this.CivName.Name = "CivName";
            this.CivName.Size = new System.Drawing.Size(100, 20);
            this.CivName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Civilization name:";
            // 
            // StartGame
            // 
            this.StartGame.Location = new System.Drawing.Point(289, 262);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(82, 30);
            this.StartGame.TabIndex = 5;
            this.StartGame.Text = "Start Game!";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // New_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CivName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Seed);
            this.Controls.Add(this.exit);
            this.Name = "New_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox Seed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CivName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartGame;
    }
}