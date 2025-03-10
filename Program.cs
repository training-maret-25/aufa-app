using System;

public class MyClass
{
    static int InputInt()
    {
        while (true)
        {
            Console.WriteLine("Masukkan angka: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Input tidak valid, masukkan angka!");
            }
        }
    }

    static int[,] InputMatrix(int rows, int columns, string matrixName)
    {
        int[,] matrix = new int[rows, columns];
        Console.WriteLine($"Masukkan elemen untuk {matrixName}:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Masukkan nilai di baris {i + 1}, kolom {j + 1}: ");
                matrix[i, j] = InputInt();
            }
        }
        return matrix;
    }

    static void PrintMatrix(int[,] matrix, string matrixName)
    {
        Console.WriteLine($"\nIsi dari {matrixName}:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static int[,] Matrix2D(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        if (cols1 != rows2)
        {
            throw new InvalidOperationException("Jumlah kolom matriks pertama harus sama dengan jumlah baris matriks kedua.");
        }

        int[,] result = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                for (int k = 0; k < cols1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Masukkan jumlah baris untuk matriks 1:");
        int rows1 = InputInt();
        Console.WriteLine("Masukkan jumlah kolom untuk matriks 1:");
        int cols1 = InputInt();
        int[,] matrix1 = InputMatrix(rows1, cols1, "Matriks 1");

        Console.WriteLine("Masukkan jumlah baris untuk matriks 2:");
        int rows2 = InputInt();
        Console.WriteLine("Masukkan jumlah kolom untuk matriks 2:");
        int cols2 = InputInt();
        int[,] matrix2 = InputMatrix(rows2, cols2, "Matriks 2");

        PrintMatrix(matrix1, "Matriks 1");
        PrintMatrix(matrix2, "Matriks 2");

        try
        {
            int[,] result = Matrix2D(matrix1, matrix2);
            PrintMatrix(result, "Hasil Matriks");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
