using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.SysoevDA.Sprint2.TaskReview.V3.Lib;

namespace Tyuiu.SysoevDA.Sprint2.TaskReview.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 Review | Выполнил: Сысоев Д.А | ПКТБ-23-1";

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* Спринт #2 Review                                                          *");
            Console.WriteLine("* Вариант #3                                                                *");
            Console.WriteLine("* Выполнил: Сысоев Данил Алексеевич | ПКТБ-23-1                             *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные             *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами    *");
            Console.WriteLine("* X,Y в заштрихованной области.                                             *");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("*****************************************************************************");

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("*****************************************************************************");

            if (ds.CheckDotInShadedArea(x, y))
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }
            Console.ReadKey();
        }
    }
}
