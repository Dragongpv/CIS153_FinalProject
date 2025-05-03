using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalGroupProject_Group6
{
    public partial class form_gameOver: Form
    {
        private Form previousgame;
        private int playerwin;
        public form_gameOver(int pwin, Form game)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            playerwin = pwin;
            previousgame = game;

            //writing of win to stat file can happen here as this form will happen regardless of single or two player
            //just put it in the correspodning if statement

            //add to total plays
            //add to wins for player 1 or 2
            //add to ties if applicable
            if (playerwin == 1)
            {
                lbl_winner.Text = "Player 1 Wins!";
            }
            else if (playerwin == 2)
            {
                lbl_winner.Text = "Player 2 Wins!";
            }
            else
            {
                lbl_winner.Text = "It's a tie!";
            }

            //showing record against ai can also be read from this form as this is where it would show anyway 
            //show win percentage 
        }

        private void btn_review_Click(object sender, EventArgs e)
        {
            previousgame.Show();
            this.Hide();
        }

        private void btn_singlePlayer_Click(object sender, EventArgs e)
        {
            form_singleplayer SPForm = new form_singleplayer();
            SPForm.Show();
            this.Close();
        }

        private void btn_twoPlayer_Click(object sender, EventArgs e)
        {
            form_twoPlayer TPForm = new form_twoPlayer();
            TPForm.Show();
            this.Close();
        }

        private void btn_EXIT_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms.Cast<Form>().ToArray())
            {
                form.Close();
            }
        }
    }
}
