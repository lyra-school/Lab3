/* Name: Lyra Karsaj
 * Date: 2/10/23
 * Desc: Summation
 */
namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int one = 2;
            int two = 10;
            Console.WriteLine(Sum(one, two));
        }

        static int Sum(int n1,  int n2)
        {
            int sum = 0;
            if(n1 > n2)
            {
                for(int i = n2; i <= n1; i++)
                {
                    if(i % 2 == 0)
                    {
                        sum += i;
                    }
                }
            } else
            {
                for (int i = n1; i <= n2; i++)
                {
                    if (i % 2 == 0)
                    {
                        sum += i;
                    }
                }
            }
            return sum;
        }
    }
}