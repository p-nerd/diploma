namespace P21Destructor
{
    class Program
    {
        ~Program()
        {
            Console.WriteLine("Destructor called");
        }
        static void Main(string[] args)
        {
            Program o = new Program();
        }
    }

}
