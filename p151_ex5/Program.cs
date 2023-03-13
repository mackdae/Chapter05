using System;

namespace p151_ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //문제3
            //사용자로부터 세 개의 정수를 입력받아, 최대값과 최소값, 합계와 평균을 구하는 프로그램

            Console.Write("세 개의 정수 중 첫번째 정수를 입력해 주세요. :");
            string input = Console.ReadLine();
            int numA = Int32.Parse(input);
            Console.Write("세 개의 정수 중 두번째 정수를 입력해 주세요. :");
            input = Console.ReadLine();
            int numB = Int32.Parse(input);
            Console.Write("세 개의 정수 중 세번째 정수를 입력해 주세요. :");
            input = Console.ReadLine();
            int numC = Int32.Parse(input);
            int max;
            int min;

            if (numA > numB)
            {
                if (numA > numC)
                {
                    max = numA;
                    if (numB > numC)
                    {   min = numC; }
                    else
                    {   min = numB; }
                }
                else
                {   
                    max = numC;
                    min = numB;
                }
            }
            else if (numB > numC)
            {
                max = numB;
                if (numA > numC)
                {   min = numC; }
                else
                {   min = numA; }
            }
            else
            {
                max = numC;
                min = numA;
            }
            Console.WriteLine($"입력하신 {numA},{numB},{numC} 중 최대값은 {max}이며, 최소값은 {min} 입니다.");
            Console.WriteLine($"입력하신 {numA},{numB},{numC} 의 합은 {numA+numB+numC}이며, 평균은 {(numA + numB + numC)/3} 입니다.");

            //Console.WriteLine(numA > numB ? numA > numC ? numB > numC ? "최대값A최소값C" : "최대값A최소값B" : "최대값C최소값B" : numB > numC ? numA > numC ? "최대값B최소값C" : "최대값B최소값A" : "최대값C최소값A");
        }
    }
}
