using System;

namespace P25MultipleInheritance
{
    interface IFoo
    {
        void DoFoo();
    }
    interface IBar
    {
        void DoBar();
    }
    class Program : IFoo, IBar
    {
        public void DoFoo()
        {
            Console.WriteLine("Doing Foo");
        }

        public void DoBar()
        {
            Console.WriteLine("Doing Bar");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.DoFoo();
            p.DoBar();
        }
    }

}