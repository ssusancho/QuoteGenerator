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

            List<string> quoteNames = new List<string>();
            quoteNames.Add("Funny");
            quoteNames.Add("Sad");
            quoteNames.Add("Inspirational");
            quoteNames.Add("Nature");
            quoteNames.Add("Music");
            quoteNames.Add("Sports");

            int userChoice = DisplayQuoteOptions(quoteNames);

            List<string> selectedQuotes = quotes[userChoice - 1];

            Random generator = new Random();
            int index = generator.Next(0, selectedQuotes.Count);
            string quote = selectedQuotes[index];
            Console.WriteLine($"{quote}");

        }

        public static int DisplayQuoteOptions(List<string> quoteNames)
        {

            if (quoteNames == null) throw new ArgumentException("List of options may not be null.");
            if (quoteNames.Count == 0) throw new ArgumentException("The list of options must contain at least 1 option.");

            

            int ix = 1;
            foreach (string name in quoteNames)
            {
                
                Console.WriteLine($"{ix}. {name}");
                ix = ix + 1;
            }

            int userChoice;
            do{
            Console.Write("Enter the number in front of your choice:");
            string input = Console.ReadLine();
            bool isANumber = int.TryParse(input, out userChoice);
            if (isANumber == false)
            {
                Console.Error.WriteLine("You did not enter a number.");
            }
            else if (userChoice > 6)
            {
                Console.Error.WriteLine("That number was greater than the options displayed.");
            }
            else if (userChoice <= 0)
            {
                Console.Error.WriteLine("That number was less than the options displayed.");
            }
            }
            while (userChoice > 6 || userChoice <= 0);
            return userChoice;
        }
        
    }
}
