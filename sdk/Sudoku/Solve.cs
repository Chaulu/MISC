using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class solve
    {
        private int[,] Sdk = new int[9, 9];
        //holds the solved matrix
        private int[,] Soln;
        //holds matrix for reseting
        private int[,] Original;
        //Bool value if it contains no or not
        private bool[,] Asg;
        //class constructor
        public solve()
        {
            int[] abc = new int[9];
            int i, k = 0;
            int[] temp = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random obj = new Random();
            while (k < 9)
            {
                i = obj.Next(1, 9);
                if (temp[i] != 0)
                {
                    abc[k] = temp[i];
                    k++;
                    temp[i] = 0;
                }
            }
            int[,] sudoku = { {abc[0], abc[1], abc[2], 0, 0, 0, 0, 0, 0 },
                             { abc[3], abc[4], abc[5], 0, 0, 0, 0, 0, 0 },
                              { abc[6], abc[7], abc[8], 0, 0, 0, 0, 0, 0 },
                              { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                             { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                              { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                              { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                              { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                              { 0, 0, 0, 0, 0, 0, 0, 0, 0 } };
            for (i = 0; i < 9; i++)
            {
                for (k = 0; k < 9; k++)
                {
                    Soln[i, k] = sudoku[i, k];
                }
            }
            SolveSudoku(Soln);
            CopySudoku(Soln, Sdk);
            makeSudoku(Sdk);
            CopySudoku(Sdk, Original);

        }
        #region functions
        //Remove the numbers from grid 
        public void makeSudoku(int[,] Sudoku)
        {
            int counter = 0, c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0, c8 = 0, c9 = 0;
            Random rnd = new Random();
            while (counter != 18)
            {
            re: int n1 = rnd.Next(1,9);
                int n2 = rnd.Next(1,9);
                if (Sudoku[(n1 - 1), (n2 - 1)] == 0)
                {
                    goto re;
                }
                if (n1 <= 3)
                {
                    if (n2 <= 3)
                    {
                        if (c1 != 2)
                        {
                            Sudoku[(n1 - 1), (n2 - 1)] = 0;
                            Asg[(n1 - 1), (n2 - 1)] = false;
                            c1++;
                            counter++;
                        }
                    }
                    if (n2 >= 4 && n2 <= 6)
                    {
                        if (c2 != 2)
                        {
                            Sudoku[(n1 - 1), (n2 - 1)] = 0;
                            Asg[(n1 - 1), (n2 - 1)] = false;
                            c2++;
                            counter++;
                        }
                    }
                    if (n2 >= 7 && n2 <= 9)
                    {
                        if (c3 != 2)
                        {
                            Sudoku[(n1 - 1), (n2 - 1)] = 0;
                            Asg[(n1 - 1), (n2 - 1)] = false;
                            c3++;
                            counter++;
                        }
                    }
                }
                if (n1 >= 4 && n1 <= 6)
                {
                    if (n2 <= 3)
                    {
                        if (c4 != 2)
                        {
                            Sudoku[(n1 - 1), (n2 - 1)] = 0;
                            Asg[(n1 - 1), (n2 - 1)] = false;
                            c4++;
                            counter++;
                        }
                    }
                    if (n2 >= 4 && n2 <= 6)
                    {
                        if (c5 != 2)
                        {
                            Sudoku[(n1 - 1), (n2 - 1)] = 0;
                            Asg[(n1 - 1), (n2 - 1)] = false;
                            c5++;
                            counter++;
                        }
                    }
                    if (n2 >= 7 && n2 <= 9)
                    {
                        if (c6 != 2)
                        {
                            Sudoku[(n1 - 1), (n2 - 1)] = 0;
                            Asg[(n1 - 1), (n2 - 1)] = false;
                            c6++;
                            counter++;
                        }
                    }
                }
                if (n1 >= 7 && n1 <= 9)
                {
                    if (n2 <= 3)
                    {
                        if (c7 != 2)
                        {
                            Sudoku[(n1 - 1), (n2 - 1)] = 0;
                            Asg[(n1 - 1), (n2 - 1)] = false;
                            c7++;
                            counter++;
                        }
                    }
                    if (n2 >= 4 && n2 <= 6)
                    {
                        if (c8 != 2)
                        {
                            Sudoku[(n1 - 1), (n2 - 1)] = 0;
                            Asg[(n1 - 1), (n2 - 1)] = false;
                            c8++;;
                            counter++;
                        }
                    }
                    if (n2 >= 7 && n2 <= 9)
                    {
                        if (c9 != 2)
                        {
                            Sudoku[(n1 - 1), (n2 - 1)] = 0;
                            Asg[(n1 - 1), (n2 - 1)] = false;
                            c9++;
                            counter++;
                        }
                    }
                }
            }
        }
        //copy matrix 1 to 2
        public void CopySudoku(int[,] Soln, int[,] Sdk)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Sdk[i, j] = Soln[i, j];
                }
            }
        }
        //make a solved matrix 
        public bool SolveSudoku(int[,] Sudoku)
        {
            int Row = 0, Column = 0;
            if (!FindUnassigned(Sudoku, Row, Column))
                return true;
            for (int num = 1; num <= 9; num++)
            {
                if (ISOKAY(Sudoku, Row, Column, num))
                {
                    Sudoku[Row, Column] = num;
                    if (SolveSudoku(Sudoku))
                        return true;
                    Sudoku[Row, Column] = 0;
                }
            }
            return false;
        }

        public bool FindUnassigned(int[,] Sudoku, int Row, int Column)
        {
            for (Row = 0; Row < 9; Row++)
                for (Column = 0; Column < 9; Column++)
                    if (Sudoku[Row, Column] == 0)
                        return true;
            return false;
        }
        public bool UsedInRow(int[,] Sudoku, int Row, int num)
        {
            for (int Column = 0; Column < 9; Column++)
                if (Sudoku[Row, Column] == num)
                    return true;
            return false;
        }
        public bool UsedInColumn(int[,] Sudoku, int Column, int num)
        {
            for (int Row = 0; Row < 9; Row++)
                if (Sudoku[Row, Column] == num)
                    return true;
            return false;
        }
        public bool UsedInBox(int[,] Sudoku, int boxStartRow, int boxStartColumn, int num)
        {
            for (int Row = 0; Row < 3; Row++)
                for (int Column = 0; Column < 3; Column++)
                    if (Sudoku[(Row + boxStartRow),
                        (Column + boxStartColumn)] == num)
                        return true;
            return false;
        }
        public bool ISOKAY(int[,] Sudoku, int Row, int Column, int num)
        {
            return !UsedInRow(Sudoku, Row, num) &&
                !UsedInColumn(Sudoku, Column, num) &&
                !UsedInBox(Sudoku, Row - Row % 3,
                    Column - Column % 3, num) &&
                Sudoku[Row, Column] == 0;
        }
        //used to input value 
        public void setVal(int x, int y,int z)
        {
            Sdk[x, y] = z;
        }
        //used to send the value to the form
        public int getVal(int x,int y)
        {
            return Sdk[x, y];
        }
        //used to make a new Matrix
        public void New()
        {
            solve a=new solve();
            CopySudoku(a.Sdk, Sdk);
            CopySudoku(a.Soln, Soln);

        }
        //used to check if the box has a predefined value       
        public bool CheckAsg(int x,int y)
        {
            return Asg[x, y];
        }
        //used to check if the puzzle has been solved 
        public bool Check()
        {
            int c=0;
            for (int i=0;i<9;i++)
            {
                for (int j=0;j<9;j++)
                {
                    if (Soln[i, j] == Sdk[i, j])
                        c++;
                }
            }
            if (c != 0)
                return false;
            else
                return true;
        }
        //used to reset the puzzle to its original state
        public void Reset()
        {
            CopySudoku(Original, Sdk);
        }

        #endregion
    }
}
