using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Overloading
{
    class Student
    {
        int Eno;
        String Name, Branch;
        Student()
        {

        }
        Student(String Name)
        {
            this.Name = Name;
        }
        Student(String Name, int Eno)
        {
            this.Name = Name;
            this.Eno = Eno;
        }
        Student(String Name ,int Eno , String Branch)
        {
            this.Name = Name;
            this.Eno = Eno;
            this.Branch = Branch;
        }
        void show()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Eno);
            Console.WriteLine(Branch);

        }
        public static void Main()
        {
            Student s = new Student("Prerana");
            Student s1 = new Student("Prerana",1703);
            Student s2 = new Student("Prerana",1703,"CE");

            s.show();
            s1.show();
            s2.show();

        }


    }
}
