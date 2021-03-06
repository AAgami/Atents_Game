using System;

namespace _01_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C#");

            /*
            변수-> 변하는 숫자
            변수의 종류를 data type이라고 한다.
            ------------------------------------------------------------
            int/float/bool/string
            ------------------------------------------------------------
            int 정수 -> 소수점이 없는 숫자(0,1,5,-7) 자연수
            float 실수 ->소수점이 있는 숫자(0.0,3.14,-55.9)등
            bool->true 혹은 false (0,1)
            string 문자열 -> " " 안에 있는 문자를 저장하는 변수 "개구리" 등
            ------------------------------------------------------------
            변수의 이름은 알파벳으로 시작한다. _와 숫자를 붙일 수 있다
            변수의 이름은 단어의 의미만으로도 알아 볼수 있도록 작성하는 것을 권장한다.
            ------------------------------------------------------------
            변수 작성법
            (변수의 종류) (변수의 이름)= (초기값);
            변수 만드는 것을 선언이라고 한다.
             */
            int strength = 0;
            int dex = 20;
            int intelligence = 10;

            float exp0 = 35.0f;
            /*
            float exp=35; C#이 int를 자동으로 float 형변환 한경우
            float exp=35f; 이것도 맞다.
             */
            bool a = true;
            bool b = false;
            int level = 5;
            float exp = 95.254f;
            string name = "인간";

            //나는 인간이고 레벨은 5고 경험치는 95퍼이다.
            //인간 다음 레벨 다음 경험치
            //Console.WriteLine 할 때 출력되는 말은 " ", 변수들은 + + 으로 적어준다. 더하기 식으로 붙여준다해서 ++라는데 귀엽다.
            Console.WriteLine("나는 "+name+ "이고, 레벨은 "+level+"이고, 경험치는 "+exp+"%이다.") ; 
            //되기는 하지만 안좋은 방법. 메모리가 낭비된다고 한다.

            Console.WriteLine("나는 {0}이고 레벨은 {1}이고 경험치는 {2}%이다.", name, level, exp);
            //무난한 방법

            Console.WriteLine($"나는 {name}이고 레벨은 {level}이고 경험치는 {exp:f2}% 이다.");
            //좋은방법!

            //exp:f2 라는 식으로 소수점 자리수를 정해서 표현가능하다. 이건 소수점 2개까지 나온다는 듯

            /*스코프(scope) = Range 
            프로그래밍에서 스코프란 변수가 살아있는 범위를 뜻한다.
            중괄호가 닫히고 열리고는 한 쌍으로 되어있어야 하고, 변수는 속해있는 중괄호가 끝나면 사라진다..

            int i=0;
            {
                int j=20;
            }
            j=30; ->j의 스코프 밖이라 접근이 불가능하다.

            "개굴개굴 개구리 노래를 한다"
            "아들 손자 며느리 다 모여서" 이렇게 출력을 하고싶다.
             
             */
            string linechange0 = "---------------------";
            string linechange1 = "l";
            string frogsong0 = "개굴개굴 개구리 노래를 한다~\n아들 손자 며느리 다 모여서~";

            Console.WriteLine(linechange0);
            Console.WriteLine(frogsong0);
            Console.WriteLine(linechange0);

            Console.Write("오늘 날짜를 적어주세요! (00/00): ");
            string inputTest0 = Console.ReadLine();

            Console.WriteLine(linechange0);
            Console.Write(linechange1);
            Console.Write($"오늘은 {inputTest0}입니다.");
            Console.WriteLine(linechange1);
            Console.WriteLine(linechange0);

        }
    }
}
