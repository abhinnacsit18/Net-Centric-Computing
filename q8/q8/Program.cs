namespace OIC
{
    class student
    {
        public int roll;
        public string name;

        public void setstudent()
        {
            Console.WriteLine("\nEnter the name of student: ");
            name =  Console.ReadLine();
            Console.WriteLine("\nEnter the roll number of student: ");
            roll = int.Parse(Console.ReadLine());
        }
        public void getstudent()
        {
            Console.Write($"Roll no: {roll}, {name}\n");
        }
    }

    class Test: student
    {
        protected int marks1;
        protected int marks2;

        public void setTest()
        {
            Console.Write("\nEnter the marks of: ");
            getstudent();
            Console.WriteLine("Enter the marks on subject 1: ");
            marks1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks on subject 2: ");
            marks2 = int.Parse(Console.ReadLine());
        }
        public void getTest()
        {
            Console.WriteLine($"Marks on subuject 1: {marks1}");
            Console.WriteLine($"Marks on subuject 2: {marks2}");

        }
    }

    class Result: Test
    {
        private int total;

        public void setResult()
        {
            setstudent();
            setTest();

            total = marks1 + marks2;
        }
        public void getResult()
        {
            getstudent();
            getTest();
            Console.WriteLine($"Total marks: {total}"); 
            Console.WriteLine($"Percentage: {total / 2}%");
        }
    }

    static class MainProgram
    {
        static void Main()
        {
            Console.WriteLine("abhinna question 8\n");

            Result result = new Result();
            result.setResult();
            result.getResult();
        }
    }

}