using System;
using System.Collections.Generic;
using System.Text;

namespace Firstday3semester
{
    public class Person
    {
     
        private string _name;
        private string _address;
        private Gender _gender;


        public Person(string name,  string address, Gender gender)
        {
            _name = name;
            _address = address;
            _gender = gender;
        }


        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Adress
        {
            get => _address;
            set => _address = value;
        }
    }
}
