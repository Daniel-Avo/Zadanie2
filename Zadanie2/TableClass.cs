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
            set 
            {
                try
                {
                    tab[i, j] = value;
                }
                catch
                {
                    if ((tab.GetLength(0) <= i) & (tab.GetLength(1) <= j))
                    {
                        setTabCapacity(i + 1, j + 1);
                        tab[i, j] = value;
                    }
                    else if ( tab.GetLength(0) <= i )
                    {
                        setTabCapacity(i+1 , tab.GetLength(1));
                        tab[i, j] = value;
                    }
                    else if ( tab.GetLength(1) <= j)
                    {
                        setTabCapacity(tab.GetLength(0), j + 1);
                        tab[i, j] = value;
                    }
                    
                }
                 
            }
        }

        public void setTabCapacity(int x, int y)
        {
            tab = new int[x, y];
        }
    }
}
