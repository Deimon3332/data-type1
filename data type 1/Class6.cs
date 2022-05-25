using System;
using System.Linq;


//Завдання 6. Дієта


namespace Task
{
    internal class Class6
    {
        public static void main()
        {


            double x = 0, y = 0, z = 0, N = 0, A = 0, B = 0, C = 0;
            double[] str = new double[1];
            double[] str1 = new double[1];

            str = Console.ReadLine().Split().Select(double.Parse).ToArray();


            x = str[0];
            y = str[1];
            z = str[2];

            N = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                str1 = Console.ReadLine().Split().Select(double.Parse).ToArray();
                A += Math.Round((str1[0] * str1[3]), 5);
                B += Math.Round((str1[1] * str1[3]), 5);
                C += Math.Round((str1[2] * str1[3]), 5);

            }
            if (A >= x && B >= y && C >= z)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }


    }
}