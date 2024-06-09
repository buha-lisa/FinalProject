
namespace FinalProject
{
    public class TestMenu
    {
        public int Option()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("+--------------------------------------+");
            Console.WriteLine("|              MAIN MENU               |");
            Console.WriteLine("+--------------------------------------+");
            Console.WriteLine("| 1. Start Level 1 (Words)             |");
            Console.WriteLine("| 2. Start Level 2 (Sentences)         |");
            Console.WriteLine("| 3. Start Level 3 (Texts)             |");
            Console.WriteLine("| 4. Change Statistics File Path       |");
            Console.WriteLine("| 5. Display Statistics                |");
            Console.WriteLine("| 0. Exit                              |");
            Console.WriteLine("+--------------------------------------+");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter your choice: ");
            int.TryParse(Console.ReadLine(), out int level);
            Console.ForegroundColor = ConsoleColor.Black;

            if (level >= 0 && level <= 5)
            {
                return level;
            }
            else
            {
                Console.WriteLine("Invalid choice. Exiting...");
                return -1;
            }
        }
    }
}
