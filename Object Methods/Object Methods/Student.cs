using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Methods
{
    class Student
    {
        public string name;
        public string classroom;
        public double grade;

        public Student(string aName, string aClassRoom, double aGrade)
        {
            name = aName;
            classroom = aClassRoom;
            grade = aGrade;

        }

        public bool HasHonors()
        {
            if(grade >= 3.5)
            {
                return true;
            }

            return false;
        }
    

    }
      
}
