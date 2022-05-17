using System;

namespace _04_levelup
{



    class Program
    {

        //┌------------------------------------┐
        //ㅣ                                    ㅣ
        //└------------------------------------┘
        //{a,5} {a:D5} 등 문자열 정렬 예쁘게 하기 
        //함수:특정한 기능을 수행하기 위해 코드를 모아놓은 것
        
        /*
         * 함수의 구성요소 
         * 이름(ex)PrintStatus
         * 파라메터(이름 뒤에 있는 ()사이 있는 변수들)
         * 함수 바디( {} 사이)
         * 함수 리턴타입(void, int 등)
         * 4개이상 넘지않도록 하기.
         * void A(int,int,int)
         * void A(int,int,float)
         * void A(int, int)
         * 리턴타입 함수이름(파라메터), 다른 함수와의 구분에 사용됨
         */
        static void PrintStatus(int str, int dex, int intel)
        {
            Console.WriteLine($"┌-----------------------┐");
            Console.WriteLine($"ㅣ  플레이어님의 스탯   ㅣ"); 
            Console.WriteLine($"ㅣ     힘:{str,5}         ㅣ");
            Console.WriteLine($"ㅣ   민첩:{dex,5}         ㅣ");
            Console.WriteLine($"ㅣ   지성:{intel,5}         ㅣ");
            Console.WriteLine($"└-----------------------┘");


            

        }

        static void Main(string[] args)
        {
            //입력받은 횟수만큼 레벨업을 하는 코드 만들기
            //레벨업 할때마다 힘,민,지 1씩 증가
            //레벨업 전/후의 스텟을 출력


            int userWantLevel = 0;
            int userStrong = 0;
            int userDex = 0;
            int userIntel = 0;
            String LineChange0 = "------------------------------------------------------------------";
            String LineChange1 = " ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";


            Console.WriteLine(LineChange0);
            Console.WriteLine("원하시는 레벨업 횟수를 적어주세요.");
            userWantLevel = int.Parse(Console.ReadLine());
            Console.WriteLine(LineChange0);
            Console.WriteLine($"현재 플레이어님의 스탯은\n힘{userStrong,5} 민첩{userDex,5} 지성{userIntel,5} 입니다.\n\n");
            Console.WriteLine(LineChange0);


            for (int i = 0; i< userWantLevel; i++)
            {
                Console.WriteLine($"\n{LineChange1}\n");
                int j = 3;
                Console.WriteLine($"--------레벨업합니다. 민첩 {userStrong+j:D5}, 민첩{userDex + j:D5}, 지성{userIntel+j:D5}이 상승합니다.--------");
                userStrong += 3;
                userDex += 3;
                userIntel += 3;

            }
            Console.WriteLine($"\n{LineChange1}\n\n");
            Console.WriteLine("                      레벨업이 완료되었습니다.\n                          축하드립니다!\n");

            Console.WriteLine($"                    증가한 플레이어님의 스탯은\n                     힘{userStrong:D5} 민첩{userDex:D5} 지성{userIntel:D5} 입니다");
            Console.WriteLine($"\n\n{LineChange1}\n");

            PrintStatus(userStrong, userDex, userIntel);

          
        }
    }
}
