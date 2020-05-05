using System;

namespace lesson1
{
    class Program
    {
        public delegate int MyDelegate(int x);
        public delegate void MyDelegate2(int y);
        static void Main(string[] args)
        {
             MyDelegate inst = MyFunction;
            int y = 5;
            int z = inst(y);
            Console.Write($"Delegate invoked with x value {z}");            

            MyDelegate2 inst2 = delegate(int y1) 
                                    {Console.Write($"Y1 value = {y1+1}");};
            inst2(5);
            MyLambda1(); 

            /* Action ret = () => {
                Console.Write("called");
                Console.Read();
            };
            ret(); */

            /* Action<string, string> foo = (x1, x2) => {
                Console.Write($"X1 = {x1}, X2= {x2}");
            };

            foo("test1", "test2"); */
        }

        public static int MyFunction(int x)
        {            
            return x+x;
        }

        public static void MyLambda1()
        {
            int outVar = 5;
            Func<int, int> sqr = (int x) => x*outVar;
            Console.Write($"Lambda1 value = {sqr(5)}");
            Console.Read();
        }
    }
}
