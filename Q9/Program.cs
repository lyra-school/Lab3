/* Name: Lyra Karsaj
 * Date: 2/10/23
 * Desc: Reading comma separated data
 */
namespace Q9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\test\sales.txt";

            string[] entries = File.ReadAllLines(path);

            Console.WriteLine("Sales Report");
            Console.WriteLine($"{"Store ID",-25}{"Sales",-25}{"Performance",-25}");

            int salesTotal = 0;
            foreach (string entry in entries)
            {
                string[] entryData = entry.Split(',');
                int salesFigure = Int32.Parse(entryData[1]);
                Console.WriteLine($"{entryData[0],-25}{salesFigure,-25}{Feedback(salesFigure),-25}");
                salesTotal += salesFigure;
            }
            int averageSales = salesTotal / entries.Length;
            Console.WriteLine($"Total Sales: {salesTotal:N0}");
            Console.WriteLine($"Average Sales: {averageSales:N0}");
        }
        static string Feedback(int sales)
        {
            if (sales >= 2000)
            {
                return "Very good";
            } else if(sales >= 1000 && sales <= 1999)
            {
                return "Moderate";
            } else
            {
                return "Needs attention";
            }
        }
    }
}