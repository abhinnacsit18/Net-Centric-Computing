namespace OIC
{
    interface Gross
    {
        public float TA();
        public float DA();
        public float Gross_sal();
    }

    class Employee
    {
        protected string name;

        public Employee()
        {
            Console.WriteLine("Enter the name of employee: ");
            string name = Console.ReadLine();
        }
        public float basic_sal()
        {
            Console.WriteLine("Enter the basic salary: ");
            float sal = float.Parse(Console.ReadLine());
            return sal;
        }
    }

    class salary: Employee, Gross
    {
        public float TA()
        {
            Console.WriteLine("Enter the travel allowance: ");
            float ta = float.Parse(Console.ReadLine());
            return ta;
        }
        public float DA()
        {
            Console.WriteLine("Enter the daily allowance: ");
            float da = float.Parse(Console.ReadLine());
            return da;
        }
        public float Gross_sal()
        {
            float gross = basic_sal() + TA() + DA();
            return gross;
        }
    }

    class MainProgram
    {
        static void Main()
        {
            Console.WriteLine("abhinna question 7\n");

            salary s = new salary();
            Console.WriteLine($"\nGross salary is: {s.Gross_sal()}");

        }
    }
}
