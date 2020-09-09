using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        private static int Add(int x, int y)
        {
            int notUsed = 2;
            return x + y;
        }
        static void Main(string[] args)
        {
            Class1 cl = new Class1();

            cl.SurpressJit(); //set bp here
            Console.WriteLine("Hello World!");

            //int dummy = 0;
            //int iLocal = 0;	// init iLocal in Func().
            //iLocal++;

            //string fourtype = "㐀㒣㕴㕵㙉㙊䵯䵰䶴䶵"; //#bp3
            //string s1 = "hello"; //#bp4
            //string s2 = "World"; //#bp6
            //Add(10,20);
            //Console.WriteLine("Hello World!");
        }
    }
}
