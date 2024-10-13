using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace pr23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] mas = new int[n, m];
            int stop = 1;
            int y_max = 0, y_min = n - 1;
            int x_min = 0, x_max = m - 1;

            while (stop <= n * m)
            {
                for (int i = x_min; i <= x_max && stop <= n * m; i++)
                {
                    mas[y_max, i] = stop++;
                }
                y_max++;

                for (int i = y_max; i <= y_min && stop <= n * m; i++)
                {
                    mas[i, x_max] = stop++;
                }
                x_max--;

                for (int i = x_max; i >= x_min && stop <= n * m; i--)
                {
                    mas[y_min, i] = stop++;
                }
                y_min--;

                for (int i = y_min; i >= y_max && stop <= n * m; i--)
                {
                    mas[i, x_min] = stop++;
                }
                x_min++;

            }

            for (int i = 0; i < n; i++)
            {
                for (int b = 0; b < m; b++)
                {
                    Console.Write($"{mas[i, b], 4} ");
                }
                Console.WriteLine();
            }
        }

    }
}
