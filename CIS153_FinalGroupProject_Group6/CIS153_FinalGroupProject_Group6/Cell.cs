using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_FinalGroupProject_Group6
{
    class Cell
    {
        //row
        //private int x;
        //collumn
        //private int y;
        //0 will be empty, 1 will be red, 2 will be yellow
        private int state;

        public Cell()
        {
            state = 0;
        }
        //public Cell(int xCord, int yCord)
        //{
        //    x = xCord;
        //    y = yCord;
        //    state = 0;
        //}
        


        //getters
        //public int getX()
        //{
        //    return x;
        //}
        //public int getY()
        //{
        //    return y;
        //}
        public int getState()
        {
            return state;
        }

        //setters
        public void setState(int ns)
        {
            //ns being "new state"
            state = ns;
        }

    }
}
