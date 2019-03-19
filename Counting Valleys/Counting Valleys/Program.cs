using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Valleys
{
    class Program
    {
        static int countingValleys(int n, string s)
        {
            s = s.ToLower();
            int valley = 0;
            int downsteps = 0;
            int upsteps = 0;
            char previousValue;
            LinkedList<char> steps= new LinkedList<char>();
            foreach (var _s in s)
            {
                steps.AddLast(_s);
            }

            foreach (var step in steps)
            {
                char value = step;

            }
            return valley;

        }

        static void Main(string[] args)
        {
           
            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            
        }
    }
}
