using System;
using System.Collections.Generic;
using System.Text;

//접근제한자(Acess modifer 액세스 한정자)
//public 공개. 누구든지 사용가능. 다른 클래스와 데이터를 주고 받을 일이 있을때 사용. 최소한으로 만들어야 함.
//private 비공개
//protect 한정공개(자식)
//C#에서는 보통 private라고 붙임
//C++에서는 안붙이면 public


namespace _06_fightEx
{
    //사람
    class Human
    {
        //데이터->멤버 변수(필드)로 표현 소문자로 쓰는게 보통ㅣ 이름, 수치들
        private string name = "a";
        private int healthPoint = 100;
        private int strongth = 10;
        private int dexterity = 10;
        private int wisdom = 10;

        //함수 (기능)  ->멤버 함수(매서드)로 표현. 대문자로 쓰는게 보통ㅣ행동들. 걷다, 공격하다
        public void Attack()
        {
            //공격가능
            Console.WriteLine("이야 때려버리겠다!");
        }
        public void TakeDamage()
        {
            //데미지를 받을 수 있다
        }
       public void Runaway()
        {
            //도망가다
        }
    }

    //오크
    class Orc 
    {
        private int healthPoint = 100;
        private int strongth = 10;
        private int dexterity = 10;
        private int wisdom = 10;

        public void Attack()
        {
            //공격가능
           
        }


    }

    class Program
    {
        void main(){

        }
    }
    

}
