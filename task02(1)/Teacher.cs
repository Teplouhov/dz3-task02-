using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task02_1_
{
    class Teacher : Man
    {
        int experience;

        public Teacher() : base() { experience = 3; }
        public Teacher(string _name, int _age, char _sex, float _weight, int _experience):base(_name, _age,  _sex, _weight)
        {
            experience = _experience;
        }


        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }

        public void CheckHomework()
        {
            Console.WriteLine("преподаватель " +name+" со стажем "+experience+" проверяет домашнее задание");
        }

        public override string ToString()
        {
            return base.ToString() + " и является преподавателем со стажем " + experience;
        }
    }
}
