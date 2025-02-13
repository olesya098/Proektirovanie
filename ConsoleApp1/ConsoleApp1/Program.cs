using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tochnost = 1E-06;
            double tochnost2 = 1E-10;
            Console.WriteLine($"Результат (while): {WhileDo(tochnost):F6}");
            Console.WriteLine($"Результат (while): {WhileDo(tochnost):F9}");

            Console.WriteLine($"Результат (do-while): {DoWhile(tochnost2):F6}");
            Console.WriteLine($"Результат (do-while): {DoWhile(tochnost2):F9}");
            Console.ReadKey();
        }

        private static double WhileDo(double tochnost)
        {
            double first = 4.0;
            double teknum = 4.0;
            int drob = 3;
            int znach = -1;
            while (Math.Abs(teknum) >= tochnost)
            {
                teknum = 4.0 / drob * znach;
                drob += 2;
                first += teknum;

                znach *= -1;

            }
            return first;
        }

        private static double DoWhile(double tochnost2)
        {
            double first = 4.0;
            double teknum = 4.0;
            int drob = 3;
            int znach = -1;
            int ogranichenie = 0;
            do
            {
                teknum = 4.0 / drob * znach;
                drob += 2;
                first += teknum;
                znach *= -1;
                ogranichenie++;

            }
            while (Math.Abs(teknum) >= tochnost2 && ogranichenie < 1000000);
            return first;
        }
    }

}
