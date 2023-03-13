using System;

namespace p151_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 학점 안내 프로그램
            // 사용자의 점수를 입력받아 90점 이상은 "A", 80점 이상은 "B", 70점 이상은 "C", 69점 이하는 "F"를 출력

            Console.Write("점수를 입력하세요 : ");
            string input = Console.ReadLine();
            int score = Int32.Parse(input);

            Console.Write($"입력하신 점수 {score}는(은) ");
            if (score >= 90) { Console.Write("A"); }
            else if (score >= 80) { Console.Write("B"); }
            else if (score >= 70) { Console.Write("C"); }
            else { Console.Write("F"); }
            Console.WriteLine(" 학점 입니다.");

            //학점저장버전
            string grade;
            if(score>=90) { grade = "A"; }
            else if (score >= 80) { grade = "B"; }
            else if (score >= 70) { grade = "C"; }
            else { grade = "F"; }
            Console.WriteLine($"입력하신 점수 {score}는(은) {grade} 학점 입니다.");

            //조건연산자버전
            Console.WriteLine(score >= 90 ? "A" : score >= 80 ? "B" : score >= 70 ? "C" : "F");
            Console.WriteLine(score < 90 ? score < 80 ? score < 70 ? "F" : "C" : "B" : "A");
        }
    }
}