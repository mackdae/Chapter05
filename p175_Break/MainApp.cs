using System;

namespace p175_Break
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 5.3 점프문
            //break //해당 스코프(?) 중단
            //continue //안쓸거임
            //goto //안쓸거임
            //return
            //throw //안배울거임

            // 5.3.1 break 
            // 탈출, 중단
            int i = 0;
            while(i>=0)
            {
                if (i >= 0)
                {
                    break;
                }
                Console.WriteLine(i++);
            }

            // p175
            while(true)
            {
                Console.Write("계속할까요?(예/아니오) : ");
                string answer = Console.ReadLine();

                if (answer == "아니오")
                {
                    break;
                }
            }
        }
    }
}
