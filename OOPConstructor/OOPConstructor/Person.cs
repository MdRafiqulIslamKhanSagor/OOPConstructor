using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPConstructor
{
    class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;

        public Person(string firstName, string middleName, string lastName):this(firstName,middleName)
        {
           
            this.lastName = lastName;
            
        }

        public Person(string firstName,string middleName):this()
        {
            this.firstName = firstName;
            this.middleName = middleName;

        }

        public Person()
        {
            int totalBalance = 1000;
        }

       

        public string GetFullName(string firstName, string middleName, string lastName)
        {

            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            string fullName = firstName + " " + middleName + " " + lastName;
            return fullName;
        }
        public string GetFullName(string firstName, string middleName)
        {
            this.firstName = firstName;
            this.middleName = middleName;

            string fullName = firstName + " " + middleName;

            return fullName;


        }

        public string GetFullName()
        {
            string fullName = firstName;
            return fullName;
        }
    }

   
}
