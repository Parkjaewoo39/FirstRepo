using System;

namespace Whatisprograming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Console.Write("반지름의 길이를 입력하시오. :");
            float stringNumber = Convert.ToSingle(Console.ReadLine());
            const float OP = 3.14f;
            float powofThree = stringNumber * stringNumber * stringNumber;

            Console.WriteLine("{0}", 4 * stringNumber * stringNumber * OP);
            Console.WriteLine("{0}", 4 * powofThree * OP / 3);
        }
           


        
    }
}
