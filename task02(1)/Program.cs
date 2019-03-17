using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task02_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Man m=new Man();
            Student s = new Student("Alexa",19,'W',50,3);
            Teacher t = new Teacher("Petro Ivanich", 61, 'M', 80, 41);

            Console.WriteLine(m.ToString());
            Console.WriteLine(s.ToString());
            Console.WriteLine(t.ToString());

            s.SkipLesson();
            t.CheckHomework();
        }
    }
}
