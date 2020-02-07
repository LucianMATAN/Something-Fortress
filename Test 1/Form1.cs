using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            New_Game NewGame = new New_Game();
            NewGame.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadGame_Click(object sender, EventArgs e)
        {
            Load_Game load = new Load_Game();
            load.ShowDialog();
        }
    }
}
