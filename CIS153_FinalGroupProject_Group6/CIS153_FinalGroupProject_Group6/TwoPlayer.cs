using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalGroupProject_Group6
{
    public partial class form_twoPlayer: Form
    {
        int playerTurn = 1; //1 is player one being red and 2 is player 2/AI being yellow
        int turnsTaken = 0; //keeps track of how many turns have been taken
        Board board = new Board();
        bool win = false;

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
            if(!win)
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
                    if (board.getCell(x, y).getState() == 0)
                    {
                        //check if piece falls and set state
                        checkFall(x, y, clickedButton);
                    }
                }
            }
        }

        private void checkFall(int xCord, int yCord, Button clickedButton)
        {
            //check if space below is empty, fall to bottom most space

            //loop thru going down, until y is 5 (lowest cell)
            for (int i = yCord; i < 6; i++)
            {

                if(board.getCell(xCord, i).getState() == 0)
                {
                    //sets y cord equal to i, that being the y value of the lower cell
                    yCord = i;
                    //Console.WriteLine("yCord is now : " + yCord);
                }
            }
            //make a temp button name to change according to new yCord
            //makes a string with the button name excluding the yCord
            string Name = clickedButton.Name.Substring(0, 5);
            //makes a string with the button name including the new yCord
            string newName = Name + yCord.ToString();
            //finds a control that is a button that's name is equal to newName
            Button fallButton = this.Controls.Find(newName, true).FirstOrDefault() as Button;

            //sets color and rotates player turn
            //player 1 turn
            if (playerTurn == 1)
            {
                //set color
                fallButton.BackColor = Color.Red;
                //set state to full/red (1)
                board.getCell(xCord, yCord).setState(1);
                //check for win
                checkWin(xCord, yCord);

                //change turn
                playerTurn = 2;
                turnsTaken++;
            }
            //player 2 or AI turn
            else
            {
                //set color
                fallButton.BackColor = Color.Yellow;
                //set state to full/yellow (2)
                board.getCell(xCord, yCord).setState(2);
                //check for win
                checkWin(xCord, yCord);

                //change turn
                playerTurn = 1;
                turnsTaken++;
            }
            //showing state 1 is red, 2 is yellow, 0 is empty
            //Console.WriteLine("cell state at" + xCord + yCord + board.getCell(xCord, yCord).getState());

            //check if max amount of turns has been taken 
            //Console.WriteLine("turns taken : " + turnsTaken);

            if (turnsTaken >= 42)
            {
                //this is where the game over scenario will go 
                Console.WriteLine("Game Over");
            }
        }


        private void checkWin(int xCord, int yCord)
        {
            //check if 4 in a row in all directions
            //inRow will keep track of how many in a row
            int inRow = 0;

            //if turn is 1, check for red
            if (playerTurn == 1)
            {
                //left
                inRow = 0;
                for (int xi = xCord; xi >= 0; xi--)
                {
                    if (win)
                    {
                        break;
                    }
                    Console.WriteLine("xi : " + xi);
                    if (board.getCell(xi, yCord).getState() == 1)
                    {
                        //if state is same color add to inRow
                        inRow++;
                        Console.WriteLine("inRow : " + inRow);
                    }
                    else if (board.getCell(xi, yCord).getState() == 2 || board.getCell(xi, yCord).getState() == 0)
                    {
                        //if state is not same color or empty
                        break;
                    }
                    if (inRow == 4)
                    {
                        //set win to true
                        win = true;
                        Console.WriteLine("4 in a row Left");
                    }
                }

                //right
                inRow = 0;
                for (int xi = xCord; xi <= 6; xi++)
                {
                    if (win)
                    {
                        break;
                    }
                    Console.WriteLine("xi : " + xi);
                    if (board.getCell(xi, yCord).getState() == 1)
                    {
                        //if state is same color add to inRow
                        inRow++;
                        Console.WriteLine("inRow : " + inRow);
                    }
                    else if (board.getCell(xi, yCord).getState() == 2 || board.getCell(xi, yCord).getState() == 0)
                    {
                        //if state is not same color or empty
                        break;
                    }
                    if (inRow == 4)
                    {
                        //set win to true
                        win = true;
                        Console.WriteLine("4 in a row Right");
                    }
                }
                //up
                //dont need a straight up

                //down
                inRow = 0;
                for (int yi = yCord; yi <= 5; yi++)
                {
                    if (win)
                    {
                        break;
                    }
                    Console.WriteLine("yi : " + yi);
                    if (board.getCell(xCord, yi).getState() == 1)
                    {
                        //if state is same color add to inRow
                        inRow++;
                        Console.WriteLine("inRow : " + inRow);
                    }
                    else if (board.getCell(xCord, yi).getState() == 2 || board.getCell(xCord, yi).getState() == 0)
                    {
                        //if state is not same color or empty
                        break;
                    }
                    if (inRow == 4)
                    {
                        //set win to true
                        win = true;
                        Console.WriteLine("4 in a row down");
                    }
                }

                //diangonal left up
                inRow = 0;
                for (int yi = yCord, xi = xCord; yi >= 0 && xi >= 0; yi--, xi--)
                {
                    if (win)
                    {
                        break;
                    }
                    Console.WriteLine("xi : " + xi + " yi : " + yi);
                    if (board.getCell(xi, yi).getState() == 1)
                    {
                        //if state is same color add to inRow
                        inRow++;
                        Console.WriteLine("inRow : " + inRow);
                    }
                    else if (board.getCell(xi, yi).getState() == 2 || board.getCell(xi, yi).getState() == 0)
                    {
                        //if state is not same color or empty
                        break;
                    }
                    if (inRow == 4)
                    {
                        //set win to true
                        win = true;
                        Console.WriteLine("4 in a row up and left");
                    }
                }

                //diagonal right up
                inRow = 0;
                for (int yi = yCord, xi = xCord; yi >= 0 && xi <= 6; yi--, xi++)
                {
                    if (win)
                    {
                        break;
                    }
                    Console.WriteLine("xi : " + xi + " yi : " + yi);
                    if (board.getCell(xi, yi).getState() == 1)
                    {
                        //if state is same color add to inRow
                        inRow++;
                        Console.WriteLine("inRow : " + inRow);
                    }
                    else if (board.getCell(xi, yi).getState() == 2 || board.getCell(xi, yi).getState() == 0)
                    {
                        //if state is not same color or empty
                        break;
                    }
                    if (inRow == 4)
                    {
                        //set win to true
                        win = true;
                        Console.WriteLine("4 in a row up and right");
                    }
                }

                //diagonal left down
                inRow = 0;
                for (int yi = yCord, xi = xCord; yi <= 5 && xi >= 0; yi++, xi--)
                {
                    if (win)
                    {
                        break;
                    }
                    Console.WriteLine("xi : " + xi + " yi : " + yi);
                    if (board.getCell(xi, yi).getState() == 1)
                    {
                        //if state is same color add to inRow
                        inRow++;
                        Console.WriteLine("inRow : " + inRow);
                    }
                    else if (board.getCell(xi, yi).getState() == 2 || board.getCell(xi, yi).getState() == 0)
                    {
                        //if state is not same color or empty
                        break;
                    }
                    if (inRow == 4)
                    {
                        //set win to true
                        win = true;
                        Console.WriteLine("4 in a row down and left");
                    }
                }
                //diagonal right down
                inRow = 0;
                for (int yi = yCord, xi = xCord; yi <= 5 && xi <= 6; yi++, xi++)
                {
                    if (win)
                    {
                        break;
                    }
                    Console.WriteLine("xi : " + xi + " yi : " + yi);
                    if (board.getCell(xi, yi).getState() == 1)
                    {
                        //if state is same color add to inRow
                        inRow++;
                        Console.WriteLine("inRow : " + inRow);
                    }
                    else if (board.getCell(xi, yi).getState() == 2 || board.getCell(xi, yi).getState() == 0)
                    {
                        //if state is not same color or empty
                        break;
                    }
                    if (inRow == 4)
                    {
                        //set win to true
                        win = true;
                        Console.WriteLine("4 in a row up and right");
                    }
                }

                if (win)
                {
                    //win condition goes here
                    Console.WriteLine("Player 1 wins!");
                }
            }

            //if it is player 2's turn
            if(playerTurn == 2)
            {
                //left
                inRow = 0;
                for (int xi = xCord; xi >= 0; xi--)
                {
                    if (win)
                    {
                        break;
                    }
                    Console.WriteLine("xi : " + xi);
                    if (board.getCell(xi, yCord).getState() == 2)
                    {
                        //if state is same color add to inRow
                        inRow++;
                        Console.WriteLine("inRow : " + inRow);
                    }
                    else if (board.getCell(xi, yCord).getState() == 1 || board.getCell(xi, yCord).getState() == 0)
                    {
                        //if state is not same color or empty
                        break;
                    }
                    if (inRow == 4)
                    {
                        //set win to true
                        win = true;
                        Console.WriteLine("4 in a row Left");
                    }
                }

                //right
                inRow = 0;
                for (int xi = xCord; xi <= 6; xi++)
                {
                    if (win)
                    {
                        break;
                    }
                    Console.WriteLine("xi : " + xi);
                    if (board.getCell(xi, yCord).getState() == 2)
                    {
                        //if state is same color add to inRow
                        inRow++;
                        Console.WriteLine("inRow : " + inRow);
                    }
                    else if (board.getCell(xi, yCord).getState() == 1 || board.getCell(xi, yCord).getState() == 0)
                    {
                        //if state is not same color or empty
                        break;
                    }
                    if (inRow == 4)
                    {
                        //set win to true
                        win = true;
                        Console.WriteLine("4 in a row Right");
                    }
                }
                //up
                //dont need a straight up

                //down
                inRow = 0;
                for (int yi = yCord; yi <= 5; yi++)
                {
                    if (win)
                    {
                        break;
                    }
                    Console.WriteLine("yi : " + yi);
                    if (board.getCell(xCord, yi).getState() == 2)
                    {
                        //if state is same color add to inRow
                        inRow++;
                        Console.WriteLine("inRow : " + inRow);
                    }
                    else if (board.getCell(xCord, yi).getState() == 1 || board.getCell(xCord, yi).getState() == 0)
                    {
                        //if state is not same color or empty
                        break;
                    }
                    if (inRow == 4)
                    {
                        //set win to true
                        win = true;
                        Console.WriteLine("4 in a row down");
                    }
                }

                //diangonal left up
                inRow = 0;
                for (int yi = yCord, xi = xCord; yi >= 0 && xi >= 0; yi--, xi--)
                {
                    if (win)
                    {
                        break;
                    }
                    Console.WriteLine("xi : " + xi + " yi : " + yi);
                    if (board.getCell(xi, yi).getState() == 2)
                    {
                        //if state is same color add to inRow
                        inRow++;
                        Console.WriteLine("inRow : " + inRow);
                    }
                    else if (board.getCell(xi, yi).getState() == 1 || board.getCell(xi, yi).getState() == 0)
                    {
                        //if state is not same color or empty
                        break;
                    }
                    if (inRow == 4)
                    {
                        //set win to true
                        win = true;
                        Console.WriteLine("4 in a row up and left");
                    }
                }

                //diagonal right up
                inRow = 0;
                for (int yi = yCord, xi = xCord; yi >= 0 && xi <= 6; yi--, xi++)
                {
                    if (win)
                    {
                        break;
                    }
                    Console.WriteLine("xi : " + xi + " yi : " + yi);
                    if (board.getCell(xi, yi).getState() == 2)
                    {
                        //if state is same color add to inRow
                        inRow++;
                        Console.WriteLine("inRow : " + inRow);
                    }
                    else if (board.getCell(xi, yi).getState() == 1 || board.getCell(xi, yi).getState() == 0)
                    {
                        //if state is not same color or empty
                        break;
                    }
                    if (inRow == 4)
                    {
                        //set win to true
                        win = true;
                        Console.WriteLine("4 in a row up and right");
                    }
                }

                //diagonal left down
                inRow = 0;
                for (int yi = yCord, xi = xCord; yi <= 5 && xi >= 0; yi++, xi--)
                {
                    if (win)
                    {
                        break;
                    }
                    Console.WriteLine("xi : " + xi + " yi : " + yi);
                    if (board.getCell(xi, yi).getState() == 2)
                    {
                        //if state is same color add to inRow
                        inRow++;
                        Console.WriteLine("inRow : " + inRow);
                    }
                    else if (board.getCell(xi, yi).getState() == 1 || board.getCell(xi, yi).getState() == 0)
                    {
                        //if state is not same color or empty
                        break;
                    }
                    if (inRow == 4)
                    {
                        //set win to true
                        win = true;
                        Console.WriteLine("4 in a row down and left");
                    }
                }
                //diagonal right down
                inRow = 0;
                for (int yi = yCord, xi = xCord; yi <= 5 && xi <= 6; yi++, xi++)
                {
                    if (win)
                    {
                        break;
                    }
                    Console.WriteLine("xi : " + xi + " yi : " + yi);
                    if (board.getCell(xi, yi).getState() == 2)
                    {
                        //if state is same color add to inRow
                        inRow++;
                        Console.WriteLine("inRow : " + inRow);
                    }
                    else if (board.getCell(xi, yi).getState() == 1 || board.getCell(xi, yi).getState() == 0)
                    {
                        //if state is not same color or empty
                        break;
                    }
                    if (inRow == 4)
                    {
                        //set win to true
                        win = true;
                        Console.WriteLine("4 in a row up and right");
                    }
                }

                if (win)
                {
                    //win condition goes here
                    Console.WriteLine("Player 2 wins!");
                }

            }
            
        }
    }
}
