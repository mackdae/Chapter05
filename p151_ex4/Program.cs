using System;

namespace p151_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //문제2
            //정수 한 개를 입력받아서, 그 수가 3의 배수인지 판단하는 프로그램

            Console.Write("정수 한 개를 입력하세요. : ");
            string input = Console.ReadLine();
            int number = Int32.Parse(input);
            Console.WriteLine("입력하신 정수 {0} 은(는) 3의 배수{1}니다.", number, number % 3 == 0 ? "입" : "가 아닙");
        }
    }
}
