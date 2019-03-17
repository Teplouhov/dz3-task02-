using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task02_1_
{
    public class Man
    {
        protected string name;
        protected int age;
        protected char sex;
        protected float weight;

        public Man():this("Ivan",30,'M',80) { }
        public Man(string _name,int _age, char _sex, float _weight)
        {
            name = _name;
            age = _age;
            sex = _sex;
            weight = _weight;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public float Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public override string ToString()
        {
            return "человек "+name+" возрастом "+age+" пола "+sex+" весом "+ weight+" кг";
        }
    }
}
