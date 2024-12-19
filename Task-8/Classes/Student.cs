using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    internal class Student
    {
        #region Properties & Attributes
        public int Id { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }
        #endregion

        #region Constructors
        public Student(int _id, string _name, int _grade)
        {
            Id = _id;
            Name = _name;
            Grade = _grade;
        }

        public Student(Student Copy)
        {
            Id = Copy.Id;
            Name = Copy.Name;
            Grade = Copy.Grade;
        }
        #endregion
        #region Method
        public void disp()
        {
            Console.WriteLine($"The is is {Id}, The name is {Name}, The grade is {Grade}");
        }
        #endregion


    }
}
