using System;

namespace p149IfElse
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 5.1 분기문(조건문): if문, swich문

            // 5.1.1 if, else / else if
            Console.WriteLine("숫자를 입력하세요. : ");
            string inputA = Console.ReadLine(); // 사용자의 입력값은 1차적으로 문자열로 받는다
            int numberA = Int32.Parse(inputA); // 문자열을 정수타입으로 형변환

            if (numberA < 0) { Console.WriteLine("음수"); }
            else if (numberA > 0) { Console.WriteLine("양수"); }
            else { Console.WriteLine("0"); }

            if (numberA % 2 == 0) Console.WriteLine("짝수");
            else Console.WriteLine("홀수\n");

            // 짝홀의 조건연산자 버전, if문보다 효율적
            Console.WriteLine(numberA % 2 == 0 ? "짝수" : "홀수");
            // 음수양수도 조건연산자로 되나?
            Console.WriteLine(numberA < 0 ? "음수" : numberA > 0 ? "양수" : "0");
            //되네

            // 5.1.2 if문 중첩
            Console.WriteLine("\n\n숫자를 입력하세요. : ");
            string inputB = Console.ReadLine();
            int numberB = Int32.Parse(inputB);

            if (numberB > 0)
            {
                if (numberB % 2 == 0) Console.WriteLine("0보다 큰 짝수.");
                else Console.WriteLine("0보다 큰 홀수.");
            }
            else
            {
                Console.WriteLine("0보다 작거나 같은 수.\n")
            }

            // if중첩 조건연산자버전
            Console.WriteLine(numberB < 0 ? numberB % 2 == 0 ? "0보다 큰 짝수" : "0보다 큰 짝수" : "0보다 작거나 같은 수.");
        }
    }
}