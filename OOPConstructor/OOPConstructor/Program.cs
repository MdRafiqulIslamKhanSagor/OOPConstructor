using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("sagor","khan");

            string fullName = person1.GetFullName();

            Console.WriteLine(fullName);
        }
    }
}
