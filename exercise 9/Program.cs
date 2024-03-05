using System.Transactions;

namespace exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your width");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter your height");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int a = 1; a <= height; a++)
            {
                for (int b = 1; b <= width; b++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}