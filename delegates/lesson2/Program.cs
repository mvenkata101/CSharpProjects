using System;
using System.Globalization;

namespace lesson2
{
    public delegate int foo(int x);

    public delegate void CustomDelegate(string str1);
    
    class Program
    {
        static void Main(string[] args)
        {
            /* foo fooObj = DelegateMethod;
            int y = fooObj(5);

            Console.Write($"x value = {y}"); */
            CustomDelegate custDelObj1, CustDelObj2, multiDelObj, minusDelObj, minusDelObj2;

            custDelObj1 = ChangeToUppercase;
            CustDelObj2 = ChangeToTitleCase;

            multiDelObj = custDelObj1 + CustDelObj2;
            
            minusDelObj = CustDelObj2 - custDelObj1;

            minusDelObj2 = multiDelObj - custDelObj1 - CustDelObj2;

            custDelObj1("Hello World");
            CustDelObj2("HELLO WORLD");
            multiDelObj("Multicast Delegate");
            minusDelObj("Good Bye");

            minusDelObj2("Final Good Bye");

        }

        public static int DelegateMethod(int x)
        {
            return x+x;
        }

        public static void ChangeToUppercase(string strInput)
        {
            strInput = strInput.ToUpper();
            Console.WriteLine($"Upper " + strInput);
        }
        
        public static void ChangeToTitleCase(string strInput)
        {
            TextInfo txtInfoObj = new CultureInfo("en-US", false).TextInfo;

            strInput = txtInfoObj.ToTitleCase($"Title Case " + strInput);
            Console.WriteLine(strInput);
        }
    }
}
