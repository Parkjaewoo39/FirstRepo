using System;

namespace WhatisInterface
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //Car myCar = new Car();
            //myCar.Go();
            //인터페이스 예제 메인 출력

            //Sonata mySonata = new Sonata();
            //mySonata.Go();

            //Dog myDog = new Dog();
            //myDog.Eat();
            //myDog.Yelp();
            //Eat과Yelp 둘다 상속받을수있음. interface 다중상속 예제

            WhatisCollection desc = new WhatisCollection();
            desc.CollectionDesc();

        
        }
        
    }
}