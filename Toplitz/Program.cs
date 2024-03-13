// See https://aka.ms/new-console-template for more information
namespace myToplitz
{
    class Toplitz
    {   
        public Boolean Top(int[,] mat, int row, int col)
        {
            for (int r=0; r<row; r++)
            {
                for (int c=0; c < col; c++)
                {
                    if (r>0 && c>0 && mat[r,c] != mat[r-1,c-1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of rows and columns for the matrix: ");

            string rowCol = Console.ReadLine();
            string[] rcs = rowCol.Split(',');

            int columns = int.Parse(rcs[1]);    //列数
            int rows = int.Parse(rcs[0]);       //行数
            int[,] matrix = new int[rows,columns];  //定义矩阵

            Console.WriteLine("Please enter the matrix:");

            for (int i=0; i<rows; i++)
            {
                string rowVal = Console.ReadLine();
                string[] row_ = rowVal.Split(",");
                for (int j=0; j<columns; j++)
                {
                    matrix[i,j] = int.Parse(row_[j]);
                }
            }

            Toplitz toplitz = new Toplitz();
            Console.WriteLine(toplitz.Top(matrix, rows, columns));
        }
    }
}
