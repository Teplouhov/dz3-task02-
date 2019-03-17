using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task02_1_
{
    class Student : Man
    {
        int year;

        public Student() : base() { year = 1; }
        public Student(string _name, int _age, char _sex, float _weight,int _year):base(_name, _age,  _sex, _weight)
        {
            year = _year;
        }


        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public void SkipLesson()
        {
            Console.WriteLine("студент " +name+" "+year+" года обучения пропускает занятие");
        }

        public override string ToString()
        {
            return base.ToString() + " и является студентом "+year+" года обучения";
        }
    }
}
