using System;
using System.Collections.Generic;
using System.Text;

namespace _06_fightEx
{
    //사람
    class Human
    {
        //데이터->멤버 변수(필드)로 표현 소문자로 쓰는게 보통ㅣ 이름, 수치들
        private int healthPoint = 100;
        private int healthPointMax = 100;
        private int healthPointMin = 0;
        public string name = "이름";


        private int strength = 10;
        private int dexterity = 10;
        private int wisdom = 10;

        //프로퍼티: 특별한 함수(매서드)
        public int HealthPoint
        {
            get //HealthPoint를 읽을 때 실행되는 함수.
            {
                return healthPoint;
            }

            set // HealthPoint 프로퍼티에 값을 넣을 때 실행되는 함수. 설정되는 값은 value라는 키워드에 들어있다.
            {
                //if (HealthPoint > healthPointMax)
                //{
                //    healthPoint = healthPointMax;
                //}
                //else if (HealthPoint < healthPointMin)
                //{
                //    healthPoint = healthPointMin;
                //} 아래에 있는 코드와 내용이 같다.
                healthPoint = value;

                healthPoint = Math.Clamp(healthPoint, healthPointMin, healthPointMax);

            }
        }


        public int Strength
        {

            get => strength; //아래 주석과 같은 내용
            //get
            //{
            //    return strength;
            //}

            set
            {
                strength = value;
            }

        }

        public int Dexterity
        {
            get => dexterity;

            set
            {
                dexterity = value;
            }
        }
        //생성자(Constructor). 함수긴 함수라서 받을순잇음
        public Human(int str, int dex, int wis, string newName="이름")
        {
            strength = str;
            dexterity = dex;
            wisdom = wis;
            name = newName;
        }
        //파라미터가 다르면 다른 생성자이다
        //public Human(str name, int dex, int wis)
        //{
        //    name = name;
        //    dexterity = dex;
        //    wisdom = wis;
        //}
        public void PrintStatus()
        {
            Console.WriteLine($"┌ 스테이터스 ────────────────────────────┐");
            Console.WriteLine($"│ 체력 : {healthPoint,5}                           │");
            Console.WriteLine($"│   힘 : {strength,5}                           │");
            Console.WriteLine($"│ 민첩 : {dexterity,5}                           │");
            Console.WriteLine($"│ 지능 : {wisdom,5}                           │");
            Console.WriteLine($"└────────────────────────────────────────┘");
        }

        public int Wisdom
        {
            get => wisdom;
            set
            {
                wisdom = value;
            }
        }



        //함수 (기능)  ->멤버 함수(매서드)로 표현. 대문자로 쓰는게 보통ㅣ행동들. 걷다, 공격하다
        public void Attack(Human attackTarget)//타겟이 있어야..
        {
            //공격가능
            
            Console.WriteLine($"{name}은(는) 저기 같은편이긴한데...라며\n{attackTarget.name}을(를) 공격합니다.");
            Console.WriteLine($"{name}은(는) {strength}만큼 피해를 줍니다.\n");

            attackTarget.TakeDamage(strength);
        }
        public void Attack(Orc attackTarget)//타겟이 있어야..
        {
            //공격가능

            Console.WriteLine($"{name}은(는) ~~이야 때려버리겠다!~~라며\n{attackTarget.name}을(를) 공격합니다.");
            Console.WriteLine($"{name}은(는) {strength}만큼 피해를 줍니다.\n");

            attackTarget.TakeDamage(strength);
        }


        public void TakeDamage(int damage)
        {
            //데미지를 받을 수 있다
            Console.WriteLine($"{name}은(는) {damage}만큼 피해를 입었습니다.");
            healthPoint -= damage;
            if (HealthPoint <= healthPointMin) //비교할 때 최대한 큰 범위로 비교를 해야 나중에 실수나 수정할 일이 줄어든다.
            {
                Console.WriteLine($"{name}은 죽었습니다.");
            }
            PrintStatus();
        }


        public void Runaway()
        {
            //도망가다
        }

      
    }


}

