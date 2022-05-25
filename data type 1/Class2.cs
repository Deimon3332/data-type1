using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


//Завдання 3.Кількість збігаються


namespace Task
{
    class Class2
    {
        public static void main()
        {

            int N = 0,numb=0;
            string str = Console.ReadLine();

            N = Convert.ToInt32(str);
            int[] array = new int[N];
            int[] array2 = new int[N];


            array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();


            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                    if (array[i] == array2[j])
                    {
                        numb++;
                    }
            }

            Console.WriteLine("numb   " + numb);
        }

    }
}