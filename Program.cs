using System.Globalization;
using System.Net.Http.Headers;
using System.Numerics;

public class MyClass
{
    static string InputString()
    {
        return Console.ReadLine();
    }
    static int InputInt()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("masukkan angka selain angka ga bisa");
            }
        }

    }
    static void Main(String[] args)

    {
        Console.WriteLine("Masukkan minimal 8 karakter Mengandung Huruf Besar dan Kecil, mengandung angka dan mengandung simbol");

        string password = InputString();

        if (password.Length >= 8)
        {
            if (password.Any(char.IsUpper))
            {
                if (password.Any(char.IsLower))
                {
                    if (password.Any(char.IsNumber))
                    {
                        if (password.Any(char.IsSymbol))
                        {
                            Console.WriteLine("SABIIIIIII");
                        }
                        else
                        {
                            Console.WriteLine("kurang karakter");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ga ada nomorn ya nih");
                    }
                }
                else
                {
                    Console.WriteLine("Ga ada huruf kecil nih bro");
                }
            }
            else
            {
                Console.WriteLine("Ga ada huruf besar nih ");
            }
        }
        else
        {
            Console.WriteLine("kurang karakter huruf minimal 8");
        }
        /*
        if (password.Any(char.IsSymbol))
        {
            Console.WriteLine("true");
        }
        //&& !password.Any(char.IsLower) && !password.Any(char.IsNumber) && password.Any(char.IsUpper)
        
        Console.WriteLine("masukkan angka");
        int baris1 = 0;
        int kolom1 = 0;
        int[,] matrix1;
        int baris2 = 0;
        int kolom2 = 0;
        int[,] matrix2;

        Console.WriteLine("masukkan brp baris untuk matrix 1");
        baris1 = InputInt();

        Console.WriteLine("masukkan berapa kolom untuk matrix 1");
        kolom1 = InputInt();

        matrix1 = new int[baris1, kolom1];
        for (int i = 0; i < baris1; i++)
        {   
            Console.WriteLine("ini baris ke "+ i);

            for (int j = 0; j < kolom1; j++)
            {
                Console.WriteLine("masukkan kolom ke " + j);
                matrix1[i, j] = InputInt();
            }
        }

        Console.WriteLine("masukkan brp baris untuk matrix ke 2");
        baris2 = InputInt();

        Console.WriteLine("masukkan berapa kolom untuk matrix ke 2 2");
        kolom2 = InputInt();

        matrix2 = new int[baris2, kolom2];
        for (int i = 0; i < baris2; i++)
        {
            Console.WriteLine("ini baris ke " + i);

            for (int j = 0; j < kolom2; j++)
            {
                Console.WriteLine("masukkan kolom ke " + j);
                matrix2[i, j] = InputInt();
            }
        }
        Console.WriteLine("");
        Console.WriteLine("jadi isi dari keduanya adlah sebagai berikut");

        for (int i = 0; i < baris1; i++)
        {
            for (int j = 0; j < kolom1; j++)
            {
                Console.Write(matrix1[i, j]);
            }
        }
        Console.WriteLine("");
        for (int i = 0; i < baris2; i++)
        {
            for (int j = 0; j < kolom2; j++)
            {
                Console.Write
                    (matrix2[i, j]);
            }
        }
        */

    }
}

