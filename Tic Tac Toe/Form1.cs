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
            count_turn++;
            checkforwinner();

        }

        // Checking for Winner 
        private void checkforwinner()
        {
            bool there_is_a_winner = false;

            //horizontal cells
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (!button1.Enabled))
                there_is_a_winner = true;
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled))
                there_is_a_winner = true;
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button7.Enabled))
                there_is_a_winner = true;

            //vertical cells
            if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button1.Enabled))
                there_is_a_winner = true;
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button2.Enabled))
                there_is_a_winner = true;
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button3.Enabled))
                there_is_a_winner = true;

            //diagonal cells
            if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button1.Enabled))
                there_is_a_winner = true;
            else if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button7.Enabled))
                there_is_a_winner = true;
            
            if (there_is_a_winner)
            {
                disableButtons();

                String winner = "";
                if (turn)
                    winner = "Player 2";
                else
                    winner = "Player 1";

                MessageBox.Show(winner + " " + "Wins!");
;            }
            else { }
                
        }// end checkforwinner

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button cell = (Button)c;
                    cell.Enabled = false;
                }
            }
            catch { }
        }

        private void enter(object sender, EventArgs e)
        {
            Button cell = (Button)sender;
            if (cell.Enabled)
            {
                if (turn)
                    cell.Text = "X";
                else
                    cell.Text = "O";
            }
        }
        private void leave(object sender, EventArgs e)
        {
            Button cell = (Button)sender;
            if (cell.Enabled)
            {
                cell.Text = "";
            }
        }

        private void newgame_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Tic-Tac-Toe Game", "Do you want to Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (iExit == DialogResult.Yes)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Do you want to Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }

        private void about_game_Click(object sender, EventArgs e)
        {
            DialogResult about;
            about = MessageBox.Show("Tic-Tac-Toe Game by Bianca Elaine B. Tuno, BS COE 1-3.\n" +
                "An activity for Object-Oriented Programming Subject under Engr. Madrigalejos.");
        }
    }
}
