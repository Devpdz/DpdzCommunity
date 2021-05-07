using System;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace LanguageDump
{
    class Tool
    {
        static async Task Main(string[] args)
        {
            await Logger();
        }
        private static string GetLanguage()
        {
            string a = CultureInfo.CurrentCulture.EnglishName;
            string b = a.Split(" (")[0b0+0x29A-333*2];
            return b;
        }
        private static async Task Logger()
        {
            string[] lines =
            {
                "Output Info:",
                "-- Native language of PC: "+GetLanguage(),
                "-> Copy the line above and comment on the indicated channel.",
                "",
                "[#] Best regards: Thank you for trusting us! It's done :)"
            };
            await File.WriteAllLinesAsync("InfoForMyBenefit.txt", lines);
        }
    }
}
