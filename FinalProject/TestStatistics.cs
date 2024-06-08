
namespace FinalProject
{
    public class TestStatistics
    {
        private readonly string _filePath;
        public TestStatistics(string filePath)
        {
            _filePath = filePath;
        }
        public void Save(double time, int mistypes)
        {
            if (!File.Exists(_filePath))
            {
                Console.WriteLine("Error. File isn't exists...");
            }
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine($"Time: {time} seconds, Mistypes: {mistypes}");
            }
        }
        public void Display()
        {
            if (!File.Exists(_filePath))
            {
                Console.WriteLine("Error. File isn't exists...");
            }
            if (File.Exists(_filePath))
            {
                string[] lines = File.ReadAllLines(_filePath);
                Console.WriteLine("Statistics:");
                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("No statistics available.");
            }
        }
    }
}
