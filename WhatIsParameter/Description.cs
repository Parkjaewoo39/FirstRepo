using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsParameter
{
    public class Description
    {
        public void ParmeterDesc() 
        {
            /**
             * 메서드의 매개변수 전달 방식
             * 
             * 메서드의 매개변수 전달 방식은 사용하는 방식에 따라 네 가지로 분류한다.
             * 지금까지 기본으로 사용한 매개변수 전달 방식은 값 전달 방식이다.
             * 이에 추가해서 ref(reffence) 키워드를 사용하는 참조형 전달 방식과 out 키워드를
             * 사용하는 반환형 전달 방식, 마지막으로 params 키워드를 사용하는 가변형
             * 전달 방식이 있다.
             * (값방식 참조방식 찾기)
             *    
             *    
             *   !
             * - 값 전달 방식 : 말 그대로 값을 그대로 복사해서 전달하는 방식을 의미한다.
             *   지금까지 사용해왔던 매개변수 방식이다.
             *   
             * - 참조 전달 방식(ref): 실제 데이터는 매개변수가 선언된 쪽에서만
             *   저장하고, 호출된 메서드에서는 참조만 하는 형태로 변수 이름만 전달하는
             *   방식이다.
             *   
             * - 반환형 전달 방식(out): 메서드를 호출하는 쪽에서 선언만 하고, 초기화
             *   하지 않고 전달하면 메서드 쪽에서 해당 데이터를 초기화해서 넘겨주는
             *   방식이다.
             *   
             * - 가변형 전달 방식(params): 1개 이상의 매개변수를 가변적을 받을 때
             *   매개변수를 선언하면 params 키우더를 붙인다. 가변적이라는 것은
             *   같은 타입으로 하나 이상을 받을 수 있도록 배열형으로 받는다는 의미이다.
             *   가변 길이 매개변수는 
             *   반드시 매개변수를 선언할 때 마지막에 위치해야 한다.
             */
        }   //PrameterDesce()

        //값전달방식
        //값만 넘겨주는 형식
        public void ValueTypeParam(int firstNumber, int secondNumber) 
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            //값 바꾸는 양식
            Console.WriteLine("first{0} second{1}", firstNumber, secondNumber);
        }

        public void RefTypeParm(ref int firstNumber, ref int secondNumber) 
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            //값 바꾸는 양식
            Console.WriteLine("first{0} second{1}", firstNumber, secondNumber);
        }

        //out 변수를 ref타입으로 답아서 초기화를 해준다.
        public void OutTypeParm(out int number) 
        {
            number = 10;
        }//써버리면 사라짐.

        public void FiexibleTypeParam(params int[] numbers)
                                    //params 받을 밸류[] 이름
        {
            foreach (int number in numbers) 
            {
                Console.Write("{0}", number);
            }
            Console.WriteLine();
        }
        //public int[] FiexibleTypeParam2(params int[] numbers)
        ////params 받을 밸류[] 이름
        //{
        //    foreach (int number in numbers)
        //    {
        //        Console.Write("{0}", number);
        //    }
        //    Console.WriteLine();

        //    return numbers;
        //}
        public void ArrayParam(int[] numbers) 
        {
            
        }
    }
}
