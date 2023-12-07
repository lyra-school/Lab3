/* Name: Lyra Karsaj
 * Date: 2/10/23
 * Desc: Average rating
 */
namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] movieRatings = { { 3, 4, 5 }, { 1, 2, 1 }, { 5, 4, 2 } };

            Console.WriteLine("Avengers Endgame average: " + Average(movieRatings, 0));
            Console.WriteLine("Spider-Man: Far From Home average: " + Average(movieRatings, 1));
            Console.WriteLine("Once Upon A Time in Hollywood average: " + Average(movieRatings, 2));
        }

        static double Average(int[,] movieRatings, int index)
        {
            double sum = 0;
            int length = movieRatings.GetLength(1);
            for (int i = 0; i < length; i++)
            {
                sum += movieRatings[index, i];
            }
            return sum / length;
        }
    }
}