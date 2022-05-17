using System;

namespace _02_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 이름,레벨,경험치,힘,민첩,지능 입력받고 양식에 맞게 출력
            나의이름은 xxx이고 레벨은 xx이며 경험치는 xx.xx%이다."
            힘:xx, 민첩:xx, 지능:xx

            int나 float은
            Convert.ToInt() 또는 int.Parse()를 사용해준다.
            Convert ToInt와 Parse 는 클래스다

            */
           

            String LineChange0 = " -----------------------------------------------------------------";

            Console.Write($"{LineChange0}\nㅣ 사용자님의 이름을 입력해주세요.                               ㅣ\n-  ");
            String userName0 = Console.ReadLine();

            Console.Write($"{LineChange0}\nㅣ 사용자님의 레벨을 입력해주세요.                               ㅣ\n-  ");
            int userLevel0 = Convert.ToInt32(Console.ReadLine());

            Console.Write($"{LineChange0}\nㅣ 사용자님의 경험치를 입력해주세요. 소수점 3자리까지 허용합니다.ㅣ\n-  ");
            float userExp0 = float.Parse((Console.ReadLine()));

            Console.Write($"{LineChange0}\nㅣ사용자님의 힘 스텟을 입력해주세요.                             ㅣ\n-  ");
            int userStrong0 = Convert.ToInt32(Console.ReadLine());

            Console.Write($"{LineChange0}\nㅣ사용자님의 민첩 스텟을 입력해주세요.                           ㅣ\n-  ");
            int userDex0 = Convert.ToInt32(Console.ReadLine());

            Console.Write($"{LineChange0}\nㅣ사용자님의 지능 스텟을 입력해주세요.                           ㅣ\n-  ");
            int userIntel0 = Convert.ToInt32(Console.ReadLine());

           
            Console.Write($"\n{LineChange0}\nㅣ나의 이름은 {userName0}이고, 레벨은 {userLevel0}이며, 경험치는 {userExp0:f3}%이다.ㅣ\n");
            Console.Write($"ㅣ힘:{userStrong0} 민첩:{userDex0} 지능:{userIntel0} (으)로 확인ㅣ\n{LineChange0}\n");
            Console.Write($"ㅣ즐거운 게임 플레이 되시기 바랍니다.                             ㅣ \n{LineChange0}");

        }
    }
}
