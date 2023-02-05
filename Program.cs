using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 0.09;
            double c;
            double a;
            int i = 1;
            Console.WriteLine("Введите сумму вклада");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество месяцев");
            double b = double.Parse(Console.ReadLine());
            a = c;
            do
            {
                i++;
                double sum = a * d; //процент за последний месяц
                a += sum; //данные состояния счета после зачисления процентов
                Console.WriteLine("Сумма после {0} месяцев = {1} рублей", i, Math.Round(a, 2));
                Console.WriteLine("Сумма процентов после {0} месяцев = {1} рублей", i, Math.Round(sum, 2));
                Console.WriteLine();
            } while (i <= b);
            Console.WriteLine("Заявленная сумма вклада: {0} рублей", c);
            Console.WriteLine("Процентная ставка: {0}", d);
            Console.WriteLine("Срок вклада: {0} месяцев.", b);
            Console.WriteLine("Стоимость вклада на конец периода: {0} рублей", Math.Round(a, 2));
            Console.ReadKey();
        }
    }
}
