using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberAcademyTrainin__Join
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Standard { get; set; }
        public Gender Gender { get; set; }
        public static List<Student> GetClasses()
        {
            return new List<Student>
            {
               new Student{RollNo = 101, Name = "Thomas", Gender = Gender.Male, Standard = 10},
               new Student{RollNo = 102, Name = "Chris", Gender = Gender.Male, Standard = 8},
               new Student{RollNo = 103, Name = "Luise", Gender = Gender.Female, Standard = 10},
               new Student{RollNo = 104, Name = "Ram", Gender = Gender.Male, Standard = 8},
               new Student{RollNo = 105, Name = "Kate", Gender = Gender.Female, Standard = 6},
               new Student{RollNo = 106, Name = "John", Gender = Gender.Male, Standard = 6},
               new Student{Name = "Ema", Gender = Gender.Female, Standard = 6},
               new Student{RollNo = 108, Name = "Ravi", Gender = Gender.Male}
            };

        }
    }

    public enum Gender
    {
        Female,
        Male,
    }

    public class Standard
    {
        public int id { get; set; }
        public string ClassTeacher { get; set; }
        public double Fees { get; set; }

        public static List<Standard> Getstandard()
        {
            return new List<Standard>
            {
                new Standard{id = 10, ClassTeacher="Max", Fees = 100.00},
                new Standard{id = 8, ClassTeacher="Ajay", Fees = 800.00},
                new Standard{id = 6, ClassTeacher="Geeta", Fees = 600.00},
                new Standard{id = 4, ClassTeacher="Rohan", Fees = 400.00},
            };

        }
    }
}
