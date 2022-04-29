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
            funny.Add("There is no sunrise so beautiful that it is worth waking me up to see it.");
            funny.Add("People say money is not the key to happiness, but I have always figured if you have enough money, you can have a key made.");
            funny.Add("When I was growing up I always wanted to be someone. Now I realize I should have been more specific.");
            funny.Add("I just want to lie on the beach and eat hot dogs. That's all I've ever wanted.");
            funny.Add("Never put off till tomorrow what you can do the day after tomorrow just as well.");
            funny.Add("Well, you know what they say: If you don't have anything nice to say about anybody, come sit by me.");
            funny.Add("Whatever women do they must do twice as well as men to be thought half as good. Luckily, this is not difficult.");
            funny.Add("I'm not offended by blonde jokes because I know I'm not dumb. And I also know that I'm not blonde.");
            funny.Add("My friends tell me I have an intimacy problem. But they don't really know me.");
            funny.Add("I don't care what they say about me. I just want to eat.");

            List<string> sad = new List<string>();
            quotes.Add(sad);
            sad.Add("You cannot protect yourself from sadness without protecting yourself from happiness.");
            sad.Add("The walls we build around us to keep sadness out also keeps out the joy.");
            sad.Add("Experiencing sadness and anger can make you feel more creative, and by being creative you can get beyond your pain or negativity.");
            sad.Add("Sad hurts but it’s a healthy feeling. It is a necessary thing to feel.");
            sad.Add("There are two types of people in the world: Those who prefer to be sad among others, and those who prefer to be sad alone.");
            sad.Add("The good life is not one immune to sadness but one in which suffering contributes to our development.");
            sad.Add("We never taste happiness in perfection, our most fortunate successes are mixed with sadness.");
            sad.Add("Melancholy is the happiness of being sad.");
            sad.Add("Sad things happen. They do. But we don’t need to live sad forever.");
            sad.Add("Tears come from the heart and not from the brain.");

            List<string> inspirational = new List<string>();
            quotes.Add(inspirational);
            inspirational.Add("When you have a dream, you’ve got to grab it and never let go.");
            inspirational.Add("Nothing is impossible. The word itself says ‘I’m possible!");
            inspirational.Add("The bad news is time flies. The good news is you’re the pilot.");
            inspirational.Add("Keep your face always toward the sunshine, and shadows will fall behind you.");
            inspirational.Add("Success is not final, failure is not fatal: it is the courage to continue that counts.");
            inspirational.Add("You are never too old to set another goal or to dream a new dream.");
            inspirational.Add("At the end of the day, whether or not those people are comfortable with how you’re living your life doesn’t matter. What matters is whether you’re comfortable with it.");
            inspirational.Add("For me, becoming isn’t about arriving somewhere or achieving a certain aim. I see it instead as forward motion, a means of evolving, a way to reach continuously toward a better self. The journey doesn’t end.");



            List<string> quoteNames = new List<string>();
            quoteNames.Add("Funny");
            quoteNames.Add("Sad");
            quoteNames.Add("Inspirational");


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
            else if (userChoice > quoteNames.Count)
            {
                Console.Error.WriteLine("That number was greater than the options displayed.");
            }
            else if (userChoice <= 0)
            {
                Console.Error.WriteLine("That number was less than the options displayed.");
            }
            }
            while (userChoice > quoteNames.Count || userChoice <= 0);
            return userChoice;
        }

    }
}
