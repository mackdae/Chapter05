using System;

namespace p177_Continue
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 5.3.2 continue
            // 반복 1회 건너뛰고 계속 반복
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            //위아래 같은 결과값
            for (int i = 0; i < 5; i++)
            {
                if (i != 3)
                {
                    Console.WriteLine(i);
                }
            }
            //p177
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine($"{i} : 홀수");
            }
        }
    }
}
