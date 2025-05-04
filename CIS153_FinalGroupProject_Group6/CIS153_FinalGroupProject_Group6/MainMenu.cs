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
    public partial class form_mainMenu: Form
    {
        public form_mainMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //Console.WriteLine("test1");
        }

        public void loadTwoPlayerForm()
        {
            //dont believe we need to pass main menu form or anything... at least not yet
            form_twoPlayer TPForm = new form_twoPlayer();
            TPForm.Show();
            this.Hide();
        }

        private void btn_TwoPlayer_Click(object sender, EventArgs e)
        {
            loadTwoPlayerForm();
        }

        private void loadSinglePlayerForm()
        {
            form_singleplayer SPForm = new form_singleplayer();
            SPForm.Show();
            this.Hide();
        }

        private void btn_singleplayer_Click(object sender, EventArgs e)
        {
            loadSinglePlayerForm();
        }
        
        private void loadStatsForm()
        {
            form_stats statsForm = new form_stats();
            statsForm.Show();
            this.Hide();
        }

        private void btn_stats_Click(object sender, EventArgs e)
        {
            loadStatsForm();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms.Cast<Form>().ToArray())
            {
                form.Close();
            }
        }
    }


}

