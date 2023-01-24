using System;

namespace OIC
{
    class Salary
    {
        private double basic;
        private double TA;
        private double DA;
        private double HRA;

        public Salary(double basic, double ta, double da = 500.00, double hra = 15000.00)
        {
            this.basic = basic;
            TA = ta;
            DA = da;
            HRA = hra;
        }

        public double display()
        {
            return (basic + TA + DA + HRA);
        }

        static void Main()
        {
            Console.WriteLine("abhinna questiton 5");

            Console.WriteLine("\nEnter basic salary:");
            double basic = double.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter travel allowance:");
            double ta = double.Parse(Console.ReadLine());

            Salary salary = new Salary(basic, ta);
            Console.WriteLine($"\nThe total salary is: {salary.display()}");
        }

    }
}
