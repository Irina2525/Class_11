using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //с клавиатуры добавляем два числа
            Console.WriteLine("***Решения линейного уравнения 0=kx+b***");
            Console.Write("ВВедите первый коэффициент уравнения b=");
            double b = Convert.ToDouble(Console.ReadLine());  
            Console.Write("ВВедите второй коэффициент уравнения k=");
            double k = Convert.ToDouble(Console.ReadLine());

            // теперь используем структуру, т.е. создаем экземпляр структуры
            Equation equation = new Equation(k, b);

            // вызываем метод Root (он вернет строку, мы ее выведем)
            Console.WriteLine(equation.Root());
            Console.ReadKey();
        }
    }
}
