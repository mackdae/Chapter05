using System;

namespace p168_For
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5.2.3 for ~하는동안
            // while문보다 반복을 정교하게 제어할 수 있다

            //      for(초기화식;조건식;반복식;)
            //          반복실행할 코드;
            // 초기화식: 가장 먼저 딱 한번 실행
            // 조건식: 반복을 계속 수행할지 결정
            // 반복식: 반복이 끝날 때마다 실행

            for (int i = 0; i < 3; i++) // 이 int i는 for문 내에서만 쓴다
                Console.WriteLine(i);
            Console.WriteLine();
            for (int i = 3; i >= 1; i--) 
                Console.WriteLine(i);
            Console.WriteLine();

            // p168
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }

            // 5.2.4 for 중첩
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                    Console.WriteLine(" 안녕!");

            // p169
            for (int i =0; i<5; i++)
            {
                for (int j =0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
