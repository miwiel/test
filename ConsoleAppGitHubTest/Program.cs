using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGitHubTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Primary prim = new Primary();
            string helper = "";

            Console.Write("Enter name: ");
            helper = Console.ReadLine();

            Console.WriteLine(prim.getName(helper));

            Console.ReadLine();
        }
    }

    class Primary
    {
        public string getName(string name)
        {
            string result = "";
            result = "Hello " + name;
            return result;
 
        }
    }
    
    class Test
    {
    }

    class SecondClass
    {

    }
}
