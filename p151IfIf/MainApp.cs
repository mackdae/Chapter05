using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p151IfIf
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 5.1.2 if문 중첩

            Console.WriteLine("\n숫자를 입력하세요. : ");
            string input = Console.ReadLine();
            int number = Int32.Parse(input);

            if (number > 0)
            {
                if (number % 2 == 0) Console.WriteLine("0보다 큰 짝수.");
                else Console.WriteLine("0보다 큰 홀수.");
            }
            else
            {
                Console.WriteLine("0보다 작거나 같은 수.\n")
            }

            // if중첩 조건연산자버전
            Console.WriteLine(number < 0 ? number % 2 == 0 ? "0보다 큰 짝수" : "0보다 큰 짝수" : "0보다 작거나 같은 수.");
        }
    }
}
