using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yojana_chapter3
{
    //internal class qn15
    //{
    //    public static void Main(string[] args)
    //    {
    //        // Input dimensions
    //        Console.Write("Enter number of rows for first matrix: ");
    //        int rows1 = Convert.ToInt32(Console.ReadLine());

    //        Console.Write("Enter number of columns for first matrix: ");
    //        int cols1 = Convert.ToInt32(Console.ReadLine());

    //        Console.Write("Enter number of rows for second matrix: ");
    //        int rows2 = Convert.ToInt32(Console.ReadLine());

    //        Console.Write("Enter number of columns for second matrix: ");
    //        int cols2 = Convert.ToInt32(Console.ReadLine());

    //        // Check if multiplication is possible
    //        if (cols1 != rows2)
    //        {
    //            Console.WriteLine("Matrix multiplication not possible. Columns of first matrix must equal rows of second.");
    //            return;
    //        }

    //        // Declare matrices
    //        int[,] matrix1 = new int[rows1, cols1];
    //        int[,] matrix2 = new int[rows2, cols2];
    //        int[,] result = new int[rows1, cols2];

    //        // Input first matrix
    //        Console.WriteLine("\nEnter elements of first matrix:");
    //        for (int i = 0; i < rows1; i++)
    //        {
    //            for (int j = 0; j < cols1; j++)
    //            {
    //                Console.Write($"Element [{i},{j}]: ");
    //                matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
    //            }
    //        }

    //        // Input second matrix
    //        Console.WriteLine("\nEnter elements of second matrix:");
    //        for (int i = 0; i < rows2; i++)
    //        {
    //            for (int j = 0; j < cols2; j++)
    //            {
    //                Console.Write($"Element [{i},{j}]: ");
    //                matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
    //            }
    //        }

    //        // Matrix multiplication
    //        for (int i = 0; i < rows1; i++)
    //        {
    //            for (int j = 0; j < cols2; j++)
    //            {
    //                result[i, j] = 0;
    //                for (int k = 0; k < cols1; k++)
    //                {
    //                    result[i, j] += matrix1[i, k] * matrix2[k, j];
    //                }
    //            }
    //        }

    //        // Display result
    //        Console.WriteLine("\nResultant Matrix:");
    //        for (int i = 0; i < rows1; i++)
    //        {
    //            for (int j = 0; j < cols2; j++)
    //            {
    //                Console.Write(result[i, j] + "\t");
    //            }
    //            Console.WriteLine();
    //        }

    //    }
    //}
}