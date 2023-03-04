using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
           
            int multiple = 3, multiple2 = 5;
            int minimumValue = 0;
            int maximumValue = 101;
            int maxNumber = random.Next(minimumValue,maximumValue);
            int sum = 0;

            for (int i = multiple; i <= maxNumber; i++)
            {
               if (i % multiple == minimumValue || i % multiple2 == minimumValue)
                {
                    sum += i;
                }
            }
            Console.WriteLine(" Рандомное число " + maxNumber + " Сумма всех чисел кратных 3 или 5 до " + maxNumber + " равна " + sum);
        }
    }
}