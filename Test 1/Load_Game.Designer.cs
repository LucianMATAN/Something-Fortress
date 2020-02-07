namespace Test_1
{
    partial class Load_Game
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
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CivName = new System.Windows.Forms.TextBox();
            this.Load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(305, 284);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(80, 40);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Return to Menu";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Civilization Name:";
            // 
            // CivName
            // 
            this.CivName.Location = new System.Drawing.Point(305, 119);
            this.CivName.Name = "CivName";
            this.CivName.Size = new System.Drawing.Size(100, 20);
            this.CivName.TabIndex = 2;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(305, 208);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 3;
            this.Load.Text = "Load Game";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Load_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.CivName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Name = "Load_Game";
            this.Text = "Load_Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CivName;
        private System.Windows.Forms.Button Load;
    }
}