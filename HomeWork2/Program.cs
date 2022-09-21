using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task_1

            
            /* Console.WriteLine("Введите элементы массива:");
             int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = A.Where((n, i) => i % 2 == 0).Sum();
             Console.WriteLine("Сумма четных элементов: "+ sum);
              */



            /*Console.ReadKey();
             Random random = new Random();
             int[,] massive = new int[3, 4];
             for (int i = 0; i < 3; i++)
             {
                 for (int j = 0; j < 4; j++)
                 {
                     massive[i, j] = random.Next(20);
                    //Console.Write(massive[i, j]);
                }
                Console.WriteLine();

            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0}\t", massive[i, j]);
                }
                Console.Write("\n");
            }
            int summ = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (massive[i, j] % 2 != 0) summ += massive[i, j];
                }
            }
            Console.WriteLine("Сумма нечётных cтолбцов массива: {0}", summ);
            */

            #endregion Task_1

            #region Task_2
            
            Random random = new Random();
            int[,] massive = new int[5, 5];
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<5;j++)
                {
                    massive[i, j] = random.Next(-100,100);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0}\t", massive[i, j]);
                }
                Console.Write("\n");
            }
            
            #endregion Task_2

        }
    }
}
