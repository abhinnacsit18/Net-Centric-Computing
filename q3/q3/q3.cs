using System;

namespace OIC
{
    public class Staff
    {
        private string name;
        private string post;

        public Staff(string name, string post)
        {
            this.name = name;
            this.post = post;
        }
        public string ReturnPost()
        {
            return post;
        }
        public void Display()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Post: {post}");
        }
    }
    public static class ClassTask
    {
        public static void Main()
        {
            Console.WriteLine("abhinna question 3\n");

            Staff[] staff = new Staff[5];

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\nEnter the name of staff #{i + 1}:");
                string name = Console.ReadLine();

                Console.WriteLine($"\nEnter the post of staff #{i + 1}:");
                string post = Console.ReadLine();

                staff[i] = new Staff(name, post);
            }

            for (int i = 0; i < 5; i++)
            {
                if((staff[i].ReturnPost()).ToUpper() == "HOD")
                {
                    Console.WriteLine($"\nstaff #{i + 1}:");
                    staff[i].Display();
                }
            }
        }
    }
}
