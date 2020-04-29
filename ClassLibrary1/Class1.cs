using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {            

        public static double AreaCalculator(double radius)
        {            
            return Math.PI * Math.Pow(radius, 2);
        }      
        
        public static string TriangleCalculator(double a, double b , double c) 
        {
            double d = (a + b + c) / 2;
            double result = Math.Sqrt(d * (d - a) * (d - b) * (d - c));
            double bc = Math.Pow(b, 2) + Math.Pow(c, 2);
            double ac = Math.Pow(a, 2) + Math.Pow(c, 2);
            double ab = Math.Pow(a, 2) + Math.Pow(b, 2);
            if ((Math.Pow(a, 2) == bc) || (Math.Pow(b, 2) == ac) || (Math.Pow(c, 2) == ab))
            {
                return $"Треугольник прямоугольный и его площадь состовляет:{Math.Round(result,3).ToString()}";
            }
            return $"Площадь треугольника:{Math.Round(result,3).ToString()}";
            
        }
              
    }    
}
