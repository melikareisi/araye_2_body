using System;
namespace ConsolApplication
{
    class program
    {
        public static void Main()

        {
            int[,] a = new int[50, 50];
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    Console.Write("Enter element [{0}, {1}]: ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            calc(a);

        }
        private static void calc(int[,] a)
        {
            int sum = 0;
            for (int i = 1; i <= 48; i++)
            {
                for (int j = 1; j <= 48; j++)
                {
                    for (int n = i; n <= i + 2; n++)
                    {
                        for (int m = j; m <= j + 2; m++)
                        {
                            sum += sum + a[n, m];
                        }
                    }
                    a[i, j] = sum / 9;
                }
            }
            for (int i = 0; i <= 49; i++)
            {
                for (int j = 0; j <= 49; j++)
                {
                    Console.WriteLine(a[i, j]);
                }
            }
        }
    }
}