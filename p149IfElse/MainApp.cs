using System;

namespace p149IfElse
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 5.1 분기문(조건문): if문, swich문

            Console.WriteLine("숫자를 입력하세요. : ");
            string input = Console.ReadLine(); // 사용자의 입력값은 1차적으로 문자열로 받는다
            int number = Int32.Parse(input); // 문자열을 정수타입으로 형변환

            if (number < 0) { Console.WriteLine("음수"); }
            else if (number > 0) { Console.WriteLine("양수"); }
            else { Console.WriteLine("0"); }

            if (number % 2 == 0) Console.WriteLine("짝수");
            else Console.WriteLine("홀수\n");

            // 짝홀의 조건연산자 버전, if문보다 효율적
            Console.WriteLine(number % 2 == 0 ? "짝수" : "홀수");
            // 음수양수도 조건연산자로 되나?
            Console.WriteLine(number < 0 ? "음수" : number > 0 ? "양수" : "0");
            //되네
        }
    }
}