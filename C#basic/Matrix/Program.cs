using System;

namespace Matrix
{
    class Matrix
    {
        private int[,] matrix = null;
        private int NumOfCols;
        private int NumOfRows;


        public Matrix() { }
        public Matrix(int numOfCols, int numOfRows)
        {
            NumOfCols = numOfCols;
            NumOfRows = numOfRows;
            matrix = new int[NumOfCols, NumOfRows];
        }
       
        public int this[int col, int row] {
            set
            { 
                matrix[col, row] = value;
            }
            get
            {
                return matrix[col, row];
            }
        }

        public void GetMatrix()
        {
            Random rnd = new Random();
            for (int i = 0; i < NumOfCols; i++)
            {
                for (int j = 0; j < NumOfRows; j++)
                {
                    matrix[i, j] = rnd.Next(1, 9);
                }
            }
        }
        public void ShowMatrix()
        {
            
            for (int i = 0; i < NumOfCols; i++)
            {
                for (int j = 0; j < NumOfRows; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Matrix matrix = new Matrix(4,4);
            matrix.GetMatrix();
            matrix.ShowMatrix();
            Console.ReadKey();
        }
    }
}
