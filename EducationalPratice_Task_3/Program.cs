using System;
namespace EducationalPratice_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
        
                Console.WriteLine("Вычисление функии f(a)");
                Console.Write("Введите число для вычисления :");
            double x = MyLibary.Input.Double();
            double y = x < 1 ? Math.Abs(x) : (x > 1 & x < 2 ? 1 : 5 - 2 * x);
            Console.WriteLine($"y={y} при x={x}");
            Console.ReadKey();

        }
       
    }
}
