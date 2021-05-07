using System;
using System.Globalization;
using System.IO;

namespace Program
{
    class Tool
    {
        static void Main(string[] args)
        {
            GetLanguage();
            Log("The file was created successfully.");
        }
        private static void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        private static string Language()
        {
            string a = CultureInfo.CurrentCulture.EnglishName;
            string b = a.Split('(', ')')[0b0 + 0x29A - 333 * 2];
            return b;
        }
        private static void GetLanguage()
        {
            string[] lines =
            {
                "Output Info:",
                "-- Native language of PC: "+Language(),
                "-> Copy the line above and comment on the indicated channel.",
                "",
                "[#] Best regards: Thank you for trusting us! It's done :)"
            };
            File.WriteAllLines("InfoForMyBenefit.txt", lines);
        }
    }
}
