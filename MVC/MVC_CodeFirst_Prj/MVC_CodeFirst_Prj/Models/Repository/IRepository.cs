using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CodeFirst_Prj.Models.Repository
{
    public interface IRepository<T> where T:class // allows only reference types
    {
        IEnumerable<T> GetAll();
        T GetById(object Id); // find an occurence of the given type
        void Insert(T obj);
        void Update(T obj);
        void Delete(object Id);
        void Save();
    }
}