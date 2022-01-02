using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_11
{
    struct Equation
    {
        double k;    // закрытые поля структуры Equation (т.е. не public)
        double b;

        public Equation(double k, double b) // конструтор, чтобы устанавливать значения
        {
            this.k = k; //(обращаемя к полю)
            this.b = b;
        }

        public string Root() //метод для решения уравнения (по заданию Root)
                             // метод не принимает аргументы, возьмет их из структуры, т.к. имеет к ним доступ
                             // метод вернет либо фразу либо число, поэтому string (выходное значение универсально строкой)
        {
            double x = b / k;
            if (k == 0)
                return "Нет решения, на 0 делить нельзя!";
            return $"Решение:x={x:0.000}";
        }

    }


}
