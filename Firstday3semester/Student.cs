using System;

namespace Firstday3semester
{

    public class Student : Person
    {
        private int _semester;

        public Student( string name, string address, Gender gender, int semester) : base(name, address, gender)
        {
            _semester = semester;

        }

        public int Semester
        {
            get { return _semester; }
            set { if(1 <= value && value <=8) 
                _semester = value;
                else throw new ArgumentOutOfRangeException();
            }
        }

    }
}
