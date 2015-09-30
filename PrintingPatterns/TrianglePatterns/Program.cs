using System;

namespace TrianglePatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			DisplayPatternA();
			DisplayPatternB();
			DisplayPatternC();
			DisplayPatternD();

			Console.ReadLine();
		}

		static void DisplayPatternA()
		{
            // your implementation here
            Console.WriteLine("Pattern A:");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("#");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

		static void DisplayPatternB()
		{
            // your implementation here
            Console.WriteLine("Pattern B:");
            for (int i = 10; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("#");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

		static void DisplayPatternC()
		{
            // your implementation here
            Console.WriteLine("Pattern C:");
            for (int i = 10; i >= 1; i--)
            {
                int j = 10;
                while (j - i > 0)
                {
                    Console.Write(" ");
                    j--;
                }
                while (j >= 1)
                {
                    Console.Write("#");
                    j--;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

		static void DisplayPatternD()
		{
            // your implementation here
            Console.WriteLine("Pattern D:");
            for (int i = 10; i >= 1; i--)
            {
                int j = 1;
                while (i - j > 0)
                {
                    Console.Write(" ");
                    j++;
                }
                while (j <= 10)
                {
                    Console.Write("#");
                    j++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
	}
}
