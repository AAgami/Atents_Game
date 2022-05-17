using System;

namespace _05_fight
{
    class Human
    {
        public string userName = "";
        public string userGender = "";
        public int userHP = 10;
        public int userStrong = 4;
        public int userDex = 3;
        public int userIntel = 3;

        public void userAttack() //때리기
        {
            Console.WriteLine($"{userName}은(는) 나무막대기를 휘둘렀다!");
        }

        public void userRun() //도망
        {
            Console.WriteLine($"{userName}은(는) 발빠르게 도망쳤다!");
        }
        public void userDamage() //아프다
        {
            Console.WriteLine($"{userName}은(는) 다쳤습니다. HP가 1 하락합니다. 현재 체력:{userHP-1}");
        }


    }

    class Orc
    {
        public int orcStrong = 3;
        public int orcHP = 5;
        public int orcDex = 2;
        public int orcIntel = 1;

        public void orcAttack ()
        {
           Console.WriteLine("오크는 땅구르기를 사용했다!");

        }
        public void orcDamage() //아프다
        {
            Console.WriteLine($"오크는 다쳤습니다. HP가 1 하락합니다. 오크의 현재 체력:{orcHP}");
        }

        public void orcEar() //귀판다
        {
            Console.WriteLine("오크는 당신을 만만히 보며 귀를 후빕니다");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            String LineChange0 = "------------------------------------------------------------------";
            String LineChange1 = "■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";
            int attackOption = 1;
            Random random = new Random();

            int attackRandom = 0;




            Human user0 = new Human();
            Orc orc0 = new Orc();


            Console.WriteLine("사용할 플레이어 이름을 입력하세요.");
            user0.userName = Console.ReadLine();
            Console.WriteLine("플레이어의 성별을 입력하세요(남,여)");
            user0.userGender = Console.ReadLine();
            Console.WriteLine(LineChange1);
            Console.WriteLine($"플레이어의의 이름은 {user0.userName}, 성별 {user0.userGender}\n기본 체력은 {user0.userHP}, 힘 {user0.userStrong}, 민첩{user0.userDex}, 지성{user0.userIntel} 입니다.");

            Console.WriteLine(LineChange1);
            Console.WriteLine($"\n{user0.userName} 플레이어는 오크를 만났습니다!");
            Console.WriteLine("공격하나요? (1->Yes 2->No)\n");
            attackOption = int.Parse(Console.ReadLine());
            Console.WriteLine(LineChange1);

            if (attackOption == 1) //공격을 눌렀을때
            {
                if (user0.userStrong >= orc0.orcStrong)  //유저 힘이 오크힘과 같거나 쎄다면
                {
                    user0.userAttack();
                    attackRandom = random.Next(0, 2); //랜덤 돌린다
                    if (attackRandom > 0)//공격 성공
                    {
                        orc0.orcHP -= 1;
                        Console.WriteLine("오크 공격에 성공했습니다.");
                        orc0.orcDamage();
                    }
                    else { //실패
                        orc0.orcEar();
                    }

                }

                else if (user0.userStrong < orc0.orcStrong)// 유저힘보다 오크힘이 쎄니까 실패
                {
                    orc0.orcEar();
                }
            }
            
        
    
                
                
            else if (attackOption == 2) //도망간다
            {
                user0.userRun();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");

            }

            Console.WriteLine(LineChange1);







        }
    }
}
