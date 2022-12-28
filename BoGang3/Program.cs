namespace BoGang3
{
    internal class Program
    {
        //[반환 타입][함수 이름]([매개변수])
        //{
        //  실행 될 내용
        //  return;
        //}


        //void는 반환할 내용이 없다는 뜻.
        static void printHello()
        {
            Console.WriteLine("Hello");
        }

        //이 함수가 작동할려면 ()안이 적혀있는걸 적어 넣어주세요.
        static void printIntByinput(int i)
        {
            Console.WriteLine(i);
        }

        //반환할 타입 적고 함수명 명시 그리고 ()에 매개변수
        static bool printOneAndReturn()
        {
            Console.WriteLine("123");
            return true;
        }
        //함수의 타입과 반환타입이 같아야지 담김.

        int getOneAndReturn(int input)
        {
            Console.WriteLine(input);
            return input;
        }

        static int UnityDouble(int toDouble) 
        {
            int a;
            a = toDouble * 2;
            return a;
        }

        static double OneAddTwo(float oneA, float oneB) 
        {
            double add;
            add = oneA + oneB;
            

            return add;
        }


        //bool TryParse() 
        //{
            
        //}
        static void Main(string[] args)
        {

            //두 실수를 입력받고, 두 수의 합을 더블형으로
            //반환하는 함수를 만들고 싶다.

            float x = 4.123f;
            float y = 6.1254f;

            Console.WriteLine(OneAddTwo(x,y)+ UnityDouble(5));
            Console.WriteLine(OneAddTwo(3f, 4f));





            Console.WriteLine(UnityDouble(5));
            
             



            //기능을 하나 만들고 싶어요
            //정수형 a를 받고
            //해당 값을 2배로 만들어서 정수형으로 반환하는 기능.


            //int a = 1;
            // printHello();
            // printIntByinput(a);

            bool b ;
            //반환값 담아서 나타내기
            b = printOneAndReturn();
            

            //int x = 5;
            //int y = 4;
            //int z = x + y;

            //Console.WriteLine(z);

            //int a_ = 10;
            // int b = 20;
            //int c = a_ + b;
            // Console.WriteLine(c);











            //int toDetermine;
            //bool incorrectInput = false;
            //Console.WriteLine("이동 할 장소를 설정해주세요");
            //incorrectInput = int.TryParse(Console.ReadLine(), out toDetermine);

            //if (incorrectInput == false)
            //{

            //    while (incorrectInput == false)
            //    {
            //        Console.WriteLine("제대로 된 입력을 다시 해주세요");
            //        incorrectInput = int.TryParse(Console.ReadLine(), out toDetermine);
            //    }
            //}
            //


            //bool을 활용한 if while 반복문 이유 확인
            //-==========================================================
            //=========================================================

            //Console.WriteLine("1. 마을");
            //Console.WriteLine("2. 사냥터");
            //Console.WriteLine("3. 상점");


            //int toDetermine;
            //bool incorrectInput = false;
            //Console.WriteLine("이동 할 장소를 설정해주세요");
            //incorrectInput = int.TryParse(Console.ReadLine(), out toDetermine);

            //if (incorrectInput == false)
            //{

            //    while (incorrectInput == false)
            //    {
            //        Console.WriteLine("제대로 된 입력을 다시 해주세요");
            //        incorrectInput = int.TryParse(Console.ReadLine(), out toDetermine);
            //    }
            //}
            //switch (toDetermine)
            //{
            //    case 1:
            //        Console.WriteLine("마을로 이동합니다");
            //        break;
            //    case 2:
            //        Console.WriteLine("사냥터로 이동합니다");
            //        break;
            //    case 3:
            //        Console.WriteLine("상점으로 이동합니다");
            //        break;
            //    default:
            //        Console.WriteLine("1,2,3 어느것도 아니에요");
            //        break;


            //switch문의 작동방법
            //-==========================================================
            //=========================================================

            //int[] cards;//기본형 값이 없고 그냥 어디 있다.
            //cards = new int[4];
            //new는 뒤에붙는걸 만들어주고 해당 변수에 넘겨주는 일을한다.
            //배열함수 카드는 정수형4배열을 넣는다.

            //cards[0] = 1;
            //cards[1] = 2;
            //cards[2] = 7;
            //cards[3] = 9;

            //cards[4] = 10;//[0]~[3]까지만 만들어놨는데
            //[4]째부터 없는 배열칸이라 컴퓨터가 처리하지 못하고 터짐.


            //Console.WriteLine(cards[0]);
            //Console.WriteLine(cards[1]);
            //Console.WriteLine(cards[2]);
            //Console.WriteLine(cards[3]);
            //Console.WriteLine(cards[4]);

            /* int[] cards = 1;*/ // 배열에서는 바로 담는건 싫어한다.



            //for (int index = 0; index < cards.Length; index++) 
            //{
            //    Console.WriteLine(cards[index]);
            //}  //가급적 for문의 조건의 최대 크기는 숫자보단 함수의 Length로 하자.

            //Console.WriteLine();
            //Collection 집합체, 여러가지를 모아놓는?

            //in 옆의 있는걸 하나씩 왼쪽에 담음
            //카드속의 있는 모든 요소를 순서대로 담아줌.
            //전부볼때까지 foreach
            //foreach (int array in cards) 
            //{
            //    Console.WriteLine(array);
            //}

            //int[,] card2 = new int[2, 2];
            //card2[0, 0] = 1;
            //card2[0, 1] = 2;
            //card2[1, 1] = 2;


        }

    }
    public class BoGangThree
    {

    }
}