using System;

namespace WhatIsParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Description desc = new Description();

            int number1 = 10;
            int number2 = 20;

            //값전달 함수를 사용하면 바뀜
            desc.ValueTypeParam(number1, number2);
           // 메인에서는 그냥 값전달 함수를 사용안해서 그대로 출력.
            Console.WriteLine("[Main] first{0} , second{1}", number1, number2);

            //ref 사용
            //ref는 ref함수를 쓰지않은 곳에도 영향을 끼침
            desc.RefTypeParm(ref number1, ref number2);
            Console.WriteLine("[Main] first{0} , second{1}", number1, number2);

            //out 사용
            //out 변수를 ref타입으로 초기화해서 반환 해준다.
            int number;
            desc.OutTypeParm(out number);
            Console.WriteLine("[Main] number: {0}", number);

            string strNumber = "!@";
            int intNumber;
            int.TryParse(strNumber, out intNumber);
            //tryparse가 strNumber 자리에서 무언가를 받아서 성공하면 out으로 intNumber로 출력해주고
            //실패하면 int형이라 0의 값을 보여줌.

            Console.WriteLine("{0} {1}", intNumber, intNumber);

            //params사용
            //params 입력값을 배열로 자동 저장해줌.


            int[] numberss = new int[5] { 1, 2, 3, 4, 5 };

            desc.FiexibleTypeParam(1, 2, 3);
            desc.ArrayParam(new int[] { 1, 2, 3, 4 });
            //만들어 놓지 않으면 매개변수 자리에 다 써야하고

            desc.ArrayParam(numberss);
            //미리 만들어서 선언한 배열의 함수이름을 넣어주면됨.

    }
}