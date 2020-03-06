namespace Test_1
{
    partial class BattleScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.EnemyCP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.YourCp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EnemyFirst = new System.Windows.Forms.RadioButton();
            this.Defend = new System.Windows.Forms.RadioButton();
            this.Attack = new System.Windows.Forms.RadioButton();
            this.StrattegyButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enemy Combat Power";
            // 
            // EnemyCP
            // 
            this.EnemyCP.AutoSize = true;
            this.EnemyCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnemyCP.Location = new System.Drawing.Point(243, 13);
            this.EnemyCP.Name = "EnemyCP";
            this.EnemyCP.Size = new System.Drawing.Size(70, 25);
            this.EnemyCP.TabIndex = 1;
            this.EnemyCP.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Your Combat Power";
            // 
            // YourCp
            // 
            this.YourCp.AutoSize = true;
            this.YourCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourCp.Location = new System.Drawing.Point(243, 56);
            this.YourCp.Name = "YourCp";
            this.YourCp.Size = new System.Drawing.Size(70, 25);
            this.YourCp.TabIndex = 3;
            this.YourCp.Text = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EnemyFirst);
            this.groupBox1.Controls.Add(this.Defend);
            this.groupBox1.Controls.Add(this.Attack);
            this.groupBox1.Location = new System.Drawing.Point(588, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // EnemyFirst
            // 
            this.EnemyFirst.AutoSize = true;
            this.EnemyFirst.Location = new System.Drawing.Point(6, 65);
            this.EnemyFirst.Name = "EnemyFirst";
            this.EnemyFirst.Size = new System.Drawing.Size(134, 17);
            this.EnemyFirst.TabIndex = 2;
            this.EnemyFirst.TabStop = true;
            this.EnemyFirst.Text = "Leave troops to decide";
            this.EnemyFirst.UseVisualStyleBackColor = true;
            // 
            // Defend
            // 
            this.Defend.AutoSize = true;
            this.Defend.Location = new System.Drawing.Point(6, 42);
            this.Defend.Name = "Defend";
            this.Defend.Size = new System.Drawing.Size(60, 17);
            this.Defend.TabIndex = 1;
            this.Defend.TabStop = true;
            this.Defend.Text = "Defend";
            this.Defend.UseVisualStyleBackColor = true;
            // 
            // Attack
            // 
            this.Attack.AutoSize = true;
            this.Attack.Location = new System.Drawing.Point(6, 19);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(78, 17);
            this.Attack.TabIndex = 0;
            this.Attack.TabStop = true;
            this.Attack.Text = "Attack First";
            this.Attack.UseVisualStyleBackColor = true;
            // 
            // StrattegyButton
            // 
            this.StrattegyButton.Location = new System.Drawing.Point(588, 131);
            this.StrattegyButton.Name = "StrattegyButton";
            this.StrattegyButton.Size = new System.Drawing.Size(75, 23);
            this.StrattegyButton.TabIndex = 5;
            this.StrattegyButton.Text = "Fight!";
            this.StrattegyButton.UseVisualStyleBackColor = true;
            this.StrattegyButton.Click += new System.EventHandler(this.StrattegyButton_Click);
            // 
            // BattleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StrattegyButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.YourCp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnemyCP);
            this.Controls.Add(this.label1);
            this.Name = "BattleScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BattleScreen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BattleScreen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EnemyCP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label YourCp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton EnemyFirst;
        private System.Windows.Forms.RadioButton Defend;
        private System.Windows.Forms.RadioButton Attack;
        private System.Windows.Forms.Button StrattegyButton;
    }
}