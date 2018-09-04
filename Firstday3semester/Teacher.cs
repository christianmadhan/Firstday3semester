using System;
using System.Collections.Generic;
using System.Text;

namespace Firstday3semester
{
   public class Teacher : Person
    {
        private int _salery;

        public Teacher(string name, string address, int salery, Gender gender) : base(name,address,gender)
        {
            _salery = salery;
        }

        public int Salery
        {
            get => _salery;
            set {if (_salery >= 0) _salery = value;}
        }

        public int CountSalery()
        {
            return 1;
        }
      

    }
}
