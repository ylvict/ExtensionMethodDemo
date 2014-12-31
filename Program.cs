using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodDemo
{
    static class MyClass
    {
        public static int ToInt(this string str)
        {
            return Convert.ToInt32(str);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string str = "1";
            var i = str.ToInt();
            Console.WriteLine(i);
        }
    }
}
