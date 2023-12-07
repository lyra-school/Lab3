/* Name: Lyra Karsaj
 * Date: 2/10/23
 * Desc: Stock & sales
 */
namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stock = 50;
            int sales1 = 51;
            Console.WriteLine("Has it succeeded? " + SaleManager(ref stock, sales1) + ". Current stock: " + stock);
            int sales2 = 49;
            Console.WriteLine("Has it succeeded? " + SaleManager(ref stock, sales2) + ". Current stock: " + stock);
        }

        static bool SaleManager(ref int stock, int sale)
        {
            if(sale > stock)
            {
                return false;
            } else
            {
                stock = stock - sale;
                return true;
            }
        }
    }
}