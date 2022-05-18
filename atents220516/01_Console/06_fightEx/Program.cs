using System;
using System.Collections.Generic;
using System.Text;

//접근제한자(Acess modifer 액세스 한정자)
//public 공개. 누구든지 사용가능. 다른 클래스와 데이터를 주고 받을 일이 있을때 사용. 최소한으로 만들어야 함.
//private 비공개
//protect 한정공개(자식)
//C#에서는 보통 private라고 붙임
//C++에서는 안붙이면 public
//메소드=함수
//참조찾기, 중단점 등으로 잘 봐보기


namespace _06_fightEx
{
 
    class Program
    {

        /// <summary>
        /// 이 프로그램의 실행 시작 지점
        /// </summary>
        /// <param name="args"></param>"
        /// 
        static void Main(string[] args)
        {
            int i = 10;
            Test aaa = new Test();    // Test클래스의 인스턴스를 만들어서, aaa라는 Test 타입 변수에 저장했다.

            //       //aaa.Test1_VariableFunctionContol();
            //  aaa.Test2_ClassTest();
            //  aaa.Test3_ClassInstance();
            aaa.Test4_HumanVSOrc();
        }
    }
    

}
