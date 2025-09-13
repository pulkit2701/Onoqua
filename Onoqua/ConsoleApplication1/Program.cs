using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "select * from {abc} where field1={jak} and field2={jak2}";
            while (str.IndexOf('{') > 0)
            {
                var field = str.Substring(str.IndexOf('{') + 1, str.IndexOf('}') - str.IndexOf('{') - 1);
                str = str.Replace("{" + field + "}", "1");
            }
            Console.WriteLine(str);

        }
    }
}
