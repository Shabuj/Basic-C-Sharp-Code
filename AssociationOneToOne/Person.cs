

namespace AssociationOneToOne
{
    class Person
    {
        public string FirstName { set; get; }
        public string MiddleName { set; get; }
        public string Lastname { set; get; }
        public Address personAddress { set; get; }


        public Person(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            Lastname = lastName;
        }
        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + Lastname;
        }
    }
}
