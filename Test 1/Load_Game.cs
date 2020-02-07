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
    public partial class Load_Game : Form
    {
        public static string CivLoadName;
        public Load_Game()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            if (CivName.Text == "")
            {
                MessageBox.Show("Please enter a civilization name");

            }
            else
            {
                string fileadd = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =";
                string fname = CivName.Text + ".accdb";
                fname = fileadd + fname;
                CivLoadName = fname;
                New_Game.filename = "";
                this.Close();
                Idlers game = new Idlers();
                game.Show();
            }
        }
    }
}
