using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_Crud.Models
{
    public class StudentRepository : IStudentRepository
    {
        List<Student> listofStudents;

        public List<Student>PopulateStudents()
        {
            listofStudents = new List<Student>()
            {
                new Student{StdId=1, StdName="Bhavagna",Gender="Female",Dept="CSC"},
                new Student{StdId=2, StdName="Bhuiyash",Gender="Male",Dept="ECE"},
                new Student{StdId=3, StdName="Hannah",Gender="Female",Dept="IT"},
                new Student{StdId=4, StdName="Muthu",Gender="Male",Dept="CSC"},
            };
            return listofStudents;
        }
        public List<Student> Create(Student s)
        {
            List<Student> newlist = PopulateStudents();
            newlist.Add(s);
            return newlist;
        }

        public List<Student> GetAllstudents()
        {
            return PopulateStudents();
        }

        public Student GetByStudentId(int stdid)
        {
            return PopulateStudents().FirstOrDefault(s => s.StdId == stdid);
        }

        public Student Update(int id, Student s)
        {
            var stddata = PopulateStudents().Find(s => s.StdId == id);
            stddata.StdName = s.StdName;
            //stddata.Gender = s.Gender;
            stddata.Dept = s.Dept;
            return stddata;
        }
    }
}
