using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Transactions;
using System.Xml.Linq;
using System.IO;
class Program
{
    static void Main()
    {
        string filepath = "data.txt";

        try 
        {
            string content = ReadFile(filepath);
            Console.WriteLine("Isi File:");
            Console.WriteLine(content);
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"File {ex.Message}");
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine($"File {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"File {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"File {ex.Message}");
        }
       
    }

    static string ReadFile(string filePath)
    {

        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"File {filePath} tidak ditemukan");
        }
        using (StreamReader reader = new StreamReader(filePath))
        {
            string content = reader.ReadToEnd();

            if (string.IsNullOrWhiteSpace(content))
            {
                return null;
            }
            return content;
        }
    }
}