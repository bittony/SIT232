using System;

namespace Defining_Class_Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Person aPerson = new Person("John", "Doe", "123456");

            Console.WriteLine("   Family name: {0}", aPerson.FamilyName);
            Console.WriteLine("    Given name: {0}", aPerson.GivenName);
            Console.WriteLine(" Date of birth: {0}", aPerson.DateOfBirth);
            Console.WriteLine();

            aPerson.FamilyName = "Bloggs";
            aPerson.GivenName = "Jane";
            aPerson.DateOfBirth = "01032013";

            Console.WriteLine("   Family name: {0}", aPerson.FamilyName);
            Console.WriteLine("    Given name: {0}", aPerson.GivenName);
            Console.WriteLine(" Date of birth: {0}", aPerson.DateOfBirth);
        }
    }
}
