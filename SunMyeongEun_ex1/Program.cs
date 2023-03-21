using System;

namespace SunMyeongEun_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //연습문제1
            //다음과 같은 결과를 출력하는 프로그램을 for문을 이용하여 작성
            //*
            //**
            //***
            //****
            //*****
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine("");
            }   
        }
    }
}
