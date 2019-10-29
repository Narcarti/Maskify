using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maskify
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Maskify("444"));
            Console.WriteLine(Maskify("4445556666"));

            Console.ReadKey();
        }

        private static string Maskify(string cc)
        {

            return (cc.Length > 4 ? string.Concat(new string('#',cc.Length-4), cc.Substring(cc.Length - 4)) : cc);
        }
    }
}
