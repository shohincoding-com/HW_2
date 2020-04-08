using System;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {
           //Task_1
           double a = 16.80, b = 12.40, c;
           c = Math.Sqrt(a * b);
           Console.WriteLine(c);
           //EndTask_1

           //Task_2
           double A, B, C, AC, BC;
           A = 1.4;
           B = -5.5;
           C = 0.6;
           AC = Math.Abs(C - A);
           BC = Math.Abs(C - B);
           Console.WriteLine($"\nAC = {AC}\nBC = {BC}\nAC + BC = {AC + BC}");
           //EndTask_2

           //Task_3
            double x1 = -6.2, x2 = 2.1, y1 = 5.2, y2 = 9.8;
            double s = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));
            Console.WriteLine($"\ns = {s}");
            //EndTask_3

            //Task_4
            int a2 = 41;
            int b2 = a2/10;
            int c2 = a2%10;
            Console.WriteLine($"\n{c2}{b2}");
            //EndTask_4

            //Task_5
            int N=10985;
            int Hours = N/60;
            Console.WriteLine($"\nHours = {Hours}");
            //EndTask_5

            //Task_6
            int d = 202;
            Console.WriteLine($"\n{202 % 7}");
            //EndTask_6
        
        }
    }
}
