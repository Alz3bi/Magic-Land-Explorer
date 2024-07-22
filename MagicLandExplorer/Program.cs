using MagicLandExplorer.Tasks;
using Newtonsoft.Json;
using System.IO;
namespace MagicLandExplorer
{
    public delegate void MyDelegate(List<Category> categories);
    public class Program
    {
        static void Main(string[] args)
        {
            // Define the path to the JSON data file
            string filePath = Path.Combine(Environment.CurrentDirectory, "data/MagicLandData.json");

            // Read the JSON content from the file
            string json = File.ReadAllText(filePath);

            // Deserialize the JSON content to a list of categories
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json)!;

            // Define delegates for different operations
            MyDelegate FilterByDestination = new MyDelegate(FilterDestinations.FilterByDestination);
            MyDelegate FindLongestDuration = new MyDelegate(LongestDuration.FindLongestDuration);
            MyDelegate SortDestinationsByName = new MyDelegate(SortByName.SortDestinationsByName);
            MyDelegate FindTop3Duration = new MyDelegate(Top3Duration.FindTop3Duration);

            while(true)
            {
                Console.Clear();
                Console.WriteLine("1. Filter by Destination Duration");
                Console.WriteLine("2. Find Longest Duration");
                Console.WriteLine("3. Sort Destinations by Name");
                Console.WriteLine("4. Find Top 3 Duration");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice:");
                string? input = Console.ReadLine();
                if (input == null) continue;

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        FilterByDestination(categories);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        FindLongestDuration(categories);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        SortDestinationsByName(categories);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        FindTop3Duration(categories);
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
