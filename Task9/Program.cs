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
            int[] mathSymb = { 1, 2, 3, 4 };

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


            int numberSymbol = 0;

            try
            {
                numberSymbol = Convert.ToInt32(Console.ReadLine());
                int symbol = mathSymb[-1 + numberSymbol];
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка. Некорректный ввод.");
                Console.ReadKey();
                return;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка. Нет операции с выбранным номером.");
                Console.ReadKey();
                return;
            }

            double expression = 0;
            try
            {
                if (numberSymbol == 1)
                {
                    expression = x + y;
                }
                else if (numberSymbol == 2)
                {
                    expression = x - y;
                }
                else if (numberSymbol == 3)
                {
                    expression = x * y;
                }
                else if (numberSymbol == 4)
                {
                    expression = x / y;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Результат = {0}", expression);
            Console.ReadKey();


        }
    }
}
