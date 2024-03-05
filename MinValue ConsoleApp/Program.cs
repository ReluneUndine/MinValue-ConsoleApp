using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinValue_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args) // Точка входа, начало кода
        {
            Console.WriteLine("Привет! Давай сыграем в игру? Введи длину последовательности: ");
            ushort length = Convert.ToUInt16(Console.ReadLine()); // ushort - потому что последовательность может быть только числом больше нуля;

            int minValue = int.MaxValue;
            
            Console.WriteLine("Отлично! Введи последовательность чисел. Используй Enter, чтобы отделить их друг от друга: ");
            

            for (int i = 0; i < length; i++)
            {
                short userNumber = Convert.ToInt16(Console.ReadLine()); // short - потому что числа могут быть меньше нуля;

                if (userNumber<minValue)
                {
                    minValue = userNumber;
                }
            }

            Console.WriteLine($"Наименьшее число - {minValue}");
            Console.ReadKey();
        }
    }
}
