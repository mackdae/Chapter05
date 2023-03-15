using System;

namespace p161_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //문제2
            //각 월에 따른 한달간의 날짜 수를 알려주는 프로그램
            Console.Write("몇월이 궁금하세요? : ");
            string input = Console.ReadLine();

            //참조
            //int month = Int32.Parse(input);
            //int Days()
            //{
            //    switch (month)
            //    {
            //        case 2:
            //            return 28;
            //        case 4:
            //        case 6:
            //        case 9:
            //        case 11:
            //            return 30;
            //        default:
            //            return 31;
            //    }
            //}
            //Console.WriteLine($"{month}월은 {Days()}일까지 있습니다.");

            int days = 0;
            switch (input)
            {
                case "2":
                    days = 28;
                    break;
                case "4": case "6": case "9": case "11":
                    days = 30;
                    break;
                case "1": case "3": case "5": case "7": case "8": case "12":
                    days = 31;
                    break; // 스위치문 종료
                default:
                    Console.WriteLine("정상적인 입력값이 아닙니다. 다시 실행하여 주세요.");
                    return; // 메소드 종료, 하단 Write 건너뜀
            }
            Console.WriteLine($"{input}월은 {days}일까지 있습니다.");
        }
    } 
}
