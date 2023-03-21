using System;

namespace SunMyeongEun_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //연습문제3
            //1,2번을 while, do문으로 작성

            int a = 0;
            int b = 0;
            while (a++ < 5)
            {
                while (b++ < a)
                    Console.Write("*");
                Console.WriteLine("");
                b = 0;
            }

            Console.WriteLine("");

            a = 0;
            b = 5;
            while (a++ < 5)
            {
                while (b-- >= a)
                    Console.Write("*");
                Console.WriteLine("");
                b = 5;
            }
        }
    }
}
