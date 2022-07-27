using MongoDbPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbPractice.Repositories.Interfaces
{
    public interface IEmployeeRepository:IGenericRepository<Employee>
    {
        public IEnumerable<Employee> GetAllEmployees();
    }
}
