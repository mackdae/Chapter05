using System;

namespace p163_While
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 5.2 반복문 (루프문)
            //while
            //do while
            //for
            //foreach 빅데이터 최적화

            // 5.2.1 while ~하는동안
            int ia = 3;
            while (ia>0)
            {
                Console.WriteLine($"ia : {ia--}");
            }

            // 5.2.2 do while
            // 최초 1회 실행 보장
            int ib = 3;
            
            do
            {
                Console.WriteLine("ib(1) : {0}", ib--);
            }
            while (ib > 0);

            do
            {
                Console.WriteLine("ib(2) : {0}", ib--);
            }
            while (ib > 0);
        }
    }
}
