﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatisInterface
{
    internal class Description  //인터페이스
    {
        /** (인터페이스는 사용되는 곳 마다 뜻이 다르기에 
         * 잘 숙지 하기)
         * 
         * 
         * 큰 규모의 프로그램일수록 뼈대를 구성하는 일이 중요하다. 인터페이스를 사용하면
         * 전체 프로그램의 설계도에 대한 명세서를 작성할 수 있다. 이 강의에서는 프로그램의
         * 표준 규약을 정하고 따를 수 있도록 강제하는 인터페이스(Interface)를 학습해
         * 보겠다. 인터페이스는 클래스에서 구현해야 하는 관련기능의 정의가 포함된 개념
         * 이다.
         * 인터페이스
         * 
         * 인터페이스
         * 인터페이스는 클래스 또는 구조체에 포함될 수 있는 관련잇는 메서드들을 묶어
         * 관리한다. 인터페이스는 명세서(규약, 표준) 역할을 한다. 인터페이스를 상속받아
         * 그 내용을 구현하는 클래스는 인터페이스에 선언된 멤버(속성, 메서드 등)가
         * 반드시 구현되어 있다는 보증을 한다.
         * 
         * - 인터페이스는 interface 키워드를 사용하여 만든다. 인터페이스는 실행
         *      가능한 코드와 데이터를 포함하고 있다.
         *      
         * - 추상 클래스처럼 다른 클래스에 멤버 이름을 미리 정의할 때 사용한다.
         *      추상 클래스와 다른점은 멤버 내용을 구현하지 않고 멤버 이름만
         *      정의 한다.
         *      
         * - 인터페이스에는 메서드, 속성, 인덱서 및 이벤트를 정의할 수 있다.
         *      (함수와 변수 사용은 같음)
         *      
         * - 현실 세계에서 전 세계 표준과 같은 기능이다.
         * 
         * - 단일 상속만 지원하는 클래스와 달리 인터페이스를 사용한 다중 상속이
         *      가능하다.
         *      (이름만 상속 받고 내용은 정의해야해서 다중 상속이 가능하다)
         *      
         * - 인터페이스 멤버는 엑세스 한정자를 붙이지 않으며 항상 public 이고,
         *      virtual 및 static 키워드를 붙일 수 없다.
         *      
         * - 인터페이스 내의 모든 멤버는 기본적으로 public 이다.
         * 
         * - C#에서 인터페이스의 이름은, ICar, IFood, ICoumputer 형태로 대문자
         *      I로 시작한다.
         *      
         * - 인터페이스는 인스턴스화 되지 않는다. 클래스를 사용해서 인스턴스화 한다.
         *      (인스턴스화=메모리에 할당만 해주고 내용이 없어서 오류가 남)
         *      
         * - 인터페이스는 계(Contract) 의미가 강하며 속성, 메서드, 이벤트,
         *      인덱서 등 구조를 미리 정의한다.
         * 
         * (구체적 : 미리 내용이 다 정의 되어서 바꾸기 힘든 모양.
         * (추상적 : 내용을 바꾸기 쉽고 구체적 정의가 없으면 없을수록 추상적이라고 한다.유연하게 바꿀수 있는?
         *  
         */

        /**
         * 인터페이스를 사용한 다중 상속 구현하기
         * 다중 상속은 클래스 하나를 콤마로 구분해서 인터페이스 하나 이상을 상속하는 것을
         * 의미한다. C#에서 클래스는 클래스에 대한 단일 상속만 지원하는 대신,
         * 인터페이스는 클래스에 인터페이스를 하나 이상 상속할 수 있다.
         */

        /**
         * 인터페이스와 추상 클래스 비교하기
         * 인터페이스와 추상 클래스를 비교해서 살펴보자.
         * 
         * 추상클래스
         *  - 구현된 코드가 들어온다. 즉, 메서드 시그니처만 있는 것이 아니라 사용
         *      가능한 실제로 구현된 메서드도 들어온다.
         *  - 단일 상속: 기본 클래스에서 상속될 수 있다.
         *  - 각 멤버는 액세스 한정자를 갖는다.
         *  - 필드, 속성, 생성자, 소멸자, 메서드, 이벤트(메서드같은 무언가), 인덱서(변수 중 무언가)  등을 갖는다.
         *      (인스턴스화가 가능. 필드 속성 생성자 등등 들어가서)
         *  
         * 인터페이스
         * - 인터페이스는 규약이다.
         * - 구현된 코드가 없다.
         * - 다중 상속: 여러 가지 인터페이스에서 상속 가능하다.
         * - 모든 멤버는 자동으로 public이다.
         * - 속성, 메서드, 이벤트와 대리자를 멤버로 갖는다.
         *          (대리자: 함수를 통째로 변수에 넣은 것과 비슷)
         *          (인스턴스화 못함)
         * 
         */
    }          //class Description

    interface ICar 
    {
        public void Go();      //자동차가 앞으로 가라고 지시하는 함수

            /**
             * public void Go();
             * {
             *      기존에는 뭔가 내용을 정의했지만 인터페이스는 위에처럼 씀
             *      Console.
             * }
             */       
            //최고 부모의 Go()는 내용이 완전히 추상적이라 자식에서 구체적으로 쓰기 용이
    }
    class Car : ICar 
    {
        public virtual void Go() 
        {
            Console.WriteLine("자동차가 앞으로 간다");
           // Console.WriteLine("{0}",
               // "인터페이스를 사용할 때는 정의된 모든 멤버를 반드시 구현해야 한다. ");

            //부모 클래스를 구체적으로 뭔가 적을수록 자식클래스에서 유연하게 사용하기 힘듬
            
        }
    }
    class Sonata : Car 
    {
        public override void Go()
        {
            base.Go();
            Console.WriteLine("소나타가 앞으로 간다. ");
        }
    }

    interface IAniaml 
    {
        void Eat();
    }

    interface IDog 
    {
        void Yelp();
    }

    class Dog : IAniaml, IDog 
    {
        public void Eat() 
        {
            Console.WriteLine("먹다.");
        }
        public void Yelp() 
        {
            Console.WriteLine("짖다");
        }
    }
}