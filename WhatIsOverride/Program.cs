using System;
using static WhatIsOverride.Child;
using static WhatIsOverride.Child;
using static WhatIsOverride.Monster;

namespace WhatIsOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Parent parent= new Parent();
            //parent.Say();
            //parent.Run();
            //parent.Walk();

            //Child child = new Child();
            //child.Say();
            //child.Run();
            //child.Walk();

            //StoreButton storeButton = new StoreButton();
            //storeButton.OnClickButton();
            BigBear bigbear = new BigBear();
            //bigbear.Name = "이거 사실 슬라임 아닌데";//왼쪽의 무엇이 임시로 담길 곳이 properti의 value 키워드
            Console.WriteLine(bigbear.Name);

        }
    }
}