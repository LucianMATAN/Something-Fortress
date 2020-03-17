﻿namespace Test_1
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Stone = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Gold = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Iron = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Wood = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Idlers = new System.Windows.Forms.Label();
            this.StoneWorkers = new System.Windows.Forms.Label();
            this.SWUp = new System.Windows.Forms.Label();
            this.SWDown = new System.Windows.Forms.Label();
            this.SWCount = new System.Windows.Forms.Label();
            this.workers_updater = new System.Windows.Forms.Timer(this.components);
            this.Stone_count = new System.Windows.Forms.Label();
            this.StoneCount = new System.Windows.Forms.Label();
            this.resource_updater = new System.Windows.Forms.Timer(this.components);
            this.Idler_count = new System.Windows.Forms.Label();
            this.WWCount = new System.Windows.Forms.Label();
            this.WWDown = new System.Windows.Forms.Label();
            this.WWUp = new System.Windows.Forms.Label();
            this.Wood_Workers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WoodCount = new System.Windows.Forms.Label();
            this.IronWorkers = new System.Windows.Forms.Label();
            this.IWUp = new System.Windows.Forms.Label();
            this.IWDown = new System.Windows.Forms.Label();
            this.IWCount = new System.Windows.Forms.Label();
            this.GoldWorkers = new System.Windows.Forms.Label();
            this.GWUp = new System.Windows.Forms.Label();
            this.GWCount = new System.Windows.Forms.Label();
            this.GWDown = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IronCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GoldCount = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.SUp = new System.Windows.Forms.Label();
            this.SDown = new System.Windows.Forms.Label();
            this.SCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CP = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.RaidTimer = new System.Windows.Forms.Timer(this.components);
            this.AddingWorkers = new System.Windows.Forms.Timer(this.components);
            this.Achievements = new System.Windows.Forms.Button();
            this.Research = new System.Windows.Forms.Button();
            this.GroupArchers = new System.Windows.Forms.GroupBox();
            this.ACount = new System.Windows.Forms.Label();
            this.ADown = new System.Windows.Forms.Label();
            this.AUp = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.Scientists = new System.Windows.Forms.Label();
            this.ScienceCount = new System.Windows.Forms.Label();
            this.ScienceUp = new System.Windows.Forms.Label();
            this.ScienceDown = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ResearchPointsCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.GroupArchers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(6, 608);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit to Menu";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Stone
            // 
            this.Stone.AutoSize = true;
            this.Stone.Location = new System.Drawing.Point(42, 97);
            this.Stone.Name = "Stone";
            this.Stone.Size = new System.Drawing.Size(35, 13);
            this.Stone.TabIndex = 2;
            this.Stone.Text = "Stone";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 499);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Gold
            // 
            this.Gold.AutoSize = true;
            this.Gold.Location = new System.Drawing.Point(42, 483);
            this.Gold.Name = "Gold";
            this.Gold.Size = new System.Drawing.Size(29, 13);
            this.Gold.TabIndex = 4;
            this.Gold.Text = "Gold";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 376);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(108, 91);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // Iron
            // 
            this.Iron.AutoSize = true;
            this.Iron.Location = new System.Drawing.Point(42, 360);
            this.Iron.Name = "Iron";
            this.Iron.Size = new System.Drawing.Size(25, 13);
            this.Iron.TabIndex = 6;
            this.Iron.Text = "Iron";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(9, 249);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(111, 94);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // Wood
            // 
            this.Wood.AutoSize = true;
            this.Wood.Location = new System.Drawing.Point(42, 233);
            this.Wood.Name = "Wood";
            this.Wood.Size = new System.Drawing.Size(36, 13);
            this.Wood.TabIndex = 8;
            this.Wood.Text = "Wood";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(496, 340);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(117, 106);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // Idlers
            // 
            this.Idlers.AutoSize = true;
            this.Idlers.Location = new System.Drawing.Point(512, 324);
            this.Idlers.Name = "Idlers";
            this.Idlers.Size = new System.Drawing.Size(35, 13);
            this.Idlers.TabIndex = 10;
            this.Idlers.Text = "Idlers:";
            // 
            // StoneWorkers
            // 
            this.StoneWorkers.AutoSize = true;
            this.StoneWorkers.Location = new System.Drawing.Point(12, 9);
            this.StoneWorkers.Name = "StoneWorkers";
            this.StoneWorkers.Size = new System.Drawing.Size(78, 13);
            this.StoneWorkers.TabIndex = 11;
            this.StoneWorkers.Text = "StoneWorkers:";
            // 
            // SWUp
            // 
            this.SWUp.AutoSize = true;
            this.SWUp.Location = new System.Drawing.Point(6, 49);
            this.SWUp.Name = "SWUp";
            this.SWUp.Size = new System.Drawing.Size(19, 13);
            this.SWUp.TabIndex = 12;
            this.SWUp.Text = "+1";
            this.SWUp.Click += new System.EventHandler(this.SWUp_Click);
            // 
            // SWDown
            // 
            this.SWDown.AutoSize = true;
            this.SWDown.Location = new System.Drawing.Point(74, 49);
            this.SWDown.Name = "SWDown";
            this.SWDown.Size = new System.Drawing.Size(16, 13);
            this.SWDown.TabIndex = 13;
            this.SWDown.Text = "-1";
            this.SWDown.Click += new System.EventHandler(this.SWDown_Click);
            // 
            // SWCount
            // 
            this.SWCount.AutoSize = true;
            this.SWCount.Location = new System.Drawing.Point(87, 9);
            this.SWCount.Name = "SWCount";
            this.SWCount.Size = new System.Drawing.Size(35, 13);
            this.SWCount.TabIndex = 14;
            this.SWCount.Text = "label1";
            // 
            // workers_updater
            // 
            this.workers_updater.Enabled = true;
            this.workers_updater.Tick += new System.EventHandler(this.Workers_updater_Tick);
            // 
            // Stone_count
            // 
            this.Stone_count.AutoSize = true;
            this.Stone_count.Location = new System.Drawing.Point(949, 151);
            this.Stone_count.Name = "Stone_count";
            this.Stone_count.Size = new System.Drawing.Size(75, 13);
            this.Stone_count.TabIndex = 15;
            this.Stone_count.Text = "Current Stone:";
            // 
            // StoneCount
            // 
            this.StoneCount.AutoSize = true;
            this.StoneCount.Location = new System.Drawing.Point(1031, 150);
            this.StoneCount.Name = "StoneCount";
            this.StoneCount.Size = new System.Drawing.Size(0, 13);
            this.StoneCount.TabIndex = 16;
            // 
            // resource_updater
            // 
            this.resource_updater.Enabled = true;
            this.resource_updater.Interval = 1000;
            this.resource_updater.Tick += new System.EventHandler(this.Resource_updater_Tick);
            // 
            // Idler_count
            // 
            this.Idler_count.AutoSize = true;
            this.Idler_count.Location = new System.Drawing.Point(551, 324);
            this.Idler_count.Name = "Idler_count";
            this.Idler_count.Size = new System.Drawing.Size(13, 13);
            this.Idler_count.TabIndex = 17;
            this.Idler_count.Text = "0";
            // 
            // WWCount
            // 
            this.WWCount.AutoSize = true;
            this.WWCount.Location = new System.Drawing.Point(203, 9);
            this.WWCount.Name = "WWCount";
            this.WWCount.Size = new System.Drawing.Size(35, 13);
            this.WWCount.TabIndex = 21;
            this.WWCount.Text = "label1";
            // 
            // WWDown
            // 
            this.WWDown.AutoSize = true;
            this.WWDown.Location = new System.Drawing.Point(191, 49);
            this.WWDown.Name = "WWDown";
            this.WWDown.Size = new System.Drawing.Size(16, 13);
            this.WWDown.TabIndex = 20;
            this.WWDown.Text = "-1";
            this.WWDown.Click += new System.EventHandler(this.WWDown_Click);
            // 
            // WWUp
            // 
            this.WWUp.AutoSize = true;
            this.WWUp.Location = new System.Drawing.Point(122, 49);
            this.WWUp.Name = "WWUp";
            this.WWUp.Size = new System.Drawing.Size(19, 13);
            this.WWUp.TabIndex = 19;
            this.WWUp.Text = "+1";
            this.WWUp.Click += new System.EventHandler(this.WWUp_Click);
            // 
            // Wood_Workers
            // 
            this.Wood_Workers.AutoSize = true;
            this.Wood_Workers.Location = new System.Drawing.Point(128, 9);
            this.Wood_Workers.Name = "Wood_Workers";
            this.Wood_Workers.Size = new System.Drawing.Size(79, 13);
            this.Wood_Workers.TabIndex = 18;
            this.Wood_Workers.Text = "WoodWorkers:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(949, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Current Wood:";
            // 
            // WoodCount
            // 
            this.WoodCount.AutoSize = true;
            this.WoodCount.Location = new System.Drawing.Point(1042, 289);
            this.WoodCount.Name = "WoodCount";
            this.WoodCount.Size = new System.Drawing.Size(0, 13);
            this.WoodCount.TabIndex = 23;
            // 
            // IronWorkers
            // 
            this.IronWorkers.AutoSize = true;
            this.IronWorkers.Location = new System.Drawing.Point(254, 8);
            this.IronWorkers.Name = "IronWorkers";
            this.IronWorkers.Size = new System.Drawing.Size(68, 13);
            this.IronWorkers.TabIndex = 24;
            this.IronWorkers.Text = "IronWorkers:";
            // 
            // IWUp
            // 
            this.IWUp.AutoSize = true;
            this.IWUp.Location = new System.Drawing.Point(257, 48);
            this.IWUp.Name = "IWUp";
            this.IWUp.Size = new System.Drawing.Size(19, 13);
            this.IWUp.TabIndex = 25;
            this.IWUp.Text = "+1";
            this.IWUp.Click += new System.EventHandler(this.IWUp_Click);
            // 
            // IWDown
            // 
            this.IWDown.AutoSize = true;
            this.IWDown.Location = new System.Drawing.Point(332, 48);
            this.IWDown.Name = "IWDown";
            this.IWDown.Size = new System.Drawing.Size(16, 13);
            this.IWDown.TabIndex = 26;
            this.IWDown.Text = "-1";
            this.IWDown.Click += new System.EventHandler(this.IWDown_Click);
            // 
            // IWCount
            // 
            this.IWCount.AutoSize = true;
            this.IWCount.Location = new System.Drawing.Point(335, 8);
            this.IWCount.Name = "IWCount";
            this.IWCount.Size = new System.Drawing.Size(35, 13);
            this.IWCount.TabIndex = 27;
            this.IWCount.Text = "label5";
            // 
            // GoldWorkers
            // 
            this.GoldWorkers.AutoSize = true;
            this.GoldWorkers.Location = new System.Drawing.Point(392, 9);
            this.GoldWorkers.Name = "GoldWorkers";
            this.GoldWorkers.Size = new System.Drawing.Size(72, 13);
            this.GoldWorkers.TabIndex = 28;
            this.GoldWorkers.Text = "GoldWorkers:";
            // 
            // GWUp
            // 
            this.GWUp.AutoSize = true;
            this.GWUp.Location = new System.Drawing.Point(392, 49);
            this.GWUp.Name = "GWUp";
            this.GWUp.Size = new System.Drawing.Size(19, 13);
            this.GWUp.TabIndex = 29;
            this.GWUp.Text = "+1";
            this.GWUp.Click += new System.EventHandler(this.GWUp_Click);
            // 
            // GWCount
            // 
            this.GWCount.AutoSize = true;
            this.GWCount.Location = new System.Drawing.Point(470, 9);
            this.GWCount.Name = "GWCount";
            this.GWCount.Size = new System.Drawing.Size(35, 13);
            this.GWCount.TabIndex = 30;
            this.GWCount.Text = "label8";
            // 
            // GWDown
            // 
            this.GWDown.AutoSize = true;
            this.GWDown.Location = new System.Drawing.Point(473, 49);
            this.GWDown.Name = "GWDown";
            this.GWDown.Size = new System.Drawing.Size(16, 13);
            this.GWDown.TabIndex = 31;
            this.GWDown.Text = "-1";
            this.GWDown.Click += new System.EventHandler(this.GWDown_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(949, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Current Iron:";
            // 
            // IronCount
            // 
            this.IronCount.AutoSize = true;
            this.IronCount.Location = new System.Drawing.Point(1031, 409);
            this.IronCount.Name = "IronCount";
            this.IronCount.Size = new System.Drawing.Size(0, 13);
            this.IronCount.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(949, 525);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Current Gold:";
            // 
            // GoldCount
            // 
            this.GoldCount.AutoSize = true;
            this.GoldCount.Location = new System.Drawing.Point(1031, 525);
            this.GoldCount.Name = "GoldCount";
            this.GoldCount.Size = new System.Drawing.Size(0, 13);
            this.GoldCount.TabIndex = 35;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(952, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(131, 87);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 36;
            this.pictureBox6.TabStop = false;
            // 
            // SUp
            // 
            this.SUp.AutoSize = true;
            this.SUp.Location = new System.Drawing.Point(960, 65);
            this.SUp.Name = "SUp";
            this.SUp.Size = new System.Drawing.Size(19, 13);
            this.SUp.TabIndex = 38;
            this.SUp.Text = "+1";
            this.SUp.Click += new System.EventHandler(this.SUp_Click);
            // 
            // SDown
            // 
            this.SDown.AutoSize = true;
            this.SDown.Location = new System.Drawing.Point(1047, 65);
            this.SDown.Name = "SDown";
            this.SDown.Size = new System.Drawing.Size(16, 13);
            this.SDown.TabIndex = 39;
            this.SDown.Text = "-1";
            this.SDown.Click += new System.EventHandler(this.SDown_Click);
            // 
            // SCount
            // 
            this.SCount.AutoSize = true;
            this.SCount.Location = new System.Drawing.Point(1047, 13);
            this.SCount.Name = "SCount";
            this.SCount.Size = new System.Drawing.Size(0, 13);
            this.SCount.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(365, 577);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Combat Power:";
            // 
            // CP
            // 
            this.CP.AutoSize = true;
            this.CP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CP.Location = new System.Drawing.Point(549, 577);
            this.CP.Name = "CP";
            this.CP.Size = new System.Drawing.Size(0, 25);
            this.CP.TabIndex = 44;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(992, 305);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(91, 90);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 45;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(992, 167);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(91, 90);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 46;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(992, 425);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(91, 90);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 47;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(992, 541);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(91, 90);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 48;
            this.pictureBox10.TabStop = false;
            // 
            // RaidTimer
            // 
            this.RaidTimer.Enabled = true;
            this.RaidTimer.Interval = 300000;
            this.RaidTimer.Tick += new System.EventHandler(this.RaidTimer_Tick);
            // 
            // Achievements
            // 
            this.Achievements.Location = new System.Drawing.Point(87, 608);
            this.Achievements.Name = "Achievements";
            this.Achievements.Size = new System.Drawing.Size(85, 23);
            this.Achievements.TabIndex = 49;
            this.Achievements.Text = "Achievements";
            this.Achievements.UseVisualStyleBackColor = true;
            this.Achievements.Click += new System.EventHandler(this.Achievements_Click);
            // 
            // Research
            // 
            this.Research.Location = new System.Drawing.Point(178, 608);
            this.Research.Name = "Research";
            this.Research.Size = new System.Drawing.Size(75, 23);
            this.Research.TabIndex = 50;
            this.Research.Text = "Research";
            this.Research.UseVisualStyleBackColor = true;
            this.Research.Click += new System.EventHandler(this.Research_Click);
            // 
            // GroupArchers
            // 
            this.GroupArchers.Controls.Add(this.ACount);
            this.GroupArchers.Controls.Add(this.ADown);
            this.GroupArchers.Controls.Add(this.AUp);
            this.GroupArchers.Controls.Add(this.pictureBox11);
            this.GroupArchers.Location = new System.Drawing.Point(719, 8);
            this.GroupArchers.Name = "GroupArchers";
            this.GroupArchers.Size = new System.Drawing.Size(208, 102);
            this.GroupArchers.TabIndex = 51;
            this.GroupArchers.TabStop = false;
            // 
            // ACount
            // 
            this.ACount.AutoSize = true;
            this.ACount.Location = new System.Drawing.Point(114, 41);
            this.ACount.Name = "ACount";
            this.ACount.Size = new System.Drawing.Size(41, 13);
            this.ACount.TabIndex = 3;
            this.ACount.Text = "Acount";
            // 
            // ADown
            // 
            this.ADown.AutoSize = true;
            this.ADown.Location = new System.Drawing.Point(111, 83);
            this.ADown.Name = "ADown";
            this.ADown.Size = new System.Drawing.Size(16, 13);
            this.ADown.TabIndex = 2;
            this.ADown.Text = "-1";
            // 
            // AUp
            // 
            this.AUp.AutoSize = true;
            this.AUp.Location = new System.Drawing.Point(111, 5);
            this.AUp.Name = "AUp";
            this.AUp.Size = new System.Drawing.Size(19, 13);
            this.AUp.TabIndex = 1;
            this.AUp.Text = "+1";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(0, 5);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(104, 97);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 0;
            this.pictureBox11.TabStop = false;
            // 
            // Scientists
            // 
            this.Scientists.AutoSize = true;
            this.Scientists.Location = new System.Drawing.Point(507, 8);
            this.Scientists.Name = "Scientists";
            this.Scientists.Size = new System.Drawing.Size(55, 13);
            this.Scientists.TabIndex = 52;
            this.Scientists.Text = "Scientists:";
            // 
            // ScienceCount
            // 
            this.ScienceCount.AutoSize = true;
            this.ScienceCount.Location = new System.Drawing.Point(568, 9);
            this.ScienceCount.Name = "ScienceCount";
            this.ScienceCount.Size = new System.Drawing.Size(0, 13);
            this.ScienceCount.TabIndex = 53;
            // 
            // ScienceUp
            // 
            this.ScienceUp.AutoSize = true;
            this.ScienceUp.Location = new System.Drawing.Point(515, 48);
            this.ScienceUp.Name = "ScienceUp";
            this.ScienceUp.Size = new System.Drawing.Size(19, 13);
            this.ScienceUp.TabIndex = 54;
            this.ScienceUp.Text = "+1";
            this.ScienceUp.Click += new System.EventHandler(this.ScienceUp_Click);
            // 
            // ScienceDown
            // 
            this.ScienceDown.AutoSize = true;
            this.ScienceDown.Location = new System.Drawing.Point(568, 48);
            this.ScienceDown.Name = "ScienceDown";
            this.ScienceDown.Size = new System.Drawing.Size(16, 13);
            this.ScienceDown.TabIndex = 55;
            this.ScienceDown.Text = "-1";
            this.ScienceDown.Click += new System.EventHandler(this.ScienceDown_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(367, 541);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 25);
            this.label5.TabIndex = 56;
            this.label5.Text = "Research Points:";
            // 
            // ResearchPointsCount
            // 
            this.ResearchPointsCount.AutoSize = true;
            this.ResearchPointsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResearchPointsCount.Location = new System.Drawing.Point(549, 541);
            this.ResearchPointsCount.Name = "ResearchPointsCount";
            this.ResearchPointsCount.Size = new System.Drawing.Size(0, 25);
            this.ResearchPointsCount.TabIndex = 57;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 633);
            this.Controls.Add(this.ResearchPointsCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ScienceDown);
            this.Controls.Add(this.ScienceUp);
            this.Controls.Add(this.ScienceCount);
            this.Controls.Add(this.Scientists);
            this.Controls.Add(this.GroupArchers);
            this.Controls.Add(this.Research);
            this.Controls.Add(this.Achievements);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.SDown);
            this.Controls.Add(this.SUp);
            this.Controls.Add(this.CP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SCount);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.GoldCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IronCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GWDown);
            this.Controls.Add(this.GWCount);
            this.Controls.Add(this.GWUp);
            this.Controls.Add(this.GoldWorkers);
            this.Controls.Add(this.IWCount);
            this.Controls.Add(this.IWDown);
            this.Controls.Add(this.IWUp);
            this.Controls.Add(this.IronWorkers);
            this.Controls.Add(this.WoodCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WWCount);
            this.Controls.Add(this.WWDown);
            this.Controls.Add(this.WWUp);
            this.Controls.Add(this.Wood_Workers);
            this.Controls.Add(this.Idler_count);
            this.Controls.Add(this.StoneCount);
            this.Controls.Add(this.Stone_count);
            this.Controls.Add(this.SWCount);
            this.Controls.Add(this.SWDown);
            this.Controls.Add(this.SWUp);
            this.Controls.Add(this.StoneWorkers);
            this.Controls.Add(this.Idlers);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Wood);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Iron);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Gold);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Stone);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.GroupArchers.ResumeLayout(false);
            this.GroupArchers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Stone;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Gold;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Iron;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label Wood;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label Idlers;
        private System.Windows.Forms.Label StoneWorkers;
        private System.Windows.Forms.Label SWUp;
        private System.Windows.Forms.Label SWDown;
        private System.Windows.Forms.Label SWCount;
        private System.Windows.Forms.Timer workers_updater;
        private System.Windows.Forms.Label Stone_count;
        private System.Windows.Forms.Label StoneCount;
        private System.Windows.Forms.Timer resource_updater;
        private System.Windows.Forms.Label Idler_count;
        private System.Windows.Forms.Label WWCount;
        private System.Windows.Forms.Label WWDown;
        private System.Windows.Forms.Label WWUp;
        private System.Windows.Forms.Label Wood_Workers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WoodCount;
        private System.Windows.Forms.Label IronWorkers;
        private System.Windows.Forms.Label IWUp;
        private System.Windows.Forms.Label IWDown;
        private System.Windows.Forms.Label IWCount;
        private System.Windows.Forms.Label GoldWorkers;
        private System.Windows.Forms.Label GWUp;
        private System.Windows.Forms.Label GWCount;
        private System.Windows.Forms.Label GWDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IronCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label GoldCount;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label SUp;
        private System.Windows.Forms.Label SDown;
        private System.Windows.Forms.Label SCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CP;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Timer RaidTimer;
        private System.Windows.Forms.Timer AddingWorkers;
        private System.Windows.Forms.Button Achievements;
        private System.Windows.Forms.Button Research;
        private System.Windows.Forms.GroupBox GroupArchers;
        private System.Windows.Forms.Label ACount;
        private System.Windows.Forms.Label ADown;
        private System.Windows.Forms.Label AUp;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Label Scientists;
        private System.Windows.Forms.Label ScienceCount;
        private System.Windows.Forms.Label ScienceUp;
        private System.Windows.Forms.Label ScienceDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ResearchPointsCount;
    }
}