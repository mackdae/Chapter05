using System;

namespace p179_Goto
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //5.3.3 goto
            //레이블(이름표) 달린 위치로 바로 뛰어넘어감
            Console.WriteLine("1");
            goto JUMP;
            Console.WriteLine("2");
            Console.WriteLine("3");
        JUMP:
            Console.WriteLine("4");
            //흐름을 자주 끊어 코드를 읽기 어렵게 만듦
            //중첩된 반복문을 단번에 뚫고 나올 때 유용

            //p179
            Console.Write("종료 조건(숫자)을 입력하세요 :");
            String input = Console.ReadLine();
            int input_number = Convert.ToInt32(input);
            int exit_number = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (exit_number++ == input_number) //비교 먼저 하고 엑시트에+1
                            goto EXIT_FOR; // 0 입력시 엑시트넘버 출력 건너뜀
                        Console.WriteLine(exit_number); // 종료조건까지 양수+1씩 반복출력
                    }    
                }
            } //음수 입력하면 2x2x3 반복
            goto EXIT_PROGRAM;
        EXIT_FOR:
            Console.WriteLine("\nExit nested for...");
        EXIT_PROGRAM:
            Console.WriteLine("Exit program...");

            //p182 연습문제1,2,3,4 평가 깃헙저장 C# 끝나기 전까지
        }
    }
}
