using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            Console.WriteLine("Калькулятор на C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                Console.Write("Введите первое число: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Ошибкаe: ");
                    numInput1 = Console.ReadLine();
                }

                Console.Write("Введите второе число: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Ошибка: ");
                    numInput2 = Console.ReadLine();
                }

                Console.WriteLine("Выберите действие с числами:");
                Console.WriteLine("\t+ - Сложить");
                Console.WriteLine("\t- - Вычесть");
                Console.WriteLine("\t* - Умножить");
                Console.WriteLine("\t/ - Разделить");
                Console.Write("Ваш выбор? ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Ошибка.\n");
                    }
                    else Console.WriteLine("Ваш результатt: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                Console.Write("Нажмите n для закрытия программы или нажмите ENTER для продолжения ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); 
            }
            return;
        }
    }
}
