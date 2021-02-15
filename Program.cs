using System;
using System.Collections.Generic;
namespace AdvancedDynamicArray
{
    class Program
    {
        static int ReadInt()
        {
            bool isCorrect = false;
            int value = 0;
            isCorrect = int.TryParse(Console.ReadLine(), out value);
            while (isCorrect == false)
            {
                Console.Write("Неккоректный ввод! Повторите ещё раз: ");
                isCorrect = int.TryParse(Console.ReadLine(), out value);
            }
            return value;
        }

        static void ShowMenu()
        {
            Console.WriteLine("Доступные команды: ");
            Console.WriteLine("Введите число, чтобы добавить его в список");
            Console.WriteLine("sum - посчитать сумму введенных чисел и вывести её на экран;");
            Console.WriteLine("exit - выйти из программы.\n");
        }

        static int CountSum(List<int> values)
        {
            int sum = 0;
            foreach (int value in values)
            {
                sum += value;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            var values = new List<int>();
            int newValue = 0, sum = 0;
            bool inputIsNumber;
            string command = "";
            while (command != "exit")
            {
                inputIsNumber = false;
                ShowMenu();
                Console.Write("Введите команду: ");
                command = Console.ReadLine();
                inputIsNumber = int.TryParse(command, out newValue);
                if (inputIsNumber == true)
                {
                    values.Add(newValue);
                    Console.WriteLine("Число добавлено в список");
                }
                else if (command == "sum")
                {
                    sum = CountSum(values);
                    Console.WriteLine($"Сумма введенных чисел = {sum}");
                }
                else if (command == "exit")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Неверная команда!");
                }
                Console.WriteLine("Нажмите на любую клавишу, чтобы продолжить");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
