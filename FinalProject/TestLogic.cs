using System.Diagnostics;

namespace FinalProject
{
    public class TestLogic
    {
        public void RunTest(string[] texts, string level, TestStatistics stats)
        {
            Random rand = new Random();
            string currentText = texts[rand.Next(texts.Length)];

            Console.WriteLine($"Type the following {level} as quickly and accurately as you can:");
            Console.WriteLine("Write everything in one line\n");
            Console.WriteLine(currentText);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string userInput = Console.ReadLine();

            stopwatch.Stop();

            int mistypes = _mistypesCounter(currentText, userInput);
            double time = stopwatch.Elapsed.TotalSeconds;


            Console.WriteLine($"Time: {time} seconds");
            Console.WriteLine($"Mistypes: {mistypes}/{currentText.Length}");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"\nMistypes Showing: {_mistypesShow(currentText, userInput)}");

            stats.Save(time, mistypes);
        }

        private int _mistypesCounter(string original, string input)
        {
            int mistypes = 0;
            int minLength = Math.Min(original.Length, input.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (original[i] != input[i])
                {
                    mistypes++;
                }
            }

            mistypes += Math.Abs(original.Length - input.Length);
            return mistypes;
        }

        private string _mistypesShow(string original, string input) 
        {
            int minLength = Math.Min(original.Length, input.Length);
            char[] highlighted = new char[original.Length];

            for (int i = 0; i < minLength; i++)
            {
                if (original[i] != input[i])
                {
                    highlighted[i] = original[i]; 
                }
                else
                {
                    highlighted[i] = '*';
                }
            }
            if (original.Length > input.Length)
            {
                for (int i = input.Length; i < original.Length; i++)
                {
                    highlighted[i] = original[i];
                }
            }

            string mistakesShow = new string(highlighted);
            return mistakesShow;
        }
    }
}
