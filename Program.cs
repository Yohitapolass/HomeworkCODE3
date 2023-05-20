using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter '+' or '-' to perform matrix operations, or any other character to exit:");
            char operation = Console.ReadLine()[0];

            if (operation != '+' && operation != '-')
            {
                Console.WriteLine("Exiting the program...");
                break;
            }

            Console.Write("Enter the size of matrix 1 (row x column): ");
            int rows1 = Convert.ToInt32(Console.ReadLine());
            int columns1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the size of matrix 2 (row x column): ");
            int rows2 = Convert.ToInt32(Console.ReadLine());
            int columns2 = Convert.ToInt32(Console.ReadLine());

            if (operation == '+')
            {
                if (rows1 != rows2 || columns1 != columns2)
                {
                    Console.WriteLine("Cannot perform addition. The sizes of the matrices are different.");
                    continue;
                }

                Console.WriteLine("Enter the elements of matrix 1:");
                double[,] matrix1 = ReadMatrix(rows1, columns1);

                Console.WriteLine("Enter the elements of matrix 2:");
                double[,] matrix2 = ReadMatrix(rows2, columns2);

                double[,] result = AddMatrices(matrix1, matrix2);
                Console.WriteLine("Result of matrix addition:");
                PrintMatrix(result);
            }
            else if (operation == '-')
            {
                if (rows1 != rows2 || columns1 != columns2)
                {
                    Console.WriteLine("Cannot perform subtraction. The sizes of the matrices are different.");
                    continue;
                }

                Console.WriteLine("Enter the elements of matrix 1:");
                double[,] matrix1 = ReadMatrix(rows1, columns1);

                Console.WriteLine("Enter the elements of matrix 2:");
                double[,] matrix2 = ReadMatrix(rows2, columns2);

                double[,] result = SubtractMatrices(matrix1, matrix2);
                Console.WriteLine("Result of matrix subtraction:");
                PrintMatrix(result);
            }
        }
    }

    static double[,] ReadMatrix(int rows, int columns)
    {
        double[,] matrix = new double[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Enter the element at position ({i + 1},{j + 1}): ");
                matrix[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }
        return matrix;
    }

    static double[,] AddMatrices(double[,] matrix1, double[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);
        double[,] result = new double[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }

    static double[,] SubtractMatrices(double[,] matrix1, double[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int columns = matrix1.GetLength(1);
        double[,] result = new double[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        return result;
    }

    static void PrintMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j].ToString("F1") + " ");
            }
            Console.WriteLine();
        }
    }
}
