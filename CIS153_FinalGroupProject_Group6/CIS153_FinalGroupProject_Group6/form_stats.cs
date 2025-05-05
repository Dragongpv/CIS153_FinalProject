using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalGroupProject_Group6
{
    public partial class form_stats: Form
    {
        //public int playerWins()

        public form_stats()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Stats stats = Stats.LoadStats();


            lbl_pWIns.Text = $"Player Wins : {stats.playerWins}";
            lbl__aiwins.Text = $"AI Wins: {stats.AiWins}";
            lbl_ties.Text = $"Ties : {stats.Ties}";
            lbl_total.Text = $"Total Games: {stats.totalGames}";
            lbl_playerpct.Text = $"Player Win %: {stats.playerWinpercentage}";
            
            lbl_aipct.Text = $"Ai Win % : {stats.AiWinpercentage}";







        }
    }
}
