using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Body : Form
    {
        bool turn = true;
        int count_turn = 0; 

        public Body()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button cell = (Button)sender;
            if (turn)
                cell.Text = "X";
            else
                cell.Text = "O";

            turn = !turn;
            cell.Enabled = false;

        }
    }
}
