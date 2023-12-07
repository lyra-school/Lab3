/* Name: Lyra Karsaj
 * Date: 2/10/23
 * Desc: Product cost
 */
namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test1 = "jeans";
            string test2 = "a";
            string test3 = "belts";

            double[] results = { ProductCost(test1), ProductCost(test2), ProductCost(test3) };
            foreach(double result in results)
            {
                if(result == -999)
                {
                    Console.WriteLine("Found error with item description.");
                } else
                {
                    Console.WriteLine(result);
                }
            }
        }

        static double ProductCost(string product)
        {
            switch(product.ToLower())
            {
                case "jeans":
                    return 67.99;
                case "jacket":
                    return 68.99;
                case "boots":
                    return 34.99;
                case "scarves":
                case "belts":
                case "socks":
                    return 10;
                default:
                    return -999;
            }
        }
    }
}