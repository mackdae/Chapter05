using System;

namespace p151_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문제1
            // 정수 한 개를 입력받아서 그 수가 50 이상의 수인지 50 미만의 수인지 판단하는 프로그램
            Console.Write("숫자를 입력하세요. : ");
            string input = Console.ReadLine();
            int number = Int32.Parse(input);

            Console.Write($"입력하신 숫자 {number}는(은) 50");
            if (number >= 50) { Console.Write("이상"); }
            else { Console.Write("미만"); }
            Console.Write("의 수 입니다.\n\n");

            //조건연산자버전
            Console.Write($"입력하신 숫자 {number}는(은) 50");
            Console.Write(number >= 50 ? "이상" : "미만");
            Console.Write("의 수 입니다.\n\n");

            Console.WriteLine("입력하신 숫자 {0}는(은) 50{1}의 수 입니다.", number, number >= 50 ? "이상" : "이하");

            //문제2는 내일까지 숙제
            //문제3,4는 평가 챕터5 끝나기 전까지
        }
    }
}
