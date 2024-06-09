
namespace FinalProject
{
    internal class Program
    {
        static void Main()
        {
            string filePath = "C:\\Users\\user\\Desktop\\statistics.txt";
            var menu = new TestMenu();
            var test = new TestLogic();
            var stats = new TestStatistics(filePath);

            while (true)
            {
                int choice = menu.Option();
                if (choice == 0) break;

                switch (choice)
                {
                    case 1:
                        test.RunTest(_words, "word", stats);
                        Console.WriteLine("Press ENTER to continue");
                        string str1 = Console.ReadLine();
                        break;
                    case 2:
                        test.RunTest(_sentences, "sentence", stats);
                        Console.WriteLine("Press ENTER to continue");
                        string str2 = Console.ReadLine();
                        break;
                    case 3:
                        test.RunTest(_texts, "text", stats);
                        Console.WriteLine("Press ENTER to continue");
                        string str3 = Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Enter new file path: ");
                        filePath = Console.ReadLine();
                        stats.ChangeFilePath(filePath);
                        break;
                    case 5:
                        stats.Display();
                        Console.WriteLine("Press ENTER to continue");
                        string str4 = Console.ReadLine();
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
