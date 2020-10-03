using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additonalfeatures
{
    public class Person
    {
        public Person(string name) : this(name, 25)
        {

        }
        
        public Person FullName (string name, int old)
        {
            
            FirstName = name;
            Age = old;

         }
       
           public string FirstName { get; set; }
           public string LastName { get; set; }
           public int Age { get; set; }
            


    }
}
