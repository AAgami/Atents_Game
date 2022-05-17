using System;
using System.Collections.Generic;
using System.Text;

namespace _06_fightEx
{
    //사람
    class Human
    {
        //데이터->멤버 변수(필드)로 표현 소문자로 쓰는게 보통ㅣ 이름, 수치들
        string name = "a";
        int healthPoint = 100;
        int strongth = 10;
        int dexterity = 10;
        int wisdom = 10;

        //함수 (기능)  ->멤버 함수(매서드)로 표현. 대문자로 쓰는게 보통ㅣ행동들. 걷다, 공격하다
        void Attack()
        {
            //공격가능
            Console.WriteLine("아야!");
        }
        void TakeDamage()
        {
            //데미지를 받을 수 있다
        }
        void Runaway()
        {
            //도망가다
        }
    }

    //오크
    class Orc {
        string name = "a";
        int healthPoint = 100;
        int strongth = 10;
        int dexterity = 10;
        int wisdom = 10;

        void Attack()
        {
            //공격가능
        }


    }

    class Program
    {
        void main()
        {

        }
    }
    

}
