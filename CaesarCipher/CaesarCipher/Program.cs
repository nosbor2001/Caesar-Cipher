using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
                int offset;
                string encode;
                int index;
                List<string> alphabet = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            while (true)
            {
                Console.Clear();
                Console.Write("Enter a string to encode: ");
                encode = Console.ReadLine();

                Console.Write("Enter the offset: ");
                offset = int.Parse(Console.ReadLine());

                foreach (char c in encode)
                {
                    index = alphabet.IndexOf(c.ToString());
                    Console.Write(alphabet[index + offset]);
                }
                Console.ReadLine();
            }
        }
    }
}
