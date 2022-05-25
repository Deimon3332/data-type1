using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

//Завдання 5.Чи зустрічалося число раніше


namespace Task
{
    class Class4
    {
        public static void main()
        {


            int N = 0, number = 0, number1 = 0, cycle;
            string str = Console.ReadLine();

            N = Convert.ToInt32(str);
            int[] array = new int[N];


            array = Console.ReadLine().Split().Select(int.Parse).ToArray();


            for (int i = 0; i < N; i++)
            {
                cycle = 1;
                for (int j = i - 1; j > -1; j--)
                {

                    if (array[i] == array[j])
                    {

                        cycle = 0;
                    }

                }
                if (cycle != 1)
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
}









