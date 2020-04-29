using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Monte
    {

        public static double Calculation(int a, int b, int с)
        {

            double total = 0;
            double yMax = 0;
            double x;
            double funct;

            int i = 0;
            do
            {
                x = GetRandomNumber(a, b);
                funct = Math.Abs(Function(x));
                if (yMax > funct)
                {
                    total += funct;
                    i++;
                }
                else
                {
                    yMax = funct * 2;
                    i = 0;
                }
            } while (i < с);

            return Math.Sqrt(Math.Abs((b - a) * total / с));
        }
        public static double Function(double x)
        {
            return Math.Cos(x);
        }
        static double GetRandomNumber(double min, double max)
        {
            Random random = new Random();
            return random.NextDouble()*(max - min) + min;
        }
    }
}
   
    
