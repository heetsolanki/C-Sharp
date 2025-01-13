using System;

namespace Method
{
    class Method
    {
        public void addition(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public void addition(float a, float b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public void addition(String a, String b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        static void Main(string[] args)
        {
            Method m = new Method();
            m.addition(3, 9);
            m.addition(3.5f, 53.4f);
            m.addition("hello", " world");
            Console.ReadKey();
        }
    }
}