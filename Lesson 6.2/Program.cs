using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[1000], y = new int[1000];
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                x[i] = 50 - random.Next(100);
                Console.Write(x[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                y[i] = 50 - random.Next(100);
                Console.Write(y[i] + " ");
            }
            double xSum = 0, ySum = 0, nn, xSum1 = 1, ySum1 = 1;
            for (int i = 0; i < n; i++)
            {
                xSum += x[i];
                xSum1 *= x[i];
                ySum += y[i];
                ySum1 *= y[i];
            }
            nn = Convert.ToDouble(n);
            Console.WriteLine();
            Console.WriteLine((xSum / nn) * (ySum / nn));
            double xx = 0, yy = 0;
            for (int i = 0; i < n; i++)
            {
                xx += x[i] * x[i];
                yy += y[i] * y[i];
            }
            Console.WriteLine(Math.Sqrt(xx / nn) + Math.Sqrt(yy / nn));
            xx = 0; yy = 0;
            for (int i = 0; i < n; i++)
            {
                if (x[i] > 0) xx++;
                if (y[i] > 0) yy++;
            }
            Console.WriteLine(xx + yy);
            xx = 0; yy = 0;
            for (int i = 0; i < n; i++)
            {
                if (x[i] < 0) xx++;
                if (y[i] < 0) yy++;
            }
            Console.WriteLine(xx + " " + yy);
            if (ySum1 == 0) ySum1++;
            Console.WriteLine(xSum / ySum1);
            xx = 0; yy = 0;
            for (int i = 0; i < n; i++)
            {
                if (x[i] % 2 == 1) xx += x[i];
                if (y[i] % 2 == 0) yy += y[i];
            }
            Console.WriteLine(xx - yy);
            xx = 0;
            for (int i = 0; i < n; i++)
            {
                if (x[i] % 7 == 0) xx += x[i];
                if (y[i] % 7 == 0) xx += x[i];
            }
            Console.WriteLine(xx);
            Console.Write("k = ");
            int k = Convert.ToInt32(Console.ReadLine());
            xx = 0;
            for (int i = 0; i < n; ++i)
            {
                if (x[i] % k == 0) xx++;
                if (y[i] % k == 0) xx++;
            }
            Console.WriteLine(xx);
            xx = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) xx += x[i];
                else xx += y[i];
            }
            Console.WriteLine(xx);
            xx = 0;
            for (int i = 0; i < n; i++)
            {
                xx += (x[i] * x[i]) + (y[i] * y[i]);
            }
            Console.WriteLine(xx);



            Console.ReadKey();
        }
    }
}
}
