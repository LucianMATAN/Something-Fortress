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
            this.CivName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StartGame = new System.Windows.Forms.Button();
            this.RaceSelect = new System.Windows.Forms.GroupBox();
            this.Humans = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Goblins = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Orcs = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Custom = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ResourceRate = new System.Windows.Forms.TextBox();
            this.CombatRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RaceSelect.SuspendLayout();
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
            // RaceSelect
            // 
            this.RaceSelect.Controls.Add(this.label4);
            this.RaceSelect.Controls.Add(this.label3);
            this.RaceSelect.Controls.Add(this.CombatRate);
            this.RaceSelect.Controls.Add(this.ResourceRate);
            this.RaceSelect.Controls.Add(this.textBox4);
            this.RaceSelect.Controls.Add(this.Custom);
            this.RaceSelect.Controls.Add(this.textBox3);
            this.RaceSelect.Controls.Add(this.Orcs);
            this.RaceSelect.Controls.Add(this.textBox2);
            this.RaceSelect.Controls.Add(this.Goblins);
            this.RaceSelect.Controls.Add(this.textBox1);
            this.RaceSelect.Controls.Add(this.Humans);
            this.RaceSelect.Location = new System.Drawing.Point(541, 0);
            this.RaceSelect.Name = "RaceSelect";
            this.RaceSelect.Size = new System.Drawing.Size(251, 470);
            this.RaceSelect.TabIndex = 7;
            this.RaceSelect.TabStop = false;
            this.RaceSelect.Text = "Select your Race";
            // 
            // Humans
            // 
            this.Humans.AutoSize = true;
            this.Humans.Location = new System.Drawing.Point(6, 33);
            this.Humans.Name = "Humans";
            this.Humans.Size = new System.Drawing.Size(64, 17);
            this.Humans.TabIndex = 0;
            this.Humans.TabStop = true;
            this.Humans.Text = "Humans";
            this.Humans.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(7, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 47);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "The most balanced of races. \r\nNo bonuses in anything, but no drawbacks either";
            // 
            // Goblins
            // 
            this.Goblins.AutoSize = true;
            this.Goblins.Location = new System.Drawing.Point(6, 112);
            this.Goblins.Name = "Goblins";
            this.Goblins.Size = new System.Drawing.Size(60, 17);
            this.Goblins.TabIndex = 2;
            this.Goblins.TabStop = true;
            this.Goblins.Text = "Goblins";
            this.Goblins.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(7, 152);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 54);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Very fast but weak workers.\r\n50% faster harvesting of resources, but 50% weaker c" +
    "ombat power";
            // 
            // Orcs
            // 
            this.Orcs.AutoSize = true;
            this.Orcs.Location = new System.Drawing.Point(7, 213);
            this.Orcs.Name = "Orcs";
            this.Orcs.Size = new System.Drawing.Size(47, 17);
            this.Orcs.TabIndex = 4;
            this.Orcs.TabStop = true;
            this.Orcs.Text = "Orcs";
            this.Orcs.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(7, 249);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(237, 43);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Tough warrior race.\r\n50% stronger combat power, but 50% slower resource harvestin" +
    "g as a result.";
            // 
            // Custom
            // 
            this.Custom.AutoSize = true;
            this.Custom.Location = new System.Drawing.Point(7, 299);
            this.Custom.Name = "Custom";
            this.Custom.Size = new System.Drawing.Size(84, 17);
            this.Custom.TabIndex = 6;
            this.Custom.TabStop = true;
            this.Custom.Text = "Custom race";
            this.Custom.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(7, 323);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(234, 33);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Create your own custom race and watch your village thrive!";
            // 
            // ResourceRate
            // 
            this.ResourceRate.Location = new System.Drawing.Point(6, 381);
            this.ResourceRate.Name = "ResourceRate";
            this.ResourceRate.Size = new System.Drawing.Size(100, 20);
            this.ResourceRate.TabIndex = 8;
            // 
            // CombatRate
            // 
            this.CombatRate.Location = new System.Drawing.Point(7, 431);
            this.CombatRate.Name = "CombatRate";
            this.CombatRate.Size = new System.Drawing.Size(100, 20);
            this.CombatRate.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Resource harvesting rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Combat power multiplier";
            // 
            // New_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 482);
            this.Controls.Add(this.RaceSelect);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CivName);
            this.Controls.Add(this.exit);
            this.Name = "New_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Game";
            this.RaceSelect.ResumeLayout(false);
            this.RaceSelect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox CivName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.GroupBox RaceSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CombatRate;
        private System.Windows.Forms.TextBox ResourceRate;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RadioButton Custom;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton Orcs;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton Goblins;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton Humans;
    }
}