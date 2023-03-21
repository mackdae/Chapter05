using System;

namespace SunMyeongEun_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //연습문제4
            //사용자로부터 입력받은 횟수만큼 별을 출력하는 프로그램 작성
            //반복 횟수를 입력하세요 : 
            //
            //*
            //**
            //***
            //****
            //*****
            //0보다 같거나 작은 숫자는 사용할 수 없습니다.
            Console.Write("반복 횟수를 입력하세요 : "); 
            string input = Console.ReadLine();
            int num = Int32.Parse(input);
            if (num > 0)
            {
                Console.WriteLine("");
                for (int i = 0; i < num; i++)
                {
                    for (int j = 0; j <= i; j++)
                        Console.Write("*");
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("0보다 같거나 작은 숫자는 사용할 수 없습니다.");
            }
        }
    }
}
