using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int expression = 0;
            int mathSymb = 0;

            try
            {
                Console.Write("Введите целое число: X = ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число: Y = ");
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return;
            }

            Console.WriteLine(@"Введите код операции:
    1 - сложение
    2 - вычитание
    3 - произведение
    4 - частное");
            Console.Write("Выш выбор: ");
            try
            {
                mathSymb = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return;
            }


            try
            {
                int[] array = new int[4];


                if (mathSymb == 1)
                {
                    expression = x + y;
                    array[0] = x + y;
                }
                else if (mathSymb == 2)
                {
                    expression = x - y;
                    array[1] = 2;
                }
                else if (mathSymb == 3)
                {
                    expression = x * y;
                    array[2] = 3;
                }
                else if (mathSymb == 4)
                {
                    expression = x / y;
                    array[3] = 4;
                }
                else
                {
                    array[5]=5;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка. Нет операции с выбранным номером.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine($"Результат = {expression}");

            Console.ReadKey();

        }
    }
}
