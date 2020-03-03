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
    public partial class New_Game : Form
    {
        public static string seed;
        public static string filename;
        public New_Game()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        { 
            Close();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        private void StartGame_Click(object sender, EventArgs e)
        {
            seed = Seed.Text;
            int RandomStone, RandomWood, RandomIron, RandomGold, MapCitizens;
            if (CivName.Text == "")
            {
                MessageBox.Show("Please enter a civilization name");

            }
            else

            {
                string fileadd = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =";
                string fname = CivName.Text + ".accdb";
                if (File.Exists(fname) == false)
                {
                    fname = fileadd + fname;
                    filename = fname;
                    ADOX.Catalog cat = new ADOX.Catalog();
                    cat.Create(fname);
                    OleDbConnection Conn = new OleDbConnection(fname);
                    Conn.Open();
                    OleDbCommand Cmd = new OleDbCommand();
                    Cmd.Connection = Conn;
                    Cmd.CommandText = "CREATE TABLE Current_Resources(Stone VARCHAR(20), Wood VARCHAR(20), Iron VARCHAR(20), Gold VARCHAR(20), Citizens VARCHAR(20), PRIMARY KEY(Citizens))";
                    Cmd.ExecuteNonQuery();
                    Cmd.CommandText = "INSERT INTO Current_Resources VALUES ( '500', '500', '500','100','10')";
                    Cmd.ExecuteNonQuery();
                    Cmd.CommandText = "CREATE TABLE Map_Resources(Stone VARCHAR(20), Wood VARCHAR(20), Iron VARCHAR(20), Gold VARCHAR(20), Citizens VARCHAR(20), PRIMARY KEY(Citizens))";
                    Cmd.ExecuteNonQuery();
                    if (seed == "")
                    {
                        Random RandomSeed = new Random();
                        RandomStone = RandomSeed.Next(10000, 20000);
                        RandomWood = RandomSeed.Next(10000, 20000);
                        RandomIron = RandomSeed.Next(10000, 20000);
                        RandomGold = RandomSeed.Next(10000, 20000);
                        MapCitizens = RandomSeed.Next(100, 200);
                        string SQL = "INSERT INTO Map_Resources";  //Construct the INSERT command
                        SQL += " VALUES('" + RandomStone + "','" + RandomWood + "', '";
                        SQL += RandomIron + "', '" + RandomGold + "', " + MapCitizens + ")";
                        Cmd.CommandText = SQL;
                        Cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("WIP, not currently implemented");
                        Random RandomSeed = new Random();
                        RandomStone = RandomSeed.Next(10000, 20000);
                        RandomWood = RandomSeed.Next(10000, 20000);
                        RandomIron = RandomSeed.Next(10000, 20000);
                        RandomGold = RandomSeed.Next(10000, 20000);
                        MapCitizens = RandomSeed.Next(100, 200);
                        string SQL = "INSERT INTO Map_Resources";  //Construct the INSERT command
                        SQL += " VALUES('" + RandomStone + "','" + RandomWood + "', '";
                        SQL += RandomIron + "', '" + RandomGold + "', " + MapCitizens + ")";
                        Cmd.CommandText = SQL;
                        Cmd.ExecuteNonQuery();
                    }
                    Conn.Close();
                    Load_Game.CivLoadName = "";
                    this.Close();
                    Game game = new Game();
                    game.Show();
                }
                else
                {
                    MessageBox.Show("Save found, please enter a different name");
                }
            }
        }
    }
}
