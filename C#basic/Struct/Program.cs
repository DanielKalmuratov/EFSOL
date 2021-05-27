using System;

namespace Struct
{
    class MyClass {
        public string change;
    }
    struct MyStruct {
        public string change;
    }
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "MyClass изменено";
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "MyStruct изменено";
        }
        static void Main(string[] args)
        {
            MyClass mClass = new MyClass();
            mClass.change = "MyClass не изменено";
            Console.WriteLine(mClass.change);
            Program.ClassTaker(mClass);
            Console.WriteLine(mClass.change);


            MyStruct mStruct = new MyStruct();
            mStruct.change = "MyStruct не изменено";
            Console.WriteLine(mStruct.change);
            Program.StruktTaker(mStruct);
            Console.WriteLine(mStruct.change);

            // В MyStruct поле change меняется только один раз в методе static void StruktTaker
            // В MyClass это поле меняется дважды в методе static void ClassTaker и в методе Main
            Console.ReadKey();
            
        }
    }
}
