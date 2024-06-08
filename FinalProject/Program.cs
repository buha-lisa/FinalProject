
namespace FinalProject
{
    internal class Program
    {
        static void Main()
        {
            var menu = new TestMenu();
            var test = new TestLogic();
            var stats = new TestStatistics("statistics.txt");

            while (true)
            {
                int choice = menu.Option();
                if (choice == 0) break;

                switch (choice)
                {
                    case 1:
                        test.RunTest(_words, "word");
                        break;
                    case 2:
                        test.RunTest(_sentences, "sentence");
                        break;
                    case 3:
                        test.RunTest(_texts, "text");
                        break;
                    case 4:
                        stats.Display();
                        break;
                }
            }

        }
        private static string[] _words = new string[]
        {
            "Aeroplane",
            "Carrier",
            "Airforce",
            "Alphabet",
            "Backpack",
            "Barbecue",
            "Bathroom",
            "Cappuccino",
            "Chess",
            "Drum",
        };
        private static string[] _sentences = new string[]
        {
            "The quick brown fox jumps over the lazy dog",
            "A journey of a thousand miles begins with a single step",
            "To be or not to be, that is the question",
            "All that glitters is not gold",
            "The only thing we have to fear is fear itself"
        };
        private static string[] _texts = new string[]
        {
            "To be, or not to be, that is the question: Whether 'tis nobler in the mind to suffer The slings and arrows of outrageous fortune, Or to take arms against a sea of troubles And by opposing end them.",

            "Suddenly, I'm not half the man I used to be, There's a shadow hanging over me, Oh, yesterday came suddenly. Why she had to go I don't know she wouldn't say."
        };
    }
}
