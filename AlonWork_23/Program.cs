using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace AlonWork_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество шагов факториала");
            int n = Convert.ToInt32(Console.ReadLine());
            SumAsinc(n);
            Console.ReadKey();
        }
        static void Sum(int n)
        {
            int s = 1;
            for (int i = 1; i < n; i++)
            {
                s *= i;
                Console.WriteLine("Локальное значение факториала на стадии {0} = {1}",i,s);
                Thread.Sleep(5);
            }
            Console.WriteLine("Значение факториала = {0}",s);
        }
        static async void SumAsinc(int n)
        {
            await Task.Run(() => Sum(n));
        }
    }
}
