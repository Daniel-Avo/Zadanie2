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
                        arrayRewriting(i + 1, j + 1);
                        tab[i, j] = value;
                    }
                    else if ( tab.GetLength(0) <= i )
                    {
                        arrayRewriting(i + 1, tab.GetLength(1));
                        tab[i, j] = value;
                    }
                    else if ( tab.GetLength(1) <= j)
                    {
                        arrayRewriting(tab.GetLength(0), j + 1);
                        tab[i, j] = value;
                    }
                    
                }
                 
            }
        }

        public void setTabCapacity(int x, int y)
        {
            tab = new int[x, y];
        }

        private void arrayRewriting(int x, int y)
        {
            int[,] oldtab = tab;
            tab = new int[x, y];
            for (int i = 0; i < oldtab.GetLength(0)-1; i++)
            {
                for (int j = 0; j < oldtab.GetLength(1) - 1; j++)
                {
                    tab[i, j] = oldtab[i, j];
                }
            }
        }

        public void getTabCapacity()
        {
            Console.WriteLine("Tab[" + tab.GetLength(0) + "][" + tab.GetLength(1) + "]");
        }
      
    }
}
