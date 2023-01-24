namespace OIC
{
    public static class OvereloadFunction
    {
        static int t;
        static float tf;
        public static void swap(ref int a, ref int b)
        {
            t = a;
            a = b;
            b = t;
        }
        public static void swap(ref float a, ref float b)
        {
            tf = a;
            a = b;
            b = tf;
            
        }

        static void Main()
        {
            Console.WriteLine("abhinna question 4:\n");

            bool choice = true;

            Console.WriteLine("Press i to swap int values");
            Console.WriteLine("Press f to swap float values");
            Console.WriteLine("Enter choice:");
            while(choice == true)
            {
                var c = Console.ReadKey();
                switch(c.Key)
                {
                    case ConsoleKey.F:
                        Console.WriteLine("\nEnter 1st floating number, fx: ");
                        float fx = float.Parse(Console.ReadLine());
                        Console.WriteLine("Enter 2st floating number, fy: ");
                        float fy = float.Parse(Console.ReadLine());

                        Console.WriteLine("\nBefore swap: ");
                        Console.WriteLine($"fx = {fx}, fy = {fy}");
                        Console.WriteLine("After swap: ");
                        swap(ref fx, ref fy);
                        Console.WriteLine($"fx = {fx}, fy = {fy}");
                        break;

                    case ConsoleKey.I:
                        Console.WriteLine("\nEnter 1st integer number, x: ");
                        int x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter 2st integer number, y: ");
                        int y = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nBefore swap: ");
                        Console.WriteLine($"x = {x}, y = {y}");
                        Console.WriteLine("After swap: ");
                        swap(ref x, ref y);
                        Console.WriteLine($"x = {x}, y = {y}");
                        break;
                    default:
                        choice = false; 
                        break;



                }
            }
        }
    }
}