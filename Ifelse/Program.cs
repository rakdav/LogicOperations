using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            // double Pi = 3.14;
            // float e = 2.7f;
            //int a;
            //int b;
            //byte c;
            //long l = 99988909080980980;
            //c =(byte) b;
            ////+,-,*,/
            ////  /,%-если оба операнда целые то результат целый
            //// 17/3=5
            //// 17%3=2
            //int la = 34;
            //int lb = 10;
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //a = int.Parse(Console.ReadLine());
            //b= int.Parse(Console.ReadLine());
            //bool r = (x > 2) && (y>3);
            //bool r1 = !(x>2);
            //bool r2 = (x > 2) && (x <= 20);//10<x<=20
            //bool r3 = (y > 0) && (y <= 4) && (x < 5);
            //bool r4 = (a > 100) && (b>100);
            //bool r5 = (a % 2 == 0) ^ (b%2==0);
            //bool r6 = (a > 0) || (b>0);
            //bool r7 = (a % 3 == 0) && (b % 3 == 0);
            //bool r8 = (y >= -2) && (y >= 1);
            //bool r9 = (y >= -2) && (y <= 1.5);
            //bool r10 = (x >= 1) && (x <= 2) && (y > 1) && (y <= 4);
            //bool r11 = (y >= 1) || (y<=-3);
            //Console.WriteLine(r);
            //Console.WriteLine(r1);
            //Console.WriteLine(r3);
            //Начальный уровень 30 вариант
            try
            {
                double x = double.Parse(Console.ReadLine());
                bool r = (x < 0) && (x > 0);
                Console.WriteLine(r);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Средний уровень 30 вариант
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                int d = int.Parse(Console.ReadLine());
                bool r = (a%5==0||b%5==0||c%5==0||d%5==0)&&(a%2==0||b%2==0||c%2==0||d%2==0);
                Console.WriteLine(r);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Высокий уровень 30 вариант
            try
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                bool r = (y<x*x)&&(y>0)&&(x>-1)&&(x<1);
                Console.WriteLine(r);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
