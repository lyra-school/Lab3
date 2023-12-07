/* Name: Lyra Karsaj
 * Date: 2/10/23
 * Desc: List of players
 */
namespace Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            while (true)
            {
                Console.Write("Enter player name (-1 to exit): ");
                string playerName = Console.ReadLine();
                if(playerName.Equals("-1"))
                {
                    break;
                }
                list.Add(playerName);
            }
            list.Sort();
            foreach(string playerName in list)
            {
                Console.WriteLine(playerName);
            }
        }
    }
}