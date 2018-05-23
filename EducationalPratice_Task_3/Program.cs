using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
           int
        }

        static int function(int x)
        {
            int y;
            if (x < 0)
                y = Math.Abs(x);
            else if (x < 2)
                y = x;
            else
            {
                if (x > 2 && x < 3)
                {
                    y = 1;
                }
                else
                    y = x - (x + 1);
            }
        }
    }
}
