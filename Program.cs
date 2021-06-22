using System;
using System.Collections.Generic;

namespace morzeCode
{
    public class Program
    {
        public static IDictionary<string, string> MorseCodeDictionary = new Dictionary<string, string>() {
            { ".-", "A"}, { "-...", "B"},{ "-.-.", "C"},{ "-..", "D"},
            { ".", "E"}, { "..-.", "F"}, { "--.", "G"}, { "....", "H"},
            { "..", "I"}, { ".---", "J"}, { "-.-", "K"}, { ".-..", "L"},
            { "--", "M"}, { "-.", "N"}, { "---", "O"}, { ".--.", "P"},
            { "--.-", "Q"}, { ".-.", "R"}, { "...", "S"}, { "-", "T"},
            { "..-", "U"}, { "...-", "V"}, { ".--", "W"}, { "-..-", "X"},
            { "-.--", "Y"},{ "--..", "Z"},
        };

        public static string morzeDecoder(string morzeMessage)
        {
            string endMessage = "";
            string currentLetter = "";
            string[] morseWords = morzeMessage.Split(new[] { "   " }, StringSplitOptions.None);
            foreach (var mWord in morseWords)
            {
                foreach (var m in mWord.Split())
                {
                    bool value = MorseCodeDictionary.TryGetValue(m, out currentLetter);

                    if (value == true)
                    {
                        MorseCodeDictionary.TryGetValue(m, out currentLetter);
                        endMessage += currentLetter;
                    }
                    else
                    {
                        string currentLetterFalse = "*";
                        endMessage += currentLetterFalse;
                    }
                }
                endMessage += " ";
            }
            return "Your message: " + endMessage.Trim();
        }

        public static void Main()
        {
            Console.WriteLine("Good afternoon! Let's decode your message.");
            Console.WriteLine("Enter the morse code and press 'Enter'\n");
            string morzeMessage = Console.ReadLine();
            string endMessage = (morzeDecoder(morzeMessage));
            Console.WriteLine(endMessage);
            Console.WriteLine("Click on any button to exit");
            Console.ReadKey();
        }
    }
}
