/* Name: Lyra Karsaj
 * Date: 2/10/23
 * Desc: Jagged arrays
 */
namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] filmReviews = new int[][]
            {
                new int[] { 3,4 },
                new int[] { 1,2,1,3 },
                new int[] { 5,4,2 }
            };
            Console.WriteLine("Avengers Endgame average: " + Average(filmReviews, 0));
            Console.WriteLine("Spider-Man: Far From Home average: " + Average(filmReviews, 1));
            Console.WriteLine("Once Upon A Time in Hollywood average: " + Average(filmReviews, 2));
        }

        static double Average(int[][] movieRatings, int index)
        {
            double sum = 0;
            int length = movieRatings[index].Length;
            for (int i = 0; i < length; i++)
            {
                sum += movieRatings[index][i];
            }
            return sum / length;
        }
    }
}