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
            Console.WriteLine("sum - посчитать сумму введенных чисел и вывести её на экран;");
            Console.WriteLine("exit - выйти из программы.\n");
        }

        static string ReadCommand()
        {
            string command = "";
            bool isCorrect = false;
            Console.Write("Введите команду: ");
            while (isCorrect == false)
            {
                command = Console.ReadLine();
                if (command == "sum" || command == "exit")
                {
                    isCorrect = true;
                }
                else
                {
                    Console.Write("Неверная команда! повторите ввод: ");
                }
            }
            return command;
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
            int quantityOfValues = 0;
            int newValue = 0, sum = 0;
            string command = "";
            Console.Write("Введите количество чисел: ");
            quantityOfValues = ReadInt();
            for (int i = 0; i < quantityOfValues; i++)
            {
                Console.Write($"Введите {i + 1}-ое число: ");
                newValue = ReadInt();
                values.Add(newValue);
            }
            while (command != "exit")
            {
                ShowMenu();
                command = ReadCommand();
                if (command == "sum")
                {
                    sum = CountSum(values);
                    Console.WriteLine($"Сумма введенных чисел = {sum}");
                }
            }
        }
    }
}
