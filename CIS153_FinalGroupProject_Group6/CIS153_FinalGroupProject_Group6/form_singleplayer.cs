using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalGroupProject_Group6
{
    public partial class form_singleplayer: Form
    {
        int playerTurn = 1; //1 is player one being red and 2 is player 2/AI being yellow
        int turnsTaken = 0; //keeps track of how many turns have been taken
        Board board = new Board();
        bool win = false;
        int playerwin = 0; //keeps track of which player won
        int aiChoice;

        public form_singleplayer()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            setColors();
        }
    

       private void Button_Click(object sender, EventArgs e)
       {
            if (!win)
            {
               
                setColors();
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
                    if (board.getCell(x, 0).getState() == 0)
                    {
                        //check if piece falls and set state
                        checkFall(x, 0, clickedButton);
                    }
                    else
                    {
                        return;
                    }

                    if (!win)
                    {
                        aiLogic();
                    }
                }
            }
       }


        private void aiTurn(int xCord, int yCord)
        {
            //check if space below is empty, fall to bottom most space

            //loop thru going down, until y is 5 (lowest cell)
            for (int i = yCord; i < 6; i++)
            {

                if (board.getCell(xCord, i).getState() == 0)
                {
                    //sets y cord equal to i, that being the y value of the lower cell
                    yCord = i;
                    //Console.WriteLine("yCord is now : " + yCord);
                }
            }

            //sets color and rotates player turn
            //player 1 turn
            if (playerTurn == 1)
            {
                //set color
                //fallButton.BackColor = Color.Red;
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
                //fallButton.BackColor = Color.Yellow;
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

        private void aiLogic()
        {

            
            //this is the logic for where it will play on the starting turn
            if (turnsTaken == 1)
            {
                //plays in the middle unless the first player played there
                aiChoice = 3;
                //if they played in the middle the ai will play one to the right
                if (board.getCell(aiChoice, 5).getState() == 1)
                {
                    aiChoice++;

                }
            }
            //this is the logic for every other turn but the first one
            else
            {
                //sets variable in this scope
                aiChoice = 3;

                checkBlock();
                checkCanWin();
                
                //if the top cell is filled it plays the cell to the right
                while (board.getCell(aiChoice, 0).getState() != 0)
                {
                    aiChoice++;
                    if (aiChoice > 6)
                    {
                        aiChoice = 0;
                    }
                }
            }

            //this is the code that actually sets the state of the correct cell
            if (board.getCell(aiChoice, 0).getState() == 0)
            {

                aiTurn(aiChoice, 0);
            }
            
        }

        private void checkBlock()
        {
            int inARow = 0;
            int tempX;
            int tempY;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    tempX = i;
                    tempY = j;
                    //up
                    inARow = 0;
                    if (tempY > 4)
                    {
                        if (board.getCell(tempX, tempY).getState() == 1)
                        {
                            int yi = tempY;
                            for (int z = 0; z < 3; z++)
                            {

                                if (board.getCell(tempX, yi).getState() == 1)
                                {

                                    inARow++;
                                }
                                if (inARow == 3 && board.getCell(tempX, yi - 1).getState() == 0)
                                {
                                    aiChoice = tempX;
                                }
                                yi--;
                            }

                        }
                    }

                    //cant block underneath so dont need a down

                    //left
                    if (tempX > 2)
                    {
                        inARow = 0;
                        if (board.getCell(tempX, tempY).getState() == 1)
                        {
                            int xi = tempX;
                            for (int z = 0; z < 3; z++)
                            {

                                if (board.getCell(xi, tempY).getState() == 1)
                                {

                                    inARow++;
                                }
                                if (inARow == 3 && board.getCell(xi - 1, tempY).getState() == 0)
                                {
                                        aiChoice = tempX - 3;
                                }
                                xi--;
                            }

                        }
                    }

                    //right
                    if (tempX < 4)
                    {
                        inARow = 0;
                        if (board.getCell(tempX, tempY).getState() == 1)
                        {
                            int xi = tempX;
                            for (int z = 0; z < 3; z++)
                            {

                                if (board.getCell(xi, tempY).getState() == 1)
                                {

                                    inARow++;
                                }
                                if (inARow == 3 && board.getCell(xi + 1, tempY).getState() == 0)
                                {
                                        aiChoice = tempX + 3;
                                }
                                xi++;
                            }

                        }
                    }

                    //right-down
                    if (tempX < 4 && tempY < 3)
                    {
                        inARow = 0;
                        if (board.getCell(tempX, tempY).getState() == 1)
                        {
                            int xi = tempX;
                            int yi = tempY;
                            for (int z = 0; z < 3; z++)
                            {

                                if (board.getCell(xi, yi).getState() == 1)
                                {

                                    inARow++;
                                }
                                if (inARow == 3 && board.getCell(xi + 1, yi + 1).getState() == 0)
                                {
                                        aiChoice = tempX + 3;
                                }
                                xi++;
                                yi++;
                            }

                        }
                    }

                    //right-up
                    if (tempX < 4 && tempY > 4)
                    {
                        inARow = 0;
                        if (board.getCell(tempX, tempY).getState() == 1)
                        {
                            int xi = tempX;
                            int yi = tempY;
                            for (int z = 0; z < 3; z++)
                            {

                                if (board.getCell(xi, yi).getState() == 1)
                                {

                                    inARow++;
                                }
                                if (inARow == 3 && board.getCell(xi + 1, yi - 1).getState() == 0)
                                {
                                    aiChoice = tempX + 3;
                                }
                                xi++;
                                yi--;
                            }

                        }
                    }

                    //left-down
                    if (tempX > 2 && tempY < 3)
                    {
                        inARow = 0;
                        if (board.getCell(tempX, tempY).getState() == 1)
                        {
                            int xi = tempX;
                            int yi = tempY;
                            for (int z = 0; z < 3; z++)
                            {

                                if (board.getCell(xi, yi).getState() == 1)
                                {

                                    inARow++;
                                }
                                if (inARow == 3 && board.getCell(xi - 1, yi + 1).getState() == 0)
                                {
                                    aiChoice = tempX - 3;
                                }
                                xi--;
                                yi++;
                            }

                        }
                    }


                    //left-up
                    if (tempX > 2 && tempY > 4)
                    {
                        inARow = 0;
                        if (board.getCell(tempX, tempY).getState() == 1)
                        {
                            int xi = tempX;
                            int yi = tempY;
                            for (int z = 0; z < 3; z++)
                            {

                                if (board.getCell(xi, yi).getState() == 1)
                                {

                                    inARow++;
                                }
                                if (inARow == 3 && board.getCell(xi - 1, yi - 1).getState() == 0)
                                {
                                    aiChoice = tempX - 3;
                                }
                                xi--;
                                yi--;
                            }

                        }
                    }


                }
            }
        }

        private void checkCanWin()
        {
            int inARow = 0;
            int tempX;
            int tempY;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    tempX = i;
                    tempY = j;
                    //up
                    inARow = 0;
                    if (tempY > 4)
                    {
                        if (board.getCell(tempX, tempY).getState() == 2)
                        {
                            int yi = tempY;
                            for (int z = 0; z < 3; z++)
                            {

                                if (board.getCell(tempX, yi).getState() == 2)
                                {

                                    inARow++;
                                }
                                if (inARow == 3 && board.getCell(tempX, yi - 1).getState() == 0)
                                {
                                    aiChoice = tempX;
                                }
                                yi--;
                            }

                        }
                    }

                    //cant block underneath so dont need a down

                    //left
                    if (tempX > 2)
                    {
                        inARow = 0;
                        if (board.getCell(tempX, tempY).getState() == 2)
                        {
                            int xi = tempX;
                            for (int z = 0; z < 3; z++)
                            {

                                if (board.getCell(xi, tempY).getState() == 2)
                                {

                                    inARow++;
                                }
                                if (inARow == 3 && board.getCell(xi - 1, tempY).getState() == 0)
                                {
                                    aiChoice = tempX - 3;
                                }
                                xi--;
                            }

                        }
                    }

                    //right
                    if (tempX < 4)
                    {
                        inARow = 0;
                        if (board.getCell(tempX, tempY).getState() == 2)
                        {
                            int xi = tempX;
                            for (int z = 0; z < 3; z++)
                            {

                                if (board.getCell(xi, tempY).getState() == 2)
                                {

                                    inARow++;
                                }
                                if (inARow == 3 && board.getCell(xi + 1, tempY).getState() == 0)
                                {
                                    aiChoice = tempX + 3;
                                }
                                xi++;
                            }

                        }
                    }

                    //right-down
                    if (tempX < 4 && tempY < 3)
                    {
                        inARow = 0;
                        if (board.getCell(tempX, tempY).getState() == 2)
                        {
                            int xi = tempX;
                            int yi = tempY;
                            for (int z = 0; z < 3; z++)
                            {

                                if (board.getCell(xi, yi).getState() == 2)
                                {

                                    inARow++;
                                }
                                if (inARow == 3 && board.getCell(xi + 1, yi + 1).getState() == 0)
                                {
                                    aiChoice = tempX + 3;
                                }
                                xi++;
                                yi++;
                            }

                        }
                    }

                    //right-up
                    if (tempX < 4 && tempY > 4)
                    {
                        inARow = 0;
                        if (board.getCell(tempX, tempY).getState() == 2)
                        {
                            int xi = tempX;
                            int yi = tempY;
                            for (int z = 0; z < 3; z++)
                            {

                                if (board.getCell(xi, yi).getState() == 2)
                                {

                                    inARow++;
                                }
                                if (inARow == 3 && board.getCell(xi + 1, yi - 1).getState() == 0)
                                {
                                    aiChoice = tempX + 3;
                                }
                                xi++;
                                yi--;
                            }

                        }
                    }

                    //left-down
                    if (tempX > 2 && tempY < 3)
                    {
                        inARow = 0;
                        if (board.getCell(tempX, tempY).getState() == 2)
                        {
                            int xi = tempX;
                            int yi = tempY;
                            for (int z = 0; z < 3; z++)
                            {

                                if (board.getCell(xi, yi).getState() == 2)
                                {

                                    inARow++;
                                }
                                if (inARow == 3 && board.getCell(xi - 1, yi + 1).getState() == 0)
                                {
                                    aiChoice = tempX - 3;
                                }
                                xi--;
                                yi++;
                            }

                        }
                    }


                    //left-up
                    if (tempX > 2 && tempY > 4)
                    {
                        inARow = 0;
                        if (board.getCell(tempX, tempY).getState() == 2)
                        {
                            int xi = tempX;
                            int yi = tempY;
                            for (int z = 0; z < 3; z++)
                            {

                                if (board.getCell(xi, yi).getState() == 2)
                                {

                                    inARow++;
                                }
                                if (inARow == 3 && board.getCell(xi - 1, yi - 1).getState() == 0)
                                {
                                    aiChoice = tempX - 3;
                                }
                                xi--;
                                yi--;
                            }

                        }
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

                if (board.getCell(xCord, i).getState() == 0)
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
                //fallButton.BackColor = Color.Red;
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
                //fallButton.BackColor = Color.Yellow;
                //set state to full/yellow (2)
                board.getCell(xCord, 0).setState(2);
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
                    playerwin = 1;
                    Console.WriteLine("Player 1 wins!");
                    form_gameOver go = new form_gameOver(playerwin, this);
                    go.Show();
                    this.Hide();
                }
            }

            //if it is player 2's turn
            if (playerTurn == 2)
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
                    playerwin = 2;
                    Console.WriteLine("Player 2 wins!");
                    form_gameOver go = new form_gameOver(playerwin, this);
                    go.Show();
                    this.Hide();
                }

            }

        }

        private void mouseHover(object sender, EventArgs e)
        {
            if(!win)
            {
                Button hoveredButton = sender as Button;
                if (hoveredButton != null && hoveredButton.BackColor != Color.Red && hoveredButton.BackColor != Color.Yellow)
                {
                    if (playerTurn == 1)
                    {
                        hoveredButton.BackColor = Color.Red;
                    }
                    else
                    {
                        hoveredButton.BackColor = Color.Yellow;
                    }
                }
            }

        }

        private void mouseLeave(object sender, EventArgs e)
        {
            setColors();

        }

        private void setColors()
        {
            //cycles through cells
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    //finds name of cells
                    string tempName = "btn_" + i.ToString() + j.ToString();
                    //finds the button with the corresponding cell name
                    Button tempButton = this.Controls.Find(tempName, true).FirstOrDefault() as Button;
                    //sets the button to the correct color depending on the stored state
                    if (board.getCell(i, j).getState() == 1)
                    {
                        tempButton.BackColor = Color.Red;
                    }
                    else if (board.getCell(i, j).getState() == 2)
                    {
                        tempButton.BackColor = Color.Yellow;
                    }
                    else
                    {
                        tempButton.BackColor = Color.FloralWhite;
                    }
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms.Cast<Form>().ToArray())
            {
                form.Close();
            }
        }

        private void lbl_turn_Click(object sender, EventArgs e)
        {

        }
    }

}
