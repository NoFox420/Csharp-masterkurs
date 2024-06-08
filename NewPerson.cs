using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_masterkurs
{
    internal class NewPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public NewPerson(string firstName, string lastName) 
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Greet()
        {
            Console.WriteLine("{0} {1} sagt: Hallo!", FirstName, LastName);
        }

        public void Greet(NewPerson personToGreet)
        {
            Console.WriteLine("{0} {1} sagt: Hallo, {2} {3}", FirstName, LastName, personToGreet.FirstName, personToGreet.LastName);
        }
    }
}
