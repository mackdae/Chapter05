using System;

namespace p171_ForEach
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 5.2.5 foreach

            //p357 배열
            //데이터형식[] 배열이름 = new 데이터형식[용량]; //new는 클래스
            //데이터형식[] 배열이름 = new 데이터형식[] {데이터,데이터,...}; //선언+초기화
            int[] scoreA = new int[2];
            scoreA[0] = 33;
            scoreA[1] = 44;
            int[] scoreB = new int[] { 33, 44 };

            //p171 배열 또는 컬렉션을 자동반복종료
            int[] arr = new int[] { 0, 1, 2, 3, 4 };
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }

            // 무한반복코드
            //for(;;) //잘 안쓰임
            //while(true) //괄호속에 불리언 타입 변수를 넣고 잘쓰임
            //유니티에서는 예외조건 없이 작동안함
        }
    }
}
