///*BlackJack;*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsClass
{
    internal class WhatIsClass
    {
        public class Description
        {
            //private string stringField = "이것은 어디에서 접근이 가능할까?";//필드
            //public Description() 
            //{
            //    Console.WriteLine("이것이 바로 숨어 있는 생성자???");
            //}
            //public Description(int number)
            //{
            //    Console.WriteLine("number를 받는 생성자 {0} 이것이 바로 숨어 있는 생성자???", number);
            //}
        }
        private class stringField
        {
            public static void Main()
            {


                //Description description =new Description(123);
                /**
                 * C#의 모든 코드에 반드시 들어가는 클래스(Class) 알아보자.
                 * 
                 * 클래스 소개하기
                 * 클래스는 지금까지 작성한 모든 예제에서 기본이 되는 C#의 핵심 코드이다. 
                 * 
                 * public class [클래스 이름] 
                 * {
                 *      *내용
                 * }
                 * 
                 * 같은 코드 블록을 사용하여 정의할 수 있다. 클래스를 정의하는 전반적인 내용과 클래스 내부 또는 
                 * 외부에 올 수 있는 구성 요소는 다음 장에서 살펴볼 것.
                 * 클래스의 구성 요소는 많지만, 그 중 속성과 메서드를 가장 많이 사용한다.
                 * 속성은 데이터를 다루고, 메서드는 로직을 다룬다.
                 * 
                 * -클래스
                 *  -속성: 데이터
                 *  -메서드: 로직
                 * 
                 * 클래스는 그 의미에 따라, 이미 닷네 프레임워크에서 만들어 놓은 내장 형식(built-in type)과 사용자가
                 * 직접 클래스 구조를 만드는 사용자 정의 형식(User definde type)으로 구분할 수 있다. 예를 들어
                 * Console, Stirng, Math 등 클래스는 내장 형식이다. 그리고 class 키워드로 Product, Note,
                 * User, Group 처럼 새로운 형식(기존에 제공되지 않는)을 정의할 수 있는데, 이를 사용자 데이터 형식
                 * 이라고 한다.
                 * 
                 * 클래스 만들기
                 * 클래스를 정의하면 다음과 같다.
                 *  - 클래스는 개체(instance)를 생성하는 틀(템플릿)이다.
                 *  - 클래스는 무엇인가를 만들어 내는 설계도이다.
                 *  
                 * 클래스는 C# 프로그래밍의 기본 단위로 새로운 개체(실체)를 생성하는 설계도(청사진) 역할을 한다.
                 * 예를 들어 자동차라는 개체(Object)를 만들려면 자동차 설계도가 필요하다. 이와 마찬가지로
                 * 프로그램밍에서도 설계도가 필요한데, 이 역할을 하는 것이 클래스(class)이다. 즉, 클래스는
                 * 개체를 생성하는 틀(템플릿)이며, 더 간단히 말하자면 "무엇인가를 만들어 내는 설계도"이다.
                 * 
                 * 클래스 선언하기
                 * - 클래스 이름은 반드시 대문자로 시작한다.//C#에서 지켜야할것
                 * 
                 * public class [클래스 이름]
                 * {
                 *          //클래스 내용을 구현
                 *          -속성 -> 변수
                 *          -메서드 -> 함수
                 * }
                 */

                //ClassNote classNote = new ClassNote();



                /**
                 * 클래스를 여러 개 사용할 때는 public 키워드를 써야 한다. public 키워드가 붙은 클래스는
                 * 클래스 외부에서 해당 클래스를 바로 호출해서 사용할 수 있도록 공개되었다는 의미이다.
                 * 반대 의미는 private 키워드를 사용한다.
                 * 
                 * static과 정적 메서드
                 * C#에서는 static을 정적으로 표현한다. 의미가 같은 다른 말로 표현하면 공유(Shared)이다.
                 * static이 붙는 클래스의 모든 멤버는 해당 클래스 내에서 누구나 공유해서 접근할 수 있다.
                 * 메서드에 static이 붙는 메서드를 정적 메서드라고 하는데, 이를 공유 메서드(Shared method)라고도
                 * 한다.
                 * 
                 * 정적 메서드와 인스턴스 메서드
                 * 닷네의 많은 API처럼 우리가 새롭게 만드는 클래스는 메서드를 포함한 각 멤버에 static 키워드
                 * 유무에 따라 정적 또는 인스턴스 멤버가 될 수 있다.
                 */
                //ClassNote classNote = new ClassNote();
                //classNote.InstanceMethod();
                //메모리 공간 할당해서 거기에 InstatnceMethoh()를 넣은거


                //변수는 주소와 값을 담고있지.
                //값형식은 값을 담고 있다.
                //참조형식은 값을 담은 개체가 어디에있고 그것이 있는자리에서 당겨와서 연산이 무겁지 않다. 대신 값형식에 직접적으로 변경을 할수 없다?.

                /**
                 * 값 형식과 참조 형식
                 * 클래스나 구조체 같은 데이터 형식을 말할 때 값 형식(Value type)과 참조 형식(Reference type)으로
                 * 구분 짓기도 한다.
                 * 
                 * 값 형식
                 * 개체에 값 자체를 담고 있는 구조이다. 지금까지 다룬 int, double 등은 내부적으로 구조체로 된
                 * 전형적인 값 형식의 데이터 구조이다.
                 * 
                 * 참조 형식
                 * 개체가 값을 담고 있는 또 다른 개체를 포인터로 바라보는 구조이다. 여러 값이 동일한 개체를
                 * 가리킬 수 있다.
                 */

                //int numberasdfasdfasdf = 10;

                //Console.WriteLine("number에 저장된 값은 {0}이고, 주소는 {1} 입니다. ",numberasdfasdfasdf);
                //값 보는법 주소 보는법 한번더 찾아보기

                /**
                 * 박싱과 언박싱
                 * 프로그래밍을 하다 보면 데이터의 형식 변환이 필요하다. 이러한 변환 과정에서 값 형식의 데이터를
                 * 참조 형식의 데이터로 변경하는 것을 박싱(Boxing)이라고 한다. 반대로 참조 형식의 데이터를
                 * 값 형식의 데이터로 변경하는 것을 언박싱(Unboxing)이라고 한다.
                 * 
                 * 박싱
                 * 박싱이란 말 그대로 박스에 포장을 하는 것이다.C#에서 박싱은 값 형식의 데이터를 참조 형식의
                 * 데이터로 변환하는 작업을 의미한다. 예를 들어 다음 코드처럼 정수 형식의 데이터를 오브젝트 형식의
                 * 데이터에 담는 형태를 박싱이라고 한다.
                 * 
                 * int number = 1234;
                 * object objectValue = number;
                 *
                 *좀 더 어렵게 말하면 스택 메모리 영역에 저장된 값 형식의 데이터를 힙 메모리 영역에 저장하는
                 *단계를 거치기 때문에 시간과 공간이 소비되는 비용이 발생한다.
                 *
                 *언박싱
                 *다음 코드는 object 변수에 저장된 1234를 실제 정수 형식의 데이터로 변환하는 모습을 보여 준다.
                 *참조 형식의 데이터를 값 형식의 데이터로 변환하는 과정이 포장을 푸는 것과 비슷해 보여서 언박싱
                 *이라고 한다. 언박싱을 캐스트(Cast)또는 캐스팅(Casting)으로 표현한다.
                 *
                 *object unboxingObjectValue = 1234;
                 *int numbers = (int)unboxingObjectValue;
                 *
                 *object 형 변수에 들어 있는 데이터 중에서 숫자 형식의 데이터는 바로 int 형 변수에 대입할 수
                 *없다. object 형 변수 값을 int 형 변수에 대입하려면 형식 변환을 해야 한다. 형식 변환은
                 *캐스팅이나 Convert 클래스 같은 변환 API를 사용하면 된다. 즉, (int) 캐스팅 또는 Convert.ToInt32()
                 *같은 형식 변환 관련 기능을 명시적으로 지정해 주어야 한다.
                 *
                 *(나의 생각 : 담은 자료를 다시 밖으로 꺼내는데 그것이 어떤형태로 나올지를 알아야하니 캐스팅을 명시적으로 해줘야하는것 같음.)
                 *
                 *object unboxingObjectValue = 1234;      //오브젝트에 1234 숫자를 담음
                 *char charValue = 'a';                   //캐릭터 a 는 아스키 코드 97번의 값을 가지고 있기에 출력시 int형 97인지 아스키코드값 97인지를 모름
                 *int intValue = 97;                      //int형과 캐릭터 형a를  비교를 위한 인트 97 선언하고
                 *char charValue2;                        //캐릭터 값의 아무거나 담을 함수를 선언해주고.
                 *unboxingObjectValue = charValue;        //오브젝트 1234 값에 캐릭터형a를 담으면 97이 나오지만
                 *charValue2 = (char)unboxingObjectValue; //빈 캐릭터형 함수에 오브젝트 함수를 캐릭터형으로 캐스팅해주면 빈 캐릭터형은 캐릭터형의 오브젝트 함수로 받아서 a를 출력함.
                 *Console.WriteLine("{0} ",charValue2);
                 *
                 *
                 */


                //박싱예제
                //int number = 1234;
                //object objectValue = number;

                //Console.WriteLine("{0} ", objectValue);
                //object는 C#에서는 모든 자료형의 모체임.

                //언박싱예제
                //object unboxingObjectValue = 1234;      //오브젝트에 1234 숫자를 담음
                //char charValue = 'a';                   //캐릭터 a 는 아스키 코드 97번의 값을 가지고 있기에 출력시 int형 97인지 아스키코드값 97인지를 모름
                //int intValue = 97;                      //int형과 캐릭터 형a를  비교를 위한 인트 97 선언하고
                //char charValue2;                        //캐릭터 값의 아무거나 담을 함수를 선언해주고.
                //unboxingObjectValue = charValue;        //오브젝트 1234 값에 캐릭터형a를 담으면 97이 나오지만
                //charValue2 = (char)unboxingObjectValue; //빈 캐릭터형 함수에 오브젝트 함수를 캐릭터형으로 캐스팅해주면 빈 캐릭터형은 캐릭터형의 오브젝트 함수로 받아서 a를 출력함.
                //Console.WriteLine("{0} ",charValue2);



                /**
                 * 클래스 시그니쳐
                 * 클래스는 다음 시그니처를 가진다.
                 * 
                 * public class Car {}
                 * 
                 * public 액세스 한정자를 사용하면 기본값인 internal을 갖는데 internal은 해당 프로그램 내에서
                 * 언제든지 접근 가능하다. 하지만 학습 단계에서는 클래스에 public만 사용해도 괜찮다. 그리고 class
                 * 키워드 다음에 클래스 이름이 오는데, 클래스 이름은 대문자로 시작하는 명사를 사용한다.
                 * 클래스 본문 또는 몸통(Class body) 을 표현하는 중괄호 안에는 지금까지 배운 메서드와 앞으로 다룰
                 * 필드, 속성, 생성자, 소멸자 등이 올 수 있는데, 이 모두를 가리켜 클래스 멤버라고 한다.
                 * 
                 *   //internal은 복잡해서 public만 써도 괜춚
                 *   
                 * 클래스 이름 짓기
                 * 클래스 이름은 의미 있는 이름을 사용하면 좋다. 이름은 명사를 사용하며, 첫 글자는 꼭 대문자여야 한다.
                 * 또 클래스 이름을 지을때는 축약형이나 특정 접두ㅏ, 언더스코어(_) 같은 특수문자는 쓰지 않는다.
                 * 
                 *  - 클래스 이름은 누구나 알기 쉽게
                 *  - 간단하고 명확하게 한다.
                 *
                 * 클래스의 주요구성 요소
                 * 클래스의 시작과 끝, 즉 클래스 블록 내에는 다음 용어(개념)들이 포험될 수 있다. 일반적으로 클래스 구성 요소를
                 * 가리킬 때 클래스 멤버라는 용어와 혼용해서 사용한다.
                 * 
                 *  - 필드(Field): 클래스의 부품 역할을 한다. 클래스 내에 선언된 변수나 데이터를 담는 그릇으로,
                 *                개체 상태를 저장한다.
                 *  - 메서드(Method): 개체 동작이나 기능을 정의한다.
                 *  - 생성자(Constructor): 개체 필드를 초기화한다. 즉, 개체를 생성할 때 미리 수행해야 할 기능을
                 *                        정의 한다.
                 *  - 소멸자(Destructor): 개체를 모두 사용한 후 메모리에서 소멸될 때 실행한다.
                 *  - 속성(Property): 개체의 색상, 크기, 형태 등을 정의한다.
                 *  
                 * 액세스 한정자
                 * 클래스를 생성할 때 public, private, internal, abstract, sealed 같은 키워드를 붙일 수 있다.
                 * 이를 액세스 한정자라고 한다. 액세스 한정자는 클래스에 접근할 수 있는 범위를 결정하는 데 도움이
                 * 된다.특별히 지정하지 않는 한 기본적으로 public 액세스 한정자를 사용하면 된다.
                 *///클래스 시그니쳐

                /*                             


                //Parent parent = new Parent();
                //parent.Print();

                //Child child = new Child();
                //child.PrintChild();
                //child.Print();
                */  //모체 자식 예제

                /*
                //Wolf monsterWolf = new Wolf();
                //monsterWolf.MoveAndAttack();

                //Slime monsterSlime = new Slime();
                //monsterSlime.MoveAndAttack();

                //BigBear bigMonster_BigBear = new BigBear();
                //bigMonster_BigBear.BigMoveAndAttack();

                //KingSlime kingslime = new KingSlime();
                //kingslime.BigMoveAndAttack();


                //SkelletonMagicion skelletonMagicion = new SkelletonMagicion();
                //skelletonMagicion.BigMoveAndAttack();
                */


                Kight kight = new Kight();      //플레이어 기사 가져오고                                

                BigMonster bigMonS = new BigMonster();          //몹 풀러오는것

                PlayerStatus playerS = new PlayerStatus();      //플레이어 스탯

                BigMonsterStatus bigMosS = new BigMonsterStatus();      //몬스터 스탯

                Random ran = new Random();

                BigBear bear = new BigBear();

                int mobRan = ran.Next(0, 2 + 1);           //몹이 랜덤하게 나오게 난수

                int[] monArr = new int[3] { 1, 2, 3 };             //생성자int형 대조.       

                int[] playerStatus = new int[3];              //플레이어는 한명
                playerStatus[0] = playerS.PlayerHpValue();
                playerStatus[1] = playerS.PlayerDamageValue();
                playerStatus[2] = playerS.PlayerDefenceValue();


                int[] bigMosStatus = new int[3];      //몬스터들의 값을 배열에 담아서 가져가기
                bigMosStatus[0] = bigMosS.BigHpValue();
                bigMosStatus[1] = bigMosS.BigDamageValue();
                bigMosStatus[2] = bigMosS.BigDefenceValue();


                string mobname = string.Empty;
                string playname = string.Empty;

                int hpValue = 0;

                //전투를 시작 1 ,2 도망ㄱ
                //한번씩 때리기
                int userInput = 0;
                Console.WriteLine("{0}이(가) 등장했다.\n{1}\n\n",
                        bear.BigMonsterName(), bear.BigSoundValue());

                Console.WriteLine("전투 시작 1\n도망을 치다 2 : ");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == 1)
                {
                    Console.WriteLine("――――――――――――");

                    Console.WriteLine("{0}이(가) 등장했다.\n{1}",
                        bear.BigMonsterName(), bear.BigSoundValue());

                    Console.WriteLine("\n체력 {0}\n공격력{1}\n방어력{2}",
                        bear.BigHpValue(), bear.BigDamageValue(), bear.BigDefenceValue());

                    Console.WriteLine("");
                    Console.WriteLine("――――――――――――");

                    Console.WriteLine("플레이어 {0}의 상태", kight.PlayerName());

                    Console.WriteLine("\n체력 {0}\n공격력{1}\n방어력{2}",
                        kight.PlayerHpValue(), kight.PlayerDamageValue(), kight.PlayerDefenceValue());

                    Console.WriteLine("");
                    Console.WriteLine("――――――――――――");


                    int userInput2 = 0;
                    Console.WriteLine("1.공격하기 \n2.막기(방어가 두배) : ");
                    userInput2 = Convert.ToInt32(Console.ReadLine());

                    if (userInput2 == 1)
                    {
                        if (0 < playerStatus[0] || 0 < bigMosStatus[0])
                        {
                            Console.WriteLine("플레이어 {0} 이(가) 공격을 했습니다!\n\n", kight.PlayerName());
                            Console.WriteLine("{0}의 데미지를 주었습니다.", kight.PlayerDamageValue());

                            Console.WriteLine("{0}이 공격을 맞았습니다.\n{1}", bear.BigMonsterName(), bear.BigSoundValue());

                            Console.WriteLine("{0}이(가) 반격을 했습니다.\n", bear.BigMonsterName());
                            Console.WriteLine("플레이어는 {0}의 데미지를 받았습니다.", bear.BigDamageValue());

                            bigMosStatus[0] -= playerStatus[1] - bigMosStatus[2];
                            playerStatus[0] -= bigMosStatus[1] - playerStatus[2];

                        }
                    }

                    else if(userInput2 ==2)
                    {
                        Console.WriteLine("플레이어는 방어를 했다!");

                    }



                }
                else
                {
                    Console.WriteLine("무사히 도망쳤다!");
                }

                switch (monArr[mobRan])
                {
                    case 0:
                        bigMonS = new BigBear();
                        break;
                    case 1:
                        bigMonS = new KingSlime();
                        break;
                    case 2:
                        bigMonS = new SkelletonMagicion();
                        break;

                }

            }  ///////Main()
            public void WhatIsConstructor()
            {
                /**
                 * C#에서 생성자는 클래스에서 맨 먼저 호출되는 메서드로, 클래스 기본값 등을 설정한다.
                 * 자동차 클래스를 예로 들면, 자동차의 시동 걸기에 해당하는 것이 바로 생성자이다.
                 * 
                 * 생성자
                 * 클래스의 구성 요소 중에는 생성자(Constructor) 라는 메서드가 숨어 있다. 단어 그대로 개체를
                 * 생성하면서 무엇인가를 하고자 할때 사용되는 메서드이다. 일반적으로 생성자는 개체를 초기화
                 * (주로 클래스 내 필드를 초기화)하는 데 사용된다. 생성자는 생성자 메서드라고도 한다. 이러한
                 * 생성자는 독특한 규칙이 있는데, 바로 생성자 이름이 클래스 이름과 동일하다는 것이다. 클래스 내에서
                 * 클래스 이름과 동일한 이름을 갖는 메서드는 모두 생성자이다.
                 * 
                 * 생성자는 매게변수가 없는 기본(Default) 생성자가 있고, 매게변수를 원하는 만큼 정의해서 사용할
                 * 수도 있다. 이때 리턴값은 가지지 않는다. 또 생성자도 siatic 생성자(정적 생성자)와 public 생성자
                 * (인스턴스 생성자)로 구분된다. 일반적으로 public 키워드를 사용하는 인스턴스 생성자를 많이
                 * 사용한다.
                      //몬스터를 이용한 예제
            }   //WhatIsConstructor()생성자

            public void WhatIsDestructor() 
            {
                /**
                 * 소멸자는 생성자와 반대 개념으로 클래스에서 인스턴스화된 개체가 메모리상에서 없어질 때 실행되는
                 * 메서드이다. 자동차 클래스를 예를 들면 자동차 주차 대행, 시동 끄기 등으로 볼 수 있다.
                 * 
                 * 종료자
                 * 종료자(Finalizer)라고도 하는 소멸자(Destructor)는 닷넷의
                 * 가비지 수집기(Garbage Collector, GC)에서 클래스의 인스턴스를 사용한 후 최종 정리할 때
                 * 실행되는 클래스에서 가장 늦게 호출하는 메서드이다.
                 * C#에서는 닷네 가비지 수집기(GC)가 개체를 소멸할 때 메모리를 해제하는 등 역할을 대신해 주기
                 * 때문에 이 책에서는 소멸자에 직접 접근할 일이 없다.
                 * 
                 * - 자동차 시동을 끄는 것에 비유할 수 있으며, 운전수가 주차하고 시동을 끄는 것이 아니라
                 *   주차 요원(GC)이 대신 주차하고 시동을 끄는 것과 의미가 비슷하다.
                 * - 소멸자는 클래스 이름과 동일한 메서드로 앞에 물결 기호인 ~(틸드)를 붙여 만든다.
                 * - 소멸자도 특별한 형태의 메서드이다. 소멸자 또한 소멸자 메서드라고도 한다. 생성자와 달리
                 *   매개변수를 받을 수 없다.
                 * - 소멸자는 오버로딩을 지원하지 않으며 직접 호출할 수도 없다.
                 * 
                 */

            }   //WhatIsDestructor()

            public void WhatIsINheritnace()
            {
                /**
                 * 클래스 간에는 부모와 자식 관계를 설정할 수 있다. 이러한 내용을 
                 * 개체 관계 프로그래밍(Object relationship programming)이라고도 한다. 상속은 부모 클래스에
                 * 정의된 기능을 다시 사용하거나 확장 또는 수정하여 자식 클래스로 만드는 것이다. 특정 클래스에서
                 * 만든 기능을 다른 클래스에 상속으로 물려주면 장점이 많이 있다.
                 * 
                 * 클래스 상속하기
                 * 개체 지향 프로그래밍의 장점 중 하나는 이미 만든 클래스를 재사용하는 것이다. 이 재사용의 핵심
                 * 개념이 바로 상속이다. 부모 재산을 자식에게 상속하듯이 부모 클래스(기본 클래스)의 모든 멤버를
                 * 자식 클래스(파생 클래스)가 재사용 하도록 허가하는 기능이다. 여러 클래스 간의 관계를 설정할 때
                 * 수평 관계가 아닌 부모와 자식 간 관계처럼 계층적인 관계를 표현할 때 사용하는 개념을 상속이라고
                 * 한다. 클래스 상속은 단일 상속(Single inheritance)과 다중 상속(Multiple inheritance)으로
                 * 구분할 수 있다. 단, C#의 클래스 상속은 단일 상속만 지원한다. 다중 상속은 나중에 배울
                 * 인터페이스로 지원받을 수 있다.
                 * 
                 * 클래스 상속 구문
                 * C#에서는 다음과 같이 클래스 이름 뒤에 콜론(:) 기호와 부모가 되는 클래스 이름을 붙인다.
                 * 
                 * public class [기본 클래스 이름]
                 * {
                 *      //기본 클래스 멤버를 정의
                 * }
                 * 
                 * public class [파생 클래스 이름]:[기본 클래스 이름]
                 * {
                 *      //기본 클래스 멤버를 포함한 자식 클래스의 멤버를 정의
                 * }
                 * 
                 * 
                 * - System.Object 클래스: System.Object 클래스는 모든 클래스의 부모 클래스이다. 닷넷에서
                 *   가장 높은 계층에 속하는 시조(조상) 클래스라고 할 수 있다. 새롭게 만드는 C#의 모든 클래스는
                 *   자동으로 Object 클래스에서 상속받기 때문에 Object 클래스를 상속하는 코드는 생략 가능하다.
                 * 
                 * - 기본(Base) 클래스: 다른 클래스의 부모 클래스가 되는 클래스로 기본 클래스라고 한다.
                 *   기본 클래스를 다른 말로 Base 클래스, Super 클래스, 부모 클래스로 표현한다.
                 *   
                 * - 파생(Derived) 클래스: 다른 클래스의 자식 클래스가 되는 클래스를 파생 클래스라고 한다.
                 *   파생 클래스는 다른 클래스에서 멤버를 물려받은 것으로, Dereved 클래스,Sub 클래스,
                 *   자식 클래스로 표현한다.
                 *   
                 * 부모 클래스와 자식 클래스
                 * 프로그래밍에서 상속을 표현할 때 상속을 주는 클래스를 부모 클래스라고 하며, 상속을 받는 클래스를
                 * 자식 클래스라고 한다. 콜론(:) 기호로 상속 관계를 지정하면 부모 클래스의 public 멤버들을
                 * 자식 클래스에서 그대로 물려받아 사용할 수 있다. public, protected 로 선언된 멤버들도 자식
                 * 클래스에서 사용 가능하다. (Private 로 선언된 멤버는 상속이 x)
                 */
            }         //WhatIsInheritance
        }   //stringField()
    }//class WhitIsClss


    //class Parent
    //{
    //    public string stringValue = "stringvalue -> 부모 클래스의 멤버 변수";
    //    protected int intValue = 1234;
    //    private float floatValue = 3.14f;
    //    public void Print()
    //    {
    //        Console.WriteLine("부모 클래스의 멤버 호출");
    //    }
    //}   //부모클래스 예제

    //class Child : Parent
    //{
    //    public void PrintChild()
    //    {

    //        Console.WriteLine("자식 클래스의 멤버 호출");
    //        Console.WriteLine("부모 클래스의 멤버 변수 호출 {0} ", base.stringValue);
    //        Console.WriteLine("부모 클래스의 멤버 변수 호출 {0} ", stringValue);
    //        //Base.stringValue인데 Base.을 안써줘도 무방하지만 명시적인게 좋다.
    //        Console.WriteLine("부모 클래스의 멤버 변수 호출: {0} {1} ",
    //            base.stringValue, base.intValue);
    //    }

    //}       //자식크랠스 예제

    class Monster
    {
        protected string name;
        protected int hp;
        protected int damage;
        protected int defence;

        public void Move(string name)
        {
            Console.WriteLine("{0}가 움직인다. ", name);
        }

        public void Attack(string name, int damage)
        {
            Console.WriteLine("{0}가 {1}의 공격력으로 공격했다.", name, damage);
        }

        public void MoveAndAttack()
        {
            this.Move(this.name);
            this.Attack(this.name, this.damage);
        }

    }   //몬스터 예제의 모체

    class Slime : Monster
    //비슷한 속성을 가진것을 모체로 부터 상속받고 변경점만 다 넣어주고 생성자만 만들면된다.
    {
        public Slime()
        {
            this.name = "푸른 슬라임";
            this.hp = 100;
            this.damage = 2;
            this.defence = 1;
        }


    }   //슬라임 자식 예제

    class Wolf : Monster
    {
        public Wolf()
        {
            this.name = "하얀 늑대";
            this.hp = 200;
            this.damage = 10;
            this.defence = 1;
        }

    }       //늑대 자식 예제





    class Player        //플레이어 모체 생성자 
    {
        public string playername;
        public int playerhp;
        public int playerdamage;
        public int playerdefence;

        protected void PlayerMove(string playername)
        {
            Console.WriteLine("{0}가 적을 만났다.\n}", playername);
            Console.WriteLine("");
            Console.WriteLine("hp{0}\n공격력{1}\n방어력{2}\n", this.playerhp, this.playerdamage, this.playerdefence);

        }
        protected void PlayerAttack(string playername, int playerdamage)
        {
            Console.WriteLine("{0}가 적을\n{1}의 공격력으로 때렸다.\n\t", playername, playerdamage);

        }

        public void PlayerMoveAndAttack()
        {
            this.PlayerMove(this.playername);
            this.PlayerAttack(this.playername, this.playerdamage);
        }

        public string PlayerName()
        {
            return this.playername;
        }
        public int PlayerHpValue()
        {
            return this.playerhp;
        }
        public int PlayerDamageValue()
        {
            return this.playerdamage;
        }
        public int PlayerDefenceValue()
        {
            return this.playerdefence;
        }

    }
    class PlayerStatus : Player
    {
        public void PlyaerStatus()
        {
            PlayerName();
            PlayerHpValue();
            PlayerDamageValue();
            PlayerDefenceValue();
        }
    }

    class Kight : Player //플레이어 자식 생성자
    {
        public Kight()
        {
            this.playername = "기사";
            this.playerhp = 500;
            this.playerdamage = 30;
            this.playerdefence = 15;
        }

    }
    class Magicion : Player
    {
        public Magicion()
        {
            this.playername = "마법사";
            this.playerhp = 300;
            this.playerdamage = 50;
            this.playerdefence = 5;
        }

    }

    class BigMonster
    {
        public string bigname;
        public int bighp;
        public int bigdamage;
        public int bigdefence;
        public string bigsound;

        public void BigMove(string move)
        {
            Console.WriteLine("{0}이 등장했다.", move);
            Console.WriteLine("");
            Console.WriteLine("hp{0}\n공격력{1}\n방어력{2}", this.bighp, this.bigdamage, this.bigdefence);

        }

        public void BigAttack(string move, int damage)
        {
            Console.WriteLine("{0} 이(가) \n\n{1}의 공격력으로 앞발을 휘둘렀다.", move, damage);
            Console.WriteLine("");
        }

        public void BigMoveAndAttack()
        {
            this.BigMove(this.bigname);
            this.BigAttack(this.bigname, this.bigdamage);
        }
        public string BigMonsterName()
        {
            return this.bigname;
        }
        public int BigHpValue()
        {
            return this.bighp;
        }
        public int BigDamageValue()
        {
            return this.bigdamage;
        }
        public int BigDefenceValue()
        {
            return this.bigdefence;
        }
        public string BigSoundValue()
        {
            return this.bigsound;
        }

    }       //큰 몬스터
    class BigMonsterStatus : BigMonster
    {
        public void MosterStatus()
        {
            BigMonsterName();
            BigHpValue();
            BigDamageValue();
            BigDefenceValue();
            BigSoundValue();
        }
    }

    class BigBear : BigMonster
    {
        public BigBear()
        {
            this.bigname = "큰 곰";
            this.bighp = 300;
            this.bigdamage = 25;
            this.bigdefence = 5;
            this.bigsound = "쿠오오오오엉!";
        }
    }
    class KingSlime : BigMonster
    {
        public KingSlime()
        {
            this.bigname = "킹 슬라임";
            this.bighp = 500;
            this.bigdamage = 50;
            this.bigdefence = 10;
            this.bigsound = "(몰캉몰캉)";
        }
    }

    class SkelletonMagicion : BigMonster
    {
        public SkelletonMagicion()
        {
            this.bigname = "해골 마법사";
            this.bighp = 420;
            this.bigdamage = 30;
            this.bigdefence = 8;
            this.bigsound = "달그락 달그락";
        }
    }

    //public class ClassNote
    //{
    //    public static void staticMethod()
    //    {
    //        Console.WriteLine("ClassNote 클래스의 staticMethod");
    //        //""의미를 완벽히 이해하기
    //    }

    //    public void InstanceMethod()
    //    {
    //        Console.WriteLine("ClassNote 클래스의 staticMethod");
    //    }            //InstanceMethod()
    //}

    //public class Lotto 
    //{
    //    public static void theLotto() 
    //    {
    //        Random ran = new Random();
    //        int ranNum = ran.Next(1, 45 + 1);
    //        int lottoNum = ranNum ;
    //        int[] lottoArray = new int[6]; //6개가 랜덤이면 될듯
    //        lottoArray[lottoNum] = ranNum;                           


    //        lottoNum = ranNum;
    //        int notNum = 0;
    //        int lottoCount = 6;
    //        bool six = false;
    //        while (six) 
    //        {
    //            for (int i = 0; i < lottoCount; i++)
    //            {
    //                lottoArray[i] = lottoNum;
    //                if (lottoNum == 0)
    //                {
    //                    break;
    //                }
    //                else { }            
    //            Console.WriteLine("로또 번호는 {0}", lottoArray[i]);
    //            }
    //        }
    //    }   //static theLotto
    //}   //Lotto클래스

    //public class What
    //{
    //    int[] lottoNumbers;
    //    public void PrintLotto()
    //    {
    //        //여기서 로또 번호 출력
    //        //로또번호 생성해서 배열에 초기화
    //        lottoNumbers = new int[45];
    //        for (int index = 0; index < 45; index++)
    //        {
    //            lottoNumbers[index] = index + 1;
    //        }   //loop: 로또 번호를 순서대로 초기화 하는 루프
    //        for (int index = 0; index < 100; index++) 
    //        {
    //            lottoNumbers = ShuffleOnce(lottoNumbers);
    //        }

    //        for (int index = 0; index < 6; index++) 
    //        {
    //            Console.Write("{0} ", lottoNumbers[index]);
    //        }
    //        Console.WriteLine();
    //    }   //PrintLotto()

    //public int[] ShuffleOnce(int[] lottoNumbers_)
    //{
    //    Random random = new Random();
    //    int sourIndex = random.Next(0, lottoNumbers_.Length);
    //    int destIndex = random.Next(0, lottoNumbers_.Length);

    //    int tempVarible = lottoNumbers_[sourIndex];
    //    lottoNumbers_[sourIndex] = lottoNumbers_[destIndex];
    //    lottoNumbers_[destIndex] = tempVarible;

    //    return lottoNumbers_;
    //}
    //}   //교수님 로또



    public class RPS
    {

        //r<p p<s p<r
        //r=r p=p s=s
        //char배열을 돌려서 나오는 값과
        //유저 입력 값을 비교해서 
        public void RPAGame()
        {
            string[] rpsGame = new string[3] { "가위", "바위", "보" };

            string rps = string.Empty;

            Console.WriteLine("가위 ,바위 , 보 중에 낼것은 입력하시오: ");



            bool RPSWin = false;



            //while (true)
            //{
            //    if (inInput == )
            //}


        }

    }

    public class Field
    {
        public void WhatIsField()
        {
            /**
             * 필드(Field)는 클래스의 부품 역할을 하는 클래스의 내부 상태 값을 저장해 놓는 그릇을 의미한다.
             * 예를 들어 필드는 자동차 클래스에 선언된 변수로 자동차 부품에 해당한다고 할 수 있다.
             * 
             * 필드
             * 클래스 내에서 선언된 변수 또는 배열 등을 C#에서는 필드라고 한다. 필드는 일반적으로 클래스의
             * 부품 역할을 하며, 대부분 privat 액세스 한정자(Access modifier)가 붙고 클래스 내에서
             * 데이터를 담는 그릇 역할을 한다. 이러한 필드는 개체 상태를 보관한다.
             * 필드는 선언한 후 초기화하지 않아도 자동으로 초기화 한다. 예를 들어 int 형 필드는 0으로,
             * string 형 필드는 String.Empty, 즉 공백으로 초기화 된다.
             * 
             * (가능하다면 모든것을 초기화하도록 하자.)
             * 
             * 지역 변수와 전역 변수
             * C#에서 변수를 선언할 때는 Main() 메서드와 같은 메서드 내에서 선언하거나 메서드 밖에서,
             * 즉 메서드와 동등한 레벨에서 변수를  선언할 수 있다. 메서드 내에서 선언된 변수 또는 배열을
             * 지역 변수(Local variable)라고 하며, 메서드 밖에서 선언된 변수를 전역 변수(Global variabel)
             * 라고 한다. 다만 C#에서는 전역 변수라는 용어를 사용하지 않고 메서드와 동일하게 액세스 한정자를
             * 붙여서 필드라고 한다.
             * 
             * 지역 변수
             * 변수는 Main() 메서드가 종료되면 자동으로 소멸된다. 변수가 살아 있는 영역은 Main() 메서드의
             * 중괄호 시작({) 과 끝 사 이(}) 이다. 특정 지역을 범위로 하기에 변수를 일반적으로 지역 변수 라고
             * 표현한다. 
             * 
             * 전역 변수
             * Main(0 메서드가 아닌 클래스 내에 선언된 변수를 필드라고 한다. C#에서 필드는 변수와 마찬가지로
             * 주로 소문자 또는 언더스코어(_)로 시작한다. 이러한 필드는 메서드 내에 선언된 지역 변수와 달리
             * 전역 변수라고도 한다.
             */
            //클래스를 사용하는 이유는 이런저런 연산을 하고 연산만 사용하기 위해 클래스를 쓰고 
            //내부에서 처리된 것을 외부에서 안보이게 하기위해 private로 접근하지 못하게 함.
        }   //whitIsFiled
    }

}
