using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var la = new List<int> {5,1, 3, 2, 9, 7};
            int k = 5;
            string str = findNum(la, k);
            Console.WriteLine(str);
            Console.Read();
        }

        private static string findNum(List<int> arr, int k)
        {
            var l = arr.Capacity;
            var m = arr.Count;
            var n = arr.FindIndex(x => x == k);

            var q = arr.IndexOf(k);
            var w = arr.Find(x => x == k);

            for (int i =0; i<m; i++)
            {
                if (arr[i] == k)
                {
                    //Console.WriteLine(string.Format("arr {0}, {1}, yes", i, k));
                    Console.WriteLine($"arr {i}, {k}, yes");    //c# 6 syntax?
                    return "yes";
                }
            }
            return "no";
        }
    }
}
