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
    public partial class form_twoPlayer: Form
    {
        int playerTurn = 1; //1 is player one being red and 2 is player 2/AI being yellow
        Board board = new Board();


        public form_twoPlayer()
        {
            InitializeComponent();


            //testing tag as a way to get position
            //Console.WriteLine("testttttttt");
           // Console.WriteLine(btn_00.Tag);

            //Console.WriteLine(btn_00.Tag.ToString()[0]);
           // Console.WriteLine(btn_00.Tag.ToString()[1]);
            //Console.WriteLine(btn_00.Tag.ToString()[2]);
        }

        //func called when button is clicked
        private void Button_Click(object sender, EventArgs e)
        {
            //store the sender (button that was clicked) as clicked button
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                //takes btn name and stores in string
                string buttonName = clickedButton.Name;
                //Console.WriteLine(buttonName);

                //grabs x cord out of name (4th index in string)
                int x = int.Parse(buttonName[4].ToString());
                //grabs y cord out of name (5th index in string)
                int y = int.Parse(buttonName[5].ToString());
                //Console.WriteLine(x);
                //Console.WriteLine(y);


                //check that cell is empty at position
                //if(board.getCell(x, y).getState() == 0)

                //make sure board cell is empty
                if (board.getCell(x, y).getState() == 0)
                {
                    //sets color and rotates player turn
                    //player 1 turn
                    if (playerTurn == 1)
                    {
                        //set color
                        clickedButton.BackColor = Color.Red;
                        board.getCell(x, y).setState(1);
                        //change turn
                        playerTurn = 2;
                    }
                    //player 2 or AI turn
                    else
                    {
                        //set color
                        clickedButton.BackColor = Color.Yellow;
                        //set state to full/yellow (2)
                        board.getCell(x, y).setState(2);
                        //change turn
                        playerTurn = 1;
                    }
                    //showing state 1 is red, 2 is yellow, 0 is empty

                }

                Console.WriteLine("cell state at" + x + y + board.getCell(x, y).getState());


            }



        }

    }
}
