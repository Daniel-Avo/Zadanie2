using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie2
{
    class TableClass
    {

        private int[,] tab;
 
        public int this[int i, int j]
        {
            get 
            { 
                return tab[i,j]; 
            }
            set { tab[i,j] = value; }
        }

        public void setTabCapacity(int x, int y)
        {
            tab = new int[x, y];
        }
    }
}
