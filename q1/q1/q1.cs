using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OIC
{
    public static class Words
    {
        static void Main()
        {
            string word_list;
            Console.WriteLine("abhinna question 1");
            Console.WriteLine("Enter list of words to quote: ");
            Console.WriteLine("\n\n");
            word_list = Console.ReadLine();
            Console.WriteLine("\n\n");
            int w_len = word_list.Length;
            Console.Write('\"');
            for (int i = 0; i < w_len; i++)
            {
                if (word_list[i] == ' ')
                {
                    Console.Write("\" \"");
                    continue;
                }
                Console.Write(word_list[i]);
            }
            Console.Write('\"');
            Console.WriteLine("\n\n");
        }
    }
}
