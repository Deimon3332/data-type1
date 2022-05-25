using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

//Завдання 5.a + b = c


namespace Task
{
    class Class5
    {
        public static void main()
        {


            double a = 0, b = 0, c = 0;
            string str = Console.ReadLine();
            string str2 = Console.ReadLine();
            string str3 = Console.ReadLine();
            a = Convert.ToDouble(str);         
            b = Convert.ToDouble(str2);
            c = Convert.ToDouble(str3);


            if (Math.Round(a + b ,7) == Math.Round( c,7))
            {
                Console.WriteLine("aboba");
            }

        }


    }
}









