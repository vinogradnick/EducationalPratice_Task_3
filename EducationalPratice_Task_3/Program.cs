using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validator;

namespace EducationalPratice_Task_3
{
    /// <summary>
    /// Дана действительная квадратичная матрица порядка 9
    /// Получить целочисленную квадратную матрицу того же порядка,
    ///  в которой элемент равен еденице, 
    ///     если соответствующий ему элемент исходной матрицы больше элемента, 
    ///         расположенного в его строке на главной диагонали,
    ///  и равен нулю в противном случае.
    /// </summary>
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление функии f(a)");
            Console.WriteLine("Введите число для вычисления");
            double a = Double();
            Console.WriteLine($"y={Function(a)} при x={a}");
        }
        /// <summary>
        /// Функция 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static double Function(double x)
        {
            double y;
            if (x < 2)
                y = Math.Abs(x);
            else if (x >= 1 && x <= 2)
                y = 1;
            else
                y = 5 - 2 * x;
            return y;
        }
        /// <summary>
        /// Число для ввода
        /// </summary>
        /// <returns></returns>
        static double Double()
        {
            double res;
            bool ok;
            do
            {
                ok = double.TryParse(Console.ReadLine(), out res);
                ok = res > 0;
                if (!ok)
                    Console.WriteLine("Вы ввели неправильное число, повторите попытку \n Введите число: ");
            } while (!ok);
            return res;
        }
    }
}
