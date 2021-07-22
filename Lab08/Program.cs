using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    class Program
    {

        static void Main(string[] args)
        {
            var Doc = new Doctor("tle", 1250000);
            Console.WriteLine(Doc.Whoami());
            Console.WriteLine(Doc.GetTex().ToString(" Tax pay" + "#,##0"));
            Console.WriteLine("----------------------");

            var Tec = new Teacher("toey", 15000);
            Console.WriteLine(Tec.Whoami());
            Console.WriteLine(Tec.GetTex().ToString(" Tax pay" + "#,##0"));
            Console.ReadLine();
        }
    }
}
