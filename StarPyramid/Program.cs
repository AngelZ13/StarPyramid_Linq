using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ChristmasTree(5)); 
        }

        public static string ChristmasTree(int height) => string.Join("\n", Enumerable.Range(1, height).Select(i => new string('*', 2 * i - 1).PadLeft(height + i - 1).PadRight(2 * height - 1)));
        

    }

   


}
