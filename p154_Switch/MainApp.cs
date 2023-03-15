using System;

namespace p154Switch
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 5.1.3 switch문

            Console.Write("요일을 입력하세요.(일,월,화,수,목,금,토) : ");
            string day = Console.ReadLine();
            int aaa = 1; // case when 예시용 아무변수

            switch (day)
            {
                case "일":
                    Console.WriteLine("Sunday");
                    break; // 점프문
                case "월":
                    if (aaa == 1) Console.WriteLine("1_Monday"); // case when 대신 if
                    else Console.WriteLine("2_Monday");
                    break;
                case "화" when (aaa == 1): // case when 예시
                    Console.WriteLine("1_Tuesday");
                    break;
                case "화":
                    Console.WriteLine("2_Tuesday");
                    break;
                case "수":
                    Console.WriteLine("Wednesday");
                    break;
                case "목":
                    Console.WriteLine("Thursday");
                    break;
                case "금":
                    Console.WriteLine("Friday");
                    break;
                case "토":
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine($"{day}는(은) 요일이 아닙니다.");
                    break;
            }

            //스위치 쓰는곳엔 이프도 쓸 수 있음
            // 이프문이 더 선호되는 경향

            // 5.1.4 switch식
            //int input = Convert.ToInt32(Console.ReadLine());
            //int score = (int)(Math.Truncate(input / 10.0)*10); // 1의 자리를 버림
            //bool repeated = true;
            //string grade = score switch
            //{
            //    90 when repeated == true => "B+", //90점이어도 repeated가 true면 B+
            //    90 => "A",
            //    80 => "B",
            //    70 => "C",
            //    60 => "D",
            //    _ => "F"
            //};
            // 버전 안 맞아서 안 됨
            // 개별구성요소 닷넷코어 설치해야 함
            // 최신버전은 문제 없으나 유니티용으로 2019 깔았음 지원안됨
        }
    }
}