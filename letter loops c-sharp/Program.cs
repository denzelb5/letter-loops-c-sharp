using System;
using System.Text;
using System.Linq;


namespace letter_loops_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            Console.WriteLine("Enter any word:");
            answer = Console.ReadLine();
            
            var res = string.Join("-", answer.Select((c, i) => Char.ToUpper(c) + new string(Char.ToLower(c), i)));
            Console.WriteLine(res);
        }
    }
}
