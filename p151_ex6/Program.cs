using System;

namespace p151_ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            //문제4
            //4학년은 70점 이상 합격, 그외 60점 이상 합격
            //0미만 100초과시 경고문구

            Console.WriteLine("중간고사 점수 합격여부 프로그램.");
            Console.Write("현재 본인의 학년을 숫자만 입력하세요.(ex.2) : ");
            string input = Console.ReadLine();
            int year = Int32.Parse(input);
            Console.Write("현재 본인의 점수를 입력해 주세요.(ex.85) : ");
            input = Console.ReadLine();
            int score = Int32.Parse(input);

            if (score >= 0)
            {
                if (score <= 100)
                { 
                    Console.WriteLine("입력하신 점수 {0}는(은) {1}합격 입니다.", score, year == 4 ? score >= 70 ? "" : "불" : score >= 60 ? "" : "불"); 
                }
                else { Console.WriteLine("범위를 잘못 입력하셨습니다. 확인 후 다시 입력해주세요."); }
            }
            else { Console.WriteLine("범위를 잘못 입력하셨습니다. 확인 후 다시 입력해주세요."); }
        }
    }
}
