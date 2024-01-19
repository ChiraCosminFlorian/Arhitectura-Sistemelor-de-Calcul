using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceți numărul în virgulă fixă:");
        string inputNumber = Console.ReadLine();

        Console.WriteLine("Introduceți baza de la care să faceți conversia (b1, între 2 și 16):");
        int b1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduceți baza către care să faceți conversia (b2, între 2 și 16):");
        int b2 = int.Parse(Console.ReadLine());

        try
        {
            string result = ConvertBase(inputNumber, b1, b2);
            Console.WriteLine($"Rezultatul conversiei: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Eroare: {ex.Message}");
        }
    }

    static string ConvertBase(string inputNumber, int fromBase, int toBase)
    {
        // Convertirea din baza sursă în baza 10
        int decimalNumber = ConvertToDecimal(inputNumber, fromBase);

        // Convertirea din baza 10 în baza destinație
        string result = ConvertFromDecimal(decimalNumber, toBase);

        return result;
    }

    static int ConvertToDecimal(string inputNumber, int fromBase)
    {
        return Convert.ToInt32(inputNumber, fromBase);
    }

    static string ConvertFromDecimal(int decimalNumber, int toBase)
    {
        return Convert.ToString(decimalNumber, toBase);
    }
}
