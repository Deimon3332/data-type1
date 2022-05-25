using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

//Завдання 4.Перетин множин


namespace Task
{
    class Class3
    {
        public static void main()
        {

            int N = 0, number = 0, cycle;
            string str = Console.ReadLine();

            N = Convert.ToInt32(str);
            int[] array = new int[N];
            int[] array2 = new int[N];


            array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                    if (array[i] == array2[j])
                    {
                        
                        Console.Write(array[i]+" ");
                    }
            }

        }
                
    }

            
        
}
