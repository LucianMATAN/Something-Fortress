using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Test_1
{
    public partial class Game : Form
    {
        public string CurrentFile;
        public static double RaidPower;
        public static double VillagePower;
        public Game()
        {
            InitializeComponent();
            this.TopMost = true;

        }
        private void Game_Load(object sender, EventArgs e)
        {
            if (Load_Game.CivLoadName == "")
            {
                OleDbConnection Conn = new OleDbConnection(New_Game.filename);
                CurrentFile = New_Game.filename;
                Conn.Open();
                OleDbCommand Cmd = new OleDbCommand
                {
                    Connection = Conn,
                    CommandText = "SELECT * FROM Map_Resources "
                };
                OleDbDataReader reader = Cmd.ExecuteReader();
                reader.Read();
                Stone.Text = string.Format("{0:N2}", reader["Stone"]) + " " + "Stone";
                Gold.Text = string.Format("{0:N2}", reader["Gold"]) + " " + "Gold";
                Iron.Text = string.Format("{0:N2}", reader["Iron"]) + " " + "Iron";
                Wood.Text = string.Format("{0:N2}", reader["Wood"]) + " " + "Wood";
                reader.Close();
                Cmd.CommandText = "CREATE TABLE Workers(StoneWorkers VARCHAR(20), WoodWorkers VARCHAR(20), IronWorkers VARCHAR(20), GoldWorkers VARCHAR(20),Soldiers VARCHAR(20), Archers VARCHAR(20), Scientists VARCHAR(20), Idlers VARCHAR(20), PRIMARY KEY(Idlers))";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Workers VALUES ('0','0','0','0','0','0','0','10')";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "CREATE TABLE Raids(RaidPower VARCHAR(20), RaidsWon VARCHAR(20), PRIMARY KEY(RaidPower))";
                Cmd.ExecuteNonQuery();
                Conn.Close();
            }
            else if(New_Game.filename=="")
            {
                OleDbConnection Conn = new OleDbConnection(Load_Game.CivLoadName);
                CurrentFile = Load_Game.CivLoadName;
                Conn.Open();
                OleDbCommand Cmd = new OleDbCommand
                {
                    Connection = Conn,
                    CommandText = "SELECT * FROM Map_Resources "
                };
                OleDbDataReader reader = Cmd.ExecuteReader();
                reader.Read();
                Stone.Text = string.Format("{0:N2}", reader["Stone"]) + " " + "Stone";
                Gold.Text = string.Format("{0:N2}", reader["Gold"]) + " " + "Gold";
                Iron.Text = string.Format("{0:N2}", reader["Iron"]) + " " + "Iron";
                Wood.Text = string.Format("{0:N2}", reader["Wood"]) + " " + "Wood";
                reader.Close();
                Conn.Close();
            }
            else
            {
                MessageBox.Show("Something has gone wrong. Returning to menu");
                this.Close();
            }
            GroupArchers.Hide();

        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SWUp_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(CurrentFile);
            OleDbCommand Cmd = new OleDbCommand
            {
                Connection = Conn
            };
            Conn.Open();
            Cmd.CommandText = "SELECT * FROM Workers ";
            OleDbDataReader reader = Cmd.ExecuteReader();
            reader.Read();
            int idlers = Convert.ToInt32(reader["Idlers"]);
            reader.Close();
            while (idlers != 0)
            {
                Cmd.CommandText = "UPDATE Workers SET Stoneworkers= StoneWorkers + 1";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "UPDATE Workers SET Idlers = Idlers + -1";
                Cmd.ExecuteNonQuery();
                break;
            }
            if (idlers == 0)
                MessageBox.Show("No more idlers");
            Conn.Close();
        }

        private void SWDown_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(CurrentFile);
            OleDbCommand Cmd = new OleDbCommand
            {
                Connection = Conn
            };
            Conn.Open();
            Cmd.CommandText = "SELECT * FROM Workers ";
            OleDbDataReader reader = Cmd.ExecuteReader();
            reader.Read();
            int workers = Convert.ToInt32(reader["Stoneworkers"]);
            reader.Close();
            while (workers != 0)
            {
                Cmd.CommandText = "UPDATE Workers SET Stoneworkers= StoneWorkers + -1";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "UPDATE Workers SET Idlers = Idlers + 1";
                Cmd.ExecuteNonQuery();
                break;
            }
            if (workers == 0)
                MessageBox.Show("No more workers");
            Conn.Close();
        }

        private void Workers_updater_Tick(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(CurrentFile);
            OleDbCommand Cmd = new OleDbCommand
            {
                Connection = Conn
            };
            Conn.Open();
            Cmd.CommandText = "SELECT * FROM Workers ";
            OleDbDataReader reader = Cmd.ExecuteReader();
            reader.Read();
            if (string.Format("{0:N2}",reader["Stoneworkers"]) != "")
            {
                SWCount.Text = string.Format("{0:N2}", reader["Stoneworkers"]);
                Idler_count.Text = string.Format("{0:N2}", reader["Idlers"]);
            }
            if (string.Format("{0:N2}", reader["Woodworkers"]) != "")
            {
                WWCount.Text = string.Format("{0:N2}", reader["Woodworkers"]);
            }
            if (string.Format("{0:N2}", reader["Ironworkers"]) != "")
            {
                IWCount.Text = string.Format("{0:N2}", reader["Ironworkers"]);
            }
            if (string.Format("{0:N2}", reader["Goldworkers"]) != "")
            {
                GWCount.Text = string.Format("{0:N2}", reader["Goldworkers"]);
            }
            if (string.Format("{0:N2}", reader["Soldiers"]) != "")
            {
                SCount.Text = string.Format("{0:N2}", reader["Soldiers"]);
            }
            if (string.Format("{0:N2}", reader["Scientists"]) != "")
            {
                ScienceCount.Text = string.Format("{0:N2}", reader["Scientists"]);
            }
            if (string.Format("{0:N2}", reader["Archers"]) != "")
            {
                ACount.Text = string.Format("{0:N2}", reader["Archers"]);
            }

            reader.Close();
            Conn.Close();

        }

        private void Resource_updater_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                OleDbConnection Conn = new OleDbConnection(CurrentFile);
                OleDbCommand Cmd = new OleDbCommand
                {
                    Connection = Conn
                };
                Conn.Open();
                Cmd.CommandText = "SELECT * FROM Map_resources ";
                OleDbDataReader reader = Cmd.ExecuteReader();
                reader.Read();
                reader.Close();
                Cmd.CommandText = "SELECT * FROM Workers ";
                reader = Cmd.ExecuteReader();
                reader.Read();
                int workers = Convert.ToInt32(reader.GetValue(i));
                reader.Close();
                Cmd.CommandText = "SELECT * FROM Race_Effects ";
                reader = Cmd.ExecuteReader();
                reader.Read();
                double ResourceRate = Convert.ToDouble(reader.GetValue(0));
                double CombatPowerRate = Convert.ToDouble(reader.GetValue(1));
                double ResearchRate = Convert.ToDouble(reader.GetValue(2));
                reader.Close();
                double UserValue;
                VillagePower = workers * 7.5 * CombatPowerRate;
                double ResourceGather = workers * 10 * ResourceRate;
                Cmd.CommandText = "SELECT * FROM Current_resources ";
                reader = Cmd.ExecuteReader();
                reader.Read();
                switch (i)
                {
                    case 0:
                 if (workers > 0)
                 {
                    UserValue = Convert.ToInt32(reader.GetValue(i)) + ResourceGather;
                    reader.Close();
                    Cmd.CommandText = "UPDATE Current_resources SET Stone=";
                    Cmd.CommandText += UserValue;
                    Cmd.ExecuteNonQuery();
                    Cmd.CommandText = "UPDATE Map_resources SET Stone= Stone";
                    Cmd.CommandText += -ResourceGather;
                    Cmd.ExecuteNonQuery();
                    Cmd.CommandText = "SELECT * FROM Map_resources ";
                    reader = Cmd.ExecuteReader();
                    reader.Read();
                    Stone.Text = string.Format("{0:N2}", reader["Stone"]) + " " + "Stone";
                    reader.Close();
                 }
                 else
                 {
                    UserValue = Convert.ToInt32(reader.GetValue(0));
                    reader.Close();
                    Cmd.CommandText = "UPDATE Current_resources SET Stone=";
                    Cmd.CommandText += UserValue;
                    Cmd.ExecuteNonQuery();
                 }
                        StoneCount.Text = Convert.ToString(UserValue);
                        break;
                    case 1:
                        if (workers > 0)
                        {
                            UserValue = Convert.ToInt32(reader.GetValue(i)) + ResourceGather;
                            reader.Close();
                            Cmd.CommandText = "UPDATE Current_resources SET Wood=";
                            Cmd.CommandText += UserValue;
                            Cmd.ExecuteNonQuery();
                            Cmd.CommandText = "UPDATE Map_resources SET Wood= Wood";
                            Cmd.CommandText += -workers * 10;
                            Cmd.ExecuteNonQuery();
                            Cmd.CommandText = "SELECT * FROM Map_resources ";
                            reader = Cmd.ExecuteReader();
                            reader.Read();
                            Wood.Text = string.Format("{0:N2}", reader["Wood"]) + " " + "Wood";
                            reader.Close();
                        }
                        else
                        {
                            UserValue = Convert.ToInt32(reader.GetValue(i));
                            reader.Close();
                            Cmd.CommandText = "UPDATE Current_resources SET Wood=";
                            Cmd.CommandText += UserValue;
                            Cmd.ExecuteNonQuery();
                        }
                        WoodCount.Text = Convert.ToString(UserValue);
                        break;
                    case 2:
                        if (workers > 0)
                        {
                            UserValue = Convert.ToInt32(reader.GetValue(i)) + ResourceGather;
                            reader.Close();
                            Cmd.CommandText = "UPDATE Current_resources SET Iron=";
                            Cmd.CommandText += UserValue;
                            Cmd.ExecuteNonQuery();
                            Cmd.CommandText = "UPDATE Map_resources SET Iron= Iron";
                            Cmd.CommandText += -workers * 10;
                            Cmd.ExecuteNonQuery();
                            Cmd.CommandText = "SELECT * FROM Map_resources ";
                            reader = Cmd.ExecuteReader();
                            reader.Read();
                            Iron.Text = string.Format("{0:N2}", reader["Iron"]) + " " + "Iron";
                            reader.Close();
                        }
                        else
                        {
                            UserValue = Convert.ToInt32(reader.GetValue(i));
                            reader.Close();
                            Cmd.CommandText = "UPDATE Current_resources SET Iron=";
                            Cmd.CommandText += UserValue;
                            Cmd.ExecuteNonQuery();
                        }
                        IronCount.Text = Convert.ToString(UserValue);
                        break;
                    case 3:
                        if (workers > 0)
                        {
                            UserValue = Convert.ToInt32(reader.GetValue(i)) + ResourceGather;
                            reader.Close();
                            Cmd.CommandText = "UPDATE Current_resources SET Gold=";
                            Cmd.CommandText += UserValue;
                            Cmd.ExecuteNonQuery();
                            Cmd.CommandText = "UPDATE Map_resources SET Gold= Gold";
                            Cmd.CommandText += -workers * 10;
                            Cmd.ExecuteNonQuery();
                            Cmd.CommandText = "SELECT * FROM Map_resources ";
                            reader = Cmd.ExecuteReader();
                            reader.Read();
                            Gold.Text = string.Format("{0:N2}", reader["Gold"]) + " " + "Gold";
                            reader.Close();
                        }
                        else
                        {
                            UserValue = Convert.ToInt32(reader.GetValue(i));
                            reader.Close();
                            Cmd.CommandText = "UPDATE Current_resources SET Gold=";
                            Cmd.CommandText += UserValue;
                            Cmd.ExecuteNonQuery();
                        }
                        GoldCount.Text = Convert.ToString(UserValue);
                        break;
                    case 4:
                        CP.Text = Convert.ToString(VillagePower);
                        break;
                    case 6:
                        reader.Close();
                        Cmd.CommandText = "SELECT * FROM Workers ";
                        reader = Cmd.ExecuteReader();
                        reader.Read();
                        workers = Convert.ToInt32(reader.GetValue(6));
                        reader.Close();
                        Cmd.CommandText = "SELECT * FROM Current_resources ";
                        reader = Cmd.ExecuteReader();
                        reader.Read();
                        double Science = workers * 10 * ResearchRate;
                        UserValue = Convert.ToInt32(reader.GetValue(4)) + Science;
                        reader.Close();
                        Cmd.CommandText = "UPDATE Current_resources SET Research=";
                        Cmd.CommandText += UserValue;
                        Cmd.ExecuteNonQuery();
                        ResearchPointsCount.Text = Convert.ToString(UserValue);
                        break;

                }
                Conn.Close();
            }
        }

        private void WWUp_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(CurrentFile);
            OleDbCommand Cmd = new OleDbCommand
            {
                Connection = Conn
            };
            Conn.Open();
            Cmd.CommandText = "SELECT * FROM Workers ";
            OleDbDataReader reader = Cmd.ExecuteReader();
            reader.Read();
            int idlers = Convert.ToInt32(reader["Idlers"]);
            reader.Close();
            while (idlers != 0)
            {
                Cmd.CommandText = "UPDATE Workers SET Woodworkers= WoodWorkers + 1";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "UPDATE Workers SET Idlers = Idlers + -1";
                Cmd.ExecuteNonQuery();
                break;
            }
            if (idlers == 0)
                MessageBox.Show("No more idlers");
            Conn.Close();
        }

        private void WWDown_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(CurrentFile);
            OleDbCommand Cmd = new OleDbCommand
            {
                Connection = Conn
            };
            Conn.Open();
            Cmd.CommandText = "SELECT * FROM Workers ";
            OleDbDataReader reader = Cmd.ExecuteReader();
            reader.Read();
            int workers = Convert.ToInt32(reader["Woodworkers"]);
            reader.Close();
            while (workers != 0)
            {
                Cmd.CommandText = "UPDATE Workers SET Woodworkers= WoodWorkers + -1";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "UPDATE Workers SET Idlers = Idlers + 1";
                Cmd.ExecuteNonQuery();
                break;
            }
            if (workers == 0)
                MessageBox.Show("No more workers");
            Conn.Close();
        }

        private void IWUp_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(CurrentFile);
            OleDbCommand Cmd = new OleDbCommand
            {
                Connection = Conn
            };
            Conn.Open();
            Cmd.CommandText = "SELECT * FROM Workers ";
            OleDbDataReader reader = Cmd.ExecuteReader();
            reader.Read();
            int idlers = Convert.ToInt32(reader["Idlers"]);
            reader.Close();
            while (idlers != 0)
            {
                Cmd.CommandText = "UPDATE Workers SET Ironworkers= IronWorkers + 1";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "UPDATE Workers SET Idlers = Idlers + -1";
                Cmd.ExecuteNonQuery();
                break;
            }
            if (idlers == 0)
                MessageBox.Show("No more idlers");
            Conn.Close();
        }

        private void IWDown_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(CurrentFile);
            OleDbCommand Cmd = new OleDbCommand
            {
                Connection = Conn
            };
            Conn.Open();
            Cmd.CommandText = "SELECT * FROM Workers ";
            OleDbDataReader reader = Cmd.ExecuteReader();
            reader.Read();
            int workers = Convert.ToInt32(reader["Ironworkers"]);
            reader.Close();
            while (workers != 0)
            {
                Cmd.CommandText = "UPDATE Workers SET Ironworkers= IronWorkers + -1";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "UPDATE Workers SET Idlers = Idlers + 1";
                Cmd.ExecuteNonQuery();
                break;
            }
            if (workers == 0)
                MessageBox.Show("No more workers");
            Conn.Close();
        }

        private void GWUp_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(CurrentFile);
            OleDbCommand Cmd = new OleDbCommand
            {
                Connection = Conn
            };
            Conn.Open();
            Cmd.CommandText = "SELECT * FROM Workers ";
            OleDbDataReader reader = Cmd.ExecuteReader();
            reader.Read();
            int idlers = Convert.ToInt32(reader["Idlers"]);
            reader.Close();
            while (idlers != 0)
            {
                Cmd.CommandText = "UPDATE Workers SET Goldworkers= GoldWorkers + 1";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "UPDATE Workers SET Idlers = Idlers + -1";
                Cmd.ExecuteNonQuery();
                break;
            }
            if (idlers == 0)
                MessageBox.Show("No more idlers");
            Conn.Close();
        }

        private void GWDown_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(CurrentFile);
            OleDbCommand Cmd = new OleDbCommand
            {
                Connection = Conn
            };
            Conn.Open();
            Cmd.CommandText = "SELECT * FROM Workers ";
            OleDbDataReader reader = Cmd.ExecuteReader();
            reader.Read();
            int workers = Convert.ToInt32(reader["Goldworkers"]);
            reader.Close();
            while (workers != 0)
            {
                Cmd.CommandText = "UPDATE Workers SET Goldworkers= GoldWorkers + -1";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "UPDATE Workers SET Idlers = Idlers + 1";
                Cmd.ExecuteNonQuery();
                break;
            }
            if (workers == 0)
                MessageBox.Show("No more workers");
            Conn.Close();
        }

        private void SUp_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(CurrentFile);
            OleDbCommand Cmd = new OleDbCommand
            {
                Connection = Conn
            };
            Conn.Open();
            Cmd.CommandText = "SELECT * FROM Workers ";
            OleDbDataReader reader = Cmd.ExecuteReader();
            reader.Read();
            int idlers = Convert.ToInt32(reader["Idlers"]);
            reader.Close();
            while (idlers != 0)
            {
                Cmd.CommandText = "UPDATE Workers SET Soldiers= Soldiers + 1";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "UPDATE Workers SET Idlers = Idlers + -1";
                Cmd.ExecuteNonQuery();
                break;
            }
            if (idlers == 0)
                MessageBox.Show("No more idlers");
            Conn.Close();
        }

        private void SDown_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(CurrentFile);
            OleDbCommand Cmd = new OleDbCommand
            {
                Connection = Conn
            };
            Conn.Open();
            Cmd.CommandText = "SELECT * FROM Workers ";
            OleDbDataReader reader = Cmd.ExecuteReader();
            reader.Read();
            int workers = Convert.ToInt32(reader["Soldiers"]);
            reader.Close();
            while (workers != 0)
            {
                Cmd.CommandText = "UPDATE Workers SET Soldiers= Soldiers + -1";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "UPDATE Workers SET Idlers = Idlers + 1";
                Cmd.ExecuteNonQuery();
                break;
            }
            if (workers == 0)
                MessageBox.Show("No more Soldiers");
            Conn.Close();
        }

        private void RaidTimer_Tick(object sender, EventArgs e)
        {
            RaidTimer.Enabled = false;
            OleDbConnection Conn = new OleDbConnection(CurrentFile);
            OleDbCommand Cmd = new OleDbCommand
            {
                Connection = Conn
            };
            Conn.Open();
            Random Random = new Random();
            if (VillagePower > 20)
            {
                RaidPower = Random.Next(Convert.ToInt32(VillagePower - 20), Convert.ToInt32(VillagePower + 10));
            }
            else
            {
                RaidPower = Random.Next(0, Convert.ToInt32(VillagePower + 10));
            }
            Cmd.CommandText = "UPDATE  Raids SET RaidPower=";
            Cmd.CommandText += RaidPower;
            Cmd.ExecuteNonQuery();
            MessageBox.Show(this,"You are being Raided! Raid Power" + RaidPower);
            BattleScreen battle = new BattleScreen();
            battle.Show();
            if(VillagePower==0)
            {
                MessageBox.Show("Your Village has been destroyed");
                this.Close();
            }
            if (RaidPower == 0)
            {
                MessageBox.Show("You have beaten the raiders... for now");
                Cmd.CommandText = "UPDATE Raids SET RaidsWon= RaidsWon + 1";
                Cmd.ExecuteNonQuery();
            }
            Conn.Close();
        }

        private void ScienceUp_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(CurrentFile);
            OleDbCommand Cmd = new OleDbCommand
            {
                Connection = Conn
            };
            Conn.Open();
            Cmd.CommandText = "SELECT * FROM Workers ";
            OleDbDataReader reader = Cmd.ExecuteReader();
            reader.Read();
            int idlers = Convert.ToInt32(reader["Idlers"]);
            reader.Close();
            while (idlers != 0)
            {
                Cmd.CommandText = "UPDATE Workers SET Scientists= Scientists + 1";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "UPDATE Workers SET Idlers = Idlers + -1";
                Cmd.ExecuteNonQuery();
                break;
            }
            if (idlers == 0)
                MessageBox.Show("No more idlers");
            Conn.Close();
        }

        private void ScienceDown_Click(object sender, EventArgs e)
        {
            OleDbConnection Conn = new OleDbConnection(CurrentFile);
            OleDbCommand Cmd = new OleDbCommand
            {
                Connection = Conn
            };
            Conn.Open();
            Cmd.CommandText = "SELECT * FROM Workers ";
            OleDbDataReader reader = Cmd.ExecuteReader();
            reader.Read();
            int workers = Convert.ToInt32(reader["Scientists"]);
            reader.Close();
            while (workers != 0)
            {
                Cmd.CommandText = "UPDATE Workers SET Scientists= Scientists + -1";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "UPDATE Workers SET Idlers = Idlers + 1";
                Cmd.ExecuteNonQuery();
                break;
            }
            if (workers == 0)
                MessageBox.Show("No more Scientists");
            Conn.Close();
        }

        private void Research_Click(object sender, EventArgs e)
        {
            Research Research = new Research();
            Research.Show();
        }

        private void Achievements_Click(object sender, EventArgs e)
        {
            Achievements Achievements = new Achievements();
            Achievements.Show();
        }
    }
}
