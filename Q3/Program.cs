/* Name: Lyra Karsaj
 * Date: 2/10/23
 * Desc: Array filling
 */
namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] anArray = { 1, 2, 3, 4, 5, };
            foreach(int i in anArray)
            {
                Console.WriteLine(i);
            }
            Zero(anArray);
            foreach(int i in anArray)
            {
                Console.WriteLine(i);
            }
        }

        static void Zero(int[] someArray)
        {
            for(int i = 0; i < someArray.Length;i++)
            {
                someArray[i] = 0;
            }
        }
    }
}