using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sock_Merchant
{
    class Program
    {
        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            var pair = 0;
            var dictionary = new Dictionary<int, int>();
            foreach (var value in ar)
            {
                if (dictionary.ContainsKey(value))
                    dictionary[value]++;
                else
                    dictionary[value] = 1;
            }

            var _ar = ar.Distinct();
            foreach (var value in _ar)
            {
                pair = pair + dictionary[value]/2;
                

            }

            return pair;
        }

        static void Main(string[] args)
        {
          //  TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = sockMerchant(n, ar);

           Console.Write(result);
           Console.ReadLine();
        }
    }
}
