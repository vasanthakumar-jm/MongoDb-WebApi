using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDbPractice.Models;
using MongoDbPractice.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDbPractice.Repositories
{
    public class MongoDBContext : IMongoDBContext
    {
        private IMongoDatabase database { get; set; }
        private MongoClient _mongoClient { get; set; }
        public IClientSessionHandle Session { get; set; }
        public MongoDBContext(IOptions<EmployeeDatabaseSettings> settings)
        {
            _mongoClient = new MongoClient(settings.Value.ConnectionString);
            database = _mongoClient.GetDatabase(settings.Value.DatabaseName);
        }

        public IMongoCollection<T> GetCollection<T>(string name)
        {
            return database.GetCollection<T>(name);
        }
    }
}
