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

            //int month = Int32.Parse(input);
            //int DaysInMonth()
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
            //Console.WriteLine($"{month}월은 {DaysInMonth()}일까지 있습니다.");

            int daysInMonth = 0;
            switch (input)
            {
                case "2"://28
                    daysInMonth = 28;
                    break;
                case "4":
                case "6":
                case "9":
                case "11":
                    daysInMonth = 30;
                    break;
                case "1":
                case "3":
                case "5":
                case "7":
                case "8":
                case "12":
                    daysInMonth = 31;
                    break;
                default:
                    Console.WriteLine("정상적인 입력값이 아닙니다. 다시 실행하여 주세요.");
                    return;
            }
            Console.WriteLine($"{input}월은 {daysInMonth}일까지 있습니다.");
        }
    } 
}
