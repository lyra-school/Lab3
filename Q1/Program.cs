/* Name: Lyra Karsaj
 * Date: 2/10/23
 * Desc: Age verification
 */
namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Can you access the website? " + AgeCheck(age));
        }

        static bool AgeCheck(int age)
        {
            if (age >= 18 && age <= 21)
            {
                return true;
            }
            return false;
        }
    }
}