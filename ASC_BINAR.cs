using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceți ora curentă în format HH:mm:ss:");
        string inputTime = Console.ReadLine();

        try
        {
            string binaryClock = ConvertToBinaryClock(inputTime);
            Console.WriteLine("Ceasul binar corespunzător:");
            Console.WriteLine(binaryClock);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Eroare: {ex.Message}");
        }
    }

    static string ConvertToBinaryClock(string inputTime)
    {
        // Parsarea inputului în obiectul DateTime
        DateTime currentTime = DateTime.ParseExact(inputTime, "HH:mm:ss", null);

        // Obținerea componentelor orei, minutei și secundei
        int hours = currentTime.Hour;
        int minutes = currentTime.Minute;
        int seconds = currentTime.Second;

        // Conversia în format binar
        string binaryHours = ConvertToBinary(hours, 4);
        string binaryMinutes = ConvertToBinary(minutes, 6);
        string binarySeconds = ConvertToBinary(seconds, 6);

        // Construirea rezultatului
        string binaryClock = $"Ore: {binaryHours}\nMinute: {binaryMinutes}\nSecunde: {binarySeconds}";

        return binaryClock;
    }

    static string ConvertToBinary(int value, int length)
    {
        // Conversia valorii în format binar
        string binaryString = "";

        for (int i = length - 1; i >= 0; i--)
        {
            int bit = (value >> i) & 1;
            binaryString += bit;
        }

        return binaryString;
    }
}
