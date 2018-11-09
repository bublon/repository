using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generarator_password
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            for (int i = 0; i < 30; i++)
            {
                string s = "";
                s = GetLetter(rnd).ToString().ToUpper();
                s += GetLetter(rnd);
                s += GetLetter(rnd);

                s += rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString();
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
        public static char GetLetter(Random _random)
        {
            int num = _random.Next(0, 26); // Zero to 25
            char let = (char)('a' + num);
            return let;
        }
    }
}