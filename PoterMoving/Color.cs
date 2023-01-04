using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoterMoving
{
    public class Color
    {


        //!컬러 딜레이 문자열 출력
        public  void PrintColorText(string text_, ConsoleColor color_)
        {
            Console.ForegroundColor = color_;
            Task.Delay(200).Wait();
            Console.Write("{0}", text_);
            Console.ForegroundColor = ConsoleColor.White;
        }       //텍스트 컬러 변경 툴. 딜레이 ++
        public void ColorfullString()
        {
            PrintColorText("\tC", ConsoleColor.Red);
            PrintColorText("o", ConsoleColor.Green);
            PrintColorText("i", ConsoleColor.Yellow);
            PrintColorText("n ", ConsoleColor.Blue);
            PrintColorText("A", ConsoleColor.Magenta);
            PrintColorText("n", ConsoleColor.Cyan);
            PrintColorText("d ", ConsoleColor.DarkRed);
            PrintColorText("M", ConsoleColor.Green);
            PrintColorText("o", ConsoleColor.DarkRed);
            PrintColorText("v", ConsoleColor.DarkGray);
            PrintColorText("i", ConsoleColor.Yellow);
            PrintColorText("n", ConsoleColor.DarkGray);
            PrintColorText("g\n", ConsoleColor.DarkBlue);                      

        } //글자 색입혀 보기.

        public static void SeeColorText(string text_, ConsoleColor color_)
        {
            Console.ForegroundColor = color_;
            Console.Write("{0}", text_);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void ColorFullString()
        {
            SeeColorText("\tC", ConsoleColor.Red);
            SeeColorText("o", ConsoleColor.Green);
            SeeColorText("i", ConsoleColor.Yellow);
            SeeColorText("n ", ConsoleColor.Blue);
            SeeColorText("A", ConsoleColor.Magenta);
            SeeColorText("n", ConsoleColor.Cyan);
            SeeColorText("d ", ConsoleColor.DarkRed);
            SeeColorText("M", ConsoleColor.Green);
            SeeColorText("o", ConsoleColor.DarkRed);
            SeeColorText("v", ConsoleColor.DarkGray);
            SeeColorText("i", ConsoleColor.Yellow);
            SeeColorText("n", ConsoleColor.DarkGray);
            SeeColorText("g\n", ConsoleColor.DarkBlue);
                       


        }
    }
}
