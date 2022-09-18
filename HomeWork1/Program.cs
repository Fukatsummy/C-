using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task_1
            /*
            int number = 0;
            do
            {
                Console.WriteLine("Введите число: ");
                try
                {
                    number = Int32.Parse(Console.ReadLine());
                    if (number < 0 || number > 100)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Попробуйте снова!");
                }
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                    return;
                }
                if (number % 3 == 0) Console.WriteLine("Fizz");
                if (number % 5 == 0) Console.WriteLine("Buzz");
                if (number % 3 != 0 && number % 5 != 0) Console.WriteLine(number);
            } while (number < 0 || number > 100);
            */
            #endregion Task_1

            #region Task_2

            /* int number = 0;
             int percent = 0;

             Console.WriteLine("Введите число: ");
             try
             {
                 number = Int32.Parse(Console.ReadLine());
                 Console.WriteLine("Введите процент: ");
                 percent = Int32.Parse(Console.ReadLine());
                 int result = number * percent / 100;
                 Console.WriteLine("Полученный результат: {0}", result);
             }
             catch(Exception)
             {
                 Console.WriteLine("Попробуйте снова.");
             }*/
            #endregion Task_2

            #region Task_3
            /*
            double number1, number2, number3, number4;
            int result;

            Console.WriteLine("Введите первую цифру: ");
            number1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую цифру: ");
            number2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите тертью цифру: ");
            number3 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите четвертую цифру: ");
            number4 = Double.Parse(Console.ReadLine());

            result = (int)number1 * 1000 + (int)number2 * 100 + (int)number3 * 10 + (int)number4;
            Console.WriteLine("Полученный результат: {0}", result);
            */
            #endregion Task_3

            #region Task_4
            // Падает, не пойму в чем причина.

            /*int size = 6;
            int[] arr = new int[size];
            Console.WriteLine("Введите шестизначное число");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }
               
            //for(int i=0;i<size;i++)
            //{
            //    arr[i] = Int32.Parse(Console.ReadLine());
            //    if(arr[i]>=10)
            //    {
            //        Console.WriteLine("Попробуйте снова.");
            //    }
            //}
            int dis1 = 0; int dis2 = 0;
            Console.WriteLine("Введите первый разряд: ");
            try
            {
                dis1 = Int32.Parse(Console.ReadLine());
                if (dis1 < 1 || dis1 > 6) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода!");
            };

            Console.WriteLine("Введите второй разряд: ");
            try
            {
                dis2 = Int32.Parse(Console.ReadLine());
                if (dis2 < 1 || dis2 > 6) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка ввода!");
            };
            int buffer = arr[dis1];
            arr[dis1] = arr[dis2];
            arr[dis2] = buffer;
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }*/

            #endregion Task_4

            #region Task_5

            String date;
            Console.WriteLine("Введите дату MM:dd:yyy");
            date = Console.ReadLine();
            DateTime dt = Convert.ToDateTime(date);
            Console.WriteLine(dt.ToLongDateString());

            #endregion Task_5

            #region Task_6

            #endregion Task_6

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
