
namespace FinalProject
{
    public class TestMenu
    {
        public int Option()
        {

            Console.WriteLine("Enter number from 1 to 3 if you want:");
            Console.WriteLine("1. Easy mode with words");
            Console.WriteLine("2. Normal mode with sentences");
            Console.WriteLine("3. Hard mode with text");
            Console.WriteLine("4. Display statistics");
            Console.WriteLine("0. Exit");
            int.TryParse(Console.ReadLine(), out int level);

            if (level >= 0 && level <= 4)
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
