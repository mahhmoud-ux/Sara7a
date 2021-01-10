using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tharaha.Data;

namespace tharaha.Models
{
    public interface MockRepository<E>
    {
        IEnumerable<E> GetEmployees();
        void Add(E e);
    }
    public class RealRepository : MockRepository<Employee>
    {
        private readonly tharahaContext db;

        public RealRepository(tharahaContext _db)
        {
            this.db = _db;
        }

        public void Add(Employee e)
        {
            db.Employees.Add(new Employee() { 
             Department=e.Department,
             FName=e.FName,
             LName=e.LName,
             imgUrl=e.imgUrl
            });
            db.SaveChanges();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return db.Employees; 
        }
    }
}
