using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbPractice.Models;
using MongoDbPractice.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbPractice.Services
{
    public class EmployeeService
    {
        private readonly IMongoCollection<Employee> _employees;
        private IEmployeeRepository repo;
        public EmployeeService(IEmployeeDatabaseSettings settings,IEmployeeRepository repository)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            repo = repository;
            _employees = database.GetCollection<Employee>(settings.EmployeesCollectionName);

        }

        public List<Employee> Get()
        {
            List<Employee> employees;
            employees=repo.GetAllEmployees().ToList();
            employees = _employees.Find(emp => true).ToList();
            return employees;
        }

        public Employee Get(string id)
        {
            var employee= _employees.Find<Employee>(emp => emp.Id == id).FirstOrDefault();
            employee.Name = "Added Employee";
            _employees.InsertOne(employee);
            return employee;
        }

    }
}
