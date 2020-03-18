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
    public partial class BattleScreen : Form
    {
        public BattleScreen()
        {
            InitializeComponent();
        }
        private void BattleScreen_Load(object sender, EventArgs e)
        {
            EnemyCP.Text = Convert.ToString(Game.RaidPower);
            YourCp.Text = Convert.ToString(Game.VillagePower);
        }

        private void StrattegyButton_Click(object sender, EventArgs e)
        {
            double EnemyPower = Game.RaidPower;
            double OwnPower = Game.VillagePower;
            while (EnemyPower != 0 && OwnPower != 0)
            {
                if (Attack.Checked)
                {
                    EnemyPower = EnemyPower - OwnPower;
                    OwnPower = OwnPower - EnemyPower;
                }
                else if(Defend.Checked)
                {
                    OwnPower = OwnPower - EnemyPower * 0.5;
                    EnemyPower = EnemyPower - OwnPower;
                }
                else if(Nothing.Checked)
                {
                    OwnPower = OwnPower - EnemyPower;
                    EnemyPower = EnemyPower - OwnPower;
                }
            }
        }
    }
}
