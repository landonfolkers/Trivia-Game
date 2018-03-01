using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TriviaGame
{
    class Program
    {
        static void Main(string[] args)
        {

            getAppInfo();

            greetUser();

            string[] questions = new string[5];
            questions[0] = "What horse is most commonly used for racing?";
            questions[1] = "What is the offspring of a donkey and a horse called?";
            questions[2] = "What is the deadliest snake on the planet?";
            questions[3] = "What do Panda Bears typically eat?";
            questions[4] = "What is the name of the fish that can swim and also walk on land?";

            Random rnd = new Random();

            string question = questions[rnd.Next(0, 2)];

            Console.WriteLine(question);

        }
        static void getAppInfo()
        {
            string appName = "Trivia Game";
            string appVersion = "1.0.0";
            string appAuthor = "Landon Folkers";

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

        static void greetUser()
        {
            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }
    }
}
