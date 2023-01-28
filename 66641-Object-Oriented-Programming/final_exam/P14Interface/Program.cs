namespace P14Interface
{
    interface IStudent
    {
        string Name { get; set; }
        int ID { get; set; }
        void DisplayStudentInfo();
    }

    class Student : IStudent
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public Student()
        {
            Name = "";
            ID = 0;
        }
        public void DisplayStudentInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + ID);
        }

        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "John Doe";
            s.ID = 12345;
            s.DisplayStudentInfo();
            Console.ReadKey();
        }
    }
}
