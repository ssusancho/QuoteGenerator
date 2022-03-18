using System;
using System.Collections.Generic;

namespace QuoteGenerator
{

    class Program
    {

        public static void Main()
        {
            List<List<string>> quotes = new List<List<string>>();


            List<string> funny = new List<string>();
            quotes.Add(funny);
            funny.Add("this is a funny quote");
            funny.Add("another a funny quote");
            funny.Add("more more funny quote");

            List<string> sad = new List<string>();
            quotes.Add(sad);

            List<string> inspirational = new List<string>();
            quotes.Add(inspirational);

            List<string> nature = new List<string>();
            quotes.Add(nature);

            List<string> music = new List<string>();
            quotes.Add(music);

            List<string> sports = new List<string>();
            quotes.Add(sports);



            Console.WriteLine($"{quotes}");

            Console.WriteLine($"Enter quote option: ");
            string input = Console.ReadLine();

            if (input == "funny")
            {
                Random generator = new Random();
                int index = generator.Next(0, funny.Count);
                string randomFunny = funny[index];
                Console.WriteLine($"{randomFunny}");
            }
            // else (input == "sad")
            // {
            //     Random generator = new Random();
            //     int index = generator.Next(0, sad.Count);
            //     string randomSad = sad[index];
            //     Console.WriteLine($"{randomSad}");
            // }

        }

        public static void DisplayQuoteOptions(List<string> quoteNames)
        {

            if (quoteNames == null) throw new ArgumentException("List of options may not be null.");
            if (quoteNames.Count == 0) throw new ArgumentException("The list of options must contain at least 1 option.");

            int ix = 1;
            foreach (string quoteName in quoteNames)
            {
                Console.WriteLine($"{ix}. {quoteNames}");
                ix = ix + 1;
            }
        }
        public static void QuoteAssignName(List<string> quotes, List<double> quoteNames)
        {
            foreach (string quote in quotes)
            {
                if (quote == "funny")
                {
                    funny = quoteNames("funny");
                }
            }
        }
    }
