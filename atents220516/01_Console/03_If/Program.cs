using System;

namespace _03_If
{
    class Program
    {
        static void Main(string[] args)
        {
            int userLevel=0, userStrong=0, userDex=0, userInter = 0;
            string userName = "";
            float userExp = 0.0f;
            String LineChange0 = "----------------------------------------------------------------";

            /*
             * 제어문
             * 조건에 따라 다른 코드를 실행하거나 특정 횟수만큼 반복하도록 하게 하는 문구
             * 조건문 - if elseif else
             * 반복문 - for while do-while
             * 
             * 레벨이 10보다 크면 "고렙이다"를 출력 
             * 10보다 작거나 같으면 "저렙이다" 출력
             * 
             * 
             * if()조건
            {
            조건이 맞으면 실행될 코드
            }

            else
            {
            조건이 틀리면 실행될 코드
            }
             */

            Console.WriteLine(LineChange0);
            //Console.Write("플레이어의 레벨을 입력하세요.\n- ");
           // userLevel=int.Parse(Console.ReadLine());
            //Console.WriteLine(LineChange0);


            /*
            if (userLevel <= 10){
                Console.WriteLine("유저의 레벨이 낮습니다.");
                Console.WriteLine(LineChange0);
            }
            else{
                Console.WriteLine("유저의 레벨이 높습니다.");
                Console.WriteLine(LineChange0);
            }*/

            //if문 쓸때 차례대로 나오도록 잘 쓰기 ㅠㅠ 이상한 곳에서 안걸러진다...
            //레벨이 10 이하면 저렙, 11~20 이면 중렙, 21~30이면 고렙
 /*
            if (userLevel <= 10){
                Console.WriteLine("유저의 레벨이 낮습니다.");
                Console.WriteLine(LineChange0);
            }
            else if (userLevel <= 20)
            {
                Console.WriteLine("유저의 레벨이 평균적입니다.");
                Console.WriteLine(LineChange0);
            }
            else if (userLevel <=30){
                Console.WriteLine("유저의 레벨이 높습니다.");
                Console.WriteLine(LineChange0);
            }
            else
            {
                Console.WriteLine("유저의 레벨이 초과되었습니다.");
                Console.WriteLine(LineChange0);
            }

            /*
             * 반복문
             * 반복하는 문장, 특정 횟수만큼 반복하고 싶을 때 사용. 특정 조건이 참이면 계속 반복되는 문장
             * for, while
             * 
             * while(조건){
             * 조건이 만족되면 실행될 코드
             * 코드를 실행한 후 다시 조건을 확인한다.
             * 조건이 틀려질때까지 반복한다.
             * }
             */

            int count = 0;

            while (count < 10) {
                count++;

                Console.WriteLine($"*** while 문의{count}번째 Level up!!! ***");
                Console.WriteLine(LineChange0);

            }

            for (int countFor=0; countFor<11; countFor++) {
                Console.WriteLine($"~  for문의 {countFor}번째 Level 올라가는중  ~");
                Console.WriteLine(LineChange0);

            }



        }
    }
}
