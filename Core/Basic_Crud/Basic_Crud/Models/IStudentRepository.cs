using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basic_Crud.Models;

namespace Basic_Crud.Models
{
    public interface IStudentRepository
    {
        List<Student> GetAllstudents();
        Student GetByStudentId(int stdid);
        public List<Student> Create(Student s);
        public Student Update(int id, Student s);
    }
}
