using System;
//System 이라는 어셈블리에서 여러 기능을 가져와서 사용할 거다.

namespace whatisArray
//내프로그램 이름이다. 내가 정함.
{

    internal class Program
    //class 라는 것인데, C#에서는 모든 요소들이 class 안에 있어야함.
    {
        static void Main(string[] args)
        //C# 콘솔(검은창) 에서 Main()는 무조건 1개 있어야함.
        {
            //프로그램은 여기서부터 읽기 시작한다.
            //Console.WriteLine("Hello World!");

            //ctrl+k+f 정렬시켜줌




            //횟수가 정해진건for, 모르는건while이 편함

            for (int variable_ = 1; variable_ <= 100; variable_++)
            {
                bool isRealMultipleOfThree = (variable_ % 3 == 0);
                //(varible_ % 3 == 0);
                //100에서 3을 나누어 0이면 3의 배수이므로 3의 배수를 구분하는 명제 bool

                Console.WriteLine("{0} -> isRealMultipleOfThree: {1}",
                    variable_, isRealMultipleOfThree);
                int sumOfNum = 0;
                if (isRealMultipleOfThree == false)
                {int sunOfNum = 0;
                    sumOfNum += variable_;
                    Console.WriteLine("잘 더해지고 있나.: {0}", sumOfNum);
                }
                else
                {

                }//loop:100번 도는 루프
                //루프가 끝나면 여기로 오니까 다 끝날 떄까지는 더해서 마지막 값을 눈으로 보고 싶으니 여기에씀
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine();

                Console.WriteLine("========================");
                Console.WriteLine("sumOfNum = {0}", sumOfNum);
                Console.WriteLine("========================");


                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                for (int index = 1; index <= 50; index++)
                {

                    Console.WriteLine("잘 굴러가나: {0}", index);

                }
                Console.WriteLine("index = {0}");
                //프로그램 사용자로부터 양의 정수를 하나 입력 받아서,
                //그 수 만큼 "Hello World!"를 출력하는 프로그램작성.
                int someNum = 100;
                bool isPositiveInteger = (0 < someNum);

                /**
                 * 프로그램 사용자로부터 계속해서 정수를 입력 받는다.
                 * 그리고 그 값을 계속해서 더해 나간다. 이러한 작업은
                 * 프로그램 사용자가 0을 입력할 때까지 계속되어야 하며,
            //     * 0이 입력되면 입력된 모든 정수의 합을 출력하고 프로그램 종료.
            //     */

                //    bool isNumberZero = (someNum== 0);

                //프로그램 사용자로부터 입력받은 숫자에 해당하는 구구단을 출력하되,
                //역숙으로 출력하는 프로그램을 작성.
                int userInputNumber = 3;
                for (int index = 9; 1 <= index; index--)
                {                             //루프의 오름차순 내림차순
                    Console.WriteLine("{0} x {1} = {2}",
                        userInputNumber, index, userInputNumber * index);
                }//loop: 9번을 도는 루프.



                /**
                 * 프로그램 사용자로부터 입력 받은 정수의 평균을 출력하는 프로그램을 작성하되,
                 * 다음 두 가지의 조건을 만족할 것.
                 * -먼저 몇 개의 정수를 입력할 것인지 프로그램 사용자에게 묻는다.
                 * 그리고 그 수만큼 정수를 입력 받는다.
                 * -평균 값은 소수점 이하까지 계산해서 출력한다.
                 */
                /**
                 * Lab1 비밀코드 맞추기
                 * 컴퓨터가 숨기고 있는 비밀 코드를 추측하는 게임을 작성
                 * 비밀코도는 a~z사이의 문자
                 * 컴퓨터는 사용자의 추측을 읽고서 앞에 있는지, 뒤에 있는지 알려준다.
                 * (힌트를준다)
                 * 
                 */
                char scretCode = 'y'; //문자입력값 한개 
                char userInPutAlphabet = 'd'; //유저 입력 한개

                bool isSmallAlphabet =
                    ('a' <= userInPutAlphabet && userInPutAlphabet <= 'z');
                bool isAlphabetFo = (userInPutAlphabet <= scretCode);
                bool isAlphabetBa = (scretCode <= userInPutAlphabet);
                if (isAlphabetFo) { }
                else
                {
                    Console.WriteLine("{0 {1}",
                        "[System]당신의 입력은 처리할 수 없습니다," +
                        "알파벳 소문자만을 입력해주세요");
                }
                if (isAlphabetFo)
                {
                    Console.WriteLine("당신의 알파벳은 비밀코드보다 앞에있음.");
                }
                else
                if (isAlphabetBa)
                {
                    Console.WriteLine("당신의 알파벳은 비밀코드보다 뒤에있음.");
                }
                else
                {
                    //Console.WriteLine("시크릿 코드를 찾았습니다.");
                }
                ///

                /**
                 * 1~100숫자 중에서 3의 배수이면서 4의 배수인 정수 합 구하기
                 */
                int sumNumber = 0;
                int someNumBer = 100;
                bool isMultipleOfThree = (someNumBer % 3 == 0);
                bool isMultipleOfFour = (someNumBer % 4 == 0);

                bool isSatisfyCondition = isMultipleOfFour && isMultipleOfThree;
                // && 둘다 포함이라는 뜻

                if (isSatisfyCondition)
                {
                    sumNumber += someNumBer;
                }
                else
                {
                }



                //별을 100번찍는법
                Console.WriteLine("{0} {1} {2} {3} {4} "
                    , "**********", "**********", "**********", "**********", "**********");
                Console.WriteLine("{0} {1} {2} {3} {4} "
                   , "**********", "**********", "**********", "**********", "**********");

                for (int index = 1; index <= 100; index++)
                {
                    Console.WriteLine("{0}", "*");

                }

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

            //    유저 입력

            //유저입력값 정하고
            //숫자를 넣고 다시 나오는 출력구문을 만들고
            //참이 될때 까지 반복인데
            //유저의 숫자를 까지 반복이고
            //int starNum = 0;

            //    Console.WriteLine("줄의 개수를 입력하시오: ");
            //    int.TryParse(Console.ReadLine(), out starNum);
            //    for (int index = 1; index <= starNum; index++)
            //    {//반복 횟수가 유저 입력이 넘지 않게



            //        for (int index2 = 1; index2 <= index; index2++)
            //        { //반복 횟수가 반복횟수를 넘지 않게
            //            Console.Write("{0}", "*");

            //        }
            //        Console.WriteLine();
            //        //줄개수는 반복됨. 추가 식 필요
            //    }



            //    //짝수홀수 로직이면


            //if else
                        //최대 20이지만 11부터 다시 작아지는
            //첫줄부터 10까지는 오름차순으로 증가
            //11부터 20까지는 내림차순으로 감소
            //int starNumDiamond = 0;

            //    Console.WriteLine("줄의 개수를 입력하시오: ");
            //    int.TryParse(Console.ReadLine(), out starNumDiamond);
            //    bool NotEven = = 0)

            //for (int index_D = 1; index_D <= starNumDiamond; index_D++)
            //{


            //    for (



            //}


            //for (int index = 1; index <= 10; index++)
            //{
            //    for (int index2 = 1; index2 <= 10; index2++)
            //    {
            //        Console.WriteLine("{0}", "*");
            //    }//loop:이건 밖의 루프가 1번 도는 10번 도는 루프
            //    Console.WriteLine();
            //    //loop: 이건 10번을 도는 루프
            //}

            //Console.WriteLine();
            //Console.WriteLine();


            //3중문
            int hundredCount = 0;

            for (int index = 1; index <= 10; index++)
            {
                for (int index2 = 1; index2 <= 10; index2++)
                {
                    for (int index3 = 1; index3 <= 10; index3++)
                    {
                        hundredCount++;
                        if (100 < hundredCount) { break; }
                        else { }

                        Console.Write("{0}", "*");
                        //여기가 별을 찍는 지점.

                        //여기서 10번마다 한줄을 띄어 줄거임
                        if (hundredCount % 10 == 0) ;
                        {
                            Console.WriteLine();
                        }
                    }
                }//loop:이건 밖의 루프가 1번 도는 10번 도는 루프

                //loop: 이건 10번을 도는 루프
            }













            string persenal_Gender = "여자";

            //강아지를 입력받으면 if와else if는 참이 되지않아서 //
            //else로 감.

            if (persenal_Gender.Equals("남자")/*여기서 조건문 검사 너 남자니? */) //첫번째 조건문
            {
                //저 조건문이 참이면 여기로 옴.
                //조건문은 여기서부터 읽기 시작.                
                Console.WriteLine("남자확인");
                //조건문은 여기서 끝난다.

            }
            else if (persenal_Gender.Equals("여자")/*새로운 조건문 너 여자니?*/)  //두번째 조건문
            {
                //새로운 조건문이 참이면 여기로 옴.
                //조건문은 여기서부터 읽기 시작.                
                Console.WriteLine("여자확인");
                //새로운 조건문의 참이면 출력되는 문장.
                //조건문은 여기서 끝난다.
            }
            else
            {
                //조 조건문이 거짓이면 여기로 옴.
                //조건문은 여기서부터 읽기 시작.
                Console.WriteLine("남자도 여자도 아님.");
                //조건문은 여기서 끝난다.
            }
            //조건문을 실행했으면 이제 다시 여기서부터 프로그램 시작한다.


            //여기서 끝남.


            //야구게임
            /**
             * 각자 3,4의 의 숫자를 임의로 정한뒤, 서로에게 3,4 숫자를 불러서 결과를 확인한다.
             * 그리고 그 결과를 토대로 상대가 적은 숫자를 예상한 뒤 맞힌다.
             * 사용되는 수자는 0~9까지 서로 다른 숫자이다. 경우에 따라 0은 사용하지 않기도 한다.
             * 숫자는 맞으나 위치가 틀렸을 때는 볼.
             * 숫자와 위치가 전부 맞으면 스트라이크
             * 숫자와 위치가 전부 틀리면 아웃. "틀렸다"는 게 중요하다.
             * 무엇이 볼이고 스트라이크인지 알려주지 않는다.
             * 두숫자 중복되면 경우의 수가 많아져서 그런지 중복 숫자는 잘 사용하지 않는다.
             * 
             *
             */

            //사용되는 숫자 0~9 랜덤 숫자 3혹은 4자리
            // 9번만에 맞추면 승리 못맞추면 패배


            //유저 입력값
            int userInput = 0;

            Console.WriteLine("숫자 야구놀이를 시작합니다! \n세자리의 숫자를 입력하시오.");
            userInput = Convert.ToInt32(Console.ReadLine());

            //총 000~999 자리 세자리 숫자 정답 맞추게 하는법
            //자리를 나누는법?뭘까
            Random random = new Random();//난수 함수 선언
            int randomOne = random.Next(0, 10);//난수 0~9까지 
            int randomTen = random.Next(0, 10);
            int randomHundred = random.Next(0, 10);


            int CountNum = 0; //유저 입력 횟수
            int strike = 0;
            int ball = 0;
            int out_ = 0;
            int answer = 0;
            //1 2 3   ball 
            while (true)  // 같은 수가 안나오게  ;;

            {
                if (randomOne != randomTen && randomOne != randomHundred && randomTen != randomHundred)
                //1자리 10자리가 다르고 1의자리 100자리가 다르고 10자리랑 100자리가 다를때 까지
                { break; }

            }


            for (CountNum = 1; CountNum < 9 + 1; CountNum++) //9번 루프해서 참을 찾아야함.
            {
                Console.WriteLine("{0}회차 ,다시 입력하시오 ", CountNum); //몇차시도인지 
                CountNum = int.Parse(Console.ReadLine());   //횟수 함수를 정수계산에 넣기

                if (userInput == randomOne)
                {

                    strike++;

                }
                else if (userInput == randomTen)
                {
                    strike++;

                }
                else if (userInput == randomHundred)
                {
                    strike++;
                }
                Console.Write("승리");
                break;


            }



            /**
             * 컬렉션
             * 이름 하나로 데이터 여러 개를 담을 수 있는 자료 구조를 컬렉션(Collection) 또는
             * 컨테이너(Container) 라고 한다. C#에서 다루는 컬렉션은 배열(Array), 리스트(List),
             * 사전(Dictinary)등이 있다.
             * 
             * 배열
             * 배열(Array)은 같은 종류의 데이터들이 순차적으로 메모리에 저장되는 자료 구조이다. 
             * 각각의 데이터들은 인덱스(번호)를 사용하여 독립적으로 접근된다. 배열을 사용하면 편리하게 데이터를 모아서 관리할 수 있다.
             * 
             * 배열의 특징들
             * 1.배열 하나에는 데이터 형식 한 종류만 보관할 수 있다.
             * 2.배열은 메모리에 연속된 공간을 미리 할당하고, 이를 대괄호([])와 0부터 시작하는 정수형 인덱스를
             * 사용하여 접근할 수 있다.
             * 3.배열을 선언할때는 new 키워드로 배열을 생성한 후 사용할 수 있다. 
             * 4.배열에서 값 하나는 요소(Element) 또는 항목 (Item)으로 표현한다.
             * 5.필요한 데이터 개수를 정확히 정한다면 메모리를 적게 사용하여 프로그램 크기가 작아지고 성능이 
             * 향상된다.
             * 
             * 배열에는 세가지 종류가 있다.
             * 1차원 배열 : 배열의 첨자를 하나만 사용하는 배열
             * 다차원 배열 : 첨차 2개 이상을 사용하는 배열(2차원, 3차원, ... n차원)
             * 가변(Jagged)배열 : '배열의 배열' 이라고도 하며, 이름 하나로 다양한 차원의 배열을 표현할 때 사용된다. 
             */

            ////배열의 선언과 초기화

            //int number1 = 1;
            //int number2 = 2;
            //int number3 = 3;
            //int number4 = 4;
            //int number5 = 5;






            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            Console.Write(numbers);
            ////0번째 1번째
            ///*umbers.Length=*/
            //for (int index = 0; index < numbers.Length; index++) 
            //{
            //    Console.Write("{0} ", numbers[index]);
            //}
            //foreach (int element in numbers) //넘버스의 엘리먼트를 찾아서 element에 저장하고 {}만큼 실행되고 조건비교없이 두번째 실행 세번째 실행 ...끝까지
            //{
            //    Console.Write("{0} ", element);
            //}




            //세 난수를 선언하고 중복이 안되게 조건을 건다. 세 난수는 서로 같을수 없다를 
            //3자리 숫자 입력하면
            //





















        }








    }
}