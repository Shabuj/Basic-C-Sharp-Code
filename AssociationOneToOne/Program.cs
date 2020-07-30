using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationOneToOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("22", "223", "HakimPur", 1700, "Jhenidah");
            Person person = new Person("Akramul", "Haque", "Shbauj");
            person.personAddress = address;
            Address person1Address = person.personAddress;
            int postCode = person1Address.PostCode;
        }
    }
}
