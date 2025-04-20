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
    }


}

