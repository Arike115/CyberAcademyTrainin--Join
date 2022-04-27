using System;
using System.Linq;

namespace CyberAcademyTrainin__Join
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = null;
            var allstudent = Student.GetClasses();
            var teacher = Standard.Getstandard();

            //GroupJoin
            //Query syntax
            var data = from d in teacher
                       join c in allstudent
                       on d.id equals c.Standard into groupedteacher
                       select new
                       {
                           d.id,
                           d.ClassTeacher,
                           groupedteacher
                       };

            var newdata = allstudent.Join(teacher,
                                 b => b.Standard,
                                 x => x.id, (bt, groupedteacher) => new
                                 {
                                     studentname = bt.Name,
                                     Id = bt.Standard,
                                     bt.Gender,
                                     groupedteacher

                                 });
            foreach (var item in data)
            {
                Console.WriteLine($"name:{item.ClassTeacher}: id:{item.id}");
                foreach (var itempro in item.groupedteacher)
                {
                    Console.WriteLine($" -------{itempro.Name} ------{itempro.RollNo}");
                }
            }
            /** //Join
             //Query syntax
             var data = from b in allstudent
                        join x in teacher
                        on b.Standard equals x.id
                        select new { 
                            b.Name,
                            x.ClassTeacher,
                            x.id,
                            b.Gender
                        };
             //Extension Method/BasedSyntax
             var newdata = allstudent.Join(teacher, 
                                 b => b.Standard, 
                                 x => x.id, (bt, xl) => new
             {
                 studentname = bt.Name,
                 teacher = xl.ClassTeacher,
                 Id = bt.Standard,
                 bt.Gender,
                 xl.Fees
             }).Where(b => b.Id > 6)
                .OrderByDescending(x => x.Fees);

             foreach (var alldata in newdata)
             {
                 Console.WriteLine($"StudentName  ----{alldata.studentname}: " +
                                     $"Teacher:----{alldata.teacher} : Id -----{alldata.Id}:" +
                                     $" SchoolLevy: ----{alldata.Fees}");
             }
            */



        }
    }
}
