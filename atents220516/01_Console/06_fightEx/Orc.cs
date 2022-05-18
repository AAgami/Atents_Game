using System;
using System.Collections.Generic;
using System.Text;

namespace _06_fightEx
{
    class Orc
    {

        //데이터
        //HP
        //그외 스텟 맘대로

        //기능
        //Attack
        //TakeDamage
        //PrintStatus

        private int healthPoint = 100;
        private int healthPointMax = 100;
        private int strength = 20;
        private int dexterity = 5;
        public string name = "새이름";
        public int HealthPoint
        {
            get
            {
                return healthPoint;
            }
            set
            {
                healthPoint = value;
                healthPoint = Math.Clamp(healthPoint, 0, healthPointMax);
            }
        }

        public int Strength
        {
            get
            {
                return strength;
            }
        }

        
        public Orc(int str, int dex,int num ,string oname= "이름")
        {
            strength = str;
            dexterity = dex;
            name = oname;

        }

        public void Attack(Human attackTarget)
        {
            Console.WriteLine($"오크 {name}은(는) {attackTarget.name}를 공격합니다.");
            Console.WriteLine($"오크 {name}은(는) {strength} 만큼 피해를 줍니다");
            attackTarget.TakeDamage((int)(strength * 1.2f));  // 20% 만큼 더 데미지를 주고 싶다. 다만 소수점 아래는 버려진다.

        }

        public void TakeDamage(int damage)
        {
            Console.WriteLine($"오크 {name}은(는) {damage}만큼 피해를 입습니다.");
            healthPoint -= damage;
            if (HealthPoint <= 0)     // 비교를 할때는 최대한 큰 범위로 비교를 해야한다.(나중에 실수나 수정할 일이 대체로 줄어든다)
            {
                Console.WriteLine($"오크 {name}은(는) 죽었다.");
            }
            PrintStatus();

        }

        public void PrintStatus()
        {
            Console.WriteLine($"┌orc {name,5} 스테이터스 ───────────────────┐");
            Console.WriteLine($"│   HP : {healthPoint,5}                           │");
            Console.WriteLine($"│   힘 : {strength,5}                           │");
            Console.WriteLine($"│ 민첩 : {dexterity,5}                           │");
            Console.WriteLine($"└────────────────────────────────────────┘");
        }

    }
}
