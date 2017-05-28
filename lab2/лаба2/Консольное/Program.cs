using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Model m = new TheModelRead("TestFile.txt");

            ModelWrite Write = new TheModelWrite("TestFile.txt");

            System.Console.WriteLine(m.Read());

            System. Console.ReadKey();

        }
    }
}