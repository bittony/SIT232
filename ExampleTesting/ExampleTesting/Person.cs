using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Class_Members
{
    class Person
    {
        public Person(string givenName, string familyName, string dateOfBirth)
        {
            _GivenName = givenName;
            _FamilyName = familyName;
            _DateOfBirth = Convert.ToInt32(dateOfBirth);
        }
        
        private string _GivenName;
        public string GivenName
        {
            get { return _GivenName; }
            set { _GivenName = value; }
        }

        private string _FamilyName;
        public string FamilyName
        {
            get { return _FamilyName; }
            set { _FamilyName = value; }
        }

        private int _DateOfBirth;
        public string DateOfBirth
        {
            get { return _DateOfBirth.ToString(); }
            set { _DateOfBirth = Convert.ToInt32(value); }
        }
    }
}
