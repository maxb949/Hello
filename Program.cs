using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static int[] array= {0,1,2,3,4};
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Console.WriteLine("Press any key for summ");
            Console.ReadKey();
            Console.WriteLine("");

            int sum = 0;
            for (int i=0; i< array.Length;i++)
            {
                Console.Write($"a[{i}]={array[i]}\t");
                sum += array[i];
            }
            Console.WriteLine($"\n\nСумма всех элементов массива равна {sum}");
            Console.ReadKey();
        }
    }
}
