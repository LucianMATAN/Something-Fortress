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
    public partial class Idlers : Form
    {
        public Idlers()
        {
            InitializeComponent();
            this.TopMost = true;

        }
        private void Game_Load(object sender, EventArgs e)
        {
            string CurrentFile;
            if (Load_Game.CivLoadName == "")
            {
                OleDbConnection Conn = new OleDbConnection(New_Game.filename);
                CurrentFile = New_Game.filename;
                Conn.Open();
                OleDbCommand Cmd = new OleDbCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = "SELECT * FROM Map_Resources ";
                OleDbDataReader reader = Cmd.ExecuteReader();
                reader.Read();
                Stone.Text = string.Format("{0:N2}", reader["Stone"]) + " " + "Stone";
                Gold.Text = string.Format("{0:N2}", reader["Gold"]) + " " + "Gold";
                Iron.Text = string.Format("{0:N2}", reader["Iron"]) + " " + "Iron";
                Wood.Text = string.Format("{0:N2}", reader["Wood"]) + " " + "Wood";
                reader.Close();
                Cmd.CommandText = "CREATE TABLE Workers(StoneWorkers VARCHAR(20), WoodWorkers VARCHAR(20), IronWorkers VARCHAR(20), GoldWorkers VARCHAR(20),Idlers VARCHAR(20), Soldiers VARCHAR(20), PRIMARY KEY(Idlers))";
                Cmd.ExecuteNonQuery();
                Cmd.CommandText = "INSERT INTO Workers VALUES ('0','0','0','0','10','0')";
                Cmd.ExecuteNonQuery();
            }
            else
            {
                OleDbConnection Conn = new OleDbConnection(Load_Game.CivLoadName);
                CurrentFile = Load_Game.CivLoadName;
                Conn.Open();
                OleDbCommand Cmd = new OleDbCommand();
                Cmd.Connection = Conn;
                Cmd.CommandText = "SELECT * FROM Map_Resources ";
                OleDbDataReader reader = Cmd.ExecuteReader();
                reader.Read();
                Stone.Text = string.Format("{0:N2}", reader["Stone"]) + " " + "Stone";
                Gold.Text = string.Format("{0:N2}", reader["Gold"]) + " " + "Gold";
                Iron.Text = string.Format("{0:N2}", reader["Iron"]) + " " + "Iron";
                Wood.Text = string.Format("{0:N2}", reader["Wood"]) + " " + "Wood";
                reader.Close();
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
