using MongoDB.Driver;
using MongoDbPractice.Models;
using MongoDbPractice.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbPractice.Repositories
{
    public class EmployeeRepository:GenericRepository<Employee>,IEmployeeRepository
    {
        public EmployeeRepository(IMongoDBContext context) : base(context,"Employees")
        {
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _dbCollection.Find(emp=>true).ToEnumerable();
        }
    }
}
