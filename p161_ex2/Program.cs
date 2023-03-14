using System;

namespace p161_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //문제1
            //정수 2개와 연산기호를 입력받아 결과값이 나오는 계산기

            Console.WriteLine("정수 2개와 연산기호를 입력해주세요!");
            Console.Write("첫 번째 정수를 입력해주세요. : ");
            string input = Console.ReadLine();
            int numA = Int32.Parse(input);
            Console.Write("첫 번째 정수를 입력해주세요. : ");
            input = Console.ReadLine();
            int numB = Int32.Parse(input);
            Console.Write("연산기호를 입력해주세요. ex)+,-,*,/,% : ");
            string symbol = Console.ReadLine();
            int result = 0;

            switch (symbol)
            {
                case "+":
                    result = numA + numB;
                    break;
                case "-":
                    result = numA - numB;
                    break;
                case "*":
                    result = numA * numB;
                    break;
                case "/":
                    result = numA / numB;
                    break;
                case "%":
                    result = numA % numB;
                    break;
                default:
                    Console.WriteLine("잘못된 연산기호");
                    return;
            }
            Console.WriteLine($"입력하신 {numA}{symbol}{numB}의 결과값은 {result}입니다.");

            //문제2,3 숙제
        }
    }
}
