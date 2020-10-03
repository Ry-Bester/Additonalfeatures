using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additonalfeatures
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Ryan";
            Console.WriteLine("Hello my name is {0}", myName);
            Console.WriteLine("Please enter a number");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x * 15);

            Person pers = new Person("Ryan" , 25 );
            Console.WriteLine(pers);
            Console.Read();
        }
    }
}
