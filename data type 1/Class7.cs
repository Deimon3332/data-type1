using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Завдання 1. Найбільш віддалена точка

namespace Task
{
    internal class Class7
    {
        public static void main()
        {
            int N = 0, number = 0, number1 = 0, cycle;
            string str = Console.ReadLine();

            N = Convert.ToInt32(str);
            int[] array = new int[N];


            array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            double maxLenght = 0; 
            int point = 0; 
            for (int i = 0; i < N; i++)
            {
                if (array[i] > maxLenght)
                {
                    maxLenght = array[i];
                    point = i;
                    Console.WriteLine(point);
                }
            }
            
        }
    }
}
    

