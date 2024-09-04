using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship.Forms
{
    public partial class GameOverForm : Form
    {
        public GameOverForm(int winCond)
        {
            InitializeComponent();
            if (winCond == 1)
            {
                label1.Text = "You WON!";
            }
            else
            {
                label1.Text = "You Lost :(";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
