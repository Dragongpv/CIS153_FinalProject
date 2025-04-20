using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalGroupProject_Group6
{
    class Board
    {
        //this would be the last played/filled cell
        private Cell currentCell;

        //the board filled with cells. 7 wide, 6 tall
        private Cell[,] board = new Cell[7, 6];

        public Board()
        {
            for (int xi = 0; xi < 7; xi++)
            {
                for (int yi = 0; yi < 6; yi++)
                {

                    board[xi, yi] = new Cell();
                    
                }


            }


        }


        //getter
        public Cell getCell(int xCord, int yCord)
        {
            return board[xCord, yCord];
            //Console.WriteLine(getCell(xCord, yCord).getState());
        }



    }
}
